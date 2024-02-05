// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterSecurityProfileKeyVaultKms : IUtf8JsonSerializable, IJsonModel<ManagedClusterSecurityProfileKeyVaultKms>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterSecurityProfileKeyVaultKms>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterSecurityProfileKeyVaultKms>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileKeyVaultKms>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileKeyVaultKms)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId);
            }
            if (Optional.IsDefined(KeyVaultNetworkAccess))
            {
                writer.WritePropertyName("keyVaultNetworkAccess"u8);
                writer.WriteStringValue(KeyVaultNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultResourceId))
            {
                writer.WritePropertyName("keyVaultResourceId"u8);
                writer.WriteStringValue(KeyVaultResourceId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ManagedClusterSecurityProfileKeyVaultKms IJsonModel<ManagedClusterSecurityProfileKeyVaultKms>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileKeyVaultKms>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileKeyVaultKms)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterSecurityProfileKeyVaultKms(document.RootElement, options);
        }

        internal static ManagedClusterSecurityProfileKeyVaultKms DeserializeManagedClusterSecurityProfileKeyVaultKms(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> keyId = default;
            Optional<ManagedClusterKeyVaultNetworkAccessType> keyVaultNetworkAccess = default;
            Optional<ResourceIdentifier> keyVaultResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keyId"u8))
                {
                    keyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultNetworkAccess = new ManagedClusterKeyVaultNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterSecurityProfileKeyVaultKms(Optional.ToNullable(enabled), keyId.Value, Optional.ToNullable(keyVaultNetworkAccess), keyVaultResourceId.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(IsEnabled))
            {
                builder.Append("  enabled:");
                var boolValue = IsEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(KeyId))
            {
                builder.Append("  keyId:");
                builder.AppendLine($" '{KeyId}'");
            }

            if (Optional.IsDefined(KeyVaultNetworkAccess))
            {
                builder.Append("  keyVaultNetworkAccess:");
                builder.AppendLine($" '{KeyVaultNetworkAccess.ToString()}'");
            }

            if (Optional.IsDefined(KeyVaultResourceId))
            {
                builder.Append("  keyVaultResourceId:");
                builder.AppendLine($" '{KeyVaultResourceId.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ManagedClusterSecurityProfileKeyVaultKms>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileKeyVaultKms>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileKeyVaultKms)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterSecurityProfileKeyVaultKms IPersistableModel<ManagedClusterSecurityProfileKeyVaultKms>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileKeyVaultKms>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterSecurityProfileKeyVaultKms(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileKeyVaultKms)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterSecurityProfileKeyVaultKms>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
