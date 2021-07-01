// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> The result of the query. SearchCommonResponse if the query completed successfully, ErrorResponse otherwise. </summary>
    public partial class SearchFuzzyBatchItemResponse : SearchCommonResponse
    {
        /// <summary> Initializes a new instance of SearchFuzzyBatchItemResponse. </summary>
        internal SearchFuzzyBatchItemResponse()
        {
        }

        /// <summary> Initializes a new instance of SearchFuzzyBatchItemResponse. </summary>
        /// <param name="summary"> Summary object for a Search API response. </param>
        /// <param name="results"> A list of Search API results. </param>
        /// <param name="error"> The error object. </param>
        internal SearchFuzzyBatchItemResponse(SearchCommonSummary summary, IReadOnlyList<SearchCommonResult> results, ErrorDetail error) : base(summary, results)
        {
            Error = error;
        }

        /// <summary> The error object. </summary>
        public ErrorDetail Error { get; }
    }
}
