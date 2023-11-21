// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Manifest attributes details. </summary>
    public partial class ArtifactManifestProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ArtifactManifestProperties"/>. </summary>
        /// <param name="digest"> Manifest. </param>
        /// <param name="createdOn"> Created time. </param>
        /// <param name="lastUpdatedOn"> Last update time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="digest"/> is null. </exception>
        internal ArtifactManifestProperties(string digest, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn)
        {
            Argument.AssertNotNull(digest, nameof(digest));

            Digest = digest;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            RelatedArtifacts = new ChangeTrackingList<ArtifactManifestPlatform>();
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ArtifactManifestProperties"/>. </summary>
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
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArtifactManifestProperties(string registryLoginServer, string repositoryName, string digest, long? sizeInBytes, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, ArtifactArchitecture? architecture, ArtifactOperatingSystem? operatingSystem, IReadOnlyList<ArtifactManifestPlatform> relatedArtifacts, IReadOnlyList<string> tags, bool? canDelete, bool? canWrite, bool? canList, bool? canRead, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RegistryLoginServer = registryLoginServer;
            RepositoryName = repositoryName;
            Digest = digest;
            SizeInBytes = sizeInBytes;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Architecture = architecture;
            OperatingSystem = operatingSystem;
            RelatedArtifacts = relatedArtifacts;
            Tags = tags;
            CanDelete = canDelete;
            CanWrite = canWrite;
            CanList = canList;
            CanRead = canRead;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </summary>
        public string RegistryLoginServer { get; }
        /// <summary> Repository name. </summary>
        public string RepositoryName { get; }
        /// <summary> Manifest. </summary>
        public string Digest { get; }
        /// <summary> Created time. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Last update time. </summary>
        public DateTimeOffset LastUpdatedOn { get; }
        /// <summary> CPU architecture. </summary>
        public ArtifactArchitecture? Architecture { get; }
        /// <summary> Operating system. </summary>
        public ArtifactOperatingSystem? OperatingSystem { get; }
        /// <summary> List of artifacts that are referenced by this manifest list, with information about the platform each supports.  This list will be empty if this is a leaf manifest and not a manifest list. </summary>
        public IReadOnlyList<ArtifactManifestPlatform> RelatedArtifacts { get; }
        /// <summary> List of tags. </summary>
        public IReadOnlyList<string> Tags { get; }
    }
}
