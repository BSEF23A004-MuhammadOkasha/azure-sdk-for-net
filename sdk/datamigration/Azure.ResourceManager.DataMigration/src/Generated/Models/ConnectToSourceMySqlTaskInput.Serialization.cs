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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToSourceMySqlTaskInput : IUtf8JsonSerializable, IJsonModel<ConnectToSourceMySqlTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToSourceMySqlTaskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectToSourceMySqlTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceMySqlTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceMySqlTaskInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo"u8);
            writer.WriteObjectValue(SourceConnectionInfo);
            if (Optional.IsDefined(TargetPlatform))
            {
                writer.WritePropertyName("targetPlatform"u8);
                writer.WriteStringValue(TargetPlatform.Value.ToString());
            }
            if (Optional.IsDefined(CheckPermissionsGroup))
            {
                writer.WritePropertyName("checkPermissionsGroup"u8);
                writer.WriteStringValue(CheckPermissionsGroup.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsOfflineMigration))
            {
                writer.WritePropertyName("isOfflineMigration"u8);
                writer.WriteBooleanValue(IsOfflineMigration.Value);
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

        ConnectToSourceMySqlTaskInput IJsonModel<ConnectToSourceMySqlTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceMySqlTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceMySqlTaskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourceMySqlTaskInput(document.RootElement, options);
        }

        internal static ConnectToSourceMySqlTaskInput DeserializeConnectToSourceMySqlTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MySqlConnectionInfo sourceConnectionInfo = default;
            Optional<MySqlTargetPlatformType> targetPlatform = default;
            Optional<ServerLevelPermissionsGroup> checkPermissionsGroup = default;
            Optional<bool> isOfflineMigration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetPlatform"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetPlatform = new MySqlTargetPlatformType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("checkPermissionsGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    checkPermissionsGroup = property.Value.GetString().ToServerLevelPermissionsGroup();
                    continue;
                }
                if (property.NameEquals("isOfflineMigration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOfflineMigration = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectToSourceMySqlTaskInput(sourceConnectionInfo, Optional.ToNullable(targetPlatform), Optional.ToNullable(checkPermissionsGroup), Optional.ToNullable(isOfflineMigration), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SourceConnectionInfo))
            {
                builder.Append("  sourceConnectionInfo:");
                AppendChildObject(builder, SourceConnectionInfo, options, 2, false);
            }

            if (Optional.IsDefined(TargetPlatform))
            {
                builder.Append("  targetPlatform:");
                builder.AppendLine($" '{TargetPlatform.ToString()}'");
            }

            if (Optional.IsDefined(CheckPermissionsGroup))
            {
                builder.Append("  checkPermissionsGroup:");
                builder.AppendLine($" '{CheckPermissionsGroup.ToString()}'");
            }

            if (Optional.IsDefined(IsOfflineMigration))
            {
                builder.Append("  isOfflineMigration:");
                var boolValue = IsOfflineMigration.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
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

        BinaryData IPersistableModel<ConnectToSourceMySqlTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceMySqlTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceMySqlTaskInput)} does not support '{options.Format}' format.");
            }
        }

        ConnectToSourceMySqlTaskInput IPersistableModel<ConnectToSourceMySqlTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceMySqlTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectToSourceMySqlTaskInput(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceMySqlTaskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToSourceMySqlTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
