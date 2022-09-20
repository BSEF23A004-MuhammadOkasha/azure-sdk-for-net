// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class EntityQueryItemProperties
    {
        internal static EntityQueryItemProperties DeserializeEntityQueryItemProperties(JsonElement element)
        {
            Optional<IReadOnlyList<EntityQueryItemPropertiesDataTypesItem>> dataTypes = default;
            Optional<EntityType> inputEntityType = default;
            Optional<IReadOnlyList<IList<string>>> requiredInputFieldsSets = default;
            Optional<BinaryData> entitiesFilter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EntityQueryItemPropertiesDataTypesItem> array = new List<EntityQueryItemPropertiesDataTypesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityQueryItemPropertiesDataTypesItem.DeserializeEntityQueryItemPropertiesDataTypesItem(item));
                    }
                    dataTypes = array;
                    continue;
                }
                if (property.NameEquals("inputEntityType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    inputEntityType = new EntityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requiredInputFieldsSets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IList<string>> array = new List<IList<string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<string> array0 = new List<string>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(item0.GetString());
                        }
                        array.Add(array0);
                    }
                    requiredInputFieldsSets = array;
                    continue;
                }
                if (property.NameEquals("entitiesFilter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    entitiesFilter = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new EntityQueryItemProperties(Optional.ToList(dataTypes), Optional.ToNullable(inputEntityType), Optional.ToList(requiredInputFieldsSets), entitiesFilter.Value);
        }
    }
}
