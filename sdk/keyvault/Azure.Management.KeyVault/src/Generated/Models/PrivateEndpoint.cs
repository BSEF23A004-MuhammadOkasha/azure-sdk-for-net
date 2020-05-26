// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.KeyVault.Models
{
    /// <summary> Private endpoint object properties. </summary>
    public partial class PrivateEndpoint
    {
        /// <summary> Initializes a new instance of PrivateEndpoint. </summary>
        public PrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpoint. </summary>
        /// <param name="id"> Full identifier of the private endpoint resource. </param>
        internal PrivateEndpoint(string id)
        {
            Id = id;
        }

        /// <summary> Full identifier of the private endpoint resource. </summary>
        public string Id { get; }
    }
}
