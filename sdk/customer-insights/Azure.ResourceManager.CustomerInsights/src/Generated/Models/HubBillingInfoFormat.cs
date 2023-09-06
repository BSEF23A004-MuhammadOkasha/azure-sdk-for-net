// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Hub billing info. </summary>
    public partial class HubBillingInfoFormat
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HubBillingInfoFormat"/>. </summary>
        public HubBillingInfoFormat()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HubBillingInfoFormat"/>. </summary>
        /// <param name="skuName"> The sku name. </param>
        /// <param name="minUnits"> The minimum number of units will be billed. One unit is 10,000 Profiles and 100,000 Interactions. </param>
        /// <param name="maxUnits"> The maximum number of units can be used.  One unit is 10,000 Profiles and 100,000 Interactions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HubBillingInfoFormat(string skuName, int? minUnits, int? maxUnits, Dictionary<string, BinaryData> rawData)
        {
            SkuName = skuName;
            MinUnits = minUnits;
            MaxUnits = maxUnits;
            _rawData = rawData;
        }

        /// <summary> The sku name. </summary>
        public string SkuName { get; set; }
        /// <summary> The minimum number of units will be billed. One unit is 10,000 Profiles and 100,000 Interactions. </summary>
        public int? MinUnits { get; set; }
        /// <summary> The maximum number of units can be used.  One unit is 10,000 Profiles and 100,000 Interactions. </summary>
        public int? MaxUnits { get; set; }
    }
}
