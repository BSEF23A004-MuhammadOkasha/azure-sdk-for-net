// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error response.
    /// </summary>
    public partial class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        public ErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        /// <param name="error">Error response indicates Azure Resource Manager
        /// is not able to process the incoming request. The reason is provided
        /// in the error message.</param>
        public ErrorResponse(ErrorResponseError error = default(ErrorResponseError))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets error response indicates Azure Resource Manager is not able to
        /// process the incoming request. The reason is provided in the error
        /// message.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponseError Error { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Error != null)
            {
                Error.Validate();
            }
        }
    }
}
