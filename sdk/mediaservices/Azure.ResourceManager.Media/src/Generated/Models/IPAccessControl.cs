// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The IP access control. </summary>
    internal partial class IPAccessControl
    {
        /// <summary> Initializes a new instance of IPAccessControl. </summary>
        public IPAccessControl()
        {
            AllowedIPs = new ChangeTrackingList<IPRange>();
        }

        /// <summary> Initializes a new instance of IPAccessControl. </summary>
        /// <param name="allowedIPs"> The IP allow list. </param>
        internal IPAccessControl(IList<IPRange> allowedIPs)
        {
            AllowedIPs = allowedIPs;
        }

        /// <summary> The IP allow list. </summary>
        public IList<IPRange> AllowedIPs { get; }
    }
}
