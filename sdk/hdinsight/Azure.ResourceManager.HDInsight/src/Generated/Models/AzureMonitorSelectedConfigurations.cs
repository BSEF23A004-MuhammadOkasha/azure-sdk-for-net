// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The selected configurations for azure monitor.
    /// Serialized Name: AzureMonitorSelectedConfigurations
    /// </summary>
    public partial class AzureMonitorSelectedConfigurations
    {
        /// <summary> Initializes a new instance of AzureMonitorSelectedConfigurations. </summary>
        public AzureMonitorSelectedConfigurations()
        {
            GlobalConfigurations = new ChangeTrackingDictionary<string, string>();
            TableList = new ChangeTrackingList<AzureMonitorTableConfiguration>();
        }

        /// <summary> Initializes a new instance of AzureMonitorSelectedConfigurations. </summary>
        /// <param name="configurationVersion">
        /// The configuration version.
        /// Serialized Name: AzureMonitorSelectedConfigurations.configurationVersion
        /// </param>
        /// <param name="globalConfigurations">
        /// The global configurations of selected configurations.
        /// Serialized Name: AzureMonitorSelectedConfigurations.globalConfigurations
        /// </param>
        /// <param name="tableList">
        /// The table list.
        /// Serialized Name: AzureMonitorSelectedConfigurations.tableList
        /// </param>
        internal AzureMonitorSelectedConfigurations(string configurationVersion, IDictionary<string, string> globalConfigurations, IList<AzureMonitorTableConfiguration> tableList)
        {
            ConfigurationVersion = configurationVersion;
            GlobalConfigurations = globalConfigurations;
            TableList = tableList;
        }

        /// <summary>
        /// The configuration version.
        /// Serialized Name: AzureMonitorSelectedConfigurations.configurationVersion
        /// </summary>
        public string ConfigurationVersion { get; set; }
        /// <summary>
        /// The global configurations of selected configurations.
        /// Serialized Name: AzureMonitorSelectedConfigurations.globalConfigurations
        /// </summary>
        public IDictionary<string, string> GlobalConfigurations { get; }
        /// <summary>
        /// The table list.
        /// Serialized Name: AzureMonitorSelectedConfigurations.tableList
        /// </summary>
        public IList<AzureMonitorTableConfiguration> TableList { get; }
    }
}
