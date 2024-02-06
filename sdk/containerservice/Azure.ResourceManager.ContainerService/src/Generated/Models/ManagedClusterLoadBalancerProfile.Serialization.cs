// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterLoadBalancerProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterLoadBalancerProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterLoadBalancerProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterLoadBalancerProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedOutboundIPs))
            {
                writer.WritePropertyName("managedOutboundIPs"u8);
                BinaryData data = ModelReaderWriter.Write(ManagedOutboundIPs, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(OutboundIPPrefixes))
            {
                writer.WritePropertyName("outboundIPPrefixes"u8);
                BinaryData data = ModelReaderWriter.Write(OutboundIPPrefixes, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(OutboundIPs))
            {
                writer.WritePropertyName("outboundIPs"u8);
                BinaryData data = ModelReaderWriter.Write(OutboundIPs, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(EffectiveOutboundIPs))
            {
                writer.WritePropertyName("effectiveOutboundIPs"u8);
                writer.WriteStartArray();
                foreach (var item in EffectiveOutboundIPs)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllocatedOutboundPorts))
            {
                writer.WritePropertyName("allocatedOutboundPorts"u8);
                writer.WriteNumberValue(AllocatedOutboundPorts.Value);
            }
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes"u8);
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(EnableMultipleStandardLoadBalancers))
            {
                writer.WritePropertyName("enableMultipleStandardLoadBalancers"u8);
                writer.WriteBooleanValue(EnableMultipleStandardLoadBalancers.Value);
            }
            if (Optional.IsDefined(BackendPoolType))
            {
                writer.WritePropertyName("backendPoolType"u8);
                writer.WriteStringValue(BackendPoolType.Value.ToString());
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

        ManagedClusterLoadBalancerProfile IJsonModel<ManagedClusterLoadBalancerProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterLoadBalancerProfile(document.RootElement, options);
        }

        internal static ManagedClusterLoadBalancerProfile DeserializeManagedClusterLoadBalancerProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedClusterLoadBalancerProfileManagedOutboundIPs> managedOutboundIPs = default;
            Optional<ManagedClusterLoadBalancerProfileOutboundIPPrefixes> outboundIPPrefixes = default;
            Optional<ManagedClusterLoadBalancerProfileOutboundIPs> outboundIPs = default;
            Optional<IList<WritableSubResource>> effectiveOutboundIPs = default;
            Optional<int> allocatedOutboundPorts = default;
            Optional<int> idleTimeoutInMinutes = default;
            Optional<bool> enableMultipleStandardLoadBalancers = default;
            Optional<ManagedClusterLoadBalancerBackendPoolType> backendPoolType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedOutboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedOutboundIPs = ManagedClusterLoadBalancerProfileManagedOutboundIPs.DeserializeManagedClusterLoadBalancerProfileManagedOutboundIPs(property.Value);
                    continue;
                }
                if (property.NameEquals("outboundIPPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundIPPrefixes = ManagedClusterLoadBalancerProfileOutboundIPPrefixes.DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(property.Value);
                    continue;
                }
                if (property.NameEquals("outboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundIPs = ManagedClusterLoadBalancerProfileOutboundIPs.DeserializeManagedClusterLoadBalancerProfileOutboundIPs(property.Value);
                    continue;
                }
                if (property.NameEquals("effectiveOutboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    effectiveOutboundIPs = array;
                    continue;
                }
                if (property.NameEquals("allocatedOutboundPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocatedOutboundPorts = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("idleTimeoutInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    idleTimeoutInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableMultipleStandardLoadBalancers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableMultipleStandardLoadBalancers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backendPoolType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendPoolType = new ManagedClusterLoadBalancerBackendPoolType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterLoadBalancerProfile(managedOutboundIPs.Value, outboundIPPrefixes.Value, outboundIPs.Value, Optional.ToList(effectiveOutboundIPs), Optional.ToNullable(allocatedOutboundPorts), Optional.ToNullable(idleTimeoutInMinutes), Optional.ToNullable(enableMultipleStandardLoadBalancers), Optional.ToNullable(backendPoolType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterLoadBalancerProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfile)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterLoadBalancerProfile IPersistableModel<ManagedClusterLoadBalancerProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterLoadBalancerProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterLoadBalancerProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
