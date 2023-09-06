// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.Identity.Models;
using Azure.Core;

namespace Azure.Communication.Identity
{
    /// <summary> A communication identity with access token. </summary>
    public partial class CommunicationUserIdentifierAndToken
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CommunicationUserIdentifierAndToken"/>. </summary>
        /// <param name="identity"> A communication identity. </param>
        /// <param name="internalAccessToken"> An access token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CommunicationUserIdentifierAndToken(CommunicationIdentity identity, CommunicationIdentityAccessToken internalAccessToken, Dictionary<string, BinaryData> rawData)
        {
            Identity = identity;
            InternalAccessToken = internalAccessToken;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationUserIdentifierAndToken"/> for deserialization. </summary>
        internal CommunicationUserIdentifierAndToken()
        {
        }
    }
}
