// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel.Internal;

public static class PipelineProtocolExtensions
{
    public static async ValueTask<PipelineResponse> ProcessMessageAsync(this ClientPipeline pipeline, PipelineMessage message, RequestOptions requestContext, CancellationToken cancellationToken = default)
    {
        await pipeline.SendAsync(message).ConfigureAwait(false);

        if (message.Response is null)
        {
            throw new InvalidOperationException("Failed to set message response.");
        }

        if (!message.Response.IsError || requestContext?.ErrorBehavior == ErrorBehavior.NoThrow)
        {
            return message.Response;
        }

        throw new ClientRequestException(message.Response);
    }

    public static PipelineResponse ProcessMessage(this ClientPipeline pipeline, PipelineMessage message, RequestOptions requestContext, CancellationToken cancellationToken = default)
    {
        pipeline.Send(message);

        if (message.Response is null)
        {
            throw new InvalidOperationException("Failed to set message response.");
        }

        if (!message.Response.IsError || requestContext?.ErrorBehavior == ErrorBehavior.NoThrow)
        {
            return message.Response;
        }

        throw new ClientRequestException(message.Response);
    }

    public static async ValueTask<NullableOutputMessage<bool>> ProcessHeadAsBoolMessageAsync(this ClientPipeline pipeline, PipelineMessage message, RequestOptions requestContext)
    {
        PipelineResponse response = await pipeline.ProcessMessageAsync(message, requestContext).ConfigureAwait(false);
        switch (response.Status)
        {
            case >= 200 and < 300:
                return OutputMessage.FromNullableValue(true, response);
            case >= 400 and < 500:
                return OutputMessage.FromNullableValue(false, response);
            default:
                return new ErrorOutputMessage<bool>(response, new ClientRequestException(response));
        }
    }

    public static NullableOutputMessage<bool> ProcessHeadAsBoolMessage(this ClientPipeline pipeline, PipelineMessage message, RequestOptions requestContext)
    {
        PipelineResponse response = pipeline.ProcessMessage(message, requestContext);
        switch (response.Status)
        {
            case >= 200 and < 300:
                return OutputMessage.FromNullableValue(true, response);
            case >= 400 and < 500:
                return OutputMessage.FromNullableValue(false, response);
            default:
                return new ErrorOutputMessage<bool>(response, new ClientRequestException(response));
        }
    }

    private class ErrorOutputMessage<T> : NullableOutputMessage<T>
    {
        private readonly PipelineResponse _response;
        private readonly ClientRequestException _exception;

        public ErrorOutputMessage(PipelineResponse response, ClientRequestException exception)
            : base(default, response)
        {
            _response = response;
            _exception = exception;
        }

        public override T? Value { get => throw _exception; }

        public override bool HasValue => false;

        public override PipelineResponse GetRawResponse() => _response;
    }
}
