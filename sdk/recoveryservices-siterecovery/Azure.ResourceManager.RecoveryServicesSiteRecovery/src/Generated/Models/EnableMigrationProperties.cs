// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Enable migration input properties. </summary>
    public partial class EnableMigrationProperties
    {
        /// <summary> Initializes a new instance of <see cref="EnableMigrationProperties"/>. </summary>
        /// <param name="policyId"> The policy Id. </param>
        /// <param name="providerSpecificDetails">
        /// The provider specific details.
        /// Please note <see cref="EnableMigrationProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtEnableMigrationContent"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyId"/> or <paramref name="providerSpecificDetails"/> is null. </exception>
        public EnableMigrationProperties(ResourceIdentifier policyId, EnableMigrationProviderSpecificContent providerSpecificDetails)
        {
            Argument.AssertNotNull(policyId, nameof(policyId));
            Argument.AssertNotNull(providerSpecificDetails, nameof(providerSpecificDetails));

            PolicyId = policyId;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary> The policy Id. </summary>
        public ResourceIdentifier PolicyId { get; }
        /// <summary>
        /// The provider specific details.
        /// Please note <see cref="EnableMigrationProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtEnableMigrationContent"/>.
        /// </summary>
        public EnableMigrationProviderSpecificContent ProviderSpecificDetails { get; }
    }
}
