// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class FailedLocalLoginsNotInAllowedRange : IUtf8JsonSerializable, IJsonModel<FailedLocalLoginsNotInAllowedRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FailedLocalLoginsNotInAllowedRange>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FailedLocalLoginsNotInAllowedRange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailedLocalLoginsNotInAllowedRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailedLocalLoginsNotInAllowedRange)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        FailedLocalLoginsNotInAllowedRange IJsonModel<FailedLocalLoginsNotInAllowedRange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailedLocalLoginsNotInAllowedRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailedLocalLoginsNotInAllowedRange)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFailedLocalLoginsNotInAllowedRange(document.RootElement, options);
        }

        internal static FailedLocalLoginsNotInAllowedRange DeserializeFailedLocalLoginsNotInAllowedRange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan timeWindowSize = default;
            int minThreshold = default;
            int maxThreshold = default;
            string displayName = default;
            string description = default;
            bool isEnabled = default;
            string ruleType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeWindowSize"u8))
                {
                    timeWindowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("minThreshold"u8))
                {
                    minThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxThreshold"u8))
                {
                    maxThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FailedLocalLoginsNotInAllowedRange(
                displayName,
                description,
                isEnabled,
                ruleType,
                serializedAdditionalRawData,
                minThreshold,
                maxThreshold,
                timeWindowSize);
        }

        BinaryData IPersistableModel<FailedLocalLoginsNotInAllowedRange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailedLocalLoginsNotInAllowedRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FailedLocalLoginsNotInAllowedRange)} does not support writing '{options.Format}' format.");
            }
        }

        FailedLocalLoginsNotInAllowedRange IPersistableModel<FailedLocalLoginsNotInAllowedRange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailedLocalLoginsNotInAllowedRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFailedLocalLoginsNotInAllowedRange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FailedLocalLoginsNotInAllowedRange)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FailedLocalLoginsNotInAllowedRange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
