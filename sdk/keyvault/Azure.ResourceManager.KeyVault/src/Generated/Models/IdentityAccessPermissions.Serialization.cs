// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class IdentityAccessPermissions : IUtf8JsonSerializable, IModelJsonSerializable<IdentityAccessPermissions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        private void Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Keys))
            {
                writer.WritePropertyName("keys"u8);
                writer.WriteStartArray();
                foreach (var item in Keys)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Storage))
            {
                writer.WritePropertyName("storage"u8);
                writer.WriteStartArray();
                foreach (var item in Storage)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IdentityAccessPermissions DeserializeIdentityAccessPermissions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<IdentityAccessKeyPermission>> keys = default;
            Optional<IList<IdentityAccessSecretPermission>> secrets = default;
            Optional<IList<IdentityAccessCertificatePermission>> certificates = default;
            Optional<IList<IdentityAccessStoragePermission>> storage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessKeyPermission> array = new List<IdentityAccessKeyPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessKeyPermission(item.GetString()));
                    }
                    keys = array;
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessSecretPermission> array = new List<IdentityAccessSecretPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessSecretPermission(item.GetString()));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("certificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessCertificatePermission> array = new List<IdentityAccessCertificatePermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessCertificatePermission(item.GetString()));
                    }
                    certificates = array;
                    continue;
                }
                if (property.NameEquals("storage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessStoragePermission> array = new List<IdentityAccessStoragePermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessStoragePermission(item.GetString()));
                    }
                    storage = array;
                    continue;
                }
            }
            return new IdentityAccessPermissions(Optional.ToList(keys), Optional.ToList(secrets), Optional.ToList(certificates), Optional.ToList(storage));
        }

        void IModelJsonSerializable<IdentityAccessPermissions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => Serialize(writer, options);

        IdentityAccessPermissions IModelJsonSerializable<IdentityAccessPermissions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return DeserializeIdentityAccessPermissions(document.RootElement, options);
        }

        BinaryData IModelSerializable<IdentityAccessPermissions>.Serialize(ModelSerializerOptions options) => (options.Format.ToString()) switch
        {
            "J" or "W" => ModelSerializer.SerializeCore(this, options),
            "bicep" => SerializeBicep(options),
            _ => throw new FormatException($"Unsupported format {options.Format}")
        };

        IdentityAccessPermissions IModelSerializable<IdentityAccessPermissions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeIdentityAccessPermissions(document.RootElement, options);
        }

        private BinaryData SerializeBicep(ModelSerializerOptions options)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{{");
            sb.AppendLine($"  secrets: [");
            foreach (var item in Secrets)
            {
                sb.AppendLine($"    '{item}'");
            }
            sb.AppendLine($"  ]");
            sb.AppendLine($"}}");
            return BinaryData.FromString(sb.ToString());
        }
    }
}
