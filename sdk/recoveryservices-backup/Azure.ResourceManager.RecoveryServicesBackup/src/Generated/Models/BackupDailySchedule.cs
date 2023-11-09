// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The BackupDailySchedule. </summary>
    internal partial class BackupDailySchedule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupDailySchedule"/>. </summary>
        public BackupDailySchedule()
        {
            ScheduleRunTimes = new ChangeTrackingList<DateTimeOffset>();
        }

        /// <summary> Initializes a new instance of <see cref="BackupDailySchedule"/>. </summary>
        /// <param name="scheduleRunTimes"> List of times of day this schedule has to be run. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupDailySchedule(IList<DateTimeOffset> scheduleRunTimes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScheduleRunTimes = scheduleRunTimes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of times of day this schedule has to be run. </summary>
        public IList<DateTimeOffset> ScheduleRunTimes { get; }
    }
}
