// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automanage;

namespace Azure.ResourceManager.Automanage.Models
{
    internal partial class ConfigurationProfileAssignmentList
    {
        internal static ConfigurationProfileAssignmentList DeserializeConfigurationProfileAssignmentList(JsonElement element)
        {
            Optional<IReadOnlyList<ConfigurationProfileAssignmentData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConfigurationProfileAssignmentData> array = new List<ConfigurationProfileAssignmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConfigurationProfileAssignmentData.DeserializeConfigurationProfileAssignmentData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ConfigurationProfileAssignmentList(Optional.ToList(value));
        }
    }
}
