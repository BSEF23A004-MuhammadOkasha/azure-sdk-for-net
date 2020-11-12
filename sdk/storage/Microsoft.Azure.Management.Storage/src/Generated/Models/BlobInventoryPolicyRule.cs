// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object that wraps the blob inventory rule. Each rule is uniquely
    /// defined by name.
    /// </summary>
    public partial class BlobInventoryPolicyRule
    {
        /// <summary>
        /// Initializes a new instance of the BlobInventoryPolicyRule class.
        /// </summary>
        public BlobInventoryPolicyRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobInventoryPolicyRule class.
        /// </summary>
        /// <param name="enabled">Rule is enabled when set to true.</param>
        /// <param name="name">A rule name can contain any combination of alpha
        /// numeric characters. Rule name is case-sensitive. It must be unique
        /// within a policy.</param>
        /// <param name="definition">An object that defines the blob inventory
        /// policy rule.</param>
        public BlobInventoryPolicyRule(bool enabled, string name, BlobInventoryPolicyDefinition definition)
        {
            Enabled = enabled;
            Name = name;
            Definition = definition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rule is enabled when set to true.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets a rule name can contain any combination of alpha
        /// numeric characters. Rule name is case-sensitive. It must be unique
        /// within a policy.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an object that defines the blob inventory policy rule.
        /// </summary>
        [JsonProperty(PropertyName = "definition")]
        public BlobInventoryPolicyDefinition Definition { get; set; }

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
            if (Definition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Definition");
            }
            if (Definition != null)
            {
                Definition.Validate();
            }
        }
    }
}
