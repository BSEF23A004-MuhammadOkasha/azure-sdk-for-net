// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class DeletedAccountData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DeletedAccountData DeserializeDeletedAccountData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> storageAccountResourceId = default;
            Optional<string> location = default;
            Optional<string> restoreReference = default;
            Optional<string> creationTime = default;
            Optional<string> deletionTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
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
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageAccountResourceId"))
                        {
                            storageAccountResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("location"))
                        {
                            location = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("restoreReference"))
                        {
                            restoreReference = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            creationTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deletionTime"))
                        {
                            deletionTime = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DeletedAccountData(id, name, type, systemData, storageAccountResourceId.Value, location.Value, restoreReference.Value, creationTime.Value, deletionTime.Value);
        }
    }
}
