// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter
{
    /// <summary> A paged collection of distribution policies. </summary>
    public partial class DistributionPolicyCollection
    {
        /// <summary> Initializes a new instance of DistributionPolicyCollection. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DistributionPolicyCollection(IEnumerable<PagedDistributionPolicy> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DistributionPolicyCollection. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal DistributionPolicyCollection(IReadOnlyList<PagedDistributionPolicy> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<PagedDistributionPolicy> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
