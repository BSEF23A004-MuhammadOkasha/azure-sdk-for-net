// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The response from the List Usages operation. </summary>
    internal partial class DataLakeStoreUsageListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreUsageListResult"/>. </summary>
        internal DataLakeStoreUsageListResult()
        {
            Value = new ChangeTrackingList<DataLakeStoreUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreUsageListResult"/>. </summary>
        /// <param name="value"> Gets or sets the list of Storage Resource Usages. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreUsageListResult(IReadOnlyList<DataLakeStoreUsage> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the list of Storage Resource Usages. </summary>
        public IReadOnlyList<DataLakeStoreUsage> Value { get; }
    }
}
