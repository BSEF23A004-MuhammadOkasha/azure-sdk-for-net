// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHub.Models
{
    public partial class AccessKeys
    {
        internal static AccessKeys DeserializeAccessKeys(JsonElement element)
        {
            Optional<string> primaryConnectionString = default;
            Optional<string> secondaryConnectionString = default;
            Optional<string> aliasPrimaryConnectionString = default;
            Optional<string> aliasSecondaryConnectionString = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<string> keyName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryConnectionString"))
                {
                    primaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryConnectionString"))
                {
                    secondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliasPrimaryConnectionString"))
                {
                    aliasPrimaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliasSecondaryConnectionString"))
                {
                    aliasSecondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyName"))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
            }
            return new AccessKeys(primaryConnectionString.Value, secondaryConnectionString.Value, aliasPrimaryConnectionString.Value, aliasSecondaryConnectionString.Value, primaryKey.Value, secondaryKey.Value, keyName.Value);
        }
    }
}
