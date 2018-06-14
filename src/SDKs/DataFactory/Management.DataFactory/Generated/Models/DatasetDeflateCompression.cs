// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.4.36.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Deflate compression method used on a dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Deflate")]
    public partial class DatasetDeflateCompression : DatasetCompression
    {
        /// <summary>
        /// Initializes a new instance of the DatasetDeflateCompression class.
        /// </summary>
        public DatasetDeflateCompression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetDeflateCompression class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="level">The Deflate compression level. Possible values
        /// include: 'Optimal', 'Fastest'</param>
        public DatasetDeflateCompression(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string level = default(string))
            : base(additionalProperties)
        {
            Level = level;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Deflate compression level. Possible values
        /// include: 'Optimal', 'Fastest'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

    }
}
