// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Path rule of URL path map of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayPathRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayPathRule class.
        /// </summary>
        public ApplicationGatewayPathRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayPathRule class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="paths">Path rules of URL path map.</param>
        /// <param name="backendAddressPool">Backend address pool resource of
        /// URL path map path rule.</param>
        /// <param name="backendHttpSettings">Backend http settings resource of
        /// URL path map path rule.</param>
        /// <param name="redirectConfiguration">Redirect configuration resource
        /// of URL path map path rule.</param>
        /// <param name="rewriteRuleSet">Rewrite rule set resource of URL path
        /// map path rule.</param>
        /// <param name="loadDistributionPolicy">Load Distribution Policy
        /// resource of URL path map path rule.</param>
        /// <param name="provisioningState">The provisioning state of the path
        /// rule resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="firewallPolicy">Reference to the FirewallPolicy
        /// resource.</param>
        /// <param name="name">Name of the path rule that is unique within an
        /// Application Gateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayPathRule(string id = default(string), IList<string> paths = default(IList<string>), SubResource backendAddressPool = default(SubResource), SubResource backendHttpSettings = default(SubResource), SubResource redirectConfiguration = default(SubResource), SubResource rewriteRuleSet = default(SubResource), SubResource loadDistributionPolicy = default(SubResource), string provisioningState = default(string), SubResource firewallPolicy = default(SubResource), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            Paths = paths;
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            RedirectConfiguration = redirectConfiguration;
            RewriteRuleSet = rewriteRuleSet;
            LoadDistributionPolicy = loadDistributionPolicy;
            ProvisioningState = provisioningState;
            FirewallPolicy = firewallPolicy;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets path rules of URL path map.
        /// </summary>
        [JsonProperty(PropertyName = "properties.paths")]
        public IList<string> Paths { get; set; }

        /// <summary>
        /// Gets or sets backend address pool resource of URL path map path
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets backend http settings resource of URL path map path
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendHttpSettings")]
        public SubResource BackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets redirect configuration resource of URL path map path
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.redirectConfiguration")]
        public SubResource RedirectConfiguration { get; set; }

        /// <summary>
        /// Gets or sets rewrite rule set resource of URL path map path rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rewriteRuleSet")]
        public SubResource RewriteRuleSet { get; set; }

        /// <summary>
        /// Gets or sets load Distribution Policy resource of URL path map path
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadDistributionPolicy")]
        public SubResource LoadDistributionPolicy { get; set; }

        /// <summary>
        /// Gets the provisioning state of the path rule resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets reference to the FirewallPolicy resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallPolicy")]
        public SubResource FirewallPolicy { get; set; }

        /// <summary>
        /// Gets or sets name of the path rule that is unique within an
        /// Application Gateway.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
