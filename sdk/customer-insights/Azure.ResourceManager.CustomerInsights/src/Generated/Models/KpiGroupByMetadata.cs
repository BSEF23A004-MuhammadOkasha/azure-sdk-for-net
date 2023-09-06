// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The KPI GroupBy field metadata. </summary>
    public partial class KpiGroupByMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KpiGroupByMetadata"/>. </summary>
        internal KpiGroupByMetadata()
        {
            DisplayName = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KpiGroupByMetadata"/>. </summary>
        /// <param name="displayName"> The display name. </param>
        /// <param name="fieldName"> The name of the field. </param>
        /// <param name="fieldType"> The type of the field. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KpiGroupByMetadata(IReadOnlyDictionary<string, string> displayName, string fieldName, string fieldType, Dictionary<string, BinaryData> rawData)
        {
            DisplayName = displayName;
            FieldName = fieldName;
            FieldType = fieldType;
            _rawData = rawData;
        }

        /// <summary> The display name. </summary>
        public IReadOnlyDictionary<string, string> DisplayName { get; }
        /// <summary> The name of the field. </summary>
        public string FieldName { get; }
        /// <summary> The type of the field. </summary>
        public string FieldType { get; }
    }
}
