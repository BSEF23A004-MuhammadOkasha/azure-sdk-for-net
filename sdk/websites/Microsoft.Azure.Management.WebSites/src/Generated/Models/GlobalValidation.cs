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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration settings that determines the validation flow of users
    /// using App Service Authentication/Authorization.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GlobalValidation : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the GlobalValidation class.
        /// </summary>
        public GlobalValidation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GlobalValidation class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="requireAuthentication">&lt;code&gt;true&lt;/code&gt;
        /// if the authentication flow is required any request is made;
        /// otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="unauthenticatedClientAction">The action to take when
        /// an unauthenticated client attempts to access the app. Possible
        /// values include: 'RedirectToLoginPage', 'AllowAnonymous',
        /// 'Return401', 'Return403'</param>
        /// <param name="redirectToProvider">The default authentication
        /// provider to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured
        /// and the unauthenticated client
        /// action is set to "RedirectToLoginPage".</param>
        /// <param name="excludedPaths">The paths for which unauthenticated
        /// flow would not be redirected to the login page.</param>
        public GlobalValidation(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), bool? requireAuthentication = default(bool?), UnauthenticatedClientActionV2? unauthenticatedClientAction = default(UnauthenticatedClientActionV2?), string redirectToProvider = default(string), IList<string> excludedPaths = default(IList<string>))
            : base(id, name, kind, type)
        {
            RequireAuthentication = requireAuthentication;
            UnauthenticatedClientAction = unauthenticatedClientAction;
            RedirectToProvider = redirectToProvider;
            ExcludedPaths = excludedPaths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if the
        /// authentication flow is required any request is made; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requireAuthentication")]
        public bool? RequireAuthentication { get; set; }

        /// <summary>
        /// Gets or sets the action to take when an unauthenticated client
        /// attempts to access the app. Possible values include:
        /// 'RedirectToLoginPage', 'AllowAnonymous', 'Return401', 'Return403'
        /// </summary>
        [JsonProperty(PropertyName = "properties.unauthenticatedClientAction")]
        public UnauthenticatedClientActionV2? UnauthenticatedClientAction { get; set; }

        /// <summary>
        /// Gets or sets the default authentication provider to use when
        /// multiple providers are configured.
        /// This setting is only needed if multiple providers are configured
        /// and the unauthenticated client
        /// action is set to "RedirectToLoginPage".
        /// </summary>
        [JsonProperty(PropertyName = "properties.redirectToProvider")]
        public string RedirectToProvider { get; set; }

        /// <summary>
        /// Gets or sets the paths for which unauthenticated flow would not be
        /// redirected to the login page.
        /// </summary>
        [JsonProperty(PropertyName = "properties.excludedPaths")]
        public IList<string> ExcludedPaths { get; set; }

    }
}
