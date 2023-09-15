// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Result of check name availability. </summary>
    public partial class HDInsightNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of HDInsightNameAvailabilityResult. </summary>
        internal HDInsightNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of HDInsightNameAvailabilityResult. </summary>
        /// <param name="isNameAvailable"> Indicator of availability of the Microsoft.HDInsight resource name. </param>
        /// <param name="reason"> The reason of unavailability. </param>
        /// <param name="message"> The error message of unavailability. </param>
        internal HDInsightNameAvailabilityResult(bool? isNameAvailable, string reason, string message)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> Indicator of availability of the Microsoft.HDInsight resource name. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason of unavailability. </summary>
        public string Reason { get; }
        /// <summary> The error message of unavailability. </summary>
        public string Message { get; }
    }
}
