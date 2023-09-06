// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> On-demand charges between firstConsumptionDate and lastConsumptionDate that were used for computing benefit recommendations. </summary>
    public partial class RecommendationUsageDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RecommendationUsageDetails"/>. </summary>
        public RecommendationUsageDetails()
        {
            Charges = new ChangeTrackingList<decimal>();
        }

        /// <summary> Initializes a new instance of <see cref="RecommendationUsageDetails"/>. </summary>
        /// <param name="usageGrain"> The grain of the usage. Supported values: 'Hourly'. </param>
        /// <param name="charges"> On-demand charges for each hour between firstConsumptionDate and lastConsumptionDate that were used for computing benefit recommendations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RecommendationUsageDetails(BenefitRecommendationUsageGrain? usageGrain, IReadOnlyList<decimal> charges, Dictionary<string, BinaryData> rawData)
        {
            UsageGrain = usageGrain;
            Charges = charges;
            _rawData = rawData;
        }

        /// <summary> The grain of the usage. Supported values: 'Hourly'. </summary>
        public BenefitRecommendationUsageGrain? UsageGrain { get; set; }
        /// <summary> On-demand charges for each hour between firstConsumptionDate and lastConsumptionDate that were used for computing benefit recommendations. </summary>
        public IReadOnlyList<decimal> Charges { get; }
    }
}
