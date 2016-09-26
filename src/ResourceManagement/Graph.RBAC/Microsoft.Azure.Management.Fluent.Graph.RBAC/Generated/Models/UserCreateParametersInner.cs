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
    /// Request parameters for create a new work or school account user
    /// </summary>
    public partial class UserCreateParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the UserCreateParametersInner class.
        /// </summary>
        public UserCreateParametersInner() { }

        /// <summary>
        /// Initializes a new instance of the UserCreateParametersInner class.
        /// </summary>
        /// <param name="accountEnabled">Enable the account. If it is enabled
        /// then true else false.</param>
        /// <param name="displayName">User display name</param>
        /// <param name="passwordProfile">Password Profile</param>
        /// <param name="userPrincipalName">The user principal name
        /// (someuser@contoso.com). It must contain one of the verified
        /// domains for the tenant.</param>
        /// <param name="mailNickname">The mail alias for the user</param>
        /// <param name="immutableId">Needs to be specified if you are using a
        /// federated domain for the user's userPrincipalName (UPN) property
        /// while creating a new user account. It is used to associate an
        /// on-premises Active Directory user account to their Azure AD user
        /// object.</param>
        public UserCreateParametersInner(bool accountEnabled, string displayName, PasswordProfile passwordProfile, string userPrincipalName, string mailNickname, string immutableId = default(string))
        {
            AccountEnabled = accountEnabled;
            DisplayName = displayName;
            PasswordProfile = passwordProfile;
            UserPrincipalName = userPrincipalName;
            MailNickname = mailNickname;
            ImmutableId = immutableId;
        }

        /// <summary>
        /// Gets or sets enable the account. If it is enabled then true else
        /// false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "accountEnabled")]
        public bool AccountEnabled { get; set; }

        /// <summary>
        /// Gets or sets user display name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets password Profile
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "passwordProfile")]
        public PasswordProfile PasswordProfile { get; set; }

        /// <summary>
        /// Gets or sets the user principal name (someuser@contoso.com). It
        /// must contain one of the verified domains for the tenant.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "userPrincipalName")]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets the mail alias for the user
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mailNickname")]
        public string MailNickname { get; set; }

        /// <summary>
        /// Gets or sets needs to be specified if you are using a federated
        /// domain for the user's userPrincipalName (UPN) property while
        /// creating a new user account. It is used to associate an
        /// on-premises Active Directory user account to their Azure AD user
        /// object.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "immutableId")]
        public string ImmutableId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DisplayName");
            }
            if (PasswordProfile == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PasswordProfile");
            }
            if (UserPrincipalName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "UserPrincipalName");
            }
            if (MailNickname == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "MailNickname");
            }
            if (this.PasswordProfile != null)
            {
                this.PasswordProfile.Validate();
            }
        }
    }
}
