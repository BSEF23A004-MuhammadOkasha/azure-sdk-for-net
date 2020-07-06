// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Security.KeyVault.Models
{
    /// <summary> The secret management attributes. </summary>
    public partial class SecretAttributes : Attributes
    {
        /// <summary> Initializes a new instance of SecretAttributes. </summary>
        public SecretAttributes()
        {
        }

        /// <summary> Initializes a new instance of SecretAttributes. </summary>
        /// <param name="enabled"> Determines whether the object is enabled. </param>
        /// <param name="notBefore"> Not before date in UTC. </param>
        /// <param name="expires"> Expiry date in UTC. </param>
        /// <param name="created"> Creation time in UTC. </param>
        /// <param name="updated"> Last updated time in UTC. </param>
        /// <param name="recoveryLevel"> Reflects the deletion recovery level currently in effect for secrets in the current vault. If it contains &apos;Purgeable&apos;, the secret can be permanently deleted by a privileged user; otherwise, only the system can purge the secret, at the end of the retention interval. </param>
        internal SecretAttributes(bool? enabled, DateTimeOffset? notBefore, DateTimeOffset? expires, DateTimeOffset? created, DateTimeOffset? updated, DeletionRecoveryLevel? recoveryLevel) : base(enabled, notBefore, expires, created, updated)
        {
            RecoveryLevel = recoveryLevel;
        }

        /// <summary> Reflects the deletion recovery level currently in effect for secrets in the current vault. If it contains &apos;Purgeable&apos;, the secret can be permanently deleted by a privileged user; otherwise, only the system can purge the secret, at the end of the retention interval. </summary>
        public DeletionRecoveryLevel? RecoveryLevel { get; }
    }
}
