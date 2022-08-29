// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The response payload for CheckNameAvailability API. </summary>
    public partial class CheckNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityResult. </summary>
        internal CheckNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of CheckNameAvailabilityResult. </summary>
        /// <param name="message"> Error message. </param>
        /// <param name="nameAvailable"> Indicates if name is valid and available. </param>
        /// <param name="reason"> The reason the name is not available. </param>
        internal CheckNameAvailabilityResult(string message, bool? nameAvailable, Reason? reason)
        {
            Message = message;
            NameAvailable = nameAvailable;
            Reason = reason;
        }

        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Indicates if name is valid and available. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason the name is not available. </summary>
        public Reason? Reason { get; }
    }
}
