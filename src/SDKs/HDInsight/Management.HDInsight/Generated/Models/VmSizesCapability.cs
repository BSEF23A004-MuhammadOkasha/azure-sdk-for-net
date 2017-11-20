// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The virtual machine sizes capability.
    /// </summary>
    public partial class VmSizesCapability
    {
        /// <summary>
        /// Initializes a new instance of the VmSizesCapability class.
        /// </summary>
        public VmSizesCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VmSizesCapability class.
        /// </summary>
        /// <param name="available">The list of virtual machine size
        /// capabilities.</param>
        public VmSizesCapability(IList<string> available = default(IList<string>))
        {
            Available = available;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of virtual machine size capabilities.
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public IList<string> Available { get; set; }

    }
}
