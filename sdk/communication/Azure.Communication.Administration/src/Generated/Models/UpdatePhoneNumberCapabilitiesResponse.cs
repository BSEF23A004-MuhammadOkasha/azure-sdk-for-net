// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    /// <summary> Response for getting a phone number update capabilities. </summary>
    public partial class UpdatePhoneNumberCapabilitiesResponse
    {
        /// <summary> Initializes a new instance of UpdatePhoneNumberCapabilitiesResponse. </summary>
        internal UpdatePhoneNumberCapabilitiesResponse()
        {
            PhoneNumberCapabilitiesUpdates = new ChangeTrackingDictionary<string, NumberUpdateCapabilities>();
        }

        /// <summary> Initializes a new instance of UpdatePhoneNumberCapabilitiesResponse. </summary>
        /// <param name="capabilitiesUpdateId"> The id of the phone number capabilities update. </param>
        /// <param name="createdAt"> The time the capabilities update was created. </param>
        /// <param name="capabilitiesUpdateStatus"> Status of the capabilities update. </param>
        /// <param name="phoneNumberCapabilitiesUpdates"> The capabilities update for each of a set of phone numbers. </param>
        internal UpdatePhoneNumberCapabilitiesResponse(string capabilitiesUpdateId, DateTimeOffset? createdAt, CapabilitiesUpdateStatus? capabilitiesUpdateStatus, IReadOnlyDictionary<string, NumberUpdateCapabilities> phoneNumberCapabilitiesUpdates)
        {
            CapabilitiesUpdateId = capabilitiesUpdateId;
            CreatedAt = createdAt;
            CapabilitiesUpdateStatus = capabilitiesUpdateStatus;
            PhoneNumberCapabilitiesUpdates = phoneNumberCapabilitiesUpdates;
        }

        /// <summary> The id of the phone number capabilities update. </summary>
        public string CapabilitiesUpdateId { get; }
        /// <summary> The time the capabilities update was created. </summary>
        public DateTimeOffset? CreatedAt { get; }
        /// <summary> Status of the capabilities update. </summary>
        public CapabilitiesUpdateStatus? CapabilitiesUpdateStatus { get; }
        /// <summary> The capabilities update for each of a set of phone numbers. </summary>
        public IReadOnlyDictionary<string, NumberUpdateCapabilities> PhoneNumberCapabilitiesUpdates { get; }
    }
}
