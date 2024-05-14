// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The UnknownRetentionPolicy. </summary>
    internal partial class UnknownRetentionPolicy : BackupRetentionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRetentionPolicy"/>. </summary>
        /// <param name="retentionPolicyType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        internal UnknownRetentionPolicy(string retentionPolicyType) : base(retentionPolicyType)
        {
            RetentionPolicyType = retentionPolicyType ?? "Unknown";
        }
    }
}
