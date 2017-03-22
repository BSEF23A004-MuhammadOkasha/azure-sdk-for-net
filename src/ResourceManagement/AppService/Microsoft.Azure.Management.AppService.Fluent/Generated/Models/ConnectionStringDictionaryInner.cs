// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// String dictionary resource.
    /// </summary>
    public partial class ConnectionStringDictionaryInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionStringDictionaryInner
        /// class.
        /// </summary>
        public ConnectionStringDictionaryInner() { }

        /// <summary>
        /// Initializes a new instance of the ConnectionStringDictionaryInner
        /// class.
        /// </summary>
        /// <param name="properties">Connection strings.</param>
        public ConnectionStringDictionaryInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), System.Collections.Generic.IDictionary<string, ConnStringValueTypePair> properties = default(System.Collections.Generic.IDictionary<string, ConnStringValueTypePair>))
            : base(location, id, name, type, tags)
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets connection strings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.IDictionary<string, ConnStringValueTypePair> Properties { get; set; }

    }
}
