// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Value object for saved search results.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SavedSearch : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SavedSearch class.
        /// </summary>
        public SavedSearch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SavedSearch class.
        /// </summary>
        /// <param name="category">The category of the saved search. This helps
        /// the user to find a saved search faster. </param>
        /// <param name="displayName">Saved search display name.</param>
        /// <param name="query">The query expression for the saved search.
        /// Please see
        /// https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-search-reference
        /// for reference.</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="eTag">The ETag of the saved search.</param>
        /// <param name="version">The version number of the query language. The
        /// current version is 2 and is the default.</param>
        /// <param name="tags">The tags attached to the saved search.</param>
        public SavedSearch(string category, string displayName, string query, string id = default(string), string name = default(string), string type = default(string), string eTag = default(string), long? version = default(long?), IList<Tag> tags = default(IList<Tag>))
            : base(id, name, type)
        {
            ETag = eTag;
            Category = category;
            DisplayName = displayName;
            Query = query;
            Version = version;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ETag of the saved search.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the category of the saved search. This helps the user
        /// to find a saved search faster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets saved search display name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the query expression for the saved search. Please see
        /// https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-search-reference
        /// for reference.
        /// </summary>
        [JsonProperty(PropertyName = "properties.query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the version number of the query language. The current
        /// version is 2 and is the default.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public long? Version { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the saved search.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IList<Tag> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Category == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Category");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Query == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Query");
            }
            if (Tags != null)
            {
                foreach (var element in Tags)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
