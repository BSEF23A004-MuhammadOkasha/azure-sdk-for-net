// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.NetworkTraversal
{
    /// <summary> A TURN credentials response. </summary>
    public partial class CommunicationRelayConfiguration
    {
        /// <summary> Initializes a new instance of CommunicationRelayConfiguration. </summary>
        /// <param name="expiresOn"> The date for which the username and credentials are not longer valid. </param>
        /// <param name="turnServers"> An array representing the credentials and the TURN server URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="turnServers"/> is null. </exception>
        internal CommunicationRelayConfiguration(DateTimeOffset expiresOn, IEnumerable<CommunicationTurnServer> turnServers)
        {
            if (turnServers == null)
            {
                throw new ArgumentNullException(nameof(turnServers));
            }

            ExpiresOn = expiresOn;
            TurnServers = turnServers.ToList();
        }

        /// <summary> Initializes a new instance of CommunicationRelayConfiguration. </summary>
        /// <param name="expiresOn"> The date for which the username and credentials are not longer valid. </param>
        /// <param name="turnServers"> An array representing the credentials and the TURN server URL. </param>
        internal CommunicationRelayConfiguration(DateTimeOffset expiresOn, IReadOnlyList<CommunicationTurnServer> turnServers)
        {
            ExpiresOn = expiresOn;
            TurnServers = turnServers;
        }

        /// <summary> The date for which the username and credentials are not longer valid. </summary>
        public DateTimeOffset ExpiresOn { get; }
        /// <summary> An array representing the credentials and the TURN server URL. </summary>
        public IReadOnlyList<CommunicationTurnServer> TurnServers { get; }
    }
}
