// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the policy for a monitored application upgrade. </summary>
    public partial class ApplicationUpgradePolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationUpgradePolicy"/>. </summary>
        public ApplicationUpgradePolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationUpgradePolicy"/>. </summary>
        /// <param name="upgradeReplicaSetCheckTimeout"> The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned 32-bit integer). </param>
        /// <param name="forceRestart"> If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data). </param>
        /// <param name="rollingUpgradeMonitoringPolicy"> The policy used for monitoring the application upgrade. </param>
        /// <param name="applicationHealthPolicy">
        /// Defines a health policy used to evaluate the health of an application or one of its children entities.
        ///
        /// </param>
        /// <param name="upgradeMode"> The mode used to monitor health during a rolling upgrade. The values are UnmonitoredAuto, UnmonitoredManual, and Monitored. </param>
        /// <param name="recreateApplication"> Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters are not allowed and it will result in availability loss. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationUpgradePolicy(TimeSpan? upgradeReplicaSetCheckTimeout, bool? forceRestart, ArmRollingUpgradeMonitoringPolicy rollingUpgradeMonitoringPolicy, ArmApplicationHealthPolicy applicationHealthPolicy, ApplicationRollingUpgradeMode? upgradeMode, bool? recreateApplication, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UpgradeReplicaSetCheckTimeout = upgradeReplicaSetCheckTimeout;
            ForceRestart = forceRestart;
            RollingUpgradeMonitoringPolicy = rollingUpgradeMonitoringPolicy;
            ApplicationHealthPolicy = applicationHealthPolicy;
            UpgradeMode = upgradeMode;
            RecreateApplication = recreateApplication;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned 32-bit integer). </summary>
        public TimeSpan? UpgradeReplicaSetCheckTimeout { get; set; }
        /// <summary> If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data). </summary>
        public bool? ForceRestart { get; set; }
        /// <summary> The policy used for monitoring the application upgrade. </summary>
        public ArmRollingUpgradeMonitoringPolicy RollingUpgradeMonitoringPolicy { get; set; }
        /// <summary>
        /// Defines a health policy used to evaluate the health of an application or one of its children entities.
        ///
        /// </summary>
        public ArmApplicationHealthPolicy ApplicationHealthPolicy { get; set; }
        /// <summary> The mode used to monitor health during a rolling upgrade. The values are UnmonitoredAuto, UnmonitoredManual, and Monitored. </summary>
        public ApplicationRollingUpgradeMode? UpgradeMode { get; set; }
        /// <summary> Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters are not allowed and it will result in availability loss. </summary>
        public bool? RecreateApplication { get; set; }
    }
}
