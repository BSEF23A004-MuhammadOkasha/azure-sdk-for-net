// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    public partial class IotCentralAppTemplate
    {
        internal static IotCentralAppTemplate DeserializeIotCentralAppTemplate(JsonElement element)
        {
            Optional<string> manifestId = default;
            Optional<string> manifestVersion = default;
            Optional<string> name = default;
            Optional<string> title = default;
            Optional<int> order = default;
            Optional<string> description = default;
            Optional<string> industry = default;
            Optional<IReadOnlyList<IotCentralAppTemplateLocation>> locations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("manifestId"))
                {
                    manifestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifestVersion"))
                {
                    manifestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("industry"))
                {
                    industry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IotCentralAppTemplateLocation> array = new List<IotCentralAppTemplateLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotCentralAppTemplateLocation.DeserializeIotCentralAppTemplateLocation(item));
                    }
                    locations = array;
                    continue;
                }
            }
            return new IotCentralAppTemplate(manifestId.Value, manifestVersion.Value, name.Value, title.Value, Optional.ToNullable(order), description.Value, industry.Value, Optional.ToList(locations));
        }
    }
}
