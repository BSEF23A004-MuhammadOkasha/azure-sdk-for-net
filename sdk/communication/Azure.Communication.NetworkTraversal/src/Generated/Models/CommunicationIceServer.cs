// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.NetworkTraversal
{
    /// <summary> An instance of a STUN/TURN server with credentials to be used for ICE negotiation. </summary>
    public partial class CommunicationIceServer
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CommunicationIceServer"/>. </summary>
        /// <param name="urls"> List of STUN/TURN server URLs. </param>
        /// <param name="username"> User account name which uniquely identifies the credentials. </param>
        /// <param name="credential"> Credential for the server. </param>
        /// <param name="routeType"> The routing methodology to where the ICE server will be located from the client. "any" will have higher reliability while "nearest" will have lower latency. It is recommended to default to use the "any" routing method unless there are specific scenarios which minimizing latency is critical. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="urls"/>, <paramref name="username"/> or <paramref name="credential"/> is null. </exception>
        public CommunicationIceServer(IEnumerable<string> urls, string username, string credential, RouteType routeType)
        {
            Argument.AssertNotNull(urls, nameof(urls));
            Argument.AssertNotNull(username, nameof(username));
            Argument.AssertNotNull(credential, nameof(credential));

            Urls = urls.ToList();
            Username = username;
            Credential = credential;
            RouteType = routeType;
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationIceServer"/>. </summary>
        /// <param name="urls"> List of STUN/TURN server URLs. </param>
        /// <param name="username"> User account name which uniquely identifies the credentials. </param>
        /// <param name="credential"> Credential for the server. </param>
        /// <param name="routeType"> The routing methodology to where the ICE server will be located from the client. "any" will have higher reliability while "nearest" will have lower latency. It is recommended to default to use the "any" routing method unless there are specific scenarios which minimizing latency is critical. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CommunicationIceServer(IList<string> urls, string username, string credential, RouteType routeType, Dictionary<string, BinaryData> rawData)
        {
            Urls = urls;
            Username = username;
            Credential = credential;
            RouteType = routeType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationIceServer"/> for deserialization. </summary>
        internal CommunicationIceServer()
        {
        }

        /// <summary> List of STUN/TURN server URLs. </summary>
        public IList<string> Urls { get; }
        /// <summary> User account name which uniquely identifies the credentials. </summary>
        public string Username { get; set; }
        /// <summary> Credential for the server. </summary>
        public string Credential { get; set; }
        /// <summary> The routing methodology to where the ICE server will be located from the client. "any" will have higher reliability while "nearest" will have lower latency. It is recommended to default to use the "any" routing method unless there are specific scenarios which minimizing latency is critical. </summary>
        public RouteType RouteType { get; set; }
    }
}
