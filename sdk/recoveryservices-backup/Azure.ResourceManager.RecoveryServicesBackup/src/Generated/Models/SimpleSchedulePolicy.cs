// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Simple policy schedule. </summary>
    public partial class SimpleSchedulePolicy : BackupSchedulePolicy
    {
        /// <summary> Initializes a new instance of <see cref="SimpleSchedulePolicy"/>. </summary>
        public SimpleSchedulePolicy()
        {
            ScheduleRunDays = new ChangeTrackingList<BackupDayOfWeek>();
            ScheduleRunTimes = new ChangeTrackingList<DateTimeOffset>();
            SchedulePolicyType = "SimpleSchedulePolicy";
        }

        /// <summary> Initializes a new instance of <see cref="SimpleSchedulePolicy"/>. </summary>
        /// <param name="schedulePolicyType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="scheduleRunFrequency"> Frequency of the schedule operation of this policy. </param>
        /// <param name="scheduleRunDays"> List of days of week this schedule has to be run. </param>
        /// <param name="scheduleRunTimes"> List of times of day this schedule has to be run. </param>
        /// <param name="hourlySchedule"> Hourly Schedule of this Policy. </param>
        /// <param name="scheduleWeeklyFrequency"> At every number weeks this schedule has to be run. </param>
        internal SimpleSchedulePolicy(string schedulePolicyType, ScheduleRunType? scheduleRunFrequency, IList<BackupDayOfWeek> scheduleRunDays, IList<DateTimeOffset> scheduleRunTimes, BackupHourlySchedule hourlySchedule, int? scheduleWeeklyFrequency) : base(schedulePolicyType)
        {
            ScheduleRunFrequency = scheduleRunFrequency;
            ScheduleRunDays = scheduleRunDays;
            ScheduleRunTimes = scheduleRunTimes;
            HourlySchedule = hourlySchedule;
            ScheduleWeeklyFrequency = scheduleWeeklyFrequency;
            SchedulePolicyType = schedulePolicyType ?? "SimpleSchedulePolicy";
        }

        /// <summary> Frequency of the schedule operation of this policy. </summary>
        public ScheduleRunType? ScheduleRunFrequency { get; set; }
        /// <summary> List of days of week this schedule has to be run. </summary>
        public IList<BackupDayOfWeek> ScheduleRunDays { get; }
        /// <summary> List of times of day this schedule has to be run. </summary>
        public IList<DateTimeOffset> ScheduleRunTimes { get; }
        /// <summary> Hourly Schedule of this Policy. </summary>
        public BackupHourlySchedule HourlySchedule { get; set; }
        /// <summary> At every number weeks this schedule has to be run. </summary>
        public int? ScheduleWeeklyFrequency { get; set; }
    }
}
