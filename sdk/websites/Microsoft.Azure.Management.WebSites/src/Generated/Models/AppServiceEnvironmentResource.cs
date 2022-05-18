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
    /// App Service Environment ARM resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AppServiceEnvironmentResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AppServiceEnvironmentResource
        /// class.
        /// </summary>
        public AppServiceEnvironmentResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppServiceEnvironmentResource
        /// class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="virtualNetwork">Description of the Virtual
        /// Network.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="provisioningState">Provisioning state of the App
        /// Service Environment. Possible values include: 'Succeeded',
        /// 'Failed', 'Canceled', 'InProgress', 'Deleting'</param>
        /// <param name="status">Current status of the App Service Environment.
        /// Possible values include: 'Preparing', 'Ready', 'Scaling',
        /// 'Deleting'</param>
        /// <param name="internalLoadBalancingMode">Specifies which endpoints
        /// to serve internally in the Virtual Network for the App Service
        /// Environment. Possible values include: 'None', 'Web', 'Publishing',
        /// 'Web, Publishing'</param>
        /// <param name="multiSize">Front-end VM size, e.g. "Medium",
        /// "Large".</param>
        /// <param name="multiRoleCount">Number of front-end instances.</param>
        /// <param name="ipsslAddressCount">Number of IP SSL addresses reserved
        /// for the App Service Environment.</param>
        /// <param name="dnsSuffix">DNS suffix of the App Service
        /// Environment.</param>
        /// <param name="maximumNumberOfMachines">Maximum number of VMs in the
        /// App Service Environment.</param>
        /// <param name="frontEndScaleFactor">Scale factor for
        /// front-ends.</param>
        /// <param name="suspended">&lt;code&gt;true&lt;/code&gt; if the App
        /// Service Environment is suspended; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;. The environment can be suspended,
        /// e.g. when the management endpoint is no longer available
        /// (most likely because NSG blocked the incoming traffic).</param>
        /// <param name="clusterSettings">Custom settings for changing the
        /// behavior of the App Service Environment.</param>
        /// <param name="userWhitelistedIpRanges">User added ip ranges to
        /// whitelist on ASE db</param>
        /// <param name="hasLinuxWorkers">Flag that displays whether an ASE has
        /// linux workers or not</param>
        /// <param name="dedicatedHostCount">Dedicated Host Count</param>
        /// <param name="zoneRedundant">Whether or not this App Service
        /// Environment is zone-redundant.</param>
        public AppServiceEnvironmentResource(string location, VirtualNetworkProfile virtualNetwork, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ProvisioningState? provisioningState = default(ProvisioningState?), HostingEnvironmentStatus? status = default(HostingEnvironmentStatus?), string internalLoadBalancingMode = default(string), string multiSize = default(string), int? multiRoleCount = default(int?), int? ipsslAddressCount = default(int?), string dnsSuffix = default(string), int? maximumNumberOfMachines = default(int?), int? frontEndScaleFactor = default(int?), bool? suspended = default(bool?), IList<NameValuePair> clusterSettings = default(IList<NameValuePair>), IList<string> userWhitelistedIpRanges = default(IList<string>), bool? hasLinuxWorkers = default(bool?), int? dedicatedHostCount = default(int?), bool? zoneRedundant = default(bool?))
            : base(location, id, name, kind, type, tags)
        {
            ProvisioningState = provisioningState;
            Status = status;
            VirtualNetwork = virtualNetwork;
            InternalLoadBalancingMode = internalLoadBalancingMode;
            MultiSize = multiSize;
            MultiRoleCount = multiRoleCount;
            IpsslAddressCount = ipsslAddressCount;
            DnsSuffix = dnsSuffix;
            MaximumNumberOfMachines = maximumNumberOfMachines;
            FrontEndScaleFactor = frontEndScaleFactor;
            Suspended = suspended;
            ClusterSettings = clusterSettings;
            UserWhitelistedIpRanges = userWhitelistedIpRanges;
            HasLinuxWorkers = hasLinuxWorkers;
            DedicatedHostCount = dedicatedHostCount;
            ZoneRedundant = zoneRedundant;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning state of the App Service Environment. Possible
        /// values include: 'Succeeded', 'Failed', 'Canceled', 'InProgress',
        /// 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets current status of the App Service Environment. Possible values
        /// include: 'Preparing', 'Ready', 'Scaling', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public HostingEnvironmentStatus? Status { get; private set; }

        /// <summary>
        /// Gets or sets description of the Virtual Network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetwork")]
        public VirtualNetworkProfile VirtualNetwork { get; set; }

        /// <summary>
        /// Gets or sets specifies which endpoints to serve internally in the
        /// Virtual Network for the App Service Environment. Possible values
        /// include: 'None', 'Web', 'Publishing', 'Web, Publishing'
        /// </summary>
        [JsonProperty(PropertyName = "properties.internalLoadBalancingMode")]
        public string InternalLoadBalancingMode { get; set; }

        /// <summary>
        /// Gets or sets front-end VM size, e.g. "Medium", "Large".
        /// </summary>
        [JsonProperty(PropertyName = "properties.multiSize")]
        public string MultiSize { get; set; }

        /// <summary>
        /// Gets number of front-end instances.
        /// </summary>
        [JsonProperty(PropertyName = "properties.multiRoleCount")]
        public int? MultiRoleCount { get; private set; }

        /// <summary>
        /// Gets or sets number of IP SSL addresses reserved for the App
        /// Service Environment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipsslAddressCount")]
        public int? IpsslAddressCount { get; set; }

        /// <summary>
        /// Gets or sets DNS suffix of the App Service Environment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSuffix")]
        public string DnsSuffix { get; set; }

        /// <summary>
        /// Gets maximum number of VMs in the App Service Environment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maximumNumberOfMachines")]
        public int? MaximumNumberOfMachines { get; private set; }

        /// <summary>
        /// Gets or sets scale factor for front-ends.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontEndScaleFactor")]
        public int? FrontEndScaleFactor { get; set; }

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if the App
        /// Service Environment is suspended; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;. The environment can
        /// be suspended, e.g. when the management endpoint is no longer
        /// available
        /// (most likely because NSG blocked the incoming traffic).
        /// </summary>
        [JsonProperty(PropertyName = "properties.suspended")]
        public bool? Suspended { get; private set; }

        /// <summary>
        /// Gets or sets custom settings for changing the behavior of the App
        /// Service Environment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterSettings")]
        public IList<NameValuePair> ClusterSettings { get; set; }

        /// <summary>
        /// Gets or sets user added ip ranges to whitelist on ASE db
        /// </summary>
        [JsonProperty(PropertyName = "properties.userWhitelistedIpRanges")]
        public IList<string> UserWhitelistedIpRanges { get; set; }

        /// <summary>
        /// Gets flag that displays whether an ASE has linux workers or not
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasLinuxWorkers")]
        public bool? HasLinuxWorkers { get; private set; }

        /// <summary>
        /// Gets or sets dedicated Host Count
        /// </summary>
        [JsonProperty(PropertyName = "properties.dedicatedHostCount")]
        public int? DedicatedHostCount { get; set; }

        /// <summary>
        /// Gets or sets whether or not this App Service Environment is
        /// zone-redundant.
        /// </summary>
        [JsonProperty(PropertyName = "properties.zoneRedundant")]
        public bool? ZoneRedundant { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (VirtualNetwork == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VirtualNetwork");
            }
            if (VirtualNetwork != null)
            {
                VirtualNetwork.Validate();
            }
        }
    }
}
