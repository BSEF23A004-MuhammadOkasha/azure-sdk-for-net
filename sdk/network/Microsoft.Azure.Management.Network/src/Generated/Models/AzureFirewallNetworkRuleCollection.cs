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
    /// Network rule collection resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AzureFirewallNetworkRuleCollection : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureFirewallNetworkRuleCollection class.
        /// </summary>
        public AzureFirewallNetworkRuleCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureFirewallNetworkRuleCollection class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="priority">Priority of the network rule collection
        /// resource.</param>
        /// <param name="action">The action type of a rule collection.</param>
        /// <param name="rules">Collection of rules used by a network rule
        /// collection.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// network rule collection resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">The name of the resource that is unique within
        /// the Azure firewall. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public AzureFirewallNetworkRuleCollection(string id = default(string), int? priority = default(int?), AzureFirewallRCAction action = default(AzureFirewallRCAction), IList<AzureFirewallNetworkRule> rules = default(IList<AzureFirewallNetworkRule>), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Priority = priority;
            Action = action;
            Rules = rules;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets priority of the network rule collection resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the action type of a rule collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.action")]
        public AzureFirewallRCAction Action { get; set; }

        /// <summary>
        /// Gets or sets collection of rules used by a network rule collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rules")]
        public IList<AzureFirewallNetworkRule> Rules { get; set; }

        /// <summary>
        /// Gets the provisioning state of the network rule collection
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within the
        /// Azure firewall. This name can be used to access the resource.
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
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Priority != null)
            {
                if (Priority > 65000)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "Priority", 65000);
                }
                if (Priority < 100)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Priority", 100);
                }
            }
        }
    }
}
