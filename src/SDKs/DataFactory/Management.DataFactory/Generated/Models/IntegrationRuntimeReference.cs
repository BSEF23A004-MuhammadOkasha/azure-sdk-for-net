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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Integration runtime reference type.
    /// </summary>
    public partial class IntegrationRuntimeReference
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeReference
        /// class.
        /// </summary>
        public IntegrationRuntimeReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeReference
        /// class.
        /// </summary>
        /// <param name="referenceName">Reference integration runtime
        /// name.</param>
        /// <param name="parameters">Arguments for integration runtime.</param>
        public IntegrationRuntimeReference(string referenceName, IDictionary<string, object> parameters = default(IDictionary<string, object>))
        {
            ReferenceName = referenceName;
            Parameters = parameters;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for IntegrationRuntimeReference class.
        /// </summary>
        static IntegrationRuntimeReference()
        {
            Type = "IntegrationRuntimeReference";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference integration runtime name.
        /// </summary>
        [JsonProperty(PropertyName = "referenceName")]
        public string ReferenceName { get; set; }

        /// <summary>
        /// Gets or sets arguments for integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// Type of integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReferenceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReferenceName");
            }
        }
    }
}
