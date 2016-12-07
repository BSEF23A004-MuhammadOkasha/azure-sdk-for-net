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
    /// Source control configuration for an app.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SiteSourceControlInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SiteSourceControlInner class.
        /// </summary>
        public SiteSourceControlInner() { }

        /// <summary>
        /// Initializes a new instance of the SiteSourceControlInner class.
        /// </summary>
        /// <param name="repoUrl">Repository or source control URL.</param>
        /// <param name="branch">Name of branch to use for deployment.</param>
        /// <param name="isManualIntegration"><code>true</code> to limit to
        /// manual integration; <code>false</code> to enable continuous
        /// integration (which configures webhooks into online repos like
        /// GitHub).</param>
        /// <param name="deploymentRollbackEnabled"><code>true</code> to
        /// enable deployment rollback; otherwise, <code>false</code>.</param>
        /// <param name="isMercurial"><code>true</code> for a Mercurial
        /// repository; <code>false</code> for a Git repository.</param>
        public SiteSourceControlInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string repoUrl = default(string), string branch = default(string), bool? isManualIntegration = default(bool?), bool? deploymentRollbackEnabled = default(bool?), bool? isMercurial = default(bool?))
            : base(location, id, name, type, tags)
        {
            RepoUrl = repoUrl;
            Branch = branch;
            IsManualIntegration = isManualIntegration;
            DeploymentRollbackEnabled = deploymentRollbackEnabled;
            IsMercurial = isMercurial;
        }

        /// <summary>
        /// Gets or sets repository or source control URL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.repoUrl")]
        public string RepoUrl { get; set; }

        /// <summary>
        /// Gets or sets name of branch to use for deployment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; to limit to manual
        /// integration; &lt;code&gt;false&lt;/code&gt; to enable continuous
        /// integration (which configures webhooks into online repos like
        /// GitHub).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isManualIntegration")]
        public bool? IsManualIntegration { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; to enable deployment
        /// rollback; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.deploymentRollbackEnabled")]
        public bool? DeploymentRollbackEnabled { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; for a Mercurial
        /// repository; &lt;code&gt;false&lt;/code&gt; for a Git repository.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isMercurial")]
        public bool? IsMercurial { get; set; }

    }
}
