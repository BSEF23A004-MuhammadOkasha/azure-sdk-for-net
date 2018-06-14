// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.4.36.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The recurrence schedule.
    /// </summary>
    public partial class RecurrenceSchedule
    {
        /// <summary>
        /// Initializes a new instance of the RecurrenceSchedule class.
        /// </summary>
        public RecurrenceSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecurrenceSchedule class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="minutes">The minutes.</param>
        /// <param name="hours">The hours.</param>
        /// <param name="weekDays">The days of the week.</param>
        /// <param name="monthDays">The month days.</param>
        /// <param name="monthlyOccurrences">The monthly occurrences.</param>
        public RecurrenceSchedule(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IList<int?> minutes = default(IList<int?>), IList<int?> hours = default(IList<int?>), IList<DaysOfWeek?> weekDays = default(IList<DaysOfWeek?>), IList<int?> monthDays = default(IList<int?>), IList<RecurrenceScheduleOccurrence> monthlyOccurrences = default(IList<RecurrenceScheduleOccurrence>))
        {
            AdditionalProperties = additionalProperties;
            Minutes = minutes;
            Hours = hours;
            WeekDays = weekDays;
            MonthDays = monthDays;
            MonthlyOccurrences = monthlyOccurrences;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets the minutes.
        /// </summary>
        [JsonProperty(PropertyName = "minutes")]
        public IList<int?> Minutes { get; set; }

        /// <summary>
        /// Gets or sets the hours.
        /// </summary>
        [JsonProperty(PropertyName = "hours")]
        public IList<int?> Hours { get; set; }

        /// <summary>
        /// Gets or sets the days of the week.
        /// </summary>
        [JsonProperty(PropertyName = "weekDays")]
        public IList<DaysOfWeek?> WeekDays { get; set; }

        /// <summary>
        /// Gets or sets the month days.
        /// </summary>
        [JsonProperty(PropertyName = "monthDays")]
        public IList<int?> MonthDays { get; set; }

        /// <summary>
        /// Gets or sets the monthly occurrences.
        /// </summary>
        [JsonProperty(PropertyName = "monthlyOccurrences")]
        public IList<RecurrenceScheduleOccurrence> MonthlyOccurrences { get; set; }

    }
}
