// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Configure pairing input properties. </summary>
    public partial class SiteRecoveryCreateProtectionContainerMappingProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryCreateProtectionContainerMappingProperties"/>. </summary>
        public SiteRecoveryCreateProtectionContainerMappingProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryCreateProtectionContainerMappingProperties"/>. </summary>
        /// <param name="targetProtectionContainerId"> The target unique protection container name. </param>
        /// <param name="policyId"> Applicable policy. </param>
        /// <param name="providerSpecificContent">
        /// Provider specific input for pairing.
        /// Please note <see cref="ReplicationProviderSpecificContainerMappingContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AContainerMappingContent"/> and <see cref="VMwareCbtContainerMappingContent"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryCreateProtectionContainerMappingProperties(ResourceIdentifier targetProtectionContainerId, ResourceIdentifier policyId, ReplicationProviderSpecificContainerMappingContent providerSpecificContent, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetProtectionContainerId = targetProtectionContainerId;
            PolicyId = policyId;
            ProviderSpecificContent = providerSpecificContent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The target unique protection container name. </summary>
        public ResourceIdentifier TargetProtectionContainerId { get; set; }
        /// <summary> Applicable policy. </summary>
        public ResourceIdentifier PolicyId { get; set; }
        /// <summary>
        /// Provider specific input for pairing.
        /// Please note <see cref="ReplicationProviderSpecificContainerMappingContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AContainerMappingContent"/> and <see cref="VMwareCbtContainerMappingContent"/>.
        /// </summary>
        public ReplicationProviderSpecificContainerMappingContent ProviderSpecificContent { get; set; }
    }
}
