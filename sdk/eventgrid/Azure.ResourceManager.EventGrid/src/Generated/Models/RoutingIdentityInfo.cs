// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Routing identity info for topic spaces configuration. </summary>
    public partial class RoutingIdentityInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoutingIdentityInfo"/>. </summary>
        public RoutingIdentityInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RoutingIdentityInfo"/>. </summary>
        /// <param name="identityType"></param>
        /// <param name="userAssignedIdentity"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoutingIdentityInfo(RoutingIdentityType? identityType, string userAssignedIdentity, Dictionary<string, BinaryData> rawData)
        {
            IdentityType = identityType;
            UserAssignedIdentity = userAssignedIdentity;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the identity type. </summary>
        public RoutingIdentityType? IdentityType { get; set; }
        /// <summary> Gets or sets the user assigned identity. </summary>
        public string UserAssignedIdentity { get; set; }
    }
}
