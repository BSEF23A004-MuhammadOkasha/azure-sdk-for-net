// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Additional parameters for SuggestGet operation.
    /// </summary>
    public partial class SuggestParameters
    {
        /// <summary>
        /// Initializes a new instance of the SuggestParameters class.
        /// </summary>
        public SuggestParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SuggestParameters class.
        /// </summary>
        /// <param name="filter">An expression that filters the documents
        /// considered for suggestions.</param>
        /// <param name="useFuzzyMatching">A value indicating whether to use
        /// fuzzy matching for the suggestions query. Default is false. When
        /// set to true, the query will find terms even if there's a
        /// substituted or missing character in the search text. While this
        /// provides a better experience in some scenarios it comes at a
        /// performance cost as fuzzy autocomplete queries are slower and
        /// consume more resources.</param>
        /// <param name="highlightPostTag">A string tag that is appended to hit
        /// highlights. Must be set with HighlightPreTag. Default is
        /// "".</param>
        /// <param name="highlightPreTag">A string tag that is prepended to hit
        /// highlights. Must be set with HighlightPostTag. Default is
        /// "".</param>
        /// <param name="minimumCoverage">A number between 0 and 100 indicating
        /// the percentage of the index that must be covered by a suggestions
        /// query in order for the query to be reported as a success. This
        /// parameter can be useful for ensuring search availability even for
        /// services with only one replica. The default is 80.</param>
        /// <param name="orderBy">The comma-separated list of OData $orderby
        /// expressions by which to sort the results. Each expression can be
        /// either a field name or a call to either the geo.distance() or the
        /// search.score() functions. Each expression can be followed by asc to
        /// indicate ascending, and desc to indicate descending. The default is
        /// ascending order. Ties will be broken by the match scores of
        /// documents. If no OrderBy is specified, the default sort order is
        /// descending by document match score. There can be at most 32 Orderby
        /// clauses.</param>
        /// <param name="searchFields">The list of comma-separated field names
        /// to search for the specified search text. Target fields must be
        /// enabled for suggestions.</param>
        /// <param name="selectStr">The comma-separated list of fields to
        /// retrieve. If unspecified, all fields marked as retrievable in the
        /// schema are included.</param>
        /// <param name="top">The number of suggestions to retrieve. The value
        /// must be a number between 1 and 100. The default is to 5.</param>
        private SuggestParameters(string filter = default(string), bool? useFuzzyMatching = default(bool?), string highlightPostTag = default(string), string highlightPreTag = default(string), double? minimumCoverage = default(double?), IList<string> orderBy = default(IList<string>), IList<string> searchFields = default(IList<string>), string selectStr = default(string), int? top = default(int?))
        {
            Filter = filter;
            UseFuzzyMatching = useFuzzyMatching;
            HighlightPostTag = highlightPostTag;
            HighlightPreTag = highlightPreTag;
            MinimumCoverage = minimumCoverage;
            OrderBy = orderBy;
            SearchFields = searchFields;
            SelectStr = selectStr;
            Top = top;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an expression that filters the documents considered
        /// for suggestions.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use fuzzy matching for
        /// the suggestions query. Default is false. When set to true, the
        /// query will find terms even if there's a substituted or missing
        /// character in the search text. While this provides a better
        /// experience in some scenarios it comes at a performance cost as
        /// fuzzy autocomplete queries are slower and consume more resources.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public bool? UseFuzzyMatching { get; set; }

        /// <summary>
        /// Gets or sets a string tag that is appended to hit highlights. Must
        /// be set with HighlightPreTag. Default is "".
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string HighlightPostTag { get; set; }

        /// <summary>
        /// Gets or sets a string tag that is prepended to hit highlights. Must
        /// be set with HighlightPostTag. Default is "".
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string HighlightPreTag { get; set; }

        /// <summary>
        /// Gets or sets a number between 0 and 100 indicating the percentage
        /// of the index that must be covered by a suggestions query in order
        /// for the query to be reported as a success. This parameter can be
        /// useful for ensuring search availability even for services with only
        /// one replica. The default is 80.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public double? MinimumCoverage { get; set; }

        /// <summary>
        /// Gets or sets the comma-separated list of OData $orderby expressions
        /// by which to sort the results. Each expression can be either a field
        /// name or a call to either the geo.distance() or the search.score()
        /// functions. Each expression can be followed by asc to indicate
        /// ascending, and desc to indicate descending. The default is
        /// ascending order. Ties will be broken by the match scores of
        /// documents. If no OrderBy is specified, the default sort order is
        /// descending by document match score. There can be at most 32 Orderby
        /// clauses.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public IList<string> OrderBy { get; set; }

        /// <summary>
        /// Gets or sets the list of comma-separated field names to search for
        /// the specified search text. Target fields must be enabled for
        /// suggestions.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public IList<string> SearchFields { get; set; }

        /// <summary>
        /// Gets or sets the comma-separated list of fields to retrieve. If
        /// unspecified, all fields marked as retrievable in the schema are
        /// included.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        protected internal string SelectStr { get { return (Select != null && Select.Any()) ? string.Join(",", Select) : "*"; } set { } }

        /// <summary>
        /// Gets or sets the number of suggestions to retrieve. The value must
        /// be a number between 1 and 100. The default is to 5.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int? Top { get; set; }

    }
}
