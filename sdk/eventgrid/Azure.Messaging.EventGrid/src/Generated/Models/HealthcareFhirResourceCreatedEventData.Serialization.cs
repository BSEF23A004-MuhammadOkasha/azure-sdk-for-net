// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(HealthcareFhirResourceCreatedEventDataConverter))]
    public partial class HealthcareFhirResourceCreatedEventData : IUtf8JsonSerializable, IJsonModel<HealthcareFhirResourceCreatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareFhirResourceCreatedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HealthcareFhirResourceCreatedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareFhirResourceCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(HealthcareFhirResourceCreatedEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FhirResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(FhirResourceType.Value.ToString());
            }
            if (Optional.IsDefined(FhirServiceHostName))
            {
                writer.WritePropertyName("resourceFhirAccount"u8);
                writer.WriteStringValue(FhirServiceHostName);
            }
            if (Optional.IsDefined(FhirResourceId))
            {
                writer.WritePropertyName("resourceFhirId"u8);
                writer.WriteStringValue(FhirResourceId);
            }
            if (Optional.IsDefined(FhirResourceVersionId))
            {
                writer.WritePropertyName("resourceVersionId"u8);
                writer.WriteNumberValue(FhirResourceVersionId.Value);
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

        HealthcareFhirResourceCreatedEventData IJsonModel<HealthcareFhirResourceCreatedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareFhirResourceCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(HealthcareFhirResourceCreatedEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareFhirResourceCreatedEventData(document.RootElement, options);
        }

        internal static HealthcareFhirResourceCreatedEventData DeserializeHealthcareFhirResourceCreatedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HealthcareFhirResourceType> resourceType = default;
            Optional<string> resourceFhirAccount = default;
            Optional<string> resourceFhirId = default;
            Optional<long> resourceVersionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new HealthcareFhirResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceFhirAccount"u8))
                {
                    resourceFhirAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceFhirId"u8))
                {
                    resourceFhirId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceVersionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceVersionId = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HealthcareFhirResourceCreatedEventData(Optional.ToNullable(resourceType), resourceFhirAccount.Value, resourceFhirId.Value, Optional.ToNullable(resourceVersionId), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareFhirResourceCreatedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareFhirResourceCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(HealthcareFhirResourceCreatedEventData)} does not support '{options.Format}' format.");
            }
        }

        HealthcareFhirResourceCreatedEventData IPersistableModel<HealthcareFhirResourceCreatedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareFhirResourceCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHealthcareFhirResourceCreatedEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(HealthcareFhirResourceCreatedEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthcareFhirResourceCreatedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class HealthcareFhirResourceCreatedEventDataConverter : JsonConverter<HealthcareFhirResourceCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, HealthcareFhirResourceCreatedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HealthcareFhirResourceCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHealthcareFhirResourceCreatedEventData(document.RootElement);
            }
        }
    }
}
