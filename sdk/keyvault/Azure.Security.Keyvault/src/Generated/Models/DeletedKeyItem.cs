// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.KeyVault.Models
{
    /// <summary> The deleted key item containing the deleted key metadata and information about deletion. </summary>
    public partial class DeletedKeyItem : KeyItem
    {
        /// <summary> Initializes a new instance of DeletedKeyItem. </summary>
        internal DeletedKeyItem()
        {
        }

        /// <summary> Initializes a new instance of DeletedKeyItem. </summary>
        /// <param name="kid"> Key identifier. </param>
        /// <param name="attributes"> The key management attributes. </param>
        /// <param name="tags"> Application specific metadata in the form of key-value pairs. </param>
        /// <param name="managed"> True if the key&apos;s lifetime is managed by key vault. If this is a key backing a certificate, then managed will be true. </param>
        /// <param name="recoveryId"> The url of the recovery object, used to identify and recover the deleted key. </param>
        /// <param name="scheduledPurgeDate"> The time when the key is scheduled to be purged, in UTC. </param>
        /// <param name="deletedDate"> The time when the key was deleted, in UTC. </param>
        internal DeletedKeyItem(string kid, KeyAttributes attributes, IReadOnlyDictionary<string, string> tags, bool? managed, string recoveryId, DateTimeOffset? scheduledPurgeDate, DateTimeOffset? deletedDate) : base(kid, attributes, tags, managed)
        {
            RecoveryId = recoveryId;
            ScheduledPurgeDate = scheduledPurgeDate;
            DeletedDate = deletedDate;
        }

        /// <summary> The url of the recovery object, used to identify and recover the deleted key. </summary>
        public string RecoveryId { get; }
        /// <summary> The time when the key is scheduled to be purged, in UTC. </summary>
        public DateTimeOffset? ScheduledPurgeDate { get; }
        /// <summary> The time when the key was deleted, in UTC. </summary>
        public DateTimeOffset? DeletedDate { get; }
    }
}
