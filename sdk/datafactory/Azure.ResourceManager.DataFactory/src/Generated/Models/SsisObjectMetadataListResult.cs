// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A list of SSIS object metadata. </summary>
    internal partial class SsisObjectMetadataListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SsisObjectMetadataListResult"/>. </summary>
        internal SsisObjectMetadataListResult()
        {
            Value = new ChangeTrackingList<SsisObjectMetadata>();
        }

        /// <summary> Initializes a new instance of <see cref="SsisObjectMetadataListResult"/>. </summary>
        /// <param name="value">
        /// List of SSIS object metadata.
        /// Please note <see cref="SsisObjectMetadata"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SsisEnvironment"/>, <see cref="SsisFolder"/>, <see cref="SsisPackage"/> and <see cref="SsisProject"/>.
        /// </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SsisObjectMetadataListResult(IReadOnlyList<SsisObjectMetadata> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary>
        /// List of SSIS object metadata.
        /// Please note <see cref="SsisObjectMetadata"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SsisEnvironment"/>, <see cref="SsisFolder"/>, <see cref="SsisPackage"/> and <see cref="SsisProject"/>.
        /// </summary>
        public IReadOnlyList<SsisObjectMetadata> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
