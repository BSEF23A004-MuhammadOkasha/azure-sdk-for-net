// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class TokenInformation : IUtf8JsonSerializable, IJsonModel<TokenInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TokenInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TokenInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TokenInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(TokenInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            if (Optional.IsDefined(ExpiryTimeInUtcTicks))
            {
                writer.WritePropertyName("expiryTimeInUtcTicks"u8);
                writer.WriteNumberValue(ExpiryTimeInUtcTicks.Value);
            }
            if (Optional.IsDefined(SecurityPin))
            {
                writer.WritePropertyName("securityPIN"u8);
                writer.WriteStringValue(SecurityPin);
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

        TokenInformation IJsonModel<TokenInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TokenInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(TokenInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTokenInformation(document.RootElement, options);
        }

        internal static TokenInformation DeserializeTokenInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> token = default;
            Optional<long> expiryTimeInUtcTicks = default;
            Optional<string> securityPin = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTimeInUtcTicks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTimeInUtcTicks = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("securityPIN"u8))
                {
                    securityPin = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TokenInformation(token.Value, Optional.ToNullable(expiryTimeInUtcTicks), securityPin.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TokenInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TokenInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(TokenInformation)} does not support '{options.Format}' format.");
            }
        }

        TokenInformation IPersistableModel<TokenInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TokenInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTokenInformation(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(TokenInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TokenInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
