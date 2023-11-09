// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Change directory response. </summary>
    public partial class ChangeDirectoryDetail
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChangeDirectoryDetail"/>. </summary>
        internal ChangeDirectoryDetail()
        {
            Reservations = new ChangeTrackingList<ChangeDirectoryResult>();
        }

        /// <summary> Initializes a new instance of <see cref="ChangeDirectoryDetail"/>. </summary>
        /// <param name="reservationOrder"> Change directory result for reservation order or reservation. </param>
        /// <param name="reservations"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChangeDirectoryDetail(ChangeDirectoryResult reservationOrder, IReadOnlyList<ChangeDirectoryResult> reservations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReservationOrder = reservationOrder;
            Reservations = reservations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Change directory result for reservation order or reservation. </summary>
        public ChangeDirectoryResult ReservationOrder { get; }
        /// <summary> Gets the reservations. </summary>
        public IReadOnlyList<ChangeDirectoryResult> Reservations { get; }
    }
}
