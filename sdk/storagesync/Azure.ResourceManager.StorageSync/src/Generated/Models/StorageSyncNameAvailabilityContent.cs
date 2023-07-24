// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Parameters for a check name availability request. </summary>
    public partial class StorageSyncNameAvailabilityContent
    {
        /// <summary> The name to check for availability. </summary>
        public string Name { get; }
        /// <summary> The resource type. Must be set to Microsoft.StorageSync/storageSyncServices. </summary>
        public StorageSyncResourceType ResourceType { get; }
    }
}
