// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// OperationInputs.
    /// </summary>
    public partial class OperationInputs
    {
        /// <summary>
        /// Initializes a new instance of the OperationInputs class.
        /// </summary>
        public OperationInputs() { }

        /// <summary>
        /// Initializes a new instance of the OperationInputs class.
        /// </summary>
        public OperationInputs(string name = default(string))
        {
            Name = name;
        }

        /// <summary>
        /// The name of the iot hub.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

    }
}
