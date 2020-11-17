// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Entity representing the reference to the template.
    /// </summary>
    public partial class TemplateLink
    {
        /// <summary>
        /// Initializes a new instance of the TemplateLink class.
        /// </summary>
        public TemplateLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TemplateLink class.
        /// </summary>
        /// <param name="uri">The URI of the template to deploy. Use either the
        /// uri or id property, but not both.</param>
        /// <param name="id">The resource id of a Template Spec. Use either the
        /// id or uri property, but not both.</param>
        /// <param name="relativePath">The relativePath property can be used to
        /// deploy a linked template at a location relative to the parent. If
        /// the parent template was linked with a TemplateSpec, this will
        /// reference an artifact in the TemplateSpec.  If the parent was
        /// linked with a URI, the child deployment will be a combination of
        /// the parent and relativePath URIs</param>
        /// <param name="queryString">The query string (for example, a SAS
        /// token) to be used with the templateLink URI.</param>
        /// <param name="contentVersion">If included, must match the
        /// ContentVersion in the template.</param>
        public TemplateLink(string uri = default(string), string id = default(string), string relativePath = default(string), string queryString = default(string), string contentVersion = default(string))
        {
            Uri = uri;
            Id = id;
            RelativePath = relativePath;
            QueryString = queryString;
            ContentVersion = contentVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URI of the template to deploy. Use either the uri
        /// or id property, but not both.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the resource id of a Template Spec. Use either the id
        /// or uri property, but not both.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the relativePath property can be used to deploy a
        /// linked template at a location relative to the parent. If the parent
        /// template was linked with a TemplateSpec, this will reference an
        /// artifact in the TemplateSpec.  If the parent was linked with a URI,
        /// the child deployment will be a combination of the parent and
        /// relativePath URIs
        /// </summary>
        [JsonProperty(PropertyName = "relativePath")]
        public string RelativePath { get; set; }

        /// <summary>
        /// Gets or sets the query string (for example, a SAS token) to be used
        /// with the templateLink URI.
        /// </summary>
        [JsonProperty(PropertyName = "queryString")]
        public string QueryString { get; set; }

        /// <summary>
        /// Gets or sets if included, must match the ContentVersion in the
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "contentVersion")]
        public string ContentVersion { get; set; }

    }
}
