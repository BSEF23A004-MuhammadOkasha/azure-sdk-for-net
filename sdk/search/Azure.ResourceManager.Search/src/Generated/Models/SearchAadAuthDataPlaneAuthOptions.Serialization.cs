// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Search;

namespace Azure.ResourceManager.Search.Models
{
    public partial class SearchAadAuthDataPlaneAuthOptions : IUtf8JsonSerializable, IJsonModel<SearchAadAuthDataPlaneAuthOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchAadAuthDataPlaneAuthOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SearchAadAuthDataPlaneAuthOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchAadAuthDataPlaneAuthOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchAadAuthDataPlaneAuthOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ApiKeyOnly))
            {
                writer.WritePropertyName("apiKeyOnly"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ApiKeyOnly);
#else
                using (JsonDocument document = JsonDocument.Parse(ApiKeyOnly))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(AadOrApiKey))
            {
                writer.WritePropertyName("aadOrApiKey"u8);
                writer.WriteObjectValue(AadOrApiKey);
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

        SearchAadAuthDataPlaneAuthOptions IJsonModel<SearchAadAuthDataPlaneAuthOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchAadAuthDataPlaneAuthOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchAadAuthDataPlaneAuthOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchAadAuthDataPlaneAuthOptions(document.RootElement, options);
        }

        internal static SearchAadAuthDataPlaneAuthOptions DeserializeSearchAadAuthDataPlaneAuthOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData apiKeyOnly = default;
            DataPlaneAadOrApiKeyAuthOption aadOrApiKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiKeyOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiKeyOnly = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("aadOrApiKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aadOrApiKey = DataPlaneAadOrApiKeyAuthOption.DeserializeDataPlaneAadOrApiKeyAuthOption(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchAadAuthDataPlaneAuthOptions(apiKeyOnly, aadOrApiKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchAadAuthDataPlaneAuthOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchAadAuthDataPlaneAuthOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SearchAadAuthDataPlaneAuthOptions)} does not support '{options.Format}' format.");
            }
        }

        SearchAadAuthDataPlaneAuthOptions IPersistableModel<SearchAadAuthDataPlaneAuthOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchAadAuthDataPlaneAuthOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSearchAadAuthDataPlaneAuthOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SearchAadAuthDataPlaneAuthOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SearchAadAuthDataPlaneAuthOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
