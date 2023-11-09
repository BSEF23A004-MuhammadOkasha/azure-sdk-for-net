// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Update appliance for protected item input properties. </summary>
    public partial class UpdateApplianceForReplicationProtectedItemProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UpdateApplianceForReplicationProtectedItemProperties"/>. </summary>
        /// <param name="targetApplianceId"> The target appliance Id. </param>
        /// <param name="providerSpecificDetails">
        /// The provider specific input to update replication protected item.
        /// Please note <see cref="UpdateApplianceForReplicationProtectedItemProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageRcmUpdateApplianceForReplicationProtectedItemContent"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetApplianceId"/> or <paramref name="providerSpecificDetails"/> is null. </exception>
        public UpdateApplianceForReplicationProtectedItemProperties(string targetApplianceId, UpdateApplianceForReplicationProtectedItemProviderSpecificContent providerSpecificDetails)
        {
            Argument.AssertNotNull(targetApplianceId, nameof(targetApplianceId));
            Argument.AssertNotNull(providerSpecificDetails, nameof(providerSpecificDetails));

            TargetApplianceId = targetApplianceId;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateApplianceForReplicationProtectedItemProperties"/>. </summary>
        /// <param name="targetApplianceId"> The target appliance Id. </param>
        /// <param name="providerSpecificDetails">
        /// The provider specific input to update replication protected item.
        /// Please note <see cref="UpdateApplianceForReplicationProtectedItemProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageRcmUpdateApplianceForReplicationProtectedItemContent"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateApplianceForReplicationProtectedItemProperties(string targetApplianceId, UpdateApplianceForReplicationProtectedItemProviderSpecificContent providerSpecificDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetApplianceId = targetApplianceId;
            ProviderSpecificDetails = providerSpecificDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateApplianceForReplicationProtectedItemProperties"/> for deserialization. </summary>
        internal UpdateApplianceForReplicationProtectedItemProperties()
        {
        }

        /// <summary> The target appliance Id. </summary>
        public string TargetApplianceId { get; }
        /// <summary>
        /// The provider specific input to update replication protected item.
        /// Please note <see cref="UpdateApplianceForReplicationProtectedItemProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageRcmUpdateApplianceForReplicationProtectedItemContent"/>.
        /// </summary>
        public UpdateApplianceForReplicationProtectedItemProviderSpecificContent ProviderSpecificDetails { get; }
    }
}
