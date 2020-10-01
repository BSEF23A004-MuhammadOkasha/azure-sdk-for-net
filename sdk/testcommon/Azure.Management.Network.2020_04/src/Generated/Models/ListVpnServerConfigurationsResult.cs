// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Result of the request to list all VpnServerConfigurations. It contains a list of VpnServerConfigurations and a URL nextLink to get the next set of results. </summary>
    public partial class ListVpnServerConfigurationsResult
    {
        /// <summary> Initializes a new instance of ListVpnServerConfigurationsResult. </summary>
        internal ListVpnServerConfigurationsResult()
        {
            Value = new ChangeTrackingList<VpnServerConfiguration>();
        }

        /// <summary> Initializes a new instance of ListVpnServerConfigurationsResult. </summary>
        /// <param name="value"> List of VpnServerConfigurations. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListVpnServerConfigurationsResult(IReadOnlyList<VpnServerConfiguration> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of VpnServerConfigurations. </summary>
        public IReadOnlyList<VpnServerConfiguration> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
