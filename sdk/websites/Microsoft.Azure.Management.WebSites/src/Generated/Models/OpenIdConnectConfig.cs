// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class OpenIdConnectConfig : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the OpenIdConnectConfig class.
        /// </summary>
        public OpenIdConnectConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OpenIdConnectConfig class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        public OpenIdConnectConfig(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string authorizationEndpoint = default(string), string tokenEndpoint = default(string), string issuer = default(string), string certificationUri = default(string), string wellKnownOpenIdConfiguration = default(string))
            : base(id, name, kind, type)
        {
            AuthorizationEndpoint = authorizationEndpoint;
            TokenEndpoint = tokenEndpoint;
            Issuer = issuer;
            CertificationUri = certificationUri;
            WellKnownOpenIdConfiguration = wellKnownOpenIdConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationEndpoint")]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.tokenEndpoint")]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificationUri")]
        public string CertificationUri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.wellKnownOpenIdConfiguration")]
        public string WellKnownOpenIdConfiguration { get; set; }

    }
}
