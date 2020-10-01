// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class CreationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("createOption");
            writer.WriteStringValue(CreateOption.ToString());
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId");
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(ImageReference))
            {
                writer.WritePropertyName("imageReference");
                writer.WriteObjectValue(ImageReference);
            }
            if (Optional.IsDefined(GalleryImageReference))
            {
                writer.WritePropertyName("galleryImageReference");
                writer.WriteObjectValue(GalleryImageReference);
            }
            if (Optional.IsDefined(SourceUri))
            {
                writer.WritePropertyName("sourceUri");
                writer.WriteStringValue(SourceUri);
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId");
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(UploadSizeBytes))
            {
                writer.WritePropertyName("uploadSizeBytes");
                writer.WriteNumberValue(UploadSizeBytes.Value);
            }
            writer.WriteEndObject();
        }

        internal static CreationData DeserializeCreationData(JsonElement element)
        {
            DiskCreateOption createOption = default;
            Optional<string> storageAccountId = default;
            Optional<ImageDiskReference> imageReference = default;
            Optional<ImageDiskReference> galleryImageReference = default;
            Optional<string> sourceUri = default;
            Optional<string> sourceResourceId = default;
            Optional<string> sourceUniqueId = default;
            Optional<long> uploadSizeBytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createOption"))
                {
                    createOption = new DiskCreateOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"))
                {
                    storageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageReference"))
                {
                    imageReference = ImageDiskReference.DeserializeImageDiskReference(property.Value);
                    continue;
                }
                if (property.NameEquals("galleryImageReference"))
                {
                    galleryImageReference = ImageDiskReference.DeserializeImageDiskReference(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceUri"))
                {
                    sourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceResourceId"))
                {
                    sourceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceUniqueId"))
                {
                    sourceUniqueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadSizeBytes"))
                {
                    uploadSizeBytes = property.Value.GetInt64();
                    continue;
                }
            }
            return new CreationData(createOption, storageAccountId.Value, imageReference.Value, galleryImageReference.Value, sourceUri.Value, sourceResourceId.Value, sourceUniqueId.Value, Optional.ToNullable(uploadSizeBytes));
        }
    }
}
