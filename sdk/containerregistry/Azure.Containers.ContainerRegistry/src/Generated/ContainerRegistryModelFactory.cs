// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Model factory for models. </summary>
    public static partial class ContainerRegistryModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistry.ContainerRepositoryProperties"/>. </summary>
        /// <param name="registryLoginServer"> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </param>
        /// <param name="name"> Image name. </param>
        /// <param name="createdOn"> Image created time. </param>
        /// <param name="lastUpdatedOn"> Image last update time. </param>
        /// <param name="manifestCount"> Number of the manifests. </param>
        /// <param name="tagCount"> Number of the tags. </param>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        /// <returns> A new <see cref="ContainerRegistry.ContainerRepositoryProperties"/> instance for mocking. </returns>
        public static ContainerRepositoryProperties ContainerRepositoryProperties(string registryLoginServer = null, string name = null, DateTimeOffset createdOn = default, DateTimeOffset lastUpdatedOn = default, int manifestCount = default, int tagCount = default, bool? canDelete = null, bool? canWrite = null, bool? canList = null, bool? canRead = null)
        {
            return new ContainerRepositoryProperties(registryLoginServer, name, createdOn, lastUpdatedOn, manifestCount, tagCount, canDelete, canWrite, canList, canRead);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistry.ArtifactTagProperties"/>. </summary>
        /// <param name="registryLoginServer"> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </param>
        /// <param name="repositoryName"> Image name. </param>
        /// <param name="name"> Tag name. </param>
        /// <param name="digest"> Tag digest. </param>
        /// <param name="createdOn"> Tag created time. </param>
        /// <param name="lastUpdatedOn"> Tag last update time. </param>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        /// <returns> A new <see cref="ContainerRegistry.ArtifactTagProperties"/> instance for mocking. </returns>
        public static ArtifactTagProperties ArtifactTagProperties(string registryLoginServer = null, string repositoryName = null, string name = null, string digest = null, DateTimeOffset createdOn = default, DateTimeOffset lastUpdatedOn = default, bool? canDelete = null, bool? canWrite = null, bool? canList = null, bool? canRead = null)
        {
            return new ArtifactTagProperties(registryLoginServer, repositoryName, name, digest, createdOn, lastUpdatedOn, canDelete, canWrite, canList, canRead);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistry.ArtifactManifestPlatform"/>. </summary>
        /// <param name="digest"> Manifest digest. </param>
        /// <param name="architecture"> CPU architecture. </param>
        /// <param name="operatingSystem"> Operating system. </param>
        /// <returns> A new <see cref="ContainerRegistry.ArtifactManifestPlatform"/> instance for mocking. </returns>
        public static ArtifactManifestPlatform ArtifactManifestPlatform(string digest = null, ArtifactArchitecture? architecture = null, ArtifactOperatingSystem? operatingSystem = null)
        {
            return new ArtifactManifestPlatform(digest, architecture, operatingSystem);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistry.ArtifactManifestProperties"/>. </summary>
        /// <param name="registryLoginServer"> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="digest"> Manifest. </param>
        /// <param name="sizeInBytes"> Image size. </param>
        /// <param name="createdOn"> Created time. </param>
        /// <param name="lastUpdatedOn"> Last update time. </param>
        /// <param name="architecture"> CPU architecture. </param>
        /// <param name="operatingSystem"> Operating system. </param>
        /// <param name="relatedArtifacts"> List of artifacts that are referenced by this manifest list, with information about the platform each supports.  This list will be empty if this is a leaf manifest and not a manifest list. </param>
        /// <param name="tags"> List of tags. </param>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        /// <returns> A new <see cref="ContainerRegistry.ArtifactManifestProperties"/> instance for mocking. </returns>
        public static ArtifactManifestProperties ArtifactManifestProperties(string registryLoginServer = null, string repositoryName = null, string digest = null, long? sizeInBytes = null, DateTimeOffset createdOn = default, DateTimeOffset lastUpdatedOn = default, ArtifactArchitecture? architecture = null, ArtifactOperatingSystem? operatingSystem = null, IEnumerable<ArtifactManifestPlatform> relatedArtifacts = null, IEnumerable<string> tags = null, bool? canDelete = null, bool? canWrite = null, bool? canList = null, bool? canRead = null)
        {
            relatedArtifacts ??= new List<ArtifactManifestPlatform>();
            tags ??= new List<string>();

            return new ArtifactManifestProperties(registryLoginServer, repositoryName, digest, sizeInBytes, createdOn, lastUpdatedOn, architecture, operatingSystem, relatedArtifacts?.ToList(), tags?.ToList(), canDelete, canWrite, canList, canRead);
        }
    }
}
