// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents
{
    internal partial class SynonymMapsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal SynonymMapsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of SynonymMapsClient for mocking. </summary>
        protected SynonymMapsClient()
        {
        }
        /// <summary> Initializes a new instance of SynonymMapsClient. </summary>
        internal SynonymMapsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-05-06-Preview")
        {
            RestClient = new SynonymMapsRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Creates a new synonym map or updates a synonym map if it already exists. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynonymMap>> CreateOrUpdateAsync(string synonymMapName, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, SynonymMap synonymMap, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateOrUpdateAsync(synonymMapName, xMsClientRequestId, ifMatch, ifNoneMatch, synonymMap, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new synonym map or updates a synonym map if it already exists. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynonymMap> CreateOrUpdate(string synonymMapName, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, SynonymMap synonymMap, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateOrUpdate(synonymMapName, xMsClientRequestId, ifMatch, ifNoneMatch, synonymMap, cancellationToken);
        }

        /// <summary> Deletes a synonym map. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to delete. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string synonymMapName, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(synonymMapName, xMsClientRequestId, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a synonym map. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to delete. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string synonymMapName, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(synonymMapName, xMsClientRequestId, ifMatch, ifNoneMatch, cancellationToken);
        }

        /// <summary> Retrieves a synonym map definition. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to retrieve. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynonymMap>> GetAsync(string synonymMapName, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(synonymMapName, xMsClientRequestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves a synonym map definition. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to retrieve. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynonymMap> Get(string synonymMapName, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(synonymMapName, xMsClientRequestId, cancellationToken);
        }

        /// <summary> Lists all synonym maps available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the synonym maps to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ListSynonymMapsResult>> ListAsync(string select, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListAsync(select, xMsClientRequestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all synonym maps available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the synonym maps to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ListSynonymMapsResult> List(string select, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.List(select, xMsClientRequestId, cancellationToken);
        }

        /// <summary> Creates a new synonym map. </summary>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynonymMap>> CreateAsync(Guid? xMsClientRequestId, SynonymMap synonymMap, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateAsync(xMsClientRequestId, synonymMap, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new synonym map. </summary>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynonymMap> Create(Guid? xMsClientRequestId, SynonymMap synonymMap, CancellationToken cancellationToken = default)
        {
            return RestClient.Create(xMsClientRequestId, synonymMap, cancellationToken);
        }
    }
}
