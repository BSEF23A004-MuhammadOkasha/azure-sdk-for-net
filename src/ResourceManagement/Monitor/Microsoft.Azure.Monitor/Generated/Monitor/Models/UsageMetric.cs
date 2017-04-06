// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Insights;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Usage Metric data.
    /// </summary>
    public partial class UsageMetric
    {
        /// <summary>
        /// Initializes a new instance of the UsageMetric class.
        /// </summary>
        public UsageMetric() { }

        /// <summary>
        /// Initializes a new instance of the UsageMetric class.
        /// </summary>
        /// <param name="name">the usage metric name and display name.</param>
        /// <param name="currentValue">the current value for the usage
        /// metric.</param>
        /// <param name="id">the id for the usage metric.</param>
        /// <param name="limit">the quota limit the usage metric.</param>
        /// <param name="unit">the unit for the usage metric.</param>
        /// <param name="nextResetTime">the next reset time for the current
        /// value.</param>
        /// <param name="quotaPeriod">the amount of time it takes to reset the
        /// value.</param>
        public UsageMetric(LocalizableString name = default(LocalizableString), double? currentValue = default(double?), string id = default(string), double? limit = default(double?), string unit = default(string), System.DateTime? nextResetTime = default(System.DateTime?), System.TimeSpan? quotaPeriod = default(System.TimeSpan?))
        {
            Name = name;
            CurrentValue = currentValue;
            Id = id;
            Limit = limit;
            Unit = unit;
            NextResetTime = nextResetTime;
            QuotaPeriod = quotaPeriod;
        }

        /// <summary>
        /// Gets or sets the usage metric name and display name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or sets the current value for the usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public double? CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets the id for the usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the quota limit the usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Gets or sets the unit for the usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the next reset time for the current value.
        /// </summary>
        [JsonProperty(PropertyName = "nextResetTime")]
        public System.DateTime? NextResetTime { get; set; }

        /// <summary>
        /// Gets or sets the amount of time it takes to reset the value.
        /// </summary>
        [JsonProperty(PropertyName = "quotaPeriod")]
        public System.TimeSpan? QuotaPeriod { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name != null)
            {
                Name.Validate();
            }
        }
    }
}
