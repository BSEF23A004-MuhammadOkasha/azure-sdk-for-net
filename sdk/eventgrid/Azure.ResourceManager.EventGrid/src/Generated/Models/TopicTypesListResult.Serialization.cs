// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class TopicTypesListResult
    {
        internal static TopicTypesListResult DeserializeTopicTypesListResult(JsonElement element)
        {
            Optional<IReadOnlyList<TopicTypeInfoData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TopicTypeInfoData> array = new List<TopicTypeInfoData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopicTypeInfoData.DeserializeTopicTypeInfoData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new TopicTypesListResult(Optional.ToList(value));
        }
    }
}
