// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> Properties specific to the monitor resource. </summary>
    public partial class MonitorProperties
    {
        /// <summary> Initializes a new instance of <see cref="MonitorProperties"/>. </summary>
        public MonitorProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitorProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the monitor resource. </param>
        /// <param name="monitoringStatus"> Flag specifying if the resource monitoring is enabled or disabled. </param>
        /// <param name="elasticProperties"> Elastic cloud properties. </param>
        /// <param name="userInfo"> User information. </param>
        /// <param name="liftrResourceCategory"></param>
        /// <param name="liftrResourcePreference"> The priority of the resource. </param>
        internal MonitorProperties(ProvisioningState? provisioningState, MonitoringStatus? monitoringStatus, ElasticProperties elasticProperties, UserInfo userInfo, LiftrResourceCategory? liftrResourceCategory, int? liftrResourcePreference)
        {
            ProvisioningState = provisioningState;
            MonitoringStatus = monitoringStatus;
            ElasticProperties = elasticProperties;
            UserInfo = userInfo;
            LiftrResourceCategory = liftrResourceCategory;
            LiftrResourcePreference = liftrResourcePreference;
        }

        /// <summary> Provisioning state of the monitor resource. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
        /// <summary> Flag specifying if the resource monitoring is enabled or disabled. </summary>
        public MonitoringStatus? MonitoringStatus { get; set; }
        /// <summary> Elastic cloud properties. </summary>
        public ElasticProperties ElasticProperties { get; set; }
        /// <summary> User information. </summary>
        public UserInfo UserInfo { get; set; }
        /// <summary> Gets the liftr resource category. </summary>
        public LiftrResourceCategory? LiftrResourceCategory { get; }
        /// <summary> The priority of the resource. </summary>
        public int? LiftrResourcePreference { get; }
    }
}
