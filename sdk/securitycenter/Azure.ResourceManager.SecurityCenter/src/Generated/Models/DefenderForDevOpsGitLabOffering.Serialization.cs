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
    public partial class DefenderForDevOpsGitLabOffering : IUtf8JsonSerializable, IJsonModel<DefenderForDevOpsGitLabOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForDevOpsGitLabOffering>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderForDevOpsGitLabOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDevOpsGitLabOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForDevOpsGitLabOffering)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        DefenderForDevOpsGitLabOffering IJsonModel<DefenderForDevOpsGitLabOffering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDevOpsGitLabOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForDevOpsGitLabOffering)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForDevOpsGitLabOffering(document.RootElement, options);
        }

        internal static DefenderForDevOpsGitLabOffering DeserializeDefenderForDevOpsGitLabOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OfferingType offeringType = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderForDevOpsGitLabOffering(offeringType, description, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForDevOpsGitLabOffering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDevOpsGitLabOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForDevOpsGitLabOffering)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderForDevOpsGitLabOffering IPersistableModel<DefenderForDevOpsGitLabOffering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDevOpsGitLabOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForDevOpsGitLabOffering(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForDevOpsGitLabOffering)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForDevOpsGitLabOffering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
