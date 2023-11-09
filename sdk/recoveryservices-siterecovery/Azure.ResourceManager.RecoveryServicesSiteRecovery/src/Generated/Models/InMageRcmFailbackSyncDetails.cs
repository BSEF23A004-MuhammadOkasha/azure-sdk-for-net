// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcmFailback disk level sync details. </summary>
    public partial class InMageRcmFailbackSyncDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackSyncDetails"/>. </summary>
        internal InMageRcmFailbackSyncDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackSyncDetails"/>. </summary>
        /// <param name="progressHealth"> The progress health. </param>
        /// <param name="transferredBytes"> The transferred bytes from source VM to azure for the disk. </param>
        /// <param name="last15MinutesTransferredBytes"> The bytes transferred in last 15 minutes from source VM to target. </param>
        /// <param name="lastDataTransferOn"> The time of the last data transfer from source VM to target. </param>
        /// <param name="processedBytes"> The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes. </param>
        /// <param name="startOn"> The start time. </param>
        /// <param name="lastRefreshedOn"> The last refresh time. </param>
        /// <param name="progressPercentage"> Progress in percentage. Progress percentage is calculated based on processed bytes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmFailbackSyncDetails(SiteRecoveryDiskReplicationProgressHealth? progressHealth, long? transferredBytes, long? last15MinutesTransferredBytes, DateTimeOffset? lastDataTransferOn, long? processedBytes, DateTimeOffset? startOn, DateTimeOffset? lastRefreshedOn, int? progressPercentage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProgressHealth = progressHealth;
            TransferredBytes = transferredBytes;
            Last15MinutesTransferredBytes = last15MinutesTransferredBytes;
            LastDataTransferOn = lastDataTransferOn;
            ProcessedBytes = processedBytes;
            StartOn = startOn;
            LastRefreshedOn = lastRefreshedOn;
            ProgressPercentage = progressPercentage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The progress health. </summary>
        public SiteRecoveryDiskReplicationProgressHealth? ProgressHealth { get; }
        /// <summary> The transferred bytes from source VM to azure for the disk. </summary>
        public long? TransferredBytes { get; }
        /// <summary> The bytes transferred in last 15 minutes from source VM to target. </summary>
        public long? Last15MinutesTransferredBytes { get; }
        /// <summary> The time of the last data transfer from source VM to target. </summary>
        public DateTimeOffset? LastDataTransferOn { get; }
        /// <summary> The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes. </summary>
        public long? ProcessedBytes { get; }
        /// <summary> The start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The last refresh time. </summary>
        public DateTimeOffset? LastRefreshedOn { get; }
        /// <summary> Progress in percentage. Progress percentage is calculated based on processed bytes. </summary>
        public int? ProgressPercentage { get; }
    }
}
