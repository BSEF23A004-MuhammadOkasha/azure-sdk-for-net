// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class SkuSetting
    {
        internal static SkuSetting DeserializeSkuSetting(JsonElement element)
        {
            string name = default;
            Optional<MachineLearningServicesSkuTier> tier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tier = property.Value.GetString().ToMachineLearningServicesSkuTier();
                    continue;
                }
            }
            return new SkuSetting(name, Optional.ToNullable(tier));
        }
    }
}
