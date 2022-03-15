// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The FlavorData. </summary>
    public partial class FlavorData
    {
        /// <summary> Initializes a new instance of FlavorData. </summary>
        public FlavorData()
        {
            Data = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of FlavorData. </summary>
        /// <param name="data"> Model flavor-specific data. </param>
        internal FlavorData(IDictionary<string, string> data)
        {
            Data = data;
        }

        /// <summary> Model flavor-specific data. </summary>
        public IDictionary<string, string> Data { get; set; }
    }
}
