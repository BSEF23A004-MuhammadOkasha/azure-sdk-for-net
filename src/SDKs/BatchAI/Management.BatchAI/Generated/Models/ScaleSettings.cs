// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// At least one of manual or autoScale settings must be specified. Only
    /// one of manual or autoScale settings can be specified. If autoScale
    /// settings are specified, the system automatically scales the cluster up
    /// and down (within the supplied limits) based on the pending jobs on the
    /// cluster.
    /// </summary>
    public partial class ScaleSettings
    {
        /// <summary>
        /// Initializes a new instance of the ScaleSettings class.
        /// </summary>
        public ScaleSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScaleSettings class.
        /// </summary>
        /// <param name="manual">The scale for the cluster by manual
        /// settings</param>
        /// <param name="autoScale">The scale for the cluster by autoscale
        /// settings</param>
        public ScaleSettings(ManualScaleSettings manual = default(ManualScaleSettings), AutoScaleSettings autoScale = default(AutoScaleSettings))
        {
            Manual = manual;
            AutoScale = autoScale;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the scale for the cluster by manual settings
        /// </summary>
        [JsonProperty(PropertyName = "manual")]
        public ManualScaleSettings Manual { get; set; }

        /// <summary>
        /// Gets or sets the scale for the cluster by autoscale settings
        /// </summary>
        [JsonProperty(PropertyName = "autoScale")]
        public AutoScaleSettings AutoScale { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Manual != null)
            {
                Manual.Validate();
            }
            if (AutoScale != null)
            {
                AutoScale.Validate();
            }
        }
    }
}
