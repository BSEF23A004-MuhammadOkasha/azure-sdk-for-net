// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The exposure control response. </summary>
    public partial class ExposureControlResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExposureControlResult"/>. </summary>
        internal ExposureControlResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExposureControlResult"/>. </summary>
        /// <param name="featureName"> The feature name. </param>
        /// <param name="value"> The feature value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExposureControlResult(string featureName, string value, Dictionary<string, BinaryData> rawData)
        {
            FeatureName = featureName;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The feature name. </summary>
        public string FeatureName { get; }
        /// <summary> The feature value. </summary>
        public string Value { get; }
    }
}
