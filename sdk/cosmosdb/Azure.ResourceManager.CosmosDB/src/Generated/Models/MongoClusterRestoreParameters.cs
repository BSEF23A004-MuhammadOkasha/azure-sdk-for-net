// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters used for restore operations. </summary>
    public partial class MongoClusterRestoreParameters
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MongoClusterRestoreParameters"/>. </summary>
        public MongoClusterRestoreParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MongoClusterRestoreParameters"/>. </summary>
        /// <param name="pointInTimeUTC"> UTC point in time to restore a mongo cluster. </param>
        /// <param name="sourceResourceId"> Resource ID to locate the source cluster to restore. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoClusterRestoreParameters(DateTimeOffset? pointInTimeUTC, string sourceResourceId, Dictionary<string, BinaryData> rawData)
        {
            PointInTimeUTC = pointInTimeUTC;
            SourceResourceId = sourceResourceId;
            _rawData = rawData;
        }

        /// <summary> UTC point in time to restore a mongo cluster. </summary>
        public DateTimeOffset? PointInTimeUTC { get; set; }
        /// <summary> Resource ID to locate the source cluster to restore. </summary>
        public string SourceResourceId { get; set; }
    }
}
