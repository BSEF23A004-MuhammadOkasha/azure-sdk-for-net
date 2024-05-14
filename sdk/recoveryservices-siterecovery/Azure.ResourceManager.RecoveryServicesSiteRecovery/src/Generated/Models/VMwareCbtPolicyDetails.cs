// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMware Cbt specific policy details. </summary>
    public partial class VMwareCbtPolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="VMwareCbtPolicyDetails"/>. </summary>
        internal VMwareCbtPolicyDetails()
        {
            InstanceType = "VMwareCbt";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtPolicyDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="recoveryPointHistoryInMinutes"> The duration in minutes until which the recovery points need to be stored. </param>
        /// <param name="appConsistentFrequencyInMinutes"> The app consistent snapshot frequency in minutes. </param>
        /// <param name="crashConsistentFrequencyInMinutes"> The crash consistent snapshot frequency in minutes. </param>
        internal VMwareCbtPolicyDetails(string instanceType, int? recoveryPointHistoryInMinutes, int? appConsistentFrequencyInMinutes, int? crashConsistentFrequencyInMinutes) : base(instanceType)
        {
            RecoveryPointHistoryInMinutes = recoveryPointHistoryInMinutes;
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
            InstanceType = instanceType ?? "VMwareCbt";
        }

        /// <summary> The duration in minutes until which the recovery points need to be stored. </summary>
        public int? RecoveryPointHistoryInMinutes { get; }
        /// <summary> The app consistent snapshot frequency in minutes. </summary>
        public int? AppConsistentFrequencyInMinutes { get; }
        /// <summary> The crash consistent snapshot frequency in minutes. </summary>
        public int? CrashConsistentFrequencyInMinutes { get; }
    }
}
