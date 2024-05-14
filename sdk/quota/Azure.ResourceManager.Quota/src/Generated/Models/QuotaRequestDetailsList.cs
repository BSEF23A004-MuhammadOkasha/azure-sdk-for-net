// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Quota;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Quota request information. </summary>
    internal partial class QuotaRequestDetailsList
    {
        /// <summary> Initializes a new instance of <see cref="QuotaRequestDetailsList"/>. </summary>
        internal QuotaRequestDetailsList()
        {
            Value = new ChangeTrackingList<QuotaRequestDetailData>();
        }

        /// <summary> Initializes a new instance of <see cref="QuotaRequestDetailsList"/>. </summary>
        /// <param name="value"> Quota request details. </param>
        /// <param name="nextLink"> The URI for fetching the next page of quota limits. When there are no more pages, this string is null. </param>
        internal QuotaRequestDetailsList(IReadOnlyList<QuotaRequestDetailData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Quota request details. </summary>
        public IReadOnlyList<QuotaRequestDetailData> Value { get; }
        /// <summary> The URI for fetching the next page of quota limits. When there are no more pages, this string is null. </summary>
        public string NextLink { get; }
    }
}
