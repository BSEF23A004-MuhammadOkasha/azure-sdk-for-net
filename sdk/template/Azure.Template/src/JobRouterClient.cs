// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.JobRouter.Models;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.JobRouter
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    // Data plane generated client.
    /// <summary> The JobRouter service client. </summary>
    public partial class JobRouterClient
    {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public virtual async Task<Response<RouterJob>> UpsertJobAsync(RouterJob job, CancellationToken cancellationToken = default)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            if (job is not IModelJsonSerializable<RouterJob> model)
            {
                throw new InvalidCastException("Model is not serializable.");
            }

            RequestContent content = RequestContent.Create(model, new ModelSerializerOptions("P"));
            Response response = await UpsertJobAsync(job.Id, content, new() { CancellationToken = cancellationToken }).ConfigureAwait(false);

            return Response.FromValue((RouterJob)response, response);
        }

        public virtual Response<RouterJob> UpsertJob(RouterJob job, CancellationToken cancellationToken = default)
        {
            if (job is not IModelJsonSerializable<RouterJob> model)
            {
                throw new InvalidCastException("Model is not serializable.");
            }

            RequestContent content = RequestContent.Create(model, new ModelSerializerOptions("P"));
            Response response = UpsertJob(job.Id, content, new() { CancellationToken = cancellationToken });

            return Response.FromValue((RouterJob)response, response);
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

        public virtual async Task<Response<RouterJob>> GetJobAsync(string id, CancellationToken cancellationToken = default)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            Response response = await GetJobAsync(id, new RequestContext() { CancellationToken = cancellationToken }).ConfigureAwait(false);

            return Response.FromValue((RouterJob)response, response);
        }

        public virtual Response<RouterJob> GetJob(string id, CancellationToken cancellationToken = default)
        {
            Response response = GetJob(id, new RequestContext() { CancellationToken = cancellationToken });

            return Response.FromValue((RouterJob)response, response);
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
