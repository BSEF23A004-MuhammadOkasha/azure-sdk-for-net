// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> Target resource. </summary>
    public partial class TargetResource : SubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of TargetResource. </summary>
        internal TargetResource()
        {
        }

        /// <summary> Initializes a new instance of TargetResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        internal TargetResource(string id, string resourceName, string resourceType) : base(id)
        {
            ResourceName = resourceName;
            ResourceType = resourceType;
        }

        /// <summary> The name of the resource. </summary>
        public string ResourceName { get; }
        /// <summary> The type of the resource. </summary>
        public string ResourceType { get; }
    }
}
