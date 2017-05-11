// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Request body for detaching data disk from a virtual machine.
    /// </summary>
    public partial class DetachDataDiskProperties
    {
        /// <summary>
        /// Initializes a new instance of the DetachDataDiskProperties class.
        /// </summary>
        public DetachDataDiskProperties() { }

        /// <summary>
        /// Initializes a new instance of the DetachDataDiskProperties class.
        /// </summary>
        public DetachDataDiskProperties(string existingLabDiskId = default(string))
        {
            ExistingLabDiskId = existingLabDiskId;
        }

        /// <summary>
        /// Specifies the disk resource ID to detach from virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "existingLabDiskId")]
        public string ExistingLabDiskId { get; set; }

    }
}
