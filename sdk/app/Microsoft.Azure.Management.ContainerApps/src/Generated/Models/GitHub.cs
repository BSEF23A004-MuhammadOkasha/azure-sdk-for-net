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
    /// The configuration settings of the GitHub provider.
    /// </summary>
    public partial class GitHub
    {
        /// <summary>
        /// Initializes a new instance of the GitHub class.
        /// </summary>
        public GitHub()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GitHub class.
        /// </summary>
        /// <param name="enabled">&lt;code&gt;false&lt;/code&gt; if the GitHub
        /// provider should not be enabled despite the set registration;
        /// otherwise, &lt;code&gt;true&lt;/code&gt;.</param>
        /// <param name="registration">The configuration settings of the app
        /// registration for the GitHub provider.</param>
        /// <param name="login">The configuration settings of the login
        /// flow.</param>
        public GitHub(bool? enabled = default(bool?), ClientRegistration registration = default(ClientRegistration), LoginScopes login = default(LoginScopes))
        {
            Enabled = enabled;
            Registration = registration;
            Login = login;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt; if the
        /// GitHub provider should not be enabled despite the set registration;
        /// otherwise, &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the app registration for
        /// the GitHub provider.
        /// </summary>
        [JsonProperty(PropertyName = "registration")]
        public ClientRegistration Registration { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the login flow.
        /// </summary>
        [JsonProperty(PropertyName = "login")]
        public LoginScopes Login { get; set; }

    }
}
