// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment script parameters to be updated. </summary>
    public partial class DeploymentScriptUpdateParameter : AzureResourceBase
    {
        /// <summary> Initializes a new instance of DeploymentScriptUpdateParameter. </summary>
        public DeploymentScriptUpdateParameter()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DeploymentScriptUpdateParameter. </summary>
        /// <param name="id"> String Id used to locate any resource on Azure. </param>
        /// <param name="name"> Name of this resource. </param>
        /// <param name="type"> Type of this resource. </param>
        /// <param name="tags"> Resource tags to be updated. </param>
        internal DeploymentScriptUpdateParameter(string id, string name, string type, IDictionary<string, string> tags) : base(id, name, type)
        {
            Tags = tags;
        }

        /// <summary> Resource tags to be updated. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
