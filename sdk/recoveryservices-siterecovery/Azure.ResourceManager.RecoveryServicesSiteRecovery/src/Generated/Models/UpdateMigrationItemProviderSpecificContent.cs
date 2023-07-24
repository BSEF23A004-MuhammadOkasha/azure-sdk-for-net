// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Update migration item provider specific input.
    /// Please note <see cref="UpdateMigrationItemProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="VMwareCbtUpdateMigrationItemContent"/>.
    /// </summary>
    public abstract partial class UpdateMigrationItemProviderSpecificContent
    {
        /// <summary> Initializes a new instance of UpdateMigrationItemProviderSpecificContent. </summary>
        protected UpdateMigrationItemProviderSpecificContent()
        {
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
