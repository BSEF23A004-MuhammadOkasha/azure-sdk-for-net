// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> EventHubs service management client. </summary>
    public class EventHubsManagementClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        private readonly string _subscriptionId;
        private readonly Uri _endpoint;

        /// <summary> Initializes a new instance of EventHubsManagementClient for mocking. </summary>
        protected EventHubsManagementClient()
        {
        }

        /// <summary> Initializes a new instance of EventHubsManagementClient. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public EventHubsManagementClient(string subscriptionId, TokenCredential tokenCredential, EventHubsManagementClientOptions options = null) : this(subscriptionId, null, tokenCredential, options)
        {
        }
        /// <summary> Initializes a new instance of EventHubsManagementClient. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public EventHubsManagementClient(string subscriptionId, Uri endpoint, TokenCredential tokenCredential, EventHubsManagementClientOptions options = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            options ??= new EventHubsManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, endpoint, options);
            _subscriptionId = subscriptionId;
            _endpoint = endpoint;
        }

        /// <summary> Returns an instance of ClustersOperations. </summary>
        public virtual ClustersOperations Clusters => new ClustersOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of NamespacesOperations. </summary>
        public virtual NamespacesOperations Namespaces => new NamespacesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of ConfigurationOperations. </summary>
        public virtual ConfigurationOperations Configuration => new ConfigurationOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of DisasterRecoveryConfigsOperations. </summary>
        public virtual DisasterRecoveryConfigsOperations DisasterRecoveryConfigs => new DisasterRecoveryConfigsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of EventHubsOperations. </summary>
        public virtual EventHubsOperations EventHubs => new EventHubsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of ConsumerGroupsOperations. </summary>
        public virtual ConsumerGroupsOperations ConsumerGroups => new ConsumerGroupsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of Operations. </summary>
        public virtual Operations Operations => new Operations(_clientDiagnostics, _pipeline, _endpoint);

        /// <summary> Returns an instance of RegionsOperations. </summary>
        public virtual RegionsOperations Regions => new RegionsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
    }
}
