// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Array of StorageSyncServices. </summary>
    internal partial class StorageSyncServiceArray
    {
        /// <summary> Initializes a new instance of <see cref="StorageSyncServiceArray"/>. </summary>
        internal StorageSyncServiceArray()
        {
            Value = new ChangeTrackingList<StorageSyncServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageSyncServiceArray"/>. </summary>
        /// <param name="value"> Collection of StorageSyncServices. </param>
        internal StorageSyncServiceArray(IReadOnlyList<StorageSyncServiceData> value)
        {
            Value = value;
        }

        /// <summary> Collection of StorageSyncServices. </summary>
        public IReadOnlyList<StorageSyncServiceData> Value { get; }
    }
}
