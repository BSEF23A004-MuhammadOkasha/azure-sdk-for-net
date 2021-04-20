// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A class representing database principal entity.
    /// </summary>
    public partial class DatabasePrincipal
    {
        /// <summary>
        /// Initializes a new instance of the DatabasePrincipal class.
        /// </summary>
        public DatabasePrincipal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabasePrincipal class.
        /// </summary>
        /// <param name="role">Database principal role. Possible values
        /// include: 'Admin', 'Ingestor', 'Monitor', 'User',
        /// 'UnrestrictedViewer', 'Viewer'</param>
        /// <param name="name">Database principal name.</param>
        /// <param name="type">Database principal type. Possible values
        /// include: 'App', 'Group', 'User'</param>
        /// <param name="fqn">Database principal fully qualified name.</param>
        /// <param name="email">Database principal email if exists.</param>
        /// <param name="appId">Application id - relevant only for application
        /// principal type.</param>
        /// <param name="tenantName">The tenant name of the principal</param>
        public DatabasePrincipal(string role, string name, string type, string fqn = default(string), string email = default(string), string appId = default(string), string tenantName = default(string))
        {
            Role = role;
            Name = name;
            Type = type;
            Fqn = fqn;
            Email = email;
            AppId = appId;
            TenantName = tenantName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets database principal role. Possible values include:
        /// 'Admin', 'Ingestor', 'Monitor', 'User', 'UnrestrictedViewer',
        /// 'Viewer'
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets database principal name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets database principal type. Possible values include:
        /// 'App', 'Group', 'User'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets database principal fully qualified name.
        /// </summary>
        [JsonProperty(PropertyName = "fqn")]
        public string Fqn { get; set; }

        /// <summary>
        /// Gets or sets database principal email if exists.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets application id - relevant only for application
        /// principal type.
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets the tenant name of the principal
        /// </summary>
        [JsonProperty(PropertyName = "tenantName")]
        public string TenantName { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Role == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Role");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
