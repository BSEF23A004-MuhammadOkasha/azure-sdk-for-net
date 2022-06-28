// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Get Data Plane read only token response definition. </summary>
    public partial class AccessPolicyResponse
    {
        /// <summary> Initializes a new instance of AccessPolicyResponse. </summary>
        internal AccessPolicyResponse()
        {
        }

        /// <summary> Initializes a new instance of AccessPolicyResponse. </summary>
        /// <param name="policy"> The user access policy. </param>
        /// <param name="accessToken"> Data Plane read only access token. </param>
        /// <param name="dataPlaneUri"> Data Plane service base URL. </param>
        internal AccessPolicyResponse(UserAccessPolicy policy, string accessToken, Uri dataPlaneUri)
        {
            Policy = policy;
            AccessToken = accessToken;
            DataPlaneUri = dataPlaneUri;
        }

        /// <summary> The user access policy. </summary>
        public UserAccessPolicy Policy { get; }
        /// <summary> Data Plane read only access token. </summary>
        public string AccessToken { get; }
        /// <summary> Data Plane service base URL. </summary>
        public Uri DataPlaneUri { get; }
    }
}
