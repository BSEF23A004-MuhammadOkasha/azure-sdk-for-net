// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Information about the status of continuous backups. </summary>
    internal partial class ContinuousBackupInformation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContinuousBackupInformation"/>. </summary>
        internal ContinuousBackupInformation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContinuousBackupInformation"/>. </summary>
        /// <param name="latestRestorableTimestamp"> The latest restorable timestamp for a resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContinuousBackupInformation(DateTimeOffset? latestRestorableTimestamp, Dictionary<string, BinaryData> rawData)
        {
            LatestRestorableTimestamp = latestRestorableTimestamp;
            _rawData = rawData;
        }

        /// <summary> The latest restorable timestamp for a resource. </summary>
        public DateTimeOffset? LatestRestorableTimestamp { get; }
    }
}
