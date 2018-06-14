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
    /// The workflow trigger recurrence.
    /// </summary>
    public partial class ScheduleTriggerRecurrence
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleTriggerRecurrence class.
        /// </summary>
        public ScheduleTriggerRecurrence()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleTriggerRecurrence class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="frequency">The frequency. Possible values include:
        /// 'NotSpecified', 'Minute', 'Hour', 'Day', 'Week', 'Month',
        /// 'Year'</param>
        /// <param name="interval">The interval.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="timeZone">The time zone.</param>
        /// <param name="schedule">The recurrence schedule.</param>
        public ScheduleTriggerRecurrence(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string frequency = default(string), int? interval = default(int?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string timeZone = default(string), RecurrenceSchedule schedule = default(RecurrenceSchedule))
        {
            AdditionalProperties = additionalProperties;
            Frequency = frequency;
            Interval = interval;
            StartTime = startTime;
            EndTime = endTime;
            TimeZone = timeZone;
            Schedule = schedule;
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
        /// Gets or sets the frequency. Possible values include:
        /// 'NotSpecified', 'Minute', 'Hour', 'Day', 'Week', 'Month', 'Year'
        /// </summary>
        [JsonProperty(PropertyName = "frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// Gets or sets the interval.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the recurrence schedule.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public RecurrenceSchedule Schedule { get; set; }

    }
}
