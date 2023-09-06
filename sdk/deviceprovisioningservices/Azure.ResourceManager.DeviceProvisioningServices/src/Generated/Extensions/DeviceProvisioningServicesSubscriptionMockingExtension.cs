// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceProvisioningServices;
using Azure.ResourceManager.DeviceProvisioningServices.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class DeviceProvisioningServicesSubscriptionMockingExtension : ArmResource
    {
        private ClientDiagnostics _deviceProvisioningServiceIotDpsResourceClientDiagnostics;
        private IotDpsResourceRestOperations _deviceProvisioningServiceIotDpsResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesSubscriptionMockingExtension"/> class for mocking. </summary>
        protected DeviceProvisioningServicesSubscriptionMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesSubscriptionMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeviceProvisioningServicesSubscriptionMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DeviceProvisioningServiceIotDpsResourceClientDiagnostics => _deviceProvisioningServiceIotDpsResourceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DeviceProvisioningServices", DeviceProvisioningServiceResource.ResourceType.Namespace, Diagnostics);
        private IotDpsResourceRestOperations DeviceProvisioningServiceIotDpsResourceRestClient => _deviceProvisioningServiceIotDpsResourceRestClient ??= new IotDpsResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DeviceProvisioningServiceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all the provisioning services for a given subscription id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/provisioningServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceProvisioningServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceProvisioningServiceResource> GetDeviceProvisioningServicesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeviceProvisioningServiceIotDpsResourceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DeviceProvisioningServiceIotDpsResourceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeviceProvisioningServiceResource(Client, DeviceProvisioningServiceData.DeserializeDeviceProvisioningServiceData(e)), DeviceProvisioningServiceIotDpsResourceClientDiagnostics, Pipeline, "DeviceProvisioningServicesSubscriptionMockingExtension.GetDeviceProvisioningServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the provisioning services for a given subscription id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/provisioningServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceProvisioningServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceProvisioningServiceResource> GetDeviceProvisioningServices(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeviceProvisioningServiceIotDpsResourceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DeviceProvisioningServiceIotDpsResourceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeviceProvisioningServiceResource(Client, DeviceProvisioningServiceData.DeserializeDeviceProvisioningServiceData(e)), DeviceProvisioningServiceIotDpsResourceClientDiagnostics, Pipeline, "DeviceProvisioningServicesSubscriptionMockingExtension.GetDeviceProvisioningServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check if a provisioning service name is available. This will validate if the name is syntactically valid and if the name is usable
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/checkProvisioningServiceNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_CheckProvisioningServiceNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the provisioning service to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<DeviceProvisioningServicesNameAvailabilityResult>> CheckDeviceProvisioningServicesNameAvailabilityAsync(DeviceProvisioningServicesNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DeviceProvisioningServiceIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesSubscriptionMockingExtension.CheckDeviceProvisioningServicesNameAvailability");
            scope.Start();
            try
            {
                var response = await DeviceProvisioningServiceIotDpsResourceRestClient.CheckProvisioningServiceNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a provisioning service name is available. This will validate if the name is syntactically valid and if the name is usable
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/checkProvisioningServiceNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_CheckProvisioningServiceNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the provisioning service to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<DeviceProvisioningServicesNameAvailabilityResult> CheckDeviceProvisioningServicesNameAvailability(DeviceProvisioningServicesNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DeviceProvisioningServiceIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesSubscriptionMockingExtension.CheckDeviceProvisioningServicesNameAvailability");
            scope.Start();
            try
            {
                var response = DeviceProvisioningServiceIotDpsResourceRestClient.CheckProvisioningServiceNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
