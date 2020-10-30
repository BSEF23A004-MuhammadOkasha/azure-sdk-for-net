// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class BootDiagnostics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(StorageUri))
            {
                writer.WritePropertyName("storageUri");
                writer.WriteStringValue(StorageUri);
            }
            writer.WriteEndObject();
        }

        internal static BootDiagnostics DeserializeBootDiagnostics(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<string> storageUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("storageUri"))
                {
                    storageUri = property.Value.GetString();
                    continue;
                }
            }
            return new BootDiagnostics(Optional.ToNullable(enabled), storageUri.Value);
        }
    }
}
