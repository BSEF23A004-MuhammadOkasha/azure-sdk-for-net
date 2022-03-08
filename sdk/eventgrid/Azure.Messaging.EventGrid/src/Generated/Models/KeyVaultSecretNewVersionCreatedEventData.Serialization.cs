// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(KeyVaultSecretNewVersionCreatedEventDataConverter))]
    public partial class KeyVaultSecretNewVersionCreatedEventData
    {
        internal static KeyVaultSecretNewVersionCreatedEventData DeserializeKeyVaultSecretNewVersionCreatedEventData(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> vaultName = default;
            Optional<string> objectType = default;
            Optional<string> objectName = default;
            Optional<string> version = default;
            Optional<float> nbf = default;
            Optional<float> exp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("VaultName"))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectName"))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NBF"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nbf = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("EXP"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    exp = property.Value.GetSingle();
                    continue;
                }
            }
            return new KeyVaultSecretNewVersionCreatedEventData(id.Value, vaultName.Value, objectType.Value, objectName.Value, version.Value, Optional.ToNullable(nbf), Optional.ToNullable(exp));
        }

        internal partial class KeyVaultSecretNewVersionCreatedEventDataConverter : JsonConverter<KeyVaultSecretNewVersionCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, KeyVaultSecretNewVersionCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override KeyVaultSecretNewVersionCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeKeyVaultSecretNewVersionCreatedEventData(document.RootElement);
            }
        }
    }
}
