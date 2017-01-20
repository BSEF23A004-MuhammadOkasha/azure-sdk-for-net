// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class RecurrenceScheduleOccurrence
    {
        /// <summary>
        /// Initializes a new instance of the RecurrenceScheduleOccurrence
        /// class.
        /// </summary>
        public RecurrenceScheduleOccurrence() { }

        /// <summary>
        /// Initializes a new instance of the RecurrenceScheduleOccurrence
        /// class.
        /// </summary>
        public RecurrenceScheduleOccurrence(DayOfWeek? day = default(DayOfWeek?), int? occurrence = default(int?))
        {
            Day = day;
            Occurrence = occurrence;
        }

        /// <summary>
        /// Gets or sets the day of the week. Possible values include:
        /// 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday',
        /// 'Saturday'
        /// </summary>
        [JsonProperty(PropertyName = "day")]
        public DayOfWeek? Day { get; set; }

        /// <summary>
        /// Gets or sets the occurrence.
        /// </summary>
        [JsonProperty(PropertyName = "occurrence")]
        public int? Occurrence { get; set; }

    }
}
