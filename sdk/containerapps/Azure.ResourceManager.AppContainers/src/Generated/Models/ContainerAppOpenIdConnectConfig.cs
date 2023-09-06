// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the endpoints used for the custom Open ID Connect provider. </summary>
    public partial class ContainerAppOpenIdConnectConfig
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppOpenIdConnectConfig"/>. </summary>
        public ContainerAppOpenIdConnectConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppOpenIdConnectConfig"/>. </summary>
        /// <param name="authorizationEndpoint"> The endpoint to be used to make an authorization request. </param>
        /// <param name="tokenEndpoint"> The endpoint to be used to request a token. </param>
        /// <param name="issuer"> The endpoint that issues the token. </param>
        /// <param name="certificationUri"> The endpoint that provides the keys necessary to validate the token. </param>
        /// <param name="wellKnownOpenIdConfiguration"> The endpoint that contains all the configuration endpoints for the provider. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppOpenIdConnectConfig(string authorizationEndpoint, string tokenEndpoint, string issuer, Uri certificationUri, string wellKnownOpenIdConfiguration, Dictionary<string, BinaryData> rawData)
        {
            AuthorizationEndpoint = authorizationEndpoint;
            TokenEndpoint = tokenEndpoint;
            Issuer = issuer;
            CertificationUri = certificationUri;
            WellKnownOpenIdConfiguration = wellKnownOpenIdConfiguration;
            _rawData = rawData;
        }

        /// <summary> The endpoint to be used to make an authorization request. </summary>
        public string AuthorizationEndpoint { get; set; }
        /// <summary> The endpoint to be used to request a token. </summary>
        public string TokenEndpoint { get; set; }
        /// <summary> The endpoint that issues the token. </summary>
        public string Issuer { get; set; }
        /// <summary> The endpoint that provides the keys necessary to validate the token. </summary>
        public Uri CertificationUri { get; set; }
        /// <summary> The endpoint that contains all the configuration endpoints for the provider. </summary>
        public string WellKnownOpenIdConfiguration { get; set; }
    }
}
