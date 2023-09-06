// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> For schedules like: 'recur every Monday' or 'recur every 3 weeks on Wednesday'. </summary>
    public partial class ContainerServiceMaintenanceWeeklySchedule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceWeeklySchedule"/>. </summary>
        /// <param name="intervalWeeks"> Specifies the number of weeks between each set of occurrences. </param>
        /// <param name="dayOfWeek"> Specifies on which day of the week the maintenance occurs. </param>
        public ContainerServiceMaintenanceWeeklySchedule(int intervalWeeks, ContainerServiceWeekDay dayOfWeek)
        {
            IntervalWeeks = intervalWeeks;
            DayOfWeek = dayOfWeek;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceWeeklySchedule"/>. </summary>
        /// <param name="intervalWeeks"> Specifies the number of weeks between each set of occurrences. </param>
        /// <param name="dayOfWeek"> Specifies on which day of the week the maintenance occurs. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceMaintenanceWeeklySchedule(int intervalWeeks, ContainerServiceWeekDay dayOfWeek, Dictionary<string, BinaryData> rawData)
        {
            IntervalWeeks = intervalWeeks;
            DayOfWeek = dayOfWeek;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceWeeklySchedule"/> for deserialization. </summary>
        internal ContainerServiceMaintenanceWeeklySchedule()
        {
        }

        /// <summary> Specifies the number of weeks between each set of occurrences. </summary>
        public int IntervalWeeks { get; set; }
        /// <summary> Specifies on which day of the week the maintenance occurs. </summary>
        public ContainerServiceWeekDay DayOfWeek { get; set; }
    }
}
