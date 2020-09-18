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
    public partial class SiteAuthSettingsV2 : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the SiteAuthSettingsV2 class.
        /// </summary>
        public SiteAuthSettingsV2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteAuthSettingsV2 class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        public SiteAuthSettingsV2(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), AuthPlatform platform = default(AuthPlatform), GlobalValidation globalValidation = default(GlobalValidation), IdentityProviders identityProviders = default(IdentityProviders), Login login = default(Login), HttpSettings httpSettings = default(HttpSettings))
            : base(id, name, kind, type)
        {
            Platform = platform;
            GlobalValidation = globalValidation;
            IdentityProviders = identityProviders;
            Login = login;
            HttpSettings = httpSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.platform")]
        public AuthPlatform Platform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.globalValidation")]
        public GlobalValidation GlobalValidation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.identityProviders")]
        public IdentityProviders IdentityProviders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.login")]
        public Login Login { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpSettings")]
        public HttpSettings HttpSettings { get; set; }

    }
}
