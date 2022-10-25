// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Quota.Models;

namespace Azure.ResourceManager.Quota
{
    internal partial class QuotaRequestStatusRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of QuotaRequestStatusRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public QuotaRequestStatusRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-03-15-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string scope, string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Quota/quotaRequests/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation. </summary>
        /// <param name="scope"> The target Azure resource URI. For example, `/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`. This is the target Azure resource URI for the List GET operation. If a `{resourceName}` is added after `/quotas`, then it&apos;s the target Azure resource URI in the GET operation for the specific resource. </param>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<QuotaRequestDetailData>> GetAsync(string scope, string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var message = CreateGetRequest(scope, id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaRequestDetailData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QuotaRequestDetailData.DeserializeQuotaRequestDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((QuotaRequestDetailData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation. </summary>
        /// <param name="scope"> The target Azure resource URI. For example, `/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`. This is the target Azure resource URI for the List GET operation. If a `{resourceName}` is added after `/quotas`, then it&apos;s the target Azure resource URI in the GET operation for the specific resource. </param>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<QuotaRequestDetailData> Get(string scope, string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var message = CreateGetRequest(scope, id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaRequestDetailData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QuotaRequestDetailData.DeserializeQuotaRequestDetailData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((QuotaRequestDetailData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string scope, string filter, int? top, string skiptoken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Quota/quotaRequests", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (skiptoken != null)
            {
                uri.AppendQuery("$skiptoken", skiptoken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> For the specified scope, get the current quota requests for a one year period ending at the time is made. Use the **oData** filter to select quota requests. </summary>
        /// <param name="scope"> The target Azure resource URI. For example, `/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`. This is the target Azure resource URI for the List GET operation. If a `{resourceName}` is added after `/quotas`, then it&apos;s the target Azure resource URI in the GET operation for the specific resource. </param>
        /// <param name="filter">
        /// | Field                    | Supported operators  
        /// |---------------------|------------------------
        /// 
        /// |requestSubmitTime | ge, le, eq, gt, lt
        ///  |provisioningState eq {QuotaRequestState}
        ///  |resourceName eq {resourceName}
        /// 
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> The **Skiptoken** parameter is used only if a previous operation returned a partial result. If a previous response contains a **nextLink** element, its value includes a **skiptoken** parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public async Task<Response<QuotaRequestDetailsList>> ListAsync(string scope, string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListRequest(scope, filter, top, skiptoken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaRequestDetailsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QuotaRequestDetailsList.DeserializeQuotaRequestDetailsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> For the specified scope, get the current quota requests for a one year period ending at the time is made. Use the **oData** filter to select quota requests. </summary>
        /// <param name="scope"> The target Azure resource URI. For example, `/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`. This is the target Azure resource URI for the List GET operation. If a `{resourceName}` is added after `/quotas`, then it&apos;s the target Azure resource URI in the GET operation for the specific resource. </param>
        /// <param name="filter">
        /// | Field                    | Supported operators  
        /// |---------------------|------------------------
        /// 
        /// |requestSubmitTime | ge, le, eq, gt, lt
        ///  |provisioningState eq {QuotaRequestState}
        ///  |resourceName eq {resourceName}
        /// 
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> The **Skiptoken** parameter is used only if a previous operation returned a partial result. If a previous response contains a **nextLink** element, its value includes a **skiptoken** parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public Response<QuotaRequestDetailsList> List(string scope, string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListRequest(scope, filter, top, skiptoken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaRequestDetailsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QuotaRequestDetailsList.DeserializeQuotaRequestDetailsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string scope, string filter, int? top, string skiptoken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> For the specified scope, get the current quota requests for a one year period ending at the time is made. Use the **oData** filter to select quota requests. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The target Azure resource URI. For example, `/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`. This is the target Azure resource URI for the List GET operation. If a `{resourceName}` is added after `/quotas`, then it&apos;s the target Azure resource URI in the GET operation for the specific resource. </param>
        /// <param name="filter">
        /// | Field                    | Supported operators  
        /// |---------------------|------------------------
        /// 
        /// |requestSubmitTime | ge, le, eq, gt, lt
        ///  |provisioningState eq {QuotaRequestState}
        ///  |resourceName eq {resourceName}
        /// 
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> The **Skiptoken** parameter is used only if a previous operation returned a partial result. If a previous response contains a **nextLink** element, its value includes a **skiptoken** parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<QuotaRequestDetailsList>> ListNextPageAsync(string nextLink, string scope, string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListNextPageRequest(nextLink, scope, filter, top, skiptoken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaRequestDetailsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QuotaRequestDetailsList.DeserializeQuotaRequestDetailsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> For the specified scope, get the current quota requests for a one year period ending at the time is made. Use the **oData** filter to select quota requests. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The target Azure resource URI. For example, `/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`. This is the target Azure resource URI for the List GET operation. If a `{resourceName}` is added after `/quotas`, then it&apos;s the target Azure resource URI in the GET operation for the specific resource. </param>
        /// <param name="filter">
        /// | Field                    | Supported operators  
        /// |---------------------|------------------------
        /// 
        /// |requestSubmitTime | ge, le, eq, gt, lt
        ///  |provisioningState eq {QuotaRequestState}
        ///  |resourceName eq {resourceName}
        /// 
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> The **Skiptoken** parameter is used only if a previous operation returned a partial result. If a previous response contains a **nextLink** element, its value includes a **skiptoken** parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public Response<QuotaRequestDetailsList> ListNextPage(string nextLink, string scope, string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListNextPageRequest(nextLink, scope, filter, top, skiptoken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaRequestDetailsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QuotaRequestDetailsList.DeserializeQuotaRequestDetailsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
