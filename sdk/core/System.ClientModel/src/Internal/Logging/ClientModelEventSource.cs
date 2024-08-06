﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Text;

namespace System.ClientModel.Internal;

[EventSource(Name = "System-ClientModel")]
internal sealed class ClientModelEventSource : EventSource
{
    private const int RequestEvent = 1;
    private const int RequestContentEvent = 2;
    private const int ResponseEvent = 5;
    private const int ResponseContentEvent = 6;
    private const int ResponseDelayEvent = 7;
    private const int ErrorResponseEvent = 8;
    private const int ErrorResponseContentEvent = 9;
    private const int RequestRetryingEvent = 10;
    private const int ResponseContentBlockEvent = 11;
    private const int ErrorResponseContentBlockEvent = 12;
    private const int ResponseContentTextEvent = 13;
    private const int ErrorResponseContentTextEvent = 14;
    private const int ResponseContentTextBlockEvent = 15;
    private const int ErrorResponseContentTextBlockEvent = 16;
    private const int RequestContentTextEvent = 17;
    private const int ExceptionResponseEvent = 18;
    private const int BackgroundRefreshFailedEvent = 19;
    private const int RequestRedirectEvent = 20;
    private const int RequestRedirectBlockedEvent = 21;
    private const int RequestRedirectCountExceededEvent = 22;
    private const int PipelineTransportOptionsNotAppliedEvent = 23;

    private ClientModelEventSource(string eventSourceName, string[]? traits = default) : base(eventSourceName, EventSourceSettings.Default, traits) { }

    //public static ClientModelEventSource Create(string eventSourceName, string[]? traits) => new(eventSourceName, traits);

    public static ClientModelEventSource Log = new("System-ClientModel");

    [Event(BackgroundRefreshFailedEvent, Level = EventLevel.Informational, Message = "Background token refresh [{0}] failed with exception {1}")]
    public void BackgroundRefreshFailed(string requestId, string exception)
    {
        WriteEvent(BackgroundRefreshFailedEvent, requestId, exception);
    }

    // TODO - It's easier to have the IsEnabled calls in this file, but since the logging policy is checking the log level of the ILogger instance as well
    // the checks are done there instead. Need to avoid double checking. However, this approach might be prone to dev error - if someone forgets to check.

    [NonEvent]
    public void Request(string requestId, PipelineRequest request, string? assemblyName, PipelineMessageSanitizer sanitizer)
    {
        Request(requestId, request.Method.ToString(), sanitizer.SanitizeUrl(request.Uri!.AbsoluteUri), FormatHeaders(request.Headers, sanitizer), assemblyName);
    }

