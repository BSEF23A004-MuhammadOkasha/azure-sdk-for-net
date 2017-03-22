// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Instance of an app.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SiteInstanceInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SiteInstanceInner class.
        /// </summary>
        public SiteInstanceInner() { }

        /// <summary>
        /// Initializes a new instance of the SiteInstanceInner class.
        /// </summary>
        /// <param name="siteInstanceName">Name of instance.</param>
        public SiteInstanceInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string siteInstanceName = default(string))
            : base(location, id, name, type, tags)
        {
            SiteInstanceName = siteInstanceName;
        }

        /// <summary>
        /// Gets name of instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.name")]
        public string SiteInstanceName { get; private set; }

    }
}
