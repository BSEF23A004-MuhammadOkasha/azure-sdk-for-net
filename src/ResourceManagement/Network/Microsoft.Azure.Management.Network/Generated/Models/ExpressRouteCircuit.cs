// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// ExpressRouteCircuit resource
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCircuit : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuit class.
        /// </summary>
        public ExpressRouteCircuit() { }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuit class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">The SKU.</param>
        /// <param name="allowClassicOperations">Allow classic
        /// operations</param>
        /// <param name="circuitProvisioningState">The
        /// CircuitProvisioningState state of the resource.</param>
        /// <param name="serviceProviderProvisioningState">The
        /// ServiceProviderProvisioningState state of the resource. Possible
        /// values are 'NotProvisioned', 'Provisioning', 'Provisioned', and
        /// 'Deprovisioning'. Possible values include: 'NotProvisioned',
        /// 'Provisioning', 'Provisioned', 'Deprovisioning'</param>
        /// <param name="authorizations">The list of authorizations.</param>
        /// <param name="peerings">The list of peerings.</param>
        /// <param name="serviceKey">The ServiceKey.</param>
        /// <param name="serviceProviderNotes">The
        /// ServiceProviderNotes.</param>
        /// <param name="serviceProviderProperties">The
        /// ServiceProviderProperties.</param>
        /// <param name="provisioningState">Gets the provisioning state of the
        /// public IP resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="gatewayManagerEtag">The GatewayManager Etag.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public ExpressRouteCircuit(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), ExpressRouteCircuitSku sku = default(ExpressRouteCircuitSku), bool? allowClassicOperations = default(bool?), string circuitProvisioningState = default(string), string serviceProviderProvisioningState = default(string), System.Collections.Generic.IList<ExpressRouteCircuitAuthorization> authorizations = default(System.Collections.Generic.IList<ExpressRouteCircuitAuthorization>), System.Collections.Generic.IList<ExpressRouteCircuitPeering> peerings = default(System.Collections.Generic.IList<ExpressRouteCircuitPeering>), string serviceKey = default(string), string serviceProviderNotes = default(string), ExpressRouteCircuitServiceProviderProperties serviceProviderProperties = default(ExpressRouteCircuitServiceProviderProperties), string provisioningState = default(string), string gatewayManagerEtag = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            AllowClassicOperations = allowClassicOperations;
            CircuitProvisioningState = circuitProvisioningState;
            ServiceProviderProvisioningState = serviceProviderProvisioningState;
            Authorizations = authorizations;
            Peerings = peerings;
            ServiceKey = serviceKey;
            ServiceProviderNotes = serviceProviderNotes;
            ServiceProviderProperties = serviceProviderProperties;
            ProvisioningState = provisioningState;
            GatewayManagerEtag = gatewayManagerEtag;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets the SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public ExpressRouteCircuitSku Sku { get; set; }

        /// <summary>
        /// Gets or sets allow classic operations
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.allowClassicOperations")]
        public bool? AllowClassicOperations { get; set; }

        /// <summary>
        /// Gets or sets the CircuitProvisioningState state of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.circuitProvisioningState")]
        public string CircuitProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the ServiceProviderProvisioningState state of the
        /// resource. Possible values are 'NotProvisioned', 'Provisioning',
        /// 'Provisioned', and 'Deprovisioning'. Possible values include:
        /// 'NotProvisioned', 'Provisioning', 'Provisioned', 'Deprovisioning'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceProviderProvisioningState")]
        public string ServiceProviderProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the list of authorizations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.authorizations")]
        public System.Collections.Generic.IList<ExpressRouteCircuitAuthorization> Authorizations { get; set; }

        /// <summary>
        /// Gets or sets the list of peerings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.peerings")]
        public System.Collections.Generic.IList<ExpressRouteCircuitPeering> Peerings { get; set; }

        /// <summary>
        /// Gets or sets the ServiceKey.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceKey")]
        public string ServiceKey { get; set; }

        /// <summary>
        /// Gets or sets the ServiceProviderNotes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceProviderNotes")]
        public string ServiceProviderNotes { get; set; }

        /// <summary>
        /// Gets or sets the ServiceProviderProperties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceProviderProperties")]
        public ExpressRouteCircuitServiceProviderProperties ServiceProviderProperties { get; set; }

        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the GatewayManager Etag.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.gatewayManagerEtag")]
        public string GatewayManagerEtag { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
