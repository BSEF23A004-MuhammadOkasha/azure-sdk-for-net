// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The check availability result. </summary>
    public partial class CostManagementNameAvailabilityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CostManagementNameAvailabilityResult"/>. </summary>
        internal CostManagementNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CostManagementNameAvailabilityResult"/>. </summary>
        /// <param name="nameAvailable"> Indicates if the resource name is available. </param>
        /// <param name="reason"> The reason why the given name is not available. </param>
        /// <param name="message"> Detailed reason why the given name is available. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CostManagementNameAvailabilityResult(bool? nameAvailable, CostManagementUnavailabilityReason? reason, string message, Dictionary<string, BinaryData> rawData)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Indicates if the resource name is available. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason why the given name is not available. </summary>
        public CostManagementUnavailabilityReason? Reason { get; }
        /// <summary> Detailed reason why the given name is available. </summary>
        public string Message { get; }
    }
}
