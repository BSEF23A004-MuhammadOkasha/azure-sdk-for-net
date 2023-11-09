// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WeeklyRetentionFormat : IUtf8JsonSerializable, IJsonModel<WeeklyRetentionFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WeeklyRetentionFormat>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<WeeklyRetentionFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DaysOfTheWeek))
            {
                writer.WritePropertyName("daysOfTheWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfTheWeek)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WeeksOfTheMonth))
            {
                writer.WritePropertyName("weeksOfTheMonth"u8);
                writer.WriteStartArray();
                foreach (var item in WeeksOfTheMonth)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        WeeklyRetentionFormat IJsonModel<WeeklyRetentionFormat>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WeeklyRetentionFormat)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWeeklyRetentionFormat(document.RootElement, options);
        }

        internal static WeeklyRetentionFormat DeserializeWeeklyRetentionFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<BackupDayOfWeek>> daysOfTheWeek = default;
            Optional<IList<BackupWeekOfMonth>> weeksOfTheMonth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysOfTheWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupDayOfWeek> array = new List<BackupDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBackupDayOfWeek());
                    }
                    daysOfTheWeek = array;
                    continue;
                }
                if (property.NameEquals("weeksOfTheMonth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupWeekOfMonth> array = new List<BackupWeekOfMonth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBackupWeekOfMonth());
                    }
                    weeksOfTheMonth = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WeeklyRetentionFormat(Optional.ToList(daysOfTheWeek), Optional.ToList(weeksOfTheMonth), serializedAdditionalRawData);
        }

        BinaryData IModel<WeeklyRetentionFormat>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WeeklyRetentionFormat)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WeeklyRetentionFormat IModel<WeeklyRetentionFormat>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WeeklyRetentionFormat)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWeeklyRetentionFormat(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<WeeklyRetentionFormat>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
