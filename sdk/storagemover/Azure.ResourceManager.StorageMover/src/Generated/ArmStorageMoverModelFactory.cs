// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageMover;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmStorageMoverModelFactory
    {
        /// <summary> Initializes a new instance of StorageMoverData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> A description for the Storage Mover. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <returns> A new <see cref="StorageMover.StorageMoverData"/> instance for mocking. </returns>
        public static StorageMoverData StorageMoverData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string description = null, StorageMoverProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new StorageMoverData(id, name, resourceType, systemData, tags, location, description, provisioningState);
        }

        /// <summary> Initializes a new instance of StorageMoverAgentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> A description for the Agent. </param>
        /// <param name="agentVersion"> The Agent version. </param>
        /// <param name="arcResourceId"> The fully qualified resource ID of the Hybrid Compute resource for the Agent. </param>
        /// <param name="arcVmUuid"> The VM UUID of the Hybrid Compute resource for the Agent. </param>
        /// <param name="agentStatus"> The Agent status. </param>
        /// <param name="lastStatusUpdate"> The last updated time of the Agent status. </param>
        /// <param name="localIPAddress"> Local IP address reported by the Agent. </param>
        /// <param name="memoryInMB"> Available memory reported by the Agent, in MB. </param>
        /// <param name="numberOfCores"> Available compute cores reported by the Agent. </param>
        /// <param name="uptimeInSeconds"> Uptime of the Agent in seconds. </param>
        /// <param name="errorDetails"></param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <returns> A new <see cref="StorageMover.StorageMoverAgentData"/> instance for mocking. </returns>
        public static StorageMoverAgentData StorageMoverAgentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string description = null, string agentVersion = null, string arcResourceId = null, string arcVmUuid = null, StorageMoverAgentStatus? agentStatus = null, DateTimeOffset? lastStatusUpdate = null, string localIPAddress = null, long? memoryInMB = null, long? numberOfCores = null, long? uptimeInSeconds = null, StorageMoverAgentPropertiesErrorDetails errorDetails = null, StorageMoverProvisioningState? provisioningState = null)
        {
            return new StorageMoverAgentData(id, name, resourceType, systemData, description, agentVersion, arcResourceId, arcVmUuid, agentStatus, lastStatusUpdate, localIPAddress, memoryInMB, numberOfCores, uptimeInSeconds, errorDetails, provisioningState);
        }

        /// <summary> Initializes a new instance of StorageMoverAgentPropertiesErrorDetails. </summary>
        /// <param name="code"> Error code reported by Agent. </param>
        /// <param name="message"> Expanded description of reported error code. </param>
        /// <returns> A new <see cref="Models.StorageMoverAgentPropertiesErrorDetails"/> instance for mocking. </returns>
        public static StorageMoverAgentPropertiesErrorDetails StorageMoverAgentPropertiesErrorDetails(string code = null, string message = null)
        {
            return new StorageMoverAgentPropertiesErrorDetails(code, message);
        }

        /// <summary> Initializes a new instance of StorageMoverEndpointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// The resource specific properties for the Storage Mover resource.
        /// Please note <see cref="Models.EndpointBaseProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.AzureStorageBlobContainerEndpointProperties"/>, <see cref="Models.AzureStorageSmbFileShareEndpointProperties"/>, <see cref="Models.NfsMountEndpointProperties"/> and <see cref="Models.SmbMountEndpointProperties"/>.
        /// </param>
        /// <returns> A new <see cref="StorageMover.StorageMoverEndpointData"/> instance for mocking. </returns>
        public static StorageMoverEndpointData StorageMoverEndpointData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, EndpointBaseProperties properties = null)
        {
            return new StorageMoverEndpointData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of EndpointBaseProperties. </summary>
        /// <param name="endpointType"> The Endpoint resource type. </param>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <returns> A new <see cref="Models.EndpointBaseProperties"/> instance for mocking. </returns>
        public static EndpointBaseProperties EndpointBaseProperties(string endpointType = "Unknown", string description = null, StorageMoverProvisioningState? provisioningState = null)
        {
            return new UnknownEndpointBaseProperties(endpointType, description, provisioningState);
        }

        /// <summary> Initializes a new instance of StorageMoverProjectData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> A description for the Project. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <returns> A new <see cref="StorageMover.StorageMoverProjectData"/> instance for mocking. </returns>
        public static StorageMoverProjectData StorageMoverProjectData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string description = null, StorageMoverProvisioningState? provisioningState = null)
        {
            return new StorageMoverProjectData(id, name, resourceType, systemData, description, provisioningState);
        }

        /// <summary> Initializes a new instance of JobDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> A description for the Job Definition. </param>
        /// <param name="copyMode"> Strategy to use for copy. </param>
        /// <param name="sourceName"> The name of the source Endpoint. </param>
        /// <param name="sourceResourceId"> Fully qualified resource ID of the source Endpoint. </param>
        /// <param name="sourceSubpath"> The subpath to use when reading from the source Endpoint. </param>
        /// <param name="targetName"> The name of the target Endpoint. </param>
        /// <param name="targetResourceId"> Fully qualified resource ID of the target Endpoint. </param>
        /// <param name="targetSubpath"> The subpath to use when writing to the target Endpoint. </param>
        /// <param name="latestJobRunName"> The name of the Job Run in a non-terminal state, if exists. </param>
        /// <param name="latestJobRunResourceId"> The fully qualified resource ID of the Job Run in a non-terminal state, if exists. </param>
        /// <param name="latestJobRunStatus"> The current status of the Job Run in a non-terminal state, if exists. </param>
        /// <param name="agentName"> Name of the Agent to assign for new Job Runs of this Job Definition. </param>
        /// <param name="agentResourceId"> Fully qualified resource id of the Agent to assign for new Job Runs of this Job Definition. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <returns> A new <see cref="StorageMover.JobDefinitionData"/> instance for mocking. </returns>
        public static JobDefinitionData JobDefinitionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string description = null, StorageMoverCopyMode copyMode = default, string sourceName = null, ResourceIdentifier sourceResourceId = null, string sourceSubpath = null, string targetName = null, ResourceIdentifier targetResourceId = null, string targetSubpath = null, string latestJobRunName = null, ResourceIdentifier latestJobRunResourceId = null, JobRunStatus? latestJobRunStatus = null, string agentName = null, ResourceIdentifier agentResourceId = null, StorageMoverProvisioningState? provisioningState = null)
        {
            return new JobDefinitionData(id, name, resourceType, systemData, description, copyMode, sourceName, sourceResourceId, sourceSubpath, targetName, targetResourceId, targetSubpath, latestJobRunName, latestJobRunResourceId, latestJobRunStatus, agentName, agentResourceId, provisioningState);
        }

        /// <summary> Initializes a new instance of JobRunResourceId. </summary>
        /// <param name="jobRunResourceIdValue"> Fully qualified resource id of the Job Run. </param>
        /// <returns> A new <see cref="Models.JobRunResourceId"/> instance for mocking. </returns>
        public static JobRunResourceId JobRunResourceId(ResourceIdentifier jobRunResourceIdValue = null)
        {
            return new JobRunResourceId(jobRunResourceIdValue);
        }

        /// <summary> Initializes a new instance of JobRunData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> The state of the job execution. </param>
        /// <param name="scanStatus"> The status of Agent's scanning of source. </param>
        /// <param name="agentName"> Name of the Agent assigned to this run. </param>
        /// <param name="agentResourceId"> Fully qualified resource id of the Agent assigned to this run. </param>
        /// <param name="executionStartOn"> Start time of the run. Null if no Agent reported that the job has started. </param>
        /// <param name="executionEndOn"> End time of the run. Null if Agent has not reported that the job has ended. </param>
        /// <param name="lastStatusUpdate"> The last updated time of the Job Run. </param>
        /// <param name="itemsScanned"> Number of items scanned so far in source. </param>
        /// <param name="itemsExcluded"> Number of items that will not be transferred, as they are excluded by user configuration. </param>
        /// <param name="itemsUnsupported"> Number of items that will not be transferred, as they are unsupported on target. </param>
        /// <param name="itemsNoTransferNeeded"> Number of items that will not be transferred, as they are already found on target (e.g. mirror mode). </param>
        /// <param name="itemsFailed"> Number of items that were attempted to transfer and failed. </param>
        /// <param name="itemsTransferred"> Number of items successfully transferred to target. </param>
        /// <param name="bytesScanned"> Bytes of data scanned so far in source. </param>
        /// <param name="bytesExcluded"> Bytes of data that will not be transferred, as they are excluded by user configuration. </param>
        /// <param name="bytesUnsupported"> Bytes of data that will not be transferred, as they are unsupported on target. </param>
        /// <param name="bytesNoTransferNeeded"> Bytes of data that will not be transferred, as they are already found on target (e.g. mirror mode). </param>
        /// <param name="bytesFailed"> Bytes of data that were attempted to transfer and failed. </param>
        /// <param name="bytesTransferred"> Bytes of data successfully transferred to target. </param>
        /// <param name="sourceName"> Name of source Endpoint resource. This resource may no longer exist. </param>
        /// <param name="sourceResourceId"> Fully qualified resource id of source Endpoint. This id may no longer exist. </param>
        /// <param name="sourceProperties"> Copy of source Endpoint resource's properties at time of Job Run creation. </param>
        /// <param name="targetName"> Name of target Endpoint resource. This resource may no longer exist. </param>
        /// <param name="targetResourceId"> Fully qualified resource id of of Endpoint. This id may no longer exist. </param>
        /// <param name="targetProperties"> Copy of Endpoint resource's properties at time of Job Run creation. </param>
        /// <param name="jobDefinitionProperties"> Copy of parent Job Definition's properties at time of Job Run creation. </param>
        /// <param name="error"> Error details. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <returns> A new <see cref="StorageMover.JobRunData"/> instance for mocking. </returns>
        public static JobRunData JobRunData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, JobRunStatus? status = null, JobRunScanStatus? scanStatus = null, string agentName = null, ResourceIdentifier agentResourceId = null, DateTimeOffset? executionStartOn = null, DateTimeOffset? executionEndOn = null, DateTimeOffset? lastStatusUpdate = null, long? itemsScanned = null, long? itemsExcluded = null, long? itemsUnsupported = null, long? itemsNoTransferNeeded = null, long? itemsFailed = null, long? itemsTransferred = null, long? bytesScanned = null, long? bytesExcluded = null, long? bytesUnsupported = null, long? bytesNoTransferNeeded = null, long? bytesFailed = null, long? bytesTransferred = null, string sourceName = null, ResourceIdentifier sourceResourceId = null, BinaryData sourceProperties = null, string targetName = null, ResourceIdentifier targetResourceId = null, BinaryData targetProperties = null, BinaryData jobDefinitionProperties = null, JobRunError error = null, StorageMoverProvisioningState? provisioningState = null)
        {
            return new JobRunData(id, name, resourceType, systemData, status, scanStatus, agentName, agentResourceId, executionStartOn, executionEndOn, lastStatusUpdate, itemsScanned, itemsExcluded, itemsUnsupported, itemsNoTransferNeeded, itemsFailed, itemsTransferred, bytesScanned, bytesExcluded, bytesUnsupported, bytesNoTransferNeeded, bytesFailed, bytesTransferred, sourceName, sourceResourceId, sourceProperties, targetName, targetResourceId, targetProperties, jobDefinitionProperties, error, provisioningState);
        }

        /// <summary> Initializes a new instance of JobRunError. </summary>
        /// <param name="code"> Error code of the given entry. </param>
        /// <param name="message"> Error message of the given entry. </param>
        /// <param name="target"> Target of the given error entry. </param>
        /// <returns> A new <see cref="Models.JobRunError"/> instance for mocking. </returns>
        public static JobRunError JobRunError(string code = null, string message = null, string target = null)
        {
            return new JobRunError(code, message, target);
        }

        /// <summary> Initializes a new instance of AzureStorageBlobContainerEndpointProperties. </summary>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <param name="storageAccountResourceId"> The Azure Resource ID of the storage account that is the target destination. </param>
        /// <param name="blobContainerName"> The name of the Storage blob container that is the target destination. </param>
        /// <returns> A new <see cref="Models.AzureStorageBlobContainerEndpointProperties"/> instance for mocking. </returns>
        public static AzureStorageBlobContainerEndpointProperties AzureStorageBlobContainerEndpointProperties(string description = null, StorageMoverProvisioningState? provisioningState = null, string storageAccountResourceId = null, string blobContainerName = null)
        {
            return new AzureStorageBlobContainerEndpointProperties(EndpointType.AzureStorageBlobContainer, description, provisioningState, storageAccountResourceId, blobContainerName);
        }

        /// <summary> Initializes a new instance of NfsMountEndpointProperties. </summary>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <param name="host"> The host name or IP address of the server exporting the file system. </param>
        /// <param name="nfsVersion"> The NFS protocol version. </param>
        /// <param name="export"> The directory being exported from the server. </param>
        /// <returns> A new <see cref="Models.NfsMountEndpointProperties"/> instance for mocking. </returns>
        public static NfsMountEndpointProperties NfsMountEndpointProperties(string description = null, StorageMoverProvisioningState? provisioningState = null, string host = null, NfsVersion? nfsVersion = null, string export = null)
        {
            return new NfsMountEndpointProperties(EndpointType.NfsMount, description, provisioningState, host, nfsVersion, export);
        }

        /// <summary> Initializes a new instance of AzureStorageSmbFileShareEndpointProperties. </summary>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <param name="storageAccountResourceId"> The Azure Resource ID of the storage account. </param>
        /// <param name="fileShareName"> The name of the Azure Storage file share. </param>
        /// <returns> A new <see cref="Models.AzureStorageSmbFileShareEndpointProperties"/> instance for mocking. </returns>
        public static AzureStorageSmbFileShareEndpointProperties AzureStorageSmbFileShareEndpointProperties(string description = null, StorageMoverProvisioningState? provisioningState = null, ResourceIdentifier storageAccountResourceId = null, string fileShareName = null)
        {
            return new AzureStorageSmbFileShareEndpointProperties(EndpointType.AzureStorageSmbFileShare, description, provisioningState, storageAccountResourceId, fileShareName);
        }

        /// <summary> Initializes a new instance of SmbMountEndpointProperties. </summary>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <param name="host"> The host name or IP address of the server exporting the file system. </param>
        /// <param name="shareName"> The name of the SMB share being exported from the server. </param>
        /// <param name="credentials"> The Azure Key Vault secret URIs which store the required credentials to access the SMB share. </param>
        /// <returns> A new <see cref="Models.SmbMountEndpointProperties"/> instance for mocking. </returns>
        public static SmbMountEndpointProperties SmbMountEndpointProperties(string description = null, StorageMoverProvisioningState? provisioningState = null, string host = null, string shareName = null, AzureKeyVaultSmbCredentials credentials = null)
        {
            return new SmbMountEndpointProperties(EndpointType.SmbMount, description, provisioningState, host, shareName, credentials);
        }
    }
}
