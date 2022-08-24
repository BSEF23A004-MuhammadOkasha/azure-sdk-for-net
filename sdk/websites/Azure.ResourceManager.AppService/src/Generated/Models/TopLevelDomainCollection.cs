// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Collection of Top-level domains.
    /// Serialized Name: TopLevelDomainCollection
    /// </summary>
    internal partial class TopLevelDomainCollection
    {
        /// <summary> Initializes a new instance of TopLevelDomainCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: TopLevelDomainCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal TopLevelDomainCollection(IEnumerable<TopLevelDomainData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of TopLevelDomainCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: TopLevelDomainCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: TopLevelDomainCollection.nextLink
        /// </param>
        internal TopLevelDomainCollection(IReadOnlyList<TopLevelDomainData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: TopLevelDomainCollection.value
        /// </summary>
        public IReadOnlyList<TopLevelDomainData> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: TopLevelDomainCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
