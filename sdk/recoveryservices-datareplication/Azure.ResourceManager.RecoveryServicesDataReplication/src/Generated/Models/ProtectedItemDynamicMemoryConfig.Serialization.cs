// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class ProtectedItemDynamicMemoryConfig : IUtf8JsonSerializable, IJsonModel<ProtectedItemDynamicMemoryConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProtectedItemDynamicMemoryConfig>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ProtectedItemDynamicMemoryConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("maximumMemoryInMegaBytes"u8);
            writer.WriteNumberValue(MaximumMemoryInMegaBytes);
            writer.WritePropertyName("minimumMemoryInMegaBytes"u8);
            writer.WriteNumberValue(MinimumMemoryInMegaBytes);
            writer.WritePropertyName("targetMemoryBufferPercentage"u8);
            writer.WriteNumberValue(TargetMemoryBufferPercentage);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ProtectedItemDynamicMemoryConfig IJsonModel<ProtectedItemDynamicMemoryConfig>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProtectedItemDynamicMemoryConfig(document.RootElement, options);
        }

        internal static ProtectedItemDynamicMemoryConfig DeserializeProtectedItemDynamicMemoryConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long maximumMemoryInMegaBytes = default;
            long minimumMemoryInMegaBytes = default;
            int targetMemoryBufferPercentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maximumMemoryInMegaBytes"u8))
                {
                    maximumMemoryInMegaBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minimumMemoryInMegaBytes"u8))
                {
                    minimumMemoryInMegaBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("targetMemoryBufferPercentage"u8))
                {
                    targetMemoryBufferPercentage = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProtectedItemDynamicMemoryConfig(maximumMemoryInMegaBytes, minimumMemoryInMegaBytes, targetMemoryBufferPercentage, serializedAdditionalRawData);
        }

        BinaryData IModel<ProtectedItemDynamicMemoryConfig>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ProtectedItemDynamicMemoryConfig IModel<ProtectedItemDynamicMemoryConfig>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeProtectedItemDynamicMemoryConfig(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ProtectedItemDynamicMemoryConfig>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
