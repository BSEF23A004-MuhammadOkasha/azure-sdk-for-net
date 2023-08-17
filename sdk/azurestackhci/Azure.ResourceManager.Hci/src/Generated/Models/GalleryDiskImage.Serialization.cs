// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    internal partial class GalleryDiskImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static GalleryDiskImage DeserializeGalleryDiskImage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> sizeInMB = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeInMB = property.Value.GetInt64();
                    continue;
                }
            }
            return new GalleryDiskImage(Optional.ToNullable(sizeInMB));
        }
    }
}
