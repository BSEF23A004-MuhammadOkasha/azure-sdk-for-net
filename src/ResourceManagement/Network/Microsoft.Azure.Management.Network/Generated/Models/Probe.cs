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
    /// A load balancer probe.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Probe : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the Probe class.
        /// </summary>
        public Probe() { }

        /// <summary>
        /// Initializes a new instance of the Probe class.
        /// </summary>
        /// <param name="protocol">The protocol of the end point. Possible
        /// values are: 'Http' or 'Tcp'. If 'Tcp' is specified, a received
        /// ACK is required for the probe to be successful. If 'Http' is
        /// specified, a 200 OK response from the specifies URI is required
        /// for the probe to be successful. Possible values include: 'Http',
        /// 'Tcp'</param>
        /// <param name="port">The port for communicating the probe. Possible
        /// values range from 1 to 65535, inclusive.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="loadBalancingRules">The load balancer rules that use
        /// this probe.</param>
        /// <param name="intervalInSeconds">The interval, in seconds, for how
        /// frequently to probe the endpoint for health status. Typically,
        /// the interval is slightly less than half the allocated timeout
        /// period (in seconds) which allows two full probes before taking
        /// the instance out of rotation. The default value is 15, the
        /// minimum value is 5.</param>
        /// <param name="numberOfProbes">The number of probes where if no
        /// response, will result in stopping further traffic from being
        /// delivered to the endpoint. This values allows endpoints to be
        /// taken out of rotation faster or slower than the typical times
        /// used in Azure.</param>
        /// <param name="requestPath">The URI used for requesting health
        /// status from the VM. Path is required if a protocol is set to
        /// http. Otherwise, it is not allowed. There is no default
        /// value.</param>
        /// <param name="provisioningState">Gets the provisioning state of the
        /// public IP resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public Probe(string protocol, int port, string id = default(string), System.Collections.Generic.IList<SubResource> loadBalancingRules = default(System.Collections.Generic.IList<SubResource>), int? intervalInSeconds = default(int?), int? numberOfProbes = default(int?), string requestPath = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            LoadBalancingRules = loadBalancingRules;
            Protocol = protocol;
            Port = port;
            IntervalInSeconds = intervalInSeconds;
            NumberOfProbes = numberOfProbes;
            RequestPath = requestPath;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets the load balancer rules that use this probe.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public System.Collections.Generic.IList<SubResource> LoadBalancingRules { get; private set; }

        /// <summary>
        /// Gets or sets the protocol of the end point. Possible values are:
        /// 'Http' or 'Tcp'. If 'Tcp' is specified, a received ACK is
        /// required for the probe to be successful. If 'Http' is specified,
        /// a 200 OK response from the specifies URI is required for the
        /// probe to be successful. Possible values include: 'Http', 'Tcp'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the port for communicating the probe. Possible values
        /// range from 1 to 65535, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.port")]
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets the interval, in seconds, for how frequently to probe
        /// the endpoint for health status. Typically, the interval is
        /// slightly less than half the allocated timeout period (in seconds)
        /// which allows two full probes before taking the instance out of
        /// rotation. The default value is 15, the minimum value is 5.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.intervalInSeconds")]
        public int? IntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the number of probes where if no response, will
        /// result in stopping further traffic from being delivered to the
        /// endpoint. This values allows endpoints to be taken out of
        /// rotation faster or slower than the typical times used in Azure.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.numberOfProbes")]
        public int? NumberOfProbes { get; set; }

        /// <summary>
        /// Gets or sets the URI used for requesting health status from the
        /// VM. Path is required if a protocol is set to http. Otherwise, it
        /// is not allowed. There is no default value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.requestPath")]
        public string RequestPath { get; set; }

        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Protocol == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Protocol");
            }
        }
    }
}
