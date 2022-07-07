// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged list of portal revisions. </summary>
    internal partial class PortalRevisionCollection
    {
        /// <summary> Initializes a new instance of PortalRevisionCollection. </summary>
        internal PortalRevisionCollection()
        {
            Value = new ChangeTrackingList<PortalRevisionContractData>();
        }

        /// <summary> Initializes a new instance of PortalRevisionCollection. </summary>
        /// <param name="value"> Collection of portal revisions. </param>
        /// <param name="nextLink"> Next page link, if any. </param>
        internal PortalRevisionCollection(IReadOnlyList<PortalRevisionContractData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of portal revisions. </summary>
        public IReadOnlyList<PortalRevisionContractData> Value { get; }
        /// <summary> Next page link, if any. </summary>
        public string NextLink { get; }
    }
}
