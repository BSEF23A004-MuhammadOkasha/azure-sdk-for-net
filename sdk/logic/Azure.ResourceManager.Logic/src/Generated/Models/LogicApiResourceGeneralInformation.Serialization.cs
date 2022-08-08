// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiResourceGeneralInformation
    {
        internal static LogicApiResourceGeneralInformation DeserializeLogicApiResourceGeneralInformation(JsonElement element)
        {
            Optional<Uri> iconUrl = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<Uri> termsOfUseUrl = default;
            Optional<string> releaseTag = default;
            Optional<LogicApiTier> tier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("iconUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        iconUrl = null;
                        continue;
                    }
                    iconUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termsOfUseUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        termsOfUseUrl = null;
                        continue;
                    }
                    termsOfUseUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("releaseTag"))
                {
                    releaseTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tier = new LogicApiTier(property.Value.GetString());
                    continue;
                }
            }
            return new LogicApiResourceGeneralInformation(iconUrl.Value, displayName.Value, description.Value, termsOfUseUrl.Value, releaseTag.Value, Optional.ToNullable(tier));
        }
    }
}
