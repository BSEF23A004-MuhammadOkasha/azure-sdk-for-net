// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The check availability result. </summary>
    public partial class ContainerAppNameAvailabilityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppNameAvailabilityResult"/>. </summary>
        internal ContainerAppNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicates if the resource name is available. </param>
        /// <param name="reason"> The reason why the given name is not available. </param>
        /// <param name="message"> Detailed reason why the given name is available. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppNameAvailabilityResult(bool? isNameAvailable, ContainerAppNameUnavailableReason? reason, string message, Dictionary<string, BinaryData> rawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Indicates if the resource name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason why the given name is not available. </summary>
        public ContainerAppNameUnavailableReason? Reason { get; }
        /// <summary> Detailed reason why the given name is available. </summary>
        public string Message { get; }
    }
}
