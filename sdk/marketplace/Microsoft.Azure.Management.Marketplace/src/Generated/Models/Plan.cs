// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Plan
    {
        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        public Plan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        /// <param name="skuId">Identifier for this plan</param>
        /// <param name="planId">Text identifier for this plan</param>
        /// <param name="planDisplayName">Friendly name for the plan for
        /// display in the marketplace</param>
        public Plan(string skuId = default(string), string planId = default(string), string planDisplayName = default(string))
        {
            SkuId = skuId;
            PlanId = planId;
            PlanDisplayName = planDisplayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets identifier for this plan
        /// </summary>
        [JsonProperty(PropertyName = "skuId")]
        public string SkuId { get; private set; }

        /// <summary>
        /// Gets text identifier for this plan
        /// </summary>
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; private set; }

        /// <summary>
        /// Gets friendly name for the plan for display in the marketplace
        /// </summary>
        [JsonProperty(PropertyName = "planDisplayName")]
        public string PlanDisplayName { get; private set; }

    }
}
