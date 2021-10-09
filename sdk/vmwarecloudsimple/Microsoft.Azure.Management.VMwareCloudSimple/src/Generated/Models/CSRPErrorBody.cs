// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VMwareCloudSimple.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Error properties
    /// </summary>
    public partial class CSRPErrorBody
    {
        /// <summary>
        /// Initializes a new instance of the CSRPErrorBody class.
        /// </summary>
        public CSRPErrorBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CSRPErrorBody class.
        /// </summary>
        /// <param name="code">Error's code</param>
        /// <param name="details">Error's details</param>
        /// <param name="message">Error's message</param>
        /// <param name="target">Error's target</param>
        public CSRPErrorBody(string code = default(string), IList<CSRPErrorBody> details = default(IList<CSRPErrorBody>), string message = default(string), string target = default(string))
        {
            Code = code;
            Details = details;
            Message = message;
            Target = target;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets error's code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets error's details
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<CSRPErrorBody> Details { get; private set; }

        /// <summary>
        /// Gets error's message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets or sets error's target
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

    }
}
