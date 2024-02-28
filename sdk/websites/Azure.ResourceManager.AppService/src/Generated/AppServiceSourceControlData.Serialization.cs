// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceSourceControlData : IUtf8JsonSerializable, IJsonModel<AppServiceSourceControlData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceSourceControlData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceSourceControlData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceSourceControlData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceSourceControlData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Token != null)
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            if (TokenSecret != null)
            {
                writer.WritePropertyName("tokenSecret"u8);
                writer.WriteStringValue(TokenSecret);
            }
            if (RefreshToken != null)
            {
                writer.WritePropertyName("refreshToken"u8);
                writer.WriteStringValue(RefreshToken);
            }
            if (ExpireOn.HasValue)
            {
                writer.WritePropertyName("expirationTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
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

        AppServiceSourceControlData IJsonModel<AppServiceSourceControlData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceSourceControlData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceSourceControlData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceSourceControlData(document.RootElement, options);
        }

        internal static AppServiceSourceControlData DeserializeAppServiceSourceControlData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string token = default;
            string tokenSecret = default;
            string refreshToken = default;
            DateTimeOffset? expirationTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("token"u8))
                        {
                            token = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tokenSecret"u8))
                        {
                            tokenSecret = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("refreshToken"u8))
                        {
                            refreshToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTime = property0.Value.GetDateTimeOffset("O");
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
            return new AppServiceSourceControlData(
                id,
                name,
                type,
                systemData,
                token,
                tokenSecret,
                refreshToken,
                expirationTime,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceSourceControlData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceSourceControlData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceSourceControlData)} does not support '{options.Format}' format.");
            }
        }

        AppServiceSourceControlData IPersistableModel<AppServiceSourceControlData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceSourceControlData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceSourceControlData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceSourceControlData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceSourceControlData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
