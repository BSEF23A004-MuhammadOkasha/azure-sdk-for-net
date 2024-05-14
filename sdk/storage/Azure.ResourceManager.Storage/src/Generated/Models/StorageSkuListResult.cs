// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The response from the List Storage SKUs operation. </summary>
    internal partial class StorageSkuListResult
    {
        /// <summary> Initializes a new instance of <see cref="StorageSkuListResult"/>. </summary>
        internal StorageSkuListResult()
        {
            Value = new ChangeTrackingList<StorageSkuInformation>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageSkuListResult"/>. </summary>
        /// <param name="value"> Get the list result of storage SKUs and their properties. </param>
        internal StorageSkuListResult(IReadOnlyList<StorageSkuInformation> value)
        {
            Value = value;
        }

        /// <summary> Get the list result of storage SKUs and their properties. </summary>
        public IReadOnlyList<StorageSkuInformation> Value { get; }
    }
}
