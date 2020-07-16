// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class GalleryApplicationVersion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PublishingProfile))
            {
                writer.WritePropertyName("publishingProfile");
                writer.WriteObjectValue(PublishingProfile);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static GalleryApplicationVersion DeserializeGalleryApplicationVersion(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<GalleryApplicationVersionPublishingProfile> publishingProfile = default;
            Optional<GalleryApplicationVersionPropertiesProvisioningState> provisioningState = default;
            Optional<ReplicationStatus> replicationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("publishingProfile"))
                        {
                            publishingProfile = GalleryApplicationVersionPublishingProfile.DeserializeGalleryApplicationVersionPublishingProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new GalleryApplicationVersionPropertiesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("replicationStatus"))
                        {
                            replicationStatus = ReplicationStatus.DeserializeReplicationStatus(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new GalleryApplicationVersion(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), publishingProfile.Value, Optional.ToNullable(provisioningState), replicationStatus.Value);
        }
    }
}
