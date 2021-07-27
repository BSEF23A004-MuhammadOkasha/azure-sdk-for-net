// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The service metric specifications.
    /// </summary>
    public partial class ServiceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        public ServiceSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        /// <param name="logSpecifications">List of log specifications.</param>
        /// <param name="metricSpecifications">List of metric
        /// specifications.</param>
        public ServiceSpecification(IList<LogSpecification> logSpecifications = default(IList<LogSpecification>), IList<MetricSpecification> metricSpecifications = default(IList<MetricSpecification>))
        {
            LogSpecifications = logSpecifications;
            MetricSpecifications = metricSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of log specifications.
        /// </summary>
        [JsonProperty(PropertyName = "logSpecifications")]
        public IList<LogSpecification> LogSpecifications { get; private set; }

        /// <summary>
        /// Gets list of metric specifications.
        /// </summary>
        [JsonProperty(PropertyName = "metricSpecifications")]
        public IList<MetricSpecification> MetricSpecifications { get; private set; }

    }
}
