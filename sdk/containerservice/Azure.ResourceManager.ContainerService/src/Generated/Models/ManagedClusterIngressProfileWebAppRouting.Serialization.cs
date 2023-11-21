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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterIngressProfileWebAppRouting : IUtf8JsonSerializable, IJsonModel<ManagedClusterIngressProfileWebAppRouting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterIngressProfileWebAppRouting>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterIngressProfileWebAppRouting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterIngressProfileWebAppRouting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ManagedClusterIngressProfileWebAppRouting)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(DnsZoneResourceId))
            {
                writer.WritePropertyName("dnsZoneResourceId"u8);
                writer.WriteStringValue(DnsZoneResourceId);
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

        ManagedClusterIngressProfileWebAppRouting IJsonModel<ManagedClusterIngressProfileWebAppRouting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterIngressProfileWebAppRouting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ManagedClusterIngressProfileWebAppRouting)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterIngressProfileWebAppRouting(document.RootElement, options);
        }

        internal static ManagedClusterIngressProfileWebAppRouting DeserializeManagedClusterIngressProfileWebAppRouting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<ResourceIdentifier> dnsZoneResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dnsZoneResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dnsZoneResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterIngressProfileWebAppRouting(Optional.ToNullable(enabled), dnsZoneResourceId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterIngressProfileWebAppRouting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterIngressProfileWebAppRouting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ManagedClusterIngressProfileWebAppRouting)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterIngressProfileWebAppRouting IPersistableModel<ManagedClusterIngressProfileWebAppRouting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterIngressProfileWebAppRouting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterIngressProfileWebAppRouting(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ManagedClusterIngressProfileWebAppRouting)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterIngressProfileWebAppRouting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
