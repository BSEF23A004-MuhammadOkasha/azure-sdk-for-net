// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cosmos DB indexing policy
    /// </summary>
    public partial class IndexingPolicy
    {
        /// <summary>
        /// Initializes a new instance of the IndexingPolicy class.
        /// </summary>
        public IndexingPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IndexingPolicy class.
        /// </summary>
        /// <param name="automatic">Indicates if the indexing policy is
        /// automatic</param>
        /// <param name="indexingMode">Indicates the indexing mode. Possible
        /// values include: 'Consistent', 'Lazy', 'None'</param>
        /// <param name="includedPaths">List of paths to include in the
        /// indexing</param>
        /// <param name="excludedPaths">List of paths to exclude from
        /// indexing</param>
        public IndexingPolicy(bool? automatic = default(bool?), string indexingMode = default(string), IList<IncludedPath> includedPaths = default(IList<IncludedPath>), IList<ExcludedPath> excludedPaths = default(IList<ExcludedPath>))
        {
            Automatic = automatic;
            IndexingMode = indexingMode;
            IncludedPaths = includedPaths;
            ExcludedPaths = excludedPaths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates if the indexing policy is automatic
        /// </summary>
        [JsonProperty(PropertyName = "automatic")]
        public bool? Automatic { get; set; }

        /// <summary>
        /// Gets or sets indicates the indexing mode. Possible values include:
        /// 'Consistent', 'Lazy', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "indexingMode")]
        public string IndexingMode { get; set; }

        /// <summary>
        /// Gets or sets list of paths to include in the indexing
        /// </summary>
        [JsonProperty(PropertyName = "includedPaths")]
        public IList<IncludedPath> IncludedPaths { get; set; }

        /// <summary>
        /// Gets or sets list of paths to exclude from indexing
        /// </summary>
        [JsonProperty(PropertyName = "excludedPaths")]
        public IList<ExcludedPath> ExcludedPaths { get; set; }

    }
}
