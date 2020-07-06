// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Models
{
    public partial class DeletedSasDefinitionBundle
    {
        internal static DeletedSasDefinitionBundle DeserializeDeletedSasDefinitionBundle(JsonElement element)
        {
            string recoveryId = default;
            DateTimeOffset? scheduledPurgeDate = default;
            DateTimeOffset? deletedDate = default;
            string id = default;
            string sid = default;
            string templateUri = default;
            SasTokenType? sasType = default;
            string validityPeriod = default;
            SasDefinitionAttributes attributes = default;
            IReadOnlyDictionary<string, string> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scheduledPurgeDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledPurgeDate = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("deletedDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletedDate = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("templateUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sasType = new SasTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("validityPeriod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validityPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributes = SasDefinitionAttributes.DeserializeSasDefinitionAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new DeletedSasDefinitionBundle(id, sid, templateUri, sasType, validityPeriod, attributes, tags, recoveryId, scheduledPurgeDate, deletedDate);
        }
    }
}
