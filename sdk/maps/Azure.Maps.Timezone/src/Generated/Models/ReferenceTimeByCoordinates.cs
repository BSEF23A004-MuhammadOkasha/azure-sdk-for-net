// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Timezone.Models
{
    /// <summary> Details in effect at the local time. </summary>
    public partial class ReferenceTimeByCoordinates
    {
        /// <summary> Initializes a new instance of ReferenceTimeByCoordinates. </summary>
        internal ReferenceTimeByCoordinates()
        {
        }

        /// <summary> Initializes a new instance of ReferenceTimeByCoordinates. </summary>
        /// <param name="tag"> Time zone name in effect at the reference timestamp (i.e. PST or PDT depending whether Daylight Savings Time is in effect). </param>
        /// <param name="standardOffset"> UTC offset in effect at the `ReferenceUTCTimestamp`. </param>
        /// <param name="daylightSavings"> Time saving in minutes in effect at the `ReferenceUTCTimestamp`. </param>
        /// <param name="wallTime"> Current wall time at the given time zone as shown in the `Tag` property. </param>
        /// <param name="posixTzValidYear"> The year this POSIX string is valid for. Note: A POSIX string will only be valid in the given year. </param>
        /// <param name="posixTz"> POSIX string used to set the time zone environment variable. </param>
        /// <param name="sunrise"> Sunrise at the given time zone as shown in the `Tag` property. </param>
        /// <param name="sunset"> Sunset at the given time zone as shown in the `Tag` property. </param>
        internal ReferenceTimeByCoordinates(string tag, string standardOffset, string daylightSavings, string wallTime, int? posixTzValidYear, string posixTz, string sunrise, string sunset)
        {
            Tag = tag;
            StandardOffset = standardOffset;
            DaylightSavings = daylightSavings;
            WallTime = wallTime;
            PosixTzValidYear = posixTzValidYear;
            PosixTz = posixTz;
            Sunrise = sunrise;
            Sunset = sunset;
        }

        /// <summary> Time zone name in effect at the reference timestamp (i.e. PST or PDT depending whether Daylight Savings Time is in effect). </summary>
        public string Tag { get; }
        /// <summary> UTC offset in effect at the `ReferenceUTCTimestamp`. </summary>
        public string StandardOffset { get; }
        /// <summary> Time saving in minutes in effect at the `ReferenceUTCTimestamp`. </summary>
        public string DaylightSavings { get; }
        /// <summary> Current wall time at the given time zone as shown in the `Tag` property. </summary>
        public string WallTime { get; }
        /// <summary> The year this POSIX string is valid for. Note: A POSIX string will only be valid in the given year. </summary>
        public int? PosixTzValidYear { get; }
        /// <summary> POSIX string used to set the time zone environment variable. </summary>
        public string PosixTz { get; }
        /// <summary> Sunrise at the given time zone as shown in the `Tag` property. </summary>
        public string Sunrise { get; }
        /// <summary> Sunset at the given time zone as shown in the `Tag` property. </summary>
        public string Sunset { get; }
    }
}
