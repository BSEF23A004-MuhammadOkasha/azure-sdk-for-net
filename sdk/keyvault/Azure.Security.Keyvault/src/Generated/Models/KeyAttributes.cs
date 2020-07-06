// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Security.KeyVault.Models
{
    /// <summary> The attributes of a key managed by the key vault service. </summary>
    public partial class KeyAttributes : Attributes
    {
        /// <summary> Initializes a new instance of KeyAttributes. </summary>
        public KeyAttributes()
        {
        }

        /// <summary> Initializes a new instance of KeyAttributes. </summary>
        /// <param name="enabled"> Determines whether the object is enabled. </param>
        /// <param name="notBefore"> Not before date in UTC. </param>
        /// <param name="expires"> Expiry date in UTC. </param>
        /// <param name="created"> Creation time in UTC. </param>
        /// <param name="updated"> Last updated time in UTC. </param>
        /// <param name="recoverableDays"> softDelete data retention days. Value should be &gt;=7 and &lt;=90 when softDelete enabled, otherwise 0. </param>
        /// <param name="recoveryLevel"> Reflects the deletion recovery level currently in effect for keys in the current vault. If it contains &apos;Purgeable&apos; the key can be permanently deleted by a privileged user; otherwise, only the system can purge the key, at the end of the retention interval. </param>
        internal KeyAttributes(bool? enabled, DateTimeOffset? notBefore, DateTimeOffset? expires, DateTimeOffset? created, DateTimeOffset? updated, int? recoverableDays, DeletionRecoveryLevel? recoveryLevel) : base(enabled, notBefore, expires, created, updated)
        {
            RecoverableDays = recoverableDays;
            RecoveryLevel = recoveryLevel;
        }

        /// <summary> softDelete data retention days. Value should be &gt;=7 and &lt;=90 when softDelete enabled, otherwise 0. </summary>
        public int? RecoverableDays { get; }
        /// <summary> Reflects the deletion recovery level currently in effect for keys in the current vault. If it contains &apos;Purgeable&apos; the key can be permanently deleted by a privileged user; otherwise, only the system can purge the key, at the end of the retention interval. </summary>
        public DeletionRecoveryLevel? RecoveryLevel { get; }
    }
}
