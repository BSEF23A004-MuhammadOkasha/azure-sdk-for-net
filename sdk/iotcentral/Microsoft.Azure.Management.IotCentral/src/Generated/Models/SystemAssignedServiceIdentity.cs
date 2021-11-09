// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotCentral.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Managed service identity (either system assigned, or none)
    /// </summary>
    public partial class SystemAssignedServiceIdentity
    {
        /// <summary>
        /// Initializes a new instance of the SystemAssignedServiceIdentity
        /// class.
        /// </summary>
        public SystemAssignedServiceIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SystemAssignedServiceIdentity
        /// class.
        /// </summary>
        /// <param name="type">Possible values include: 'None',
        /// 'SystemAssigned'</param>
        /// <param name="principalId">The service principal ID of the system
        /// assigned identity. This property will only be provided for a system
        /// assigned identity.</param>
        /// <param name="tenantId">The tenant ID of the system assigned
        /// identity. This property will only be provided for a system assigned
        /// identity.</param>
        public SystemAssignedServiceIdentity(string type, System.Guid? principalId = default(System.Guid?), System.Guid? tenantId = default(System.Guid?))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the service principal ID of the system assigned identity. This
        /// property will only be provided for a system assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public System.Guid? PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant ID of the system assigned identity. This property
        /// will only be provided for a system assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; private set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'SystemAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
