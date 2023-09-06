// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Wraps data-residency related information for edge-resource and this should be used with ARM layer. </summary>
    internal partial class DataResidency
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataResidency"/>. </summary>
        public DataResidency()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataResidency"/>. </summary>
        /// <param name="residencyType"> DataResidencyType enum. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataResidency(DataBoxEdgeDataResidencyType? residencyType, Dictionary<string, BinaryData> rawData)
        {
            ResidencyType = residencyType;
            _rawData = rawData;
        }

        /// <summary> DataResidencyType enum. </summary>
        public DataBoxEdgeDataResidencyType? ResidencyType { get; set; }
    }
}
