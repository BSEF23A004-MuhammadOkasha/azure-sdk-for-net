// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Applications.Containers.Models
{
    /// <summary> The configuration settings of the paths HTTP requests. </summary>
    internal partial class HttpSettingsRoutes
    {
        /// <summary> Initializes a new instance of HttpSettingsRoutes. </summary>
        public HttpSettingsRoutes()
        {
        }

        /// <summary> Initializes a new instance of HttpSettingsRoutes. </summary>
        /// <param name="apiPrefix"> The prefix that should precede all the authentication/authorization paths. </param>
        internal HttpSettingsRoutes(string apiPrefix)
        {
            ApiPrefix = apiPrefix;
        }

        /// <summary> The prefix that should precede all the authentication/authorization paths. </summary>
        public string ApiPrefix { get; set; }
    }
}
