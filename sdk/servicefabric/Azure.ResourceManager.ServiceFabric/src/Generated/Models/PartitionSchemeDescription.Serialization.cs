// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    [PersistableModelProxy(typeof(UnknownPartitionSchemeDescription))]
    public partial class PartitionSchemeDescription : IUtf8JsonSerializable, IJsonModel<PartitionSchemeDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartitionSchemeDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartitionSchemeDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PartitionSchemeDescription)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
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

        PartitionSchemeDescription IJsonModel<PartitionSchemeDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PartitionSchemeDescription)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartitionSchemeDescription(document.RootElement, options);
        }

        internal static PartitionSchemeDescription DeserializePartitionSchemeDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("partitionScheme", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Named": return NamedPartitionSchemeDescription.DeserializeNamedPartitionSchemeDescription(element);
                    case "Singleton": return SingletonPartitionSchemeDescription.DeserializeSingletonPartitionSchemeDescription(element);
                    case "UniformInt64Range": return UniformInt64RangePartitionSchemeDescription.DeserializeUniformInt64RangePartitionSchemeDescription(element);
                }
            }
            return UnknownPartitionSchemeDescription.DeserializeUnknownPartitionSchemeDescription(element);
        }

        BinaryData IPersistableModel<PartitionSchemeDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PartitionSchemeDescription)} does not support '{options.Format}' format.");
            }
        }

        PartitionSchemeDescription IPersistableModel<PartitionSchemeDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartitionSchemeDescription(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PartitionSchemeDescription)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartitionSchemeDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
