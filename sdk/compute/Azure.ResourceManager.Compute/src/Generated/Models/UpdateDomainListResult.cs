// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The list operation result. </summary>
    internal partial class UpdateDomainListResult
    {
        /// <summary> Initializes a new instance of <see cref="UpdateDomainListResult"/>. </summary>
        /// <param name="value"> The list of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal UpdateDomainListResult(IEnumerable<UpdateDomainIdentifier> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="UpdateDomainListResult"/>. </summary>
        /// <param name="value"> The list of resources. </param>
        /// <param name="nextLink"> The URI to fetch the next page of resources. Use this to get the next page of resources. Do this till nextLink is null to fetch all the resources. </param>
        internal UpdateDomainListResult(IReadOnlyList<UpdateDomainIdentifier> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of resources. </summary>
        public IReadOnlyList<UpdateDomainIdentifier> Value { get; }
        /// <summary> The URI to fetch the next page of resources. Use this to get the next page of resources. Do this till nextLink is null to fetch all the resources. </summary>
        public string NextLink { get; }
    }
}
