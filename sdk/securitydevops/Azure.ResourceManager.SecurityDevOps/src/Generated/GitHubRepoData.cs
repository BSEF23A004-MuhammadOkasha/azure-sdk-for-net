// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityDevOps.Models;

namespace Azure.ResourceManager.SecurityDevOps
{
    /// <summary>
    /// A class representing the GitHubRepo data model.
    /// GitHub repo Proxy Resource.
    /// </summary>
    public partial class GitHubRepoData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GitHubRepoData"/>. </summary>
        public GitHubRepoData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubRepoData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> GitHub Repo properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubRepoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, GitHubRepoProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> GitHub Repo properties. </summary>
        public GitHubRepoProperties Properties { get; set; }
    }
}
