// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeAlertData : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeAlertData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeAlertData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxEdgeAlertData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeAlertData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeAlertData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (options.Format != "W" && Optional.IsDefined(AlertType))
            {
                writer.WritePropertyName("alertType"u8);
                writer.WriteStringValue(AlertType);
            }
            if (options.Format != "W" && Optional.IsDefined(AppearedOn))
            {
                writer.WritePropertyName("appearedAtDateTime"u8);
                writer.WriteStringValue(AppearedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Recommendation))
            {
                writer.WritePropertyName("recommendation"u8);
                writer.WriteStringValue(Recommendation);
            }
            if (options.Format != "W" && Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorDetails))
            {
                writer.WritePropertyName("errorDetails"u8);
                BinaryData data = ModelReaderWriter.Write(ErrorDetails, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DetailedInformation))
            {
                writer.WritePropertyName("detailedInformation"u8);
                writer.WriteStartObject();
                foreach (var item in DetailedInformation)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
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

        DataBoxEdgeAlertData IJsonModel<DataBoxEdgeAlertData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeAlertData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeAlertData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeAlertData(document.RootElement, options);
        }

        internal static DataBoxEdgeAlertData DeserializeDataBoxEdgeAlertData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> title = default;
            Optional<string> alertType = default;
            Optional<DateTimeOffset> appearedAtDateTime = default;
            Optional<string> recommendation = default;
            Optional<DataBoxEdgeAlertSeverity> severity = default;
            Optional<DataBoxEdgeAlertErrorDetails> errorDetails = default;
            Optional<IReadOnlyDictionary<string, string>> detailedInformation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("title"u8))
                        {
                            title = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertType"u8))
                        {
                            alertType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appearedAtDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appearedAtDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("recommendation"u8))
                        {
                            recommendation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new DataBoxEdgeAlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errorDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorDetails = DataBoxEdgeAlertErrorDetails.DeserializeDataBoxEdgeAlertErrorDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("detailedInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            detailedInformation = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxEdgeAlertData(id, name, type, systemData.Value, title.Value, alertType.Value, Optional.ToNullable(appearedAtDateTime), recommendation.Value, Optional.ToNullable(severity), errorDetails.Value, Optional.ToDictionary(detailedInformation), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeAlertData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeAlertData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeAlertData)} does not support '{options.Format}' format.");
            }
        }

        DataBoxEdgeAlertData IPersistableModel<DataBoxEdgeAlertData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeAlertData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeAlertData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeAlertData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeAlertData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
