// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceBus;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of a Check Name availability request properties.
    /// </summary>
    public partial class CheckNameAvailability
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailability class.
        /// </summary>
        public CheckNameAvailability()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailability class.
        /// </summary>
        /// <param name="name">The Name to check the namespce name availability
        /// and The namespace name can contain only letters, numbers, and
        /// hyphens. The namespace must start with a letter, and it must end
        /// with a letter or number.</param>
        public CheckNameAvailability(string name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Name to check the namespce name availability and
        /// The namespace name can contain only letters, numbers, and hyphens.
        /// The namespace must start with a letter, and it must end with a
        /// letter or number.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
