// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="TopicNetworkSecurityPerimeterConfigurationResource"/> and their operations.
    /// Each <see cref="TopicNetworkSecurityPerimeterConfigurationResource"/> in the collection will belong to the same instance of <see cref="EventGridTopicResource"/>.
    /// To get a <see cref="TopicNetworkSecurityPerimeterConfigurationCollection"/> instance call the GetTopicNetworkSecurityPerimeterConfigurations method from an instance of <see cref="EventGridTopicResource"/>.
    /// </summary>
    public partial class TopicNetworkSecurityPerimeterConfigurationCollection : ArmCollection, IEnumerable<NetworkSecurityPerimeterConfigurationData>, IAsyncEnumerable<NetworkSecurityPerimeterConfigurationData>
    {
        private readonly ClientDiagnostics _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics;
        private readonly NetworkSecurityPerimeterConfigurationsRestOperations _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient;
        private readonly ClientDiagnostics _networkSecurityPerimeterConfigurationsClientDiagnostics;
        private readonly NetworkSecurityPerimeterConfigurationsRestOperations _networkSecurityPerimeterConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TopicNetworkSecurityPerimeterConfigurationCollection"/> class for mocking. </summary>
        protected TopicNetworkSecurityPerimeterConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TopicNetworkSecurityPerimeterConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TopicNetworkSecurityPerimeterConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", TopicNetworkSecurityPerimeterConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TopicNetworkSecurityPerimeterConfigurationResource.ResourceType, out string topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsApiVersion);
            _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient = new NetworkSecurityPerimeterConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsApiVersion);
            _networkSecurityPerimeterConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _networkSecurityPerimeterConfigurationsRestClient = new NetworkSecurityPerimeterConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventGridTopicResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventGridTopicResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a specific network security perimeter configuration with a topic or domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}.{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="perimeterGuid"> Unique identifier for perimeter. </param>
        /// <param name="associationName"> Association name to association network security perimeter resource to profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is null. </exception>
        public virtual async Task<Response<TopicNetworkSecurityPerimeterConfigurationResource>> GetAsync(string perimeterGuid, string associationName, CancellationToken cancellationToken = default)
        {
            if (perimeterGuid == null)
            {
                throw new ArgumentNullException(nameof(perimeterGuid));
            }
            if (perimeterGuid.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(perimeterGuid));
            }
            if (associationName == null)
            {
                throw new ArgumentNullException(nameof(associationName));
            }
            if (associationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(associationName));
            }

            using var scope = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("TopicNetworkSecurityPerimeterConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Name, perimeterGuid, associationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicNetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific network security perimeter configuration with a topic or domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}.{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="perimeterGuid"> Unique identifier for perimeter. </param>
        /// <param name="associationName"> Association name to association network security perimeter resource to profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is null. </exception>
        public virtual Response<TopicNetworkSecurityPerimeterConfigurationResource> Get(string perimeterGuid, string associationName, CancellationToken cancellationToken = default)
        {
            if (perimeterGuid == null)
            {
                throw new ArgumentNullException(nameof(perimeterGuid));
            }
            if (perimeterGuid.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(perimeterGuid));
            }
            if (associationName == null)
            {
                throw new ArgumentNullException(nameof(associationName));
            }
            if (associationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(associationName));
            }

            using var scope = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("TopicNetworkSecurityPerimeterConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Name, perimeterGuid, associationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicNetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all network security perimeter configurations associated with a topic or domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkSecurityPerimeterConfigurationData"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkSecurityPerimeterConfigurationData> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityPerimeterConfigurationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => NetworkSecurityPerimeterConfigurationData.DeserializeNetworkSecurityPerimeterConfigurationData(e), _networkSecurityPerimeterConfigurationsClientDiagnostics, Pipeline, "TopicNetworkSecurityPerimeterConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get all network security perimeter configurations associated with a topic or domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkSecurityPerimeterConfigurationData"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkSecurityPerimeterConfigurationData> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityPerimeterConfigurationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => NetworkSecurityPerimeterConfigurationData.DeserializeNetworkSecurityPerimeterConfigurationData(e), _networkSecurityPerimeterConfigurationsClientDiagnostics, Pipeline, "TopicNetworkSecurityPerimeterConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}.{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="perimeterGuid"> Unique identifier for perimeter. </param>
        /// <param name="associationName"> Association name to association network security perimeter resource to profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string perimeterGuid, string associationName, CancellationToken cancellationToken = default)
        {
            if (perimeterGuid == null)
            {
                throw new ArgumentNullException(nameof(perimeterGuid));
            }
            if (perimeterGuid.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(perimeterGuid));
            }
            if (associationName == null)
            {
                throw new ArgumentNullException(nameof(associationName));
            }
            if (associationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(associationName));
            }

            using var scope = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("TopicNetworkSecurityPerimeterConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Name, perimeterGuid, associationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}.{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="perimeterGuid"> Unique identifier for perimeter. </param>
        /// <param name="associationName"> Association name to association network security perimeter resource to profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is null. </exception>
        public virtual Response<bool> Exists(string perimeterGuid, string associationName, CancellationToken cancellationToken = default)
        {
            if (perimeterGuid == null)
            {
                throw new ArgumentNullException(nameof(perimeterGuid));
            }
            if (perimeterGuid.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(perimeterGuid));
            }
            if (associationName == null)
            {
                throw new ArgumentNullException(nameof(associationName));
            }
            if (associationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(associationName));
            }

            using var scope = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("TopicNetworkSecurityPerimeterConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Name, perimeterGuid, associationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}.{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="perimeterGuid"> Unique identifier for perimeter. </param>
        /// <param name="associationName"> Association name to association network security perimeter resource to profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is null. </exception>
        public virtual async Task<NullableResponse<TopicNetworkSecurityPerimeterConfigurationResource>> GetIfExistsAsync(string perimeterGuid, string associationName, CancellationToken cancellationToken = default)
        {
            if (perimeterGuid == null)
            {
                throw new ArgumentNullException(nameof(perimeterGuid));
            }
            if (perimeterGuid.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(perimeterGuid));
            }
            if (associationName == null)
            {
                throw new ArgumentNullException(nameof(associationName));
            }
            if (associationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(associationName));
            }

            using var scope = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("TopicNetworkSecurityPerimeterConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Name, perimeterGuid, associationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TopicNetworkSecurityPerimeterConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new TopicNetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}.{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopicNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="perimeterGuid"> Unique identifier for perimeter. </param>
        /// <param name="associationName"> Association name to association network security perimeter resource to profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is null. </exception>
        public virtual NullableResponse<TopicNetworkSecurityPerimeterConfigurationResource> GetIfExists(string perimeterGuid, string associationName, CancellationToken cancellationToken = default)
        {
            if (perimeterGuid == null)
            {
                throw new ArgumentNullException(nameof(perimeterGuid));
            }
            if (perimeterGuid.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(perimeterGuid));
            }
            if (associationName == null)
            {
                throw new ArgumentNullException(nameof(associationName));
            }
            if (associationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(associationName));
            }

            using var scope = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("TopicNetworkSecurityPerimeterConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Name, perimeterGuid, associationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TopicNetworkSecurityPerimeterConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new TopicNetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkSecurityPerimeterConfigurationData> IEnumerable<NetworkSecurityPerimeterConfigurationData>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkSecurityPerimeterConfigurationData> IAsyncEnumerable<NetworkSecurityPerimeterConfigurationData>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
