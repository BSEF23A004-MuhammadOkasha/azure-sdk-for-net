// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters that define the representation of topology.
    /// </summary>
    public partial class TopologyParameters
    {
        /// <summary>
        /// Initializes a new instance of the TopologyParameters class.
        /// </summary>
        public TopologyParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TopologyParameters class.
        /// </summary>
        /// <param name="targetResourceGroupName">The name of the target
        /// resource group to perform topology on.</param>
        public TopologyParameters(string targetResourceGroupName)
        {
            TargetResourceGroupName = targetResourceGroupName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the target resource group to perform
        /// topology on.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroupName")]
        public string TargetResourceGroupName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceGroupName");
            }
        }
    }
}
