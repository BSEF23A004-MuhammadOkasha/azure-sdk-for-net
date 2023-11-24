// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    [PersistableModelProxy(typeof(UnknownScalingTrigger))]
    public partial class ManagedServiceScalingTrigger : IUtf8JsonSerializable, IJsonModel<ManagedServiceScalingTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServiceScalingTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedServiceScalingTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ManagedServiceScalingTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        ManagedServiceScalingTrigger IJsonModel<ManagedServiceScalingTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ManagedServiceScalingTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServiceScalingTrigger(document.RootElement, options);
        }

        internal static ManagedServiceScalingTrigger DeserializeManagedServiceScalingTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AveragePartitionLoadTrigger": return AveragePartitionLoadScalingTrigger.DeserializeAveragePartitionLoadScalingTrigger(element);
                    case "AverageServiceLoadTrigger": return AverageServiceLoadScalingTrigger.DeserializeAverageServiceLoadScalingTrigger(element);
                }
            }
            return UnknownScalingTrigger.DeserializeUnknownScalingTrigger(element);
        }

        BinaryData IPersistableModel<ManagedServiceScalingTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ManagedServiceScalingTrigger)} does not support '{options.Format}' format.");
            }
        }

        ManagedServiceScalingTrigger IPersistableModel<ManagedServiceScalingTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedServiceScalingTrigger(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ManagedServiceScalingTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServiceScalingTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
