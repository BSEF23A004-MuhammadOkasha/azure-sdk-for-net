// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Blob info from a Filter Blobs API call. </summary>
    internal partial class FilterBlobItem
    {
        /// <summary> Initializes a new instance of FilterBlobItem. </summary>
        /// <param name="name"></param>
        /// <param name="containerName"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="containerName"/> is null. </exception>
        internal FilterBlobItem(string name, string containerName)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            Name = name;
            ContainerName = containerName;
        }

        /// <summary> Initializes a new instance of FilterBlobItem. </summary>
        /// <param name="name"></param>
        /// <param name="containerName"></param>
        /// <param name="tags"> Blob tags. </param>
        /// <param name="versionId"></param>
        /// <param name="isCurrentVersion"></param>
        internal FilterBlobItem(string name, string containerName, BlobTags tags, string versionId, bool? isCurrentVersion)
        {
            Name = name;
            ContainerName = containerName;
            Tags = tags;
            VersionId = versionId;
            IsCurrentVersion = isCurrentVersion;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the container name. </summary>
        public string ContainerName { get; }
        /// <summary> Blob tags. </summary>
        public BlobTags Tags { get; }
        /// <summary> Gets the version id. </summary>
        public string VersionId { get; }
        /// <summary> Gets the is current version. </summary>
        public bool? IsCurrentVersion { get; }
    }
}
