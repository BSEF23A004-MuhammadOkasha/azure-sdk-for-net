// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters used to update a Data Lake Store account while updating a Data Lake Analytics account.
    /// Serialized Name: UpdateDataLakeStoreWithAccountParameters
    /// </summary>
    public partial class DataLakeStoreForDataLakeAnalyticsAccountUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreForDataLakeAnalyticsAccountUpdateContent"/>. </summary>
        /// <param name="name">
        /// The unique name of the Data Lake Store account to update.
        /// Serialized Name: UpdateDataLakeStoreWithAccountParameters.name
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DataLakeStoreForDataLakeAnalyticsAccountUpdateContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreForDataLakeAnalyticsAccountUpdateContent"/>. </summary>
        /// <param name="name">
        /// The unique name of the Data Lake Store account to update.
        /// Serialized Name: UpdateDataLakeStoreWithAccountParameters.name
        /// </param>
        /// <param name="suffix">
        /// The optional suffix for the Data Lake Store account.
        /// Serialized Name: UpdateDataLakeStoreWithAccountParameters.properties.suffix
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreForDataLakeAnalyticsAccountUpdateContent(string name, string suffix, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Suffix = suffix;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreForDataLakeAnalyticsAccountUpdateContent"/> for deserialization. </summary>
        internal DataLakeStoreForDataLakeAnalyticsAccountUpdateContent()
        {
        }

        /// <summary>
        /// The unique name of the Data Lake Store account to update.
        /// Serialized Name: UpdateDataLakeStoreWithAccountParameters.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The optional suffix for the Data Lake Store account.
        /// Serialized Name: UpdateDataLakeStoreWithAccountParameters.properties.suffix
        /// </summary>
        public string Suffix { get; set; }
    }
}
