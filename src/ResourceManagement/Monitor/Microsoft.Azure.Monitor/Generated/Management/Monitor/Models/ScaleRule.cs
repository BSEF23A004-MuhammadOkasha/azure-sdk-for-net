// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Insights;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A rule that provide the triggers and parameters for the scaling action.
    /// </summary>
    public partial class ScaleRule
    {
        /// <summary>
        /// Initializes a new instance of the ScaleRule class.
        /// </summary>
        public ScaleRule() { }

        /// <summary>
        /// Initializes a new instance of the ScaleRule class.
        /// </summary>
        /// <param name="metricTrigger">the trigger that results in a scaling
        /// action.</param>
        /// <param name="scaleAction">the parameters for the scaling
        /// action.</param>
        public ScaleRule(MetricTrigger metricTrigger, ScaleAction scaleAction)
        {
            MetricTrigger = metricTrigger;
            ScaleAction = scaleAction;
        }

        /// <summary>
        /// Gets or sets the trigger that results in a scaling action.
        /// </summary>
        [JsonProperty(PropertyName = "metricTrigger")]
        public MetricTrigger MetricTrigger { get; set; }

        /// <summary>
        /// Gets or sets the parameters for the scaling action.
        /// </summary>
        [JsonProperty(PropertyName = "scaleAction")]
        public ScaleAction ScaleAction { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MetricTrigger == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MetricTrigger");
            }
            if (ScaleAction == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScaleAction");
            }
            if (MetricTrigger != null)
            {
                MetricTrigger.Validate();
            }
            if (ScaleAction != null)
            {
                ScaleAction.Validate();
            }
        }
    }
}
