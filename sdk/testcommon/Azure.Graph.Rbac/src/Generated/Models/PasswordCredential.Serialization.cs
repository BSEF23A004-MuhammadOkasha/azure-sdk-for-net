// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class PasswordCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StartDate))
            {
                writer.WritePropertyName("startDate");
                writer.WriteStringValue(StartDate.Value, "O");
            }
            if (Optional.IsDefined(EndDate))
            {
                writer.WritePropertyName("endDate");
                writer.WriteStringValue(EndDate.Value, "O");
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId");
                writer.WriteStringValue(KeyId);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(CustomKeyIdentifier))
            {
                writer.WritePropertyName("customKeyIdentifier");
                writer.WriteBase64StringValue(CustomKeyIdentifier);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static PasswordCredential DeserializePasswordCredential(JsonElement element)
        {
            Optional<DateTimeOffset> startDate = default;
            Optional<DateTimeOffset> endDate = default;
            Optional<string> keyId = default;
            Optional<string> value = default;
            Optional<byte[]> customKeyIdentifier = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startDate"))
                {
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDate"))
                {
                    endDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("keyId"))
                {
                    keyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customKeyIdentifier"))
                {
                    customKeyIdentifier = property.Value.GetBytesFromBase64();
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PasswordCredential(Optional.ToNullable(startDate), Optional.ToNullable(endDate), keyId.Value, value.Value, customKeyIdentifier.Value, additionalProperties);
        }
    }
}
