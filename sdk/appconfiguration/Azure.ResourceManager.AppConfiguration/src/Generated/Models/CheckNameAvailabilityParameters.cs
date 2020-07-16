// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> Parameters used for checking whether a resource name is available. </summary>
    public partial class CheckNameAvailabilityParameters
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityParameters. </summary>
        /// <param name="name"> The name to check for availability. </param>
        /// <param name="type"> The resource type to check for name availability. </param>
        public CheckNameAvailabilityParameters(string name, ConfigurationResourceType type)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Type = type;
        }

        /// <summary> The name to check for availability. </summary>
        public string Name { get; }
        /// <summary> The resource type to check for name availability. </summary>
        public ConfigurationResourceType Type { get; }
    }
}
