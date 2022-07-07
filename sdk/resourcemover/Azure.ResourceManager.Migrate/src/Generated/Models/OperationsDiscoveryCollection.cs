// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Collection of ClientDiscovery details. </summary>
    internal partial class OperationsDiscoveryCollection
    {
        /// <summary> Initializes a new instance of OperationsDiscoveryCollection. </summary>
        internal OperationsDiscoveryCollection()
        {
            Value = new ChangeTrackingList<OperationsDiscovery>();
        }

        /// <summary> Initializes a new instance of OperationsDiscoveryCollection. </summary>
        /// <param name="value"> Gets or sets the ClientDiscovery details. </param>
        /// <param name="nextLink"> Gets or sets the value of next link. </param>
        internal OperationsDiscoveryCollection(IReadOnlyList<OperationsDiscovery> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets the ClientDiscovery details. </summary>
        public IReadOnlyList<OperationsDiscovery> Value { get; }
        /// <summary> Gets or sets the value of next link. </summary>
        public string NextLink { get; }
    }
}
