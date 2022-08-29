// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs
{
    public partial class NotificationHubAuthorizationRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
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
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Rights))
            {
                writer.WritePropertyName("rights");
                writer.WriteStartArray();
                foreach (var item in Rights)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NotificationHubAuthorizationRuleData DeserializeNotificationHubAuthorizationRuleData(JsonElement element)
        {
            Optional<NotificationHubSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<AuthorizationRuleAccessRight>> rights = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<string> keyName = default;
            Optional<string> claimType = default;
            Optional<string> claimValue = default;
            Optional<DateTimeOffset> modifiedTime = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<int> revision = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = NotificationHubSku.DeserializeNotificationHubSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("rights"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AuthorizationRuleAccessRight> array = new List<AuthorizationRuleAccessRight>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString().ToAuthorizationRuleAccessRight());
                            }
                            rights = array;
                            continue;
                        }
                        if (property0.NameEquals("primaryKey"))
                        {
                            primaryKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryKey"))
                        {
                            secondaryKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyName"))
                        {
                            keyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("claimType"))
                        {
                            claimType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("claimValue"))
                        {
                            claimValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("modifiedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            modifiedTime = property0.Value.GetDateTimeOffset();
                            continue;
                        }
                        if (property0.NameEquals("createdTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset();
                            continue;
                        }
                        if (property0.NameEquals("revision"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            revision = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NotificationHubAuthorizationRuleData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToList(rights), primaryKey.Value, secondaryKey.Value, keyName.Value, claimType.Value, claimValue.Value, Optional.ToNullable(modifiedTime), Optional.ToNullable(createdTime), Optional.ToNullable(revision), sku.Value);
        }
    }
}
