// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> List of ProtectionContainer resources. </summary>
    internal partial class ProtectionContainerResourceList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProtectionContainerResourceList"/>. </summary>
        internal ProtectionContainerResourceList()
        {
            Value = new ChangeTrackingList<BackupProtectionContainerData>();
        }

        /// <summary> Initializes a new instance of <see cref="ProtectionContainerResourceList"/>. </summary>
        /// <param name="value"> List of resources. </param>
        /// <param name="nextLink"> The uri to fetch the next page of resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProtectionContainerResourceList(IReadOnlyList<BackupProtectionContainerData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of resources. </summary>
        public IReadOnlyList<BackupProtectionContainerData> Value { get; }
        /// <summary> The uri to fetch the next page of resources. </summary>
        public string NextLink { get; }
    }
}
