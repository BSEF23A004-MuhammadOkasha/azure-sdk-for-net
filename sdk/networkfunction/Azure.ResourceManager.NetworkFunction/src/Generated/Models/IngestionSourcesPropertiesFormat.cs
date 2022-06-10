// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkFunction.Models
{
    /// <summary> Ingestion policy properties. </summary>
    public partial class IngestionSourcesPropertiesFormat
    {
        /// <summary> Initializes a new instance of IngestionSourcesPropertiesFormat. </summary>
        public IngestionSourcesPropertiesFormat()
        {
        }

        /// <summary> Initializes a new instance of IngestionSourcesPropertiesFormat. </summary>
        /// <param name="sourceType"> Ingestion source type. </param>
        /// <param name="resourceId"> Resource ID. </param>
        internal IngestionSourcesPropertiesFormat(SourceType? sourceType, string resourceId)
        {
            SourceType = sourceType;
            ResourceId = resourceId;
        }

        /// <summary> Ingestion source type. </summary>
        public SourceType? SourceType { get; set; }
        /// <summary> Resource ID. </summary>
        public string ResourceId { get; set; }
    }
}
