// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    [PersistableModelProxy(typeof(UnknownSecretInfoBase))]
    public partial class SecretBaseInfo : IUtf8JsonSerializable, IJsonModel<SecretBaseInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecretBaseInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecretBaseInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecretBaseInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SecretBaseInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("secretType"u8);
            writer.WriteStringValue(SecretType.ToString());
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

        SecretBaseInfo IJsonModel<SecretBaseInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecretBaseInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SecretBaseInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecretBaseInfo(document.RootElement, options);
        }

        internal static SecretBaseInfo DeserializeSecretBaseInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("secretType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "keyVaultSecretReference": return KeyVaultSecretReferenceSecretInfo.DeserializeKeyVaultSecretReferenceSecretInfo(element);
                    case "keyVaultSecretUri": return KeyVaultSecretUriSecretInfo.DeserializeKeyVaultSecretUriSecretInfo(element);
                    case "rawValue": return RawValueSecretInfo.DeserializeRawValueSecretInfo(element);
                }
            }
            return UnknownSecretInfoBase.DeserializeUnknownSecretInfoBase(element);
        }

        BinaryData IPersistableModel<SecretBaseInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecretBaseInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SecretBaseInfo)} does not support '{options.Format}' format.");
            }
        }

        SecretBaseInfo IPersistableModel<SecretBaseInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecretBaseInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecretBaseInfo(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SecretBaseInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecretBaseInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
