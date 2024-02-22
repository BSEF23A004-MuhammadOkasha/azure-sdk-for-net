// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class AvailabilityGroupListenerLoadBalancerConfiguration : IUtf8JsonSerializable, IJsonModel<AvailabilityGroupListenerLoadBalancerConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailabilityGroupListenerLoadBalancerConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvailabilityGroupListenerLoadBalancerConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupListenerLoadBalancerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupListenerLoadBalancerConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIpAddress"u8);
                writer.WriteObjectValue(PrivateIPAddress);
            }
            if (Optional.IsDefined(PublicIPAddressResourceId))
            {
                writer.WritePropertyName("publicIpAddressResourceId"u8);
                writer.WriteStringValue(PublicIPAddressResourceId);
            }
            if (Optional.IsDefined(LoadBalancerResourceId))
            {
                writer.WritePropertyName("loadBalancerResourceId"u8);
                writer.WriteStringValue(LoadBalancerResourceId);
            }
            if (Optional.IsDefined(ProbePort))
            {
                writer.WritePropertyName("probePort"u8);
                writer.WriteNumberValue(ProbePort.Value);
            }
            if (!(SqlVmInstances is ChangeTrackingList<ResourceIdentifier> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("sqlVirtualMachineInstances"u8);
                writer.WriteStartArray();
                foreach (var item in SqlVmInstances)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        AvailabilityGroupListenerLoadBalancerConfiguration IJsonModel<AvailabilityGroupListenerLoadBalancerConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupListenerLoadBalancerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupListenerLoadBalancerConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilityGroupListenerLoadBalancerConfiguration(document.RootElement, options);
        }

        internal static AvailabilityGroupListenerLoadBalancerConfiguration DeserializeAvailabilityGroupListenerLoadBalancerConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AvailabilityGroupListenerPrivateIPAddress> privateIPAddress = default;
            Optional<ResourceIdentifier> publicIPAddressResourceId = default;
            Optional<ResourceIdentifier> loadBalancerResourceId = default;
            Optional<int> probePort = default;
            Optional<IList<ResourceIdentifier>> sqlVmInstances = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateIPAddress = AvailabilityGroupListenerPrivateIPAddress.DeserializeAvailabilityGroupListenerPrivateIPAddress(property.Value, options);
                    continue;
                }
                if (property.NameEquals("publicIpAddressResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIPAddressResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBalancerResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("probePort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probePort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sqlVirtualMachineInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    sqlVmInstances = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailabilityGroupListenerLoadBalancerConfiguration(privateIPAddress.Value, publicIPAddressResourceId.Value, loadBalancerResourceId.Value, Optional.ToNullable(probePort), Optional.ToList(sqlVmInstances), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailabilityGroupListenerLoadBalancerConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupListenerLoadBalancerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvailabilityGroupListenerLoadBalancerConfiguration)} does not support '{options.Format}' format.");
            }
        }

        AvailabilityGroupListenerLoadBalancerConfiguration IPersistableModel<AvailabilityGroupListenerLoadBalancerConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupListenerLoadBalancerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvailabilityGroupListenerLoadBalancerConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailabilityGroupListenerLoadBalancerConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailabilityGroupListenerLoadBalancerConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
