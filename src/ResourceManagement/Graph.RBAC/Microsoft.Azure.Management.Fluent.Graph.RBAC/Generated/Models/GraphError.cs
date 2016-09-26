// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Models
{
    using System.Linq;

    /// <summary>
    /// Active Directory error information
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class GraphError
    {
        /// <summary>
        /// Initializes a new instance of the GraphError class.
        /// </summary>
        public GraphError() { }

        /// <summary>
        /// Initializes a new instance of the GraphError class.
        /// </summary>
        /// <param name="code">Error code.</param>
        /// <param name="message">Error message value.</param>
        public GraphError(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
        }

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "odata\\.error.code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "odata\\.error.message.value")]
        public string Message { get; set; }

    }
}
