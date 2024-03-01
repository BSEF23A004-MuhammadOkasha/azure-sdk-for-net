// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class FhirServiceAcrConfiguration : IUtf8JsonSerializable, IJsonModel<FhirServiceAcrConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirServiceAcrConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FhirServiceAcrConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceAcrConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirServiceAcrConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(LoginServers is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("loginServers"u8);
                writer.WriteStartArray();
                foreach (var item in LoginServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(OciArtifacts is ChangeTrackingList<HealthcareApisServiceOciArtifactEntry> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("ociArtifacts"u8);
                writer.WriteStartArray();
                foreach (var item in OciArtifacts)
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

        FhirServiceAcrConfiguration IJsonModel<FhirServiceAcrConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceAcrConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirServiceAcrConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirServiceAcrConfiguration(document.RootElement, options);
        }

        internal static FhirServiceAcrConfiguration DeserializeFhirServiceAcrConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> loginServers = default;
            IList<HealthcareApisServiceOciArtifactEntry> ociArtifacts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loginServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    loginServers = array;
                    continue;
                }
                if (property.NameEquals("ociArtifacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareApisServiceOciArtifactEntry> array = new List<HealthcareApisServiceOciArtifactEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisServiceOciArtifactEntry.DeserializeHealthcareApisServiceOciArtifactEntry(item, options));
                    }
                    ociArtifacts = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FhirServiceAcrConfiguration(loginServers ?? new ChangeTrackingList<string>(), ociArtifacts ?? new ChangeTrackingList<HealthcareApisServiceOciArtifactEntry>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FhirServiceAcrConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceAcrConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FhirServiceAcrConfiguration)} does not support '{options.Format}' format.");
            }
        }

        FhirServiceAcrConfiguration IPersistableModel<FhirServiceAcrConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceAcrConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFhirServiceAcrConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirServiceAcrConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirServiceAcrConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
