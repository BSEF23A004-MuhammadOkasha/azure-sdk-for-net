// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics DDL name item.
    /// </summary>
    public partial class DdlName
    {
        /// <summary>
        /// Initializes a new instance of the DdlName class.
        /// </summary>
        public DdlName() { }

        /// <summary>
        /// Initializes a new instance of the DdlName class.
        /// </summary>
        public DdlName(string firstPart = default(string), string secondPart = default(string), string thirdPart = default(string), string server = default(string))
        {
            FirstPart = firstPart;
            SecondPart = secondPart;
            ThirdPart = thirdPart;
            Server = server;
        }

        /// <summary>
        /// Gets or sets the name of the table associated with this database
        /// and schema.
        /// </summary>
        [JsonProperty(PropertyName = "firstPart")]
        public string FirstPart { get; set; }

        /// <summary>
        /// Gets or sets the name of the table associated with this database
        /// and schema.
        /// </summary>
        [JsonProperty(PropertyName = "secondPart")]
        public string SecondPart { get; set; }

        /// <summary>
        /// Gets or sets the name of the table associated with this database
        /// and schema.
        /// </summary>
        [JsonProperty(PropertyName = "thirdPart")]
        public string ThirdPart { get; set; }

        /// <summary>
        /// Gets or sets the name of the table associated with this database
        /// and schema.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string Server { get; set; }

    }
}
