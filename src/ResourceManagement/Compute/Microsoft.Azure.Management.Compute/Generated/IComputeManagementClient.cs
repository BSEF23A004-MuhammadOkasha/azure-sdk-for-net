// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Composite Swagger for Compute Client
    /// </summary>
    public partial interface IComputeManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every
        /// service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IAvailabilitySetsOperations.
        /// </summary>
        IAvailabilitySetsOperations AvailabilitySets { get; }

        /// <summary>
        /// Gets the IVirtualMachineExtensionImagesOperations.
        /// </summary>
        IVirtualMachineExtensionImagesOperations VirtualMachineExtensionImages { get; }

        /// <summary>
        /// Gets the IVirtualMachineExtensionsOperations.
        /// </summary>
        IVirtualMachineExtensionsOperations VirtualMachineExtensions { get; }

        /// <summary>
        /// Gets the IVirtualMachineImagesOperations.
        /// </summary>
        IVirtualMachineImagesOperations VirtualMachineImages { get; }

        /// <summary>
        /// Gets the IUsageOperations.
        /// </summary>
        IUsageOperations Usage { get; }

        /// <summary>
        /// Gets the IVirtualMachineSizesOperations.
        /// </summary>
        IVirtualMachineSizesOperations VirtualMachineSizes { get; }

        /// <summary>
        /// Gets the IImagesOperations.
        /// </summary>
        IImagesOperations Images { get; }

        /// <summary>
        /// Gets the IVirtualMachinesOperations.
        /// </summary>
        IVirtualMachinesOperations VirtualMachines { get; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetsOperations.
        /// </summary>
        IVirtualMachineScaleSetsOperations VirtualMachineScaleSets { get; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetVMsOperations.
        /// </summary>
        IVirtualMachineScaleSetVMsOperations VirtualMachineScaleSetVMs { get; }

        /// <summary>
        /// Gets the IContainerServicesOperations.
        /// </summary>
        IContainerServicesOperations ContainerServices { get; }

        /// <summary>
        /// Gets the IDisksOperations.
        /// </summary>
        IDisksOperations Disks { get; }

        /// <summary>
        /// Gets the ISnapshotsOperations.
        /// </summary>
        ISnapshotsOperations Snapshots { get; }

    }
}

