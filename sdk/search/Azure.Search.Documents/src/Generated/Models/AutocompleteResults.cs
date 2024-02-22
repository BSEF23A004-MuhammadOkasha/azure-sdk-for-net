// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Models
{
    /// <summary> The result of Autocomplete query. </summary>
    public partial class AutocompleteResults
    {
        /// <summary> Initializes a new instance of <see cref="AutocompleteResults"/>. </summary>
        /// <param name="results"> The list of returned Autocompleted items. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal AutocompleteResults(IEnumerable<AutocompleteItem> results)
        {
            if (results == null)
            {
                throw new ArgumentNullException(nameof(results));
            }

            Results = results.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AutocompleteResults"/>. </summary>
        /// <param name="coverage"> A value indicating the percentage of the index that was considered by the autocomplete request, or null if minimumCoverage was not specified in the request. </param>
        /// <param name="results"> The list of returned Autocompleted items. </param>
        internal AutocompleteResults(double? coverage, IReadOnlyList<AutocompleteItem> results)
        {
            Coverage = coverage;
            Results = results;
        }

        /// <summary> A value indicating the percentage of the index that was considered by the autocomplete request, or null if minimumCoverage was not specified in the request. </summary>
        public double? Coverage { get; }
        /// <summary> The list of returned Autocompleted items. </summary>
        public IReadOnlyList<AutocompleteItem> Results { get; }
    }
}
