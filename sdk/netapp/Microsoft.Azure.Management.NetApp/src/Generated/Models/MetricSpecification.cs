// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Metric specification of operation.
    /// </summary>
    public partial class MetricSpecification
    {
        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        public MetricSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        /// <param name="name">Name of metric specification.</param>
        /// <param name="displayName">Display name of metric
        /// specification.</param>
        /// <param name="displayDescription">Display description of metric
        /// specification.</param>
        /// <param name="unit">Unit could be Bytes or Count.</param>
        /// <param name="supportedAggregationTypes">Support metric aggregation
        /// type.</param>
        /// <param name="supportedTimeGrainTypes">The supported time grain
        /// types for the metrics.</param>
        /// <param name="internalMetricName">The internal metric name.</param>
        /// <param name="sourceMdmAccount">The source MDM account.</param>
        /// <param name="sourceMdmNamespace">The source MDM namespace.</param>
        /// <param name="dimensions">Dimensions of blobs, including blob type
        /// and access tier.</param>
        /// <param name="aggregationType">Aggregation type could be
        /// Average.</param>
        /// <param name="fillGapWithZero">The property to decide fill gap with
        /// zero or not.</param>
        /// <param name="category">The category this metric specification
        /// belong to, could be Capacity.</param>
        /// <param name="resourceIdDimensionNameOverride">Account Resource
        /// Id.</param>
        public MetricSpecification(string name = default(string), string displayName = default(string), string displayDescription = default(string), string unit = default(string), IList<string> supportedAggregationTypes = default(IList<string>), IList<string> supportedTimeGrainTypes = default(IList<string>), string internalMetricName = default(string), string sourceMdmAccount = default(string), string sourceMdmNamespace = default(string), IList<Dimension> dimensions = default(IList<Dimension>), string aggregationType = default(string), bool? fillGapWithZero = default(bool?), string category = default(string), string resourceIdDimensionNameOverride = default(string))
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            SupportedAggregationTypes = supportedAggregationTypes;
            SupportedTimeGrainTypes = supportedTimeGrainTypes;
            InternalMetricName = internalMetricName;
            SourceMdmAccount = sourceMdmAccount;
            SourceMdmNamespace = sourceMdmNamespace;
            Dimensions = dimensions;
            AggregationType = aggregationType;
            FillGapWithZero = fillGapWithZero;
            Category = category;
            ResourceIdDimensionNameOverride = resourceIdDimensionNameOverride;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets display name of metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets display description of metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets unit could be Bytes or Count.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets support metric aggregation type.
        /// </summary>
        [JsonProperty(PropertyName = "supportedAggregationTypes")]
        public IList<string> SupportedAggregationTypes { get; set; }

        /// <summary>
        /// Gets or sets the supported time grain types for the metrics.
        /// </summary>
        [JsonProperty(PropertyName = "supportedTimeGrainTypes")]
        public IList<string> SupportedTimeGrainTypes { get; set; }

        /// <summary>
        /// Gets or sets the internal metric name.
        /// </summary>
        [JsonProperty(PropertyName = "internalMetricName")]
        public string InternalMetricName { get; set; }

        /// <summary>
        /// Gets or sets the source MDM account.
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmAccount")]
        public string SourceMdmAccount { get; set; }

        /// <summary>
        /// Gets or sets the source MDM namespace.
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmNamespace")]
        public string SourceMdmNamespace { get; set; }

        /// <summary>
        /// Gets or sets dimensions of blobs, including blob type and access
        /// tier.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<Dimension> Dimensions { get; set; }

        /// <summary>
        /// Gets or sets aggregation type could be Average.
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; set; }

        /// <summary>
        /// Gets or sets the property to decide fill gap with zero or not.
        /// </summary>
        [JsonProperty(PropertyName = "fillGapWithZero")]
        public bool? FillGapWithZero { get; set; }

        /// <summary>
        /// Gets or sets the category this metric specification belong to,
        /// could be Capacity.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets account Resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "resourceIdDimensionNameOverride")]
        public string ResourceIdDimensionNameOverride { get; set; }

    }
}
