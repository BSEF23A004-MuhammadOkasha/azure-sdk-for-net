// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class KeyVaultAccessPolicy : IUtf8JsonSerializable, IModelJsonSerializable<KeyVaultAccessPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        private void Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tenantId"u8);
            writer.WriteStringValue(TenantId);
            writer.WritePropertyName("objectId"u8);
            writer.WriteStringValue(ObjectId);
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId.Value);
            }
            writer.WritePropertyName("permissions"u8);
            writer.WriteObjectValue(Permissions);
            writer.WriteEndObject();
        }

        internal static KeyVaultAccessPolicy DeserializeKeyVaultAccessPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid tenantId = default;
            string objectId = default;
            Optional<Guid> applicationId = default;
            IdentityAccessPermissions permissions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("permissions"u8))
                {
                    permissions = IdentityAccessPermissions.DeserializeIdentityAccessPermissions(property.Value);
                    continue;
                }
            }
            return new KeyVaultAccessPolicy(tenantId, objectId, Optional.ToNullable(applicationId), permissions);
        }

        void IModelJsonSerializable<KeyVaultAccessPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => Serialize(writer, options);

        KeyVaultAccessPolicy IModelJsonSerializable<KeyVaultAccessPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultAccessPolicy(document.RootElement, options);
        }

        BinaryData IModelSerializable<KeyVaultAccessPolicy>.Serialize(ModelSerializerOptions options) => (options.Format.ToString()) switch
        {
            "J" or "W" => ModelSerializer.SerializeCore(this, options),
            "bicep" => SerializeBicep(options),
            _ => throw new FormatException($"Unsupported format {options.Format}")
        };

        KeyVaultAccessPolicy IModelSerializable<KeyVaultAccessPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeKeyVaultAccessPolicy(document.RootElement, options);
        }

        private BinaryData SerializeBicep(ModelSerializerOptions options)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{{");
            sb.AppendLine($"  objectId: '{ObjectId}'");
            sb.Append($"  permissions: ");
            sb.AppendChildObject(Permissions, options);
            sb.AppendLine($"  tenantId: '{TenantId}'");
            sb.AppendLine($"}}");
            return BinaryData.FromString(sb.ToString());
        }
    }
}
