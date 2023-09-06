// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Identity
{
    /// <summary> An access token. </summary>
    internal partial class CommunicationIdentityAccessToken
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CommunicationIdentityAccessToken"/>. </summary>
        /// <param name="token"> The access token issued for the identity. </param>
        /// <param name="expiresOn"> The expiry time of the token. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="token"/> is null. </exception>
        internal CommunicationIdentityAccessToken(string token, DateTimeOffset expiresOn)
        {
            Argument.AssertNotNull(token, nameof(token));

            Token = token;
            ExpiresOn = expiresOn;
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationIdentityAccessToken"/>. </summary>
        /// <param name="token"> The access token issued for the identity. </param>
        /// <param name="expiresOn"> The expiry time of the token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CommunicationIdentityAccessToken(string token, DateTimeOffset expiresOn, Dictionary<string, BinaryData> rawData)
        {
            Token = token;
            ExpiresOn = expiresOn;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationIdentityAccessToken"/> for deserialization. </summary>
        internal CommunicationIdentityAccessToken()
        {
        }

        /// <summary> The access token issued for the identity. </summary>
        public string Token { get; }
        /// <summary> The expiry time of the token. </summary>
        public DateTimeOffset ExpiresOn { get; }
    }
}
