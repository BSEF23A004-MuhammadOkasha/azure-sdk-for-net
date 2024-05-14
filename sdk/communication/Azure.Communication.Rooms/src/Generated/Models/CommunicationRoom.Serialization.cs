// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Rooms
{
    public partial class CommunicationRoom
    {
        internal static CommunicationRoom DeserializeCommunicationRoom(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            DateTimeOffset createdAt = default;
            DateTimeOffset validFrom = default;
            DateTimeOffset validUntil = default;
            bool pstnDialOutEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("validFrom"u8))
                {
                    validFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("validUntil"u8))
                {
                    validUntil = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("pstnDialOutEnabled"u8))
                {
                    pstnDialOutEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new CommunicationRoom(id, createdAt, validFrom, validUntil, pstnDialOutEnabled);
        }
    }
}
