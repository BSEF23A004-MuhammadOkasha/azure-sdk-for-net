// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.CustomSearch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the top-level object that the response includes when the
    /// request succeeds.
    /// </summary>
    public partial class SearchResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the SearchResponse class.
        /// </summary>
        public SearchResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchResponse class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="queryContext">An object that contains the query string
        /// that Bing used for the request. This object contains the query
        /// string as entered by the user. It may also contain an altered query
        /// string that Bing used for the query if the query string contained a
        /// spelling mistake.</param>
        /// <param name="webPages">A list of webpages that are relevant to the
        /// search query.</param>
        public SearchResponse(string id = default(string), string webSearchUrl = default(string), QueryContext queryContext = default(QueryContext), WebWebAnswer webPages = default(WebWebAnswer))
            : base(id, webSearchUrl)
        {
            QueryContext = queryContext;
            WebPages = webPages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets an object that contains the query string that Bing used for
        /// the request. This object contains the query string as entered by
        /// the user. It may also contain an altered query string that Bing
        /// used for the query if the query string contained a spelling
        /// mistake.
        /// </summary>
        [JsonProperty(PropertyName = "queryContext")]
        public QueryContext QueryContext { get; private set; }

        /// <summary>
        /// Gets a list of webpages that are relevant to the search query.
        /// </summary>
        [JsonProperty(PropertyName = "webPages")]
        public WebWebAnswer WebPages { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (QueryContext != null)
            {
                QueryContext.Validate();
            }
            if (WebPages != null)
            {
                WebPages.Validate();
            }
        }
    }
}
