// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Collection of static site functions.
    /// Serialized Name: StaticSiteFunctionOverviewCollection
    /// </summary>
    internal partial class StaticSiteFunctionOverviewCollection
    {
        /// <summary> Initializes a new instance of StaticSiteFunctionOverviewCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: StaticSiteFunctionOverviewCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal StaticSiteFunctionOverviewCollection(IEnumerable<StaticSiteFunctionOverview> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of StaticSiteFunctionOverviewCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: StaticSiteFunctionOverviewCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: StaticSiteFunctionOverviewCollection.nextLink
        /// </param>
        internal StaticSiteFunctionOverviewCollection(IReadOnlyList<StaticSiteFunctionOverview> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: StaticSiteFunctionOverviewCollection.value
        /// </summary>
        public IReadOnlyList<StaticSiteFunctionOverview> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: StaticSiteFunctionOverviewCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
