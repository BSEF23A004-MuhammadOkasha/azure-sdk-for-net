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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class SourceCodeRepoAuthInfo : IUtf8JsonSerializable, IJsonModel<SourceCodeRepoAuthInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceCodeRepoAuthInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SourceCodeRepoAuthInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoAuthInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SourceCodeRepoAuthInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("tokenType"u8);
            writer.WriteStringValue(TokenType.ToString());
            writer.WritePropertyName("token"u8);
            writer.WriteStringValue(Token);
            if (Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken"u8);
                writer.WriteStringValue(RefreshToken);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(ExpireInSeconds))
            {
                writer.WritePropertyName("expiresIn"u8);
                writer.WriteNumberValue(ExpireInSeconds.Value);
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

        SourceCodeRepoAuthInfo IJsonModel<SourceCodeRepoAuthInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoAuthInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SourceCodeRepoAuthInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceCodeRepoAuthInfo(document.RootElement, options);
        }

        internal static SourceCodeRepoAuthInfo DeserializeSourceCodeRepoAuthInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceCodeRepoAuthTokenType tokenType = default;
            string token = default;
            Optional<string> refreshToken = default;
            Optional<string> scope = default;
            Optional<int> expiresIn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tokenType"u8))
                {
                    tokenType = new SourceCodeRepoAuthTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshToken"u8))
                {
                    refreshToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiresIn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresIn = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SourceCodeRepoAuthInfo(tokenType, token, refreshToken.Value, scope.Value, Optional.ToNullable(expiresIn), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SourceCodeRepoAuthInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoAuthInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SourceCodeRepoAuthInfo)} does not support '{options.Format}' format.");
            }
        }

        SourceCodeRepoAuthInfo IPersistableModel<SourceCodeRepoAuthInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoAuthInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceCodeRepoAuthInfo(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SourceCodeRepoAuthInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceCodeRepoAuthInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
