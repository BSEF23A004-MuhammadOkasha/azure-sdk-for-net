// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Time.
    /// </summary>
    public partial class Time
    {
        /// <summary>
        /// Initializes a new instance of the Time class.
        /// </summary>
        public Time()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Time class.
        /// </summary>
        /// <param name="hour">The hour.</param>
        /// <param name="minute">The minute.</param>
        public Time(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the hour.
        /// </summary>
        [JsonProperty(PropertyName = "hour")]
        public int Hour { get; set; }

        /// <summary>
        /// Gets or sets the minute.
        /// </summary>
        [JsonProperty(PropertyName = "minute")]
        public int Minute { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Hour > 23)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Hour", 23);
            }
            if (Hour < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Hour", 0);
            }
            if (Minute > 59)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Minute", 59);
            }
            if (Minute < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Minute", 0);
            }
        }
    }
}
