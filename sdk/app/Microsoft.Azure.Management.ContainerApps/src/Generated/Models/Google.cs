// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the Google provider.
    /// </summary>
    public partial class Google
    {
        /// <summary>
        /// Initializes a new instance of the Google class.
        /// </summary>
        public Google()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Google class.
        /// </summary>
        /// <param name="enabled">&lt;code&gt;false&lt;/code&gt; if the Google
        /// provider should not be enabled despite the set registration;
        /// otherwise, &lt;code&gt;true&lt;/code&gt;.</param>
        /// <param name="registration">The configuration settings of the app
        /// registration for the Google provider.</param>
        /// <param name="login">The configuration settings of the login
        /// flow.</param>
        /// <param name="validation">The configuration settings of the Azure
        /// Active Directory token validation flow.</param>
        public Google(bool? enabled = default(bool?), ClientRegistration registration = default(ClientRegistration), LoginScopes login = default(LoginScopes), AllowedAudiencesValidation validation = default(AllowedAudiencesValidation))
        {
            Enabled = enabled;
            Registration = registration;
            Login = login;
            Validation = validation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt; if the
        /// Google provider should not be enabled despite the set registration;
        /// otherwise, &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the app registration for
        /// the Google provider.
        /// </summary>
        [JsonProperty(PropertyName = "registration")]
        public ClientRegistration Registration { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the login flow.
        /// </summary>
        [JsonProperty(PropertyName = "login")]
        public LoginScopes Login { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the Azure Active
        /// Directory token validation flow.
        /// </summary>
        [JsonProperty(PropertyName = "validation")]
        public AllowedAudiencesValidation Validation { get; set; }

    }
}
