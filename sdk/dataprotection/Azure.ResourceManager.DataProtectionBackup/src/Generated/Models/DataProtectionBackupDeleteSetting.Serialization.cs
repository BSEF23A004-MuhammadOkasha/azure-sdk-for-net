// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    [PersistableModelProxy(typeof(UnknownDeleteOption))]
    public partial class DataProtectionBackupDeleteSetting : IUtf8JsonSerializable, IJsonModel<DataProtectionBackupDeleteSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProtectionBackupDeleteSetting>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataProtectionBackupDeleteSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupDeleteSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataProtectionBackupDeleteSetting)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("duration"u8);
            writer.WriteStringValue(Duration, "P");
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

        DataProtectionBackupDeleteSetting IJsonModel<DataProtectionBackupDeleteSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupDeleteSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataProtectionBackupDeleteSetting)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupDeleteSetting(document.RootElement, options);
        }

        internal static DataProtectionBackupDeleteSetting DeserializeDataProtectionBackupDeleteSetting(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "AbsoluteDeleteOption": return DataProtectionBackupAbsoluteDeleteSetting.DeserializeDataProtectionBackupAbsoluteDeleteSetting(element);
                }
            }
            return UnknownDeleteOption.DeserializeUnknownDeleteOption(element);
        }

        BinaryData IPersistableModel<DataProtectionBackupDeleteSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupDeleteSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DataProtectionBackupDeleteSetting)} does not support '{options.Format}' format.");
            }
        }

        DataProtectionBackupDeleteSetting IPersistableModel<DataProtectionBackupDeleteSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupDeleteSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProtectionBackupDeleteSetting(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DataProtectionBackupDeleteSetting)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProtectionBackupDeleteSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
