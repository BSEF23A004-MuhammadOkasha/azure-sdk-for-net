// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    internal partial class BlobItemInternal
    {
        internal static BlobItemInternal DeserializeBlobItemInternal(XElement element)
        {
            BlobName name = default;
            bool deleted = default;
            string snapshot = default;
            string versionId = default;
            bool? isCurrentVersion = default;
            BlobPropertiesInternal properties = default;
            IReadOnlyDictionary<string, string> metadata = default;
            BlobTags blobTags = default;
            IReadOnlyDictionary<string, string> objectReplicationMetadata = default;
            bool? hasVersionsOnly = default;
            if (element.Element("Name") is XElement nameElement)
            {
                name = BlobName.DeserializeBlobName(nameElement);
            }
            if (element.Element("Deleted") is XElement deletedElement)
            {
                deleted = (bool)deletedElement;
            }
            if (element.Element("Snapshot") is XElement snapshotElement)
            {
                snapshot = (string)snapshotElement;
            }
            if (element.Element("VersionId") is XElement versionIdElement)
            {
                versionId = (string)versionIdElement;
            }
            if (element.Element("IsCurrentVersion") is XElement isCurrentVersionElement)
            {
                isCurrentVersion = (bool?)isCurrentVersionElement;
            }
            if (element.Element("Properties") is XElement propertiesElement)
            {
                properties = BlobPropertiesInternal.DeserializeBlobPropertiesInternal(propertiesElement);
            }
            if (element.Element("Metadata") is XElement metadataElement)
            {
                var dictionary = new Dictionary<string, string>();
                foreach (var e in metadataElement.Elements())
                {
                    dictionary.Add(e.Name.LocalName, (string)e);
                }
                metadata = dictionary;
            }
            if (element.Element("Tags") is XElement tagsElement)
            {
                blobTags = BlobTags.DeserializeBlobTags(tagsElement);
            }
            if (element.Element("ObjectReplicationMetadata") is XElement objectReplicationMetadataElement)
            {
                var dictionary = new Dictionary<string, string>();
                foreach (var e in objectReplicationMetadataElement.Elements())
                {
                    dictionary.Add(e.Name.LocalName, (string)e);
                }
                objectReplicationMetadata = dictionary;
            }
            if (element.Element("HasVersionsOnly") is XElement hasVersionsOnlyElement)
            {
                hasVersionsOnly = (bool?)hasVersionsOnlyElement;
            }
            return new BlobItemInternal(name, deleted, snapshot, versionId, isCurrentVersion, properties, metadata, blobTags, objectReplicationMetadata, hasVersionsOnly);
        }
    }
}
