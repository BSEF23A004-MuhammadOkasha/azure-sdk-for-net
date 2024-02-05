// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupInstancePolicySettings : IUtf8JsonSerializable, IJsonModel<BackupInstancePolicySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupInstancePolicySettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupInstancePolicySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupInstancePolicySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupInstancePolicySettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DataStoreParametersList))
            {
                writer.WritePropertyName("dataStoreParametersList"u8);
                writer.WriteStartArray();
                foreach (var item in DataStoreParametersList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BackupDataSourceParametersList))
            {
                writer.WritePropertyName("backupDatasourceParametersList"u8);
                writer.WriteStartArray();
                foreach (var item in BackupDataSourceParametersList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        BackupInstancePolicySettings IJsonModel<BackupInstancePolicySettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupInstancePolicySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupInstancePolicySettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupInstancePolicySettings(document.RootElement, options);
        }

        internal static BackupInstancePolicySettings DeserializeBackupInstancePolicySettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DataStoreSettings>> dataStoreParametersList = default;
            Optional<IList<BackupDataSourceSettings>> backupDatasourceParametersList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataStoreParametersList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataStoreSettings> array = new List<DataStoreSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataStoreSettings.DeserializeDataStoreSettings(item));
                    }
                    dataStoreParametersList = array;
                    continue;
                }
                if (property.NameEquals("backupDatasourceParametersList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupDataSourceSettings> array = new List<BackupDataSourceSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupDataSourceSettings.DeserializeBackupDataSourceSettings(item));
                    }
                    backupDatasourceParametersList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupInstancePolicySettings(Optional.ToList(dataStoreParametersList), Optional.ToList(backupDatasourceParametersList), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(DataStoreParametersList))
            {
                if (DataStoreParametersList.Any())
                {
                    builder.Append("  dataStoreParametersList:");
                    builder.AppendLine(" [");
                    foreach (var item in DataStoreParametersList)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(BackupDataSourceParametersList))
            {
                if (BackupDataSourceParametersList.Any())
                {
                    builder.Append("  backupDatasourceParametersList:");
                    builder.AppendLine(" [");
                    foreach (var item in BackupDataSourceParametersList)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
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

        BinaryData IPersistableModel<BackupInstancePolicySettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupInstancePolicySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BackupInstancePolicySettings)} does not support '{options.Format}' format.");
            }
        }

        BackupInstancePolicySettings IPersistableModel<BackupInstancePolicySettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupInstancePolicySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupInstancePolicySettings(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(BackupInstancePolicySettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupInstancePolicySettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
