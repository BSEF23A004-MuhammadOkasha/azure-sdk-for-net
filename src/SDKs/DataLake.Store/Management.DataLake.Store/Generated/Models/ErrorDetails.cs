// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Store;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data Lake Store error details information
    /// </summary>
    public partial class ErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDetails class.
        /// </summary>
        public ErrorDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetails class.
        /// </summary>
        /// <param name="code">the HTTP status code or error code associated
        /// with this error</param>
        /// <param name="message">the error message localized based on
        /// Accept-Language</param>
        /// <param name="target">the target of the particular error (for
        /// example, the name of the property in error).</param>
        public ErrorDetails(string code = default(string), string message = default(string), string target = default(string))
        {
            Code = code;
            Message = message;
            Target = target;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the HTTP status code or error code associated with this error
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the error message localized based on Accept-Language
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the target of the particular error (for example, the name of
        /// the property in error).
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; private set; }

    }
}
