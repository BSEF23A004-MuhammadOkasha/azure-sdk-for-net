// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Daily retention schedule. </summary>
    public partial class DailyRetentionSchedule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DailyRetentionSchedule"/>. </summary>
        public DailyRetentionSchedule()
        {
            RetentionTimes = new ChangeTrackingList<DateTimeOffset>();
        }

        /// <summary> Initializes a new instance of <see cref="DailyRetentionSchedule"/>. </summary>
        /// <param name="retentionTimes"> Retention times of retention policy. </param>
        /// <param name="retentionDuration"> Retention duration of retention Policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DailyRetentionSchedule(IList<DateTimeOffset> retentionTimes, RetentionDuration retentionDuration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RetentionTimes = retentionTimes;
            RetentionDuration = retentionDuration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Retention times of retention policy. </summary>
        public IList<DateTimeOffset> RetentionTimes { get; }
        /// <summary> Retention duration of retention Policy. </summary>
        public RetentionDuration RetentionDuration { get; set; }
    }
}
