// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the load balancer configuration. </summary>
    public partial class LoadBalancerConfiguration : WritableSubResource
    {
        /// <summary> Initializes a new instance of LoadBalancerConfiguration. </summary>
        /// <param name="name"> The name of the Load balancer. </param>
        /// <param name="properties"> Properties of the load balancer configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        public LoadBalancerConfiguration(string name, LoadBalancerConfigurationProperties properties)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Name = name;
            Properties = properties;
        }

        /// <summary> Initializes a new instance of LoadBalancerConfiguration. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name of the Load balancer. </param>
        /// <param name="properties"> Properties of the load balancer configuration. </param>
        internal LoadBalancerConfiguration(string id, string name, LoadBalancerConfigurationProperties properties) : base(id)
        {
            Name = name;
            Properties = properties;
        }

        /// <summary> The name of the Load balancer. </summary>
        public string Name { get; set; }
        /// <summary> Properties of the load balancer configuration. </summary>
        public LoadBalancerConfigurationProperties Properties { get; set; }
    }
}
