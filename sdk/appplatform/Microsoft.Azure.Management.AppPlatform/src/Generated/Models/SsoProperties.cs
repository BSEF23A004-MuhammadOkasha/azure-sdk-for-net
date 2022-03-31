// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single sign-on related configuration
    /// </summary>
    public partial class SsoProperties
    {
        /// <summary>
        /// Initializes a new instance of the SsoProperties class.
        /// </summary>
        public SsoProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SsoProperties class.
        /// </summary>
        /// <param name="scope">It defines the specific actions applications
        /// can be allowed to do on a user's behalf</param>
        /// <param name="clientId">The public identifier for the
        /// application</param>
        /// <param name="clientSecret">The secret known only to the application
        /// and the authorization server</param>
        /// <param name="issuerUri">The URI of Issuer Identifier</param>
        public SsoProperties(IList<string> scope = default(IList<string>), string clientId = default(string), string clientSecret = default(string), string issuerUri = default(string))
        {
            Scope = scope;
            ClientId = clientId;
            ClientSecret = clientSecret;
            IssuerUri = issuerUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets it defines the specific actions applications can be
        /// allowed to do on a user's behalf
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public IList<string> Scope { get; set; }

        /// <summary>
        /// Gets or sets the public identifier for the application
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the secret known only to the application and the
        /// authorization server
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the URI of Issuer Identifier
        /// </summary>
        [JsonProperty(PropertyName = "issuerUri")]
        public string IssuerUri { get; set; }

    }
}
