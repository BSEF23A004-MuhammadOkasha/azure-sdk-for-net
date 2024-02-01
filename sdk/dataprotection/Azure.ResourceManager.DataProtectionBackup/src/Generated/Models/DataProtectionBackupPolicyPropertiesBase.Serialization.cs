// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    [PersistableModelProxy(typeof(UnknownBaseBackupPolicy))]
    public partial class DataProtectionBackupPolicyPropertiesBase : IUtf8JsonSerializable, IJsonModel<DataProtectionBackupPolicyPropertiesBase>, IPersistableModel<DataProtectionBackupPolicyPropertiesBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProtectionBackupPolicyPropertiesBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataProtectionBackupPolicyPropertiesBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupPolicyPropertiesBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupPolicyPropertiesBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("datasourceTypes"u8);
            writer.WriteStartArray();
            foreach (var item in DataSourceTypes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        DataProtectionBackupPolicyPropertiesBase IJsonModel<DataProtectionBackupPolicyPropertiesBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupPolicyPropertiesBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupPolicyPropertiesBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupPolicyPropertiesBase(document.RootElement, options);
        }

        internal static DataProtectionBackupPolicyPropertiesBase DeserializeDataProtectionBackupPolicyPropertiesBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "BackupPolicy": return RuleBasedBackupPolicy.DeserializeRuleBasedBackupPolicy(element);
                }
            }
            return UnknownBaseBackupPolicy.DeserializeUnknownBaseBackupPolicy(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(DataSourceTypes))
            {
                builder.Append("  datasourceTypes:");
                builder.AppendLine(" [");
                foreach (var item in DataSourceTypes)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(ObjectType))
            {
                builder.Append("  objectType:");
                builder.AppendLine($" '{ObjectType}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<DataProtectionBackupPolicyPropertiesBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupPolicyPropertiesBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupPolicyPropertiesBase)} does not support '{options.Format}' format.");
            }
        }

        DataProtectionBackupPolicyPropertiesBase IPersistableModel<DataProtectionBackupPolicyPropertiesBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupPolicyPropertiesBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProtectionBackupPolicyPropertiesBase(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupPolicyPropertiesBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProtectionBackupPolicyPropertiesBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
