// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DomainServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Error model.
    /// </summary>
    public partial class DefaultErrorResponseError
    {
        /// <summary>
        /// Initializes a new instance of the DefaultErrorResponseError class.
        /// </summary>
        public DefaultErrorResponseError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefaultErrorResponseError class.
        /// </summary>
        /// <param name="code">Standardized string to programmatically identify
        /// the error.</param>
        /// <param name="message">Detailed error description and debugging
        /// information.</param>
        /// <param name="target">Detailed error description and debugging
        /// information.</param>
        /// <param name="details">Error details.</param>
        /// <param name="innererror">More information to debug error.</param>
        public DefaultErrorResponseError(string code = default(string), string message = default(string), string target = default(string), IList<DefaultErrorResponseErrorDetailsItem> details = default(IList<DefaultErrorResponseErrorDetailsItem>), string innererror = default(string))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Innererror = innererror;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets standardized string to programmatically identify the error.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets detailed error description and debugging information.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets detailed error description and debugging information.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; private set; }

        /// <summary>
        /// Gets or sets error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<DefaultErrorResponseErrorDetailsItem> Details { get; set; }

        /// <summary>
        /// Gets more information to debug error.
        /// </summary>
        [JsonProperty(PropertyName = "innererror")]
        public string Innererror { get; private set; }

    }
}
