// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Enabled configuration.
    /// Serialized Name: EnabledConfig
    /// </summary>
    internal partial class EnabledConfig
    {
        /// <summary> Initializes a new instance of EnabledConfig. </summary>
        public EnabledConfig()
        {
        }

        /// <summary> Initializes a new instance of EnabledConfig. </summary>
        /// <param name="enabled">
        /// True if configuration is enabled, false if it is disabled and null if configuration is not set.
        /// Serialized Name: EnabledConfig.enabled
        /// </param>
        internal EnabledConfig(bool? enabled)
        {
            Enabled = enabled;
        }

        /// <summary>
        /// True if configuration is enabled, false if it is disabled and null if configuration is not set.
        /// Serialized Name: EnabledConfig.enabled
        /// </summary>
        public bool? Enabled { get; set; }
    }
}
