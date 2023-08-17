// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The observed state of storage containers. </summary>
    public partial class HciStorageContainerStatus
    {
        /// <summary> Initializes a new instance of HciStorageContainerStatus. </summary>
        internal HciStorageContainerStatus()
        {
        }

        /// <summary> Initializes a new instance of HciStorageContainerStatus. </summary>
        /// <param name="errorCode"> StorageContainer provisioning error code. </param>
        /// <param name="errorMessage"> Descriptive error message. </param>
        /// <param name="availableSizeMB"> Amount of space available on the disk in MB. </param>
        /// <param name="containerSizeMB"> Total size of the disk in MB. </param>
        /// <param name="provisioningStatus"></param>
        internal HciStorageContainerStatus(string errorCode, string errorMessage, long? availableSizeMB, long? containerSizeMB, HciStorageContainerProvisioningStatus provisioningStatus)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            AvailableSizeMB = availableSizeMB;
            ContainerSizeMB = containerSizeMB;
            ProvisioningStatus = provisioningStatus;
        }

        /// <summary> StorageContainer provisioning error code. </summary>
        public string ErrorCode { get; }
        /// <summary> Descriptive error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Amount of space available on the disk in MB. </summary>
        public long? AvailableSizeMB { get; }
        /// <summary> Total size of the disk in MB. </summary>
        public long? ContainerSizeMB { get; }
        /// <summary> Gets the provisioning status. </summary>
        public HciStorageContainerProvisioningStatus ProvisioningStatus { get; }
    }
}
