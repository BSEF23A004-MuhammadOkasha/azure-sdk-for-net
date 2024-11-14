// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    [PersistableModelProxy(typeof(UnknownInternalConnectionProperties))]
    internal partial class InternalConnectionProperties : IUtf8JsonSerializable, IJsonModel<InternalConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InternalConnectionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InternalConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalConnectionProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToSerialString());
            writer.WritePropertyName("category"u8);
            writer.WriteStringValue(Category.ToSerialString());
            writer.WritePropertyName("target"u8);
            writer.WriteStringValue(Target);
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
        }

        InternalConnectionProperties IJsonModel<InternalConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalConnectionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalConnectionProperties(document.RootElement, options);
        }

        internal static InternalConnectionProperties DeserializeInternalConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("authType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AAD": return InternalConnectionPropertiesAADAuth.DeserializeInternalConnectionPropertiesAADAuth(element, options);
                    case "ApiKey": return InternalConnectionPropertiesApiKeyAuth.DeserializeInternalConnectionPropertiesApiKeyAuth(element, options);
                    case "SAS": return InternalConnectionPropertiesSASAuth.DeserializeInternalConnectionPropertiesSASAuth(element, options);
                }
            }
            return UnknownInternalConnectionProperties.DeserializeUnknownInternalConnectionProperties(element, options);
        }

        BinaryData IPersistableModel<InternalConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalConnectionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        InternalConnectionProperties IPersistableModel<InternalConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalConnectionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalConnectionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static InternalConnectionProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalConnectionProperties(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
