// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> This class contains all the details about a critical operation. </summary>
    public partial class ResourceGuardOperationDetails
    {
        /// <summary> Initializes a new instance of <see cref="ResourceGuardOperationDetails"/>. </summary>
        internal ResourceGuardOperationDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceGuardOperationDetails"/>. </summary>
        /// <param name="vaultCriticalOperation"> Name of the critical operation. </param>
        /// <param name="requestResourceType"> Type of resource request. </param>
        internal ResourceGuardOperationDetails(string vaultCriticalOperation, ResourceType? requestResourceType)
        {
            VaultCriticalOperation = vaultCriticalOperation;
            RequestResourceType = requestResourceType;
        }

        /// <summary> Name of the critical operation. </summary>
        public string VaultCriticalOperation { get; }
        /// <summary> Type of resource request. </summary>
        public ResourceType? RequestResourceType { get; }
    }
}