    [Event(RequestEvent, Level = EventLevel.Informational, Message = "Request [{0}] {1} {2}\r\n{3}client assembly: {4}")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with primitive types.")]
    public void Request(string requestId, string method, string uri, string headers, string? clientAssembly)
    {
        WriteEvent(RequestEvent, requestId, method, uri, headers, clientAssembly);
    }

    [NonEvent]
    public void RequestContent(string requestId, byte[] content, Encoding? textEncoding)
    {
        if (textEncoding is not null)
        {
            RequestContentText(requestId, textEncoding.GetString(content));
        }
        else
        {
            RequestContent(requestId, content);
        }
    }

    [Event(RequestContentEvent, Level = EventLevel.Verbose, Message = "Request [{0}] content: {1}")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with an array with primitive type elements.")]
    public void RequestContent(string requestId, byte[] content)
    {
        WriteEvent(RequestContentEvent, requestId, content);
    }

    [Event(RequestContentTextEvent, Level = EventLevel.Verbose, Message = "Request [{0}] content: {1}")]
    public void RequestContentText(string requestId, string content)
    {
        WriteEvent(RequestContentTextEvent, requestId, content);
    }

    [NonEvent]
    public void Response(string requestId, PipelineResponse response, PipelineMessageSanitizer sanitizer, double elapsed)
    {
        Response(requestId, response.Status, response.ReasonPhrase, FormatHeaders(response.Headers, sanitizer), elapsed);
    }

    [Event(ResponseEvent, Level = EventLevel.Informational, Message = "Response [{0}] {1} {2} ({4:00.0}s)\r\n{3}")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with primitive types.")]
    public void Response(string requestId, int status, string reasonPhrase, string headers, double seconds)
    {
        WriteEvent(ResponseEvent, requestId, status, reasonPhrase, headers, seconds);
    }

    [NonEvent]
    public void ResponseContent(string requestId, byte[] content, Encoding? textEncoding)
    {
        if (textEncoding is not null)
        {
            ResponseContentText(requestId, textEncoding.GetString(content));
        }
        else
        {
            ResponseContent(requestId, content);
        }
    }

    [Event(ResponseContentEvent, Level = EventLevel.Verbose, Message = "Response [{0}] content: {1}")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with an array with primitive type elements.")]
    public void ResponseContent(string requestId, byte[] content)
    {
        WriteEvent(ResponseContentEvent, requestId, content);
    }

    [Event(ResponseContentTextEvent, Level = EventLevel.Verbose, Message = "Response [{0}] content: {1}")]
    public void ResponseContentText(string requestId, string content)
    {
        WriteEvent(ResponseContentTextEvent, requestId, content);
    }

    [NonEvent]
    public void ResponseContentBlock(string requestId, int blockNumber, byte[] content, Encoding? textEncoding)
    {
        if (textEncoding is not null)
        {
            ResponseContentTextBlock(requestId, blockNumber, textEncoding.GetString(content));
        }
        else
        {
            ResponseContentBlock(requestId, blockNumber, content);
        }
    }

    [Event(ResponseContentBlockEvent, Level = EventLevel.Verbose, Message = "Response [{0}] content block {1}: {2}")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with an array with primitive type elements.")]
    public void ResponseContentBlock(string requestId, int blockNumber, byte[] content)
    {
        WriteEvent(ResponseContentBlockEvent, requestId, blockNumber, content);
    }

    [Event(ResponseContentTextBlockEvent, Level = EventLevel.Verbose, Message = "Response [{0}] content block {1}: {2}")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with primitive types.")]
    public void ResponseContentTextBlock(string requestId, int blockNumber, string content)
    {
        WriteEvent(ResponseContentTextBlockEvent, requestId, blockNumber, content);
    }

    [NonEvent]
    public void ErrorResponse(string requestId, PipelineResponse response, PipelineMessageSanitizer sanitizer, double elapsed)
    {
        ErrorResponse(requestId, response.Status, response.ReasonPhrase, FormatHeaders(response.Headers, sanitizer), elapsed);
    }

    [Event(ErrorResponseEvent, Level = EventLevel.Warning, Message = "Error response [{0}] {1} {2} ({4:00.0}s)\r\n{3}")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with primitive types.")]
    public void ErrorResponse(string requestId, int status, string reasonPhrase, string headers, double seconds)
    {
        WriteEvent(ErrorResponseEvent, requestId, status, reasonPhrase, headers, seconds);
    }

    [NonEvent]
    public void ErrorResponseContent(string requestId, byte[] content, Encoding? textEncoding)
    {
        if (textEncoding is not null)
        {
            ErrorResponseContentText(requestId, textEncoding.GetString(content));
        }
        else
        {
            ErrorResponseContent(requestId, content);
        }
    }

    [Event(ErrorResponseContentEvent, Level = EventLevel.Informational, Message = "Error response [{0}] content: {1}")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with an array with primitive type elements.")]
    public void ErrorResponseContent(string requestId, byte[] content)
    {
        WriteEvent(ErrorResponseContentEvent, requestId, content);
    }

    [Event(ErrorResponseContentTextEvent, Level = EventLevel.Informational, Message = "Error response [{0}] content: {1}")]
    public void ErrorResponseContentText(string requestId, string content)
    {
        WriteEvent(ErrorResponseContentTextEvent, requestId, content);
    }

    [NonEvent]
    public void ErrorResponseContentBlock(string requestId, int blockNumber, byte[] content, Encoding? textEncoding)
    {
        if (textEncoding is not null)
        {
            ErrorResponseContentTextBlock(requestId, blockNumber, textEncoding.GetString(content));
        }
        else
        {
            ErrorResponseContentBlock(requestId, blockNumber, content);
        }
    }

    [Event(ErrorResponseContentBlockEvent, Level = EventLevel.Informational, Message = "Error response [{0}] content block {1}: {2}")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with an array with primitive type elements.")]
    public void ErrorResponseContentBlock(string requestId, int blockNumber, byte[] content)
    {
        WriteEvent(ErrorResponseContentBlockEvent, requestId, blockNumber, content);
    }

    [Event(ErrorResponseContentTextBlockEvent, Level = EventLevel.Informational, Message = "Error response [{0}] content block {1}: {2}")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with primitive types.")]
    public void ErrorResponseContentTextBlock(string requestId, int blockNumber, string content)
    {
        WriteEvent(ErrorResponseContentTextBlockEvent, requestId, blockNumber, content);
    }

    [Event(RequestRetryingEvent, Level = EventLevel.Informational, Message = "Request [{0}] attempt number {1} took {2:00.0}s")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with primitive types.")]
    public void RequestRetrying(string requestId, int retryNumber, double seconds)
    {
        WriteEvent(RequestRetryingEvent, requestId, retryNumber, seconds);
    }

    [Event(ResponseDelayEvent, Level = EventLevel.Warning, Message = "Response [{0}] took {1:00.0}s")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "WriteEvent is used with primitive types.")]
    public void ResponseDelay(string requestId, double seconds)
    {
        WriteEvent(ResponseDelayEvent, requestId, seconds);
    }

    [Event(ExceptionResponseEvent, Level = EventLevel.Informational, Message = "Request [{0}] exception {1}")]
    public void ExceptionResponse(string requestId, string exception)
    {
        WriteEvent(ExceptionResponseEvent, requestId, exception);
    }

    [NonEvent]
    public void PipelineTransportOptionsNotApplied(Type optionsType)
    {
        PipelineTransportOptionsNotApplied(optionsType.FullName ?? string.Empty);
    }

    [Event(PipelineTransportOptionsNotAppliedEvent, Level = EventLevel.Informational, Message = "The client requires transport configuration but it was not applied because custom transport was provided. Type: {0}")]
    public void PipelineTransportOptionsNotApplied(string optionsType)
    {
        WriteEvent(PipelineTransportOptionsNotAppliedEvent, optionsType);
    }

    [NonEvent]
    private static string FormatHeaders(IEnumerable<KeyValuePair<string, string>> headers, PipelineMessageSanitizer sanitizer)
    {
        var stringBuilder = new StringBuilder();
        foreach (var header in headers)
        {
            stringBuilder.Append(header.Key);
            stringBuilder.Append(':');
            stringBuilder.Append(sanitizer.SanitizeHeader(header.Key, header.Value));
            stringBuilder.Append(Environment.NewLine);
        }
        return stringBuilder.ToString();
    }
}
