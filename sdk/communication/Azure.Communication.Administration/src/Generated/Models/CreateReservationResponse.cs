// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Administration.Models
{
    /// <summary> Represents a search creation response. </summary>
    public partial class CreateReservationResponse
    {
        /// <summary> Initializes a new instance of CreateReservationResponse. </summary>
        /// <param name="reservationId"> The search id of the search that was created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationId"/> is null. </exception>
        internal CreateReservationResponse(string reservationId)
        {
            if (reservationId == null)
            {
                throw new ArgumentNullException(nameof(reservationId));
            }

            ReservationId = reservationId;
        }
    }
}
