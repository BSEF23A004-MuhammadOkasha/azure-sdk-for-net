// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of endpoint certificates on the target instance. </summary>
    internal partial class EndpointCertificateListResult
    {
        /// <summary> Initializes a new instance of <see cref="EndpointCertificateListResult"/>. </summary>
        internal EndpointCertificateListResult()
        {
            Value = new ChangeTrackingList<EndpointCertificateData>();
        }

        /// <summary> Initializes a new instance of <see cref="EndpointCertificateListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal EndpointCertificateListResult(IReadOnlyList<EndpointCertificateData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<EndpointCertificateData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
