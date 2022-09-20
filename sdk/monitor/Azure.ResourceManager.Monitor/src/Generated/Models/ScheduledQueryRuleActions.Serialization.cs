// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ScheduledQueryRuleActions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ActionGroups))
            {
                writer.WritePropertyName("actionGroups");
                writer.WriteStartArray();
                foreach (var item in ActionGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomProperties))
            {
                writer.WritePropertyName("customProperties");
                writer.WriteStartObject();
                foreach (var item in CustomProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ScheduledQueryRuleActions DeserializeScheduledQueryRuleActions(JsonElement element)
        {
            Optional<IList<string>> actionGroups = default;
            Optional<IDictionary<string, string>> customProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionGroups"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    actionGroups = array;
                    continue;
                }
                if (property.NameEquals("customProperties"))
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
                    customProperties = dictionary;
                    continue;
                }
            }
            return new ScheduledQueryRuleActions(Optional.ToList(actionGroups), Optional.ToDictionary(customProperties));
        }
    }
}
