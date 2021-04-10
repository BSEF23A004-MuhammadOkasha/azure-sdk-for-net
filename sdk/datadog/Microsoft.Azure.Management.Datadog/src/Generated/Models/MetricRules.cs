// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Datadog.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Set of rules for sending metrics for the Monitor resource.
    /// </summary>
    public partial class MetricRules
    {
        /// <summary>
        /// Initializes a new instance of the MetricRules class.
        /// </summary>
        public MetricRules()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricRules class.
        /// </summary>
        /// <param name="filteringTags">List of filtering tags to be used for
        /// capturing metrics. If empty, all resources will be captured. If
        /// only Exclude action is specified, the rules will apply to the list
        /// of all available resources. If Include actions are specified, the
        /// rules will only include resources with the associated tags.</param>
        public MetricRules(IList<FilteringTag> filteringTags = default(IList<FilteringTag>))
        {
            FilteringTags = filteringTags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of filtering tags to be used for capturing
        /// metrics. If empty, all resources will be captured. If only Exclude
        /// action is specified, the rules will apply to the list of all
        /// available resources. If Include actions are specified, the rules
        /// will only include resources with the associated tags.
        /// </summary>
        [JsonProperty(PropertyName = "filteringTags")]
        public IList<FilteringTag> FilteringTags { get; set; }

    }
}
