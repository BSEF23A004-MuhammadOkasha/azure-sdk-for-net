// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Update policy input. </summary>
    public partial class SiteRecoveryPolicyPatch
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryPolicyPatch"/>. </summary>
        public SiteRecoveryPolicyPatch()
        {
        }

        /// <summary> The ReplicationProviderSettings. </summary>
        internal UpdatePolicyContentProperties Properties { get; set; }
        /// <summary>
        /// The ReplicationProviderSettings.
        /// Please note <see cref="PolicyProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2APolicyCreationContent"/>, <see cref="A2ACrossClusterMigrationPolicyCreationContent"/>, <see cref="HyperVReplicaPolicyContent"/>, <see cref="HyperVReplicaBluePolicyContent"/>, <see cref="HyperVReplicaAzurePolicyContent"/>, <see cref="InMagePolicyContent"/>, <see cref="InMageAzureV2PolicyContent"/>, <see cref="InMageRcmPolicyCreationContent"/>, <see cref="InMageRcmFailbackPolicyCreationContent"/> and <see cref="VMwareCbtPolicyCreationContent"/>.
        /// </summary>
        public PolicyProviderSpecificContent UpdatePolicyContentReplicationProviderSettings
        {
            get => Properties is null ? default : Properties.ReplicationProviderSettings;
            set
            {
                if (Properties is null)
                    Properties = new UpdatePolicyContentProperties();
                Properties.ReplicationProviderSettings = value;
            }
        }
    }
}
