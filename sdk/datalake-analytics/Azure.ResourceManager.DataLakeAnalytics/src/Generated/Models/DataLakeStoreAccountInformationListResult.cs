// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataLakeAnalytics;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// Data Lake Store account list information.
    /// Serialized Name: DataLakeStoreAccountInformationListResult
    /// </summary>
    internal partial class DataLakeStoreAccountInformationListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountInformationListResult"/>. </summary>
        internal DataLakeStoreAccountInformationListResult()
        {
            Value = new ChangeTrackingList<DataLakeStoreAccountInformationData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountInformationListResult"/>. </summary>
        /// <param name="value">
        /// The results of the list operation.
        /// Serialized Name: DataLakeStoreAccountInformationListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The link (url) to the next page of results.
        /// Serialized Name: DataLakeStoreAccountInformationListResult.nextLink
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreAccountInformationListResult(IReadOnlyList<DataLakeStoreAccountInformationData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary>
        /// The results of the list operation.
        /// Serialized Name: DataLakeStoreAccountInformationListResult.value
        /// </summary>
        public IReadOnlyList<DataLakeStoreAccountInformationData> Value { get; }
        /// <summary>
        /// The link (url) to the next page of results.
        /// Serialized Name: DataLakeStoreAccountInformationListResult.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
