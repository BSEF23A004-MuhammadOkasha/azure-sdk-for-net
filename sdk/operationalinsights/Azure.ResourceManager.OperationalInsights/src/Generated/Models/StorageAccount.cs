// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Describes a storage account connection. </summary>
    public partial class StorageAccount
    {
        /// <summary> Initializes a new instance of StorageAccount. </summary>
        /// <param name="id"> The Azure Resource Manager ID of the storage account resource. </param>
        /// <param name="key"> The storage account key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="key"/> is null. </exception>
        public StorageAccount(string id, string key)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Id = id;
            Key = key;
        }

        /// <summary> The Azure Resource Manager ID of the storage account resource. </summary>
        public string Id { get; set; }
        /// <summary> The storage account key. </summary>
        public string Key { get; set; }
    }
}
