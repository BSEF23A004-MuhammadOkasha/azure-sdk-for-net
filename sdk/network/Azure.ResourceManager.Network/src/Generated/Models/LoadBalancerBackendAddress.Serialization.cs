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

namespace Azure.ResourceManager.Network.Models
{
    public partial class LoadBalancerBackendAddress : IUtf8JsonSerializable, IJsonModel<LoadBalancerBackendAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadBalancerBackendAddress>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LoadBalancerBackendAddress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerBackendAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerBackendAddress)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualNetwork))
            {
                writer.WritePropertyName("virtualNetwork"u8);
                JsonSerializer.Serialize(writer, VirtualNetwork);
            }
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                JsonSerializer.Serialize(writer, Subnet);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkInterfaceIPConfiguration))
            {
                writer.WritePropertyName("networkInterfaceIPConfiguration"u8);
                JsonSerializer.Serialize(writer, NetworkInterfaceIPConfiguration);
            }
            if (Optional.IsDefined(LoadBalancerFrontendIPConfiguration))
            {
                writer.WritePropertyName("loadBalancerFrontendIPConfiguration"u8);
                JsonSerializer.Serialize(writer, LoadBalancerFrontendIPConfiguration);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(InboundNatRulesPortMapping))
            {
                writer.WritePropertyName("inboundNatRulesPortMapping"u8);
                writer.WriteStartArray();
                foreach (var item in InboundNatRulesPortMapping)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AdminState))
            {
                writer.WritePropertyName("adminState"u8);
                writer.WriteStringValue(AdminState.Value.ToString());
            }
            writer.WriteEndObject();
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

        LoadBalancerBackendAddress IJsonModel<LoadBalancerBackendAddress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerBackendAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerBackendAddress)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerBackendAddress(document.RootElement, options);
        }

        internal static LoadBalancerBackendAddress DeserializeLoadBalancerBackendAddress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            WritableSubResource virtualNetwork = default;
            WritableSubResource subnet = default;
            string ipAddress = default;
            WritableSubResource networkInterfaceIPConfiguration = default;
            WritableSubResource loadBalancerFrontendIPConfiguration = default;
            IReadOnlyList<NatRulePortMapping> inboundNatRulesPortMapping = default;
            LoadBalancerBackendAddressAdminState? adminState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetwork = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"u8))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaceIPConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkInterfaceIPConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerFrontendIPConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadBalancerFrontendIPConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("inboundNatRulesPortMapping"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NatRulePortMapping> array = new List<NatRulePortMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NatRulePortMapping.DeserializeNatRulePortMapping(item, options));
                            }
                            inboundNatRulesPortMapping = array;
                            continue;
                        }
                        if (property0.NameEquals("adminState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adminState = new LoadBalancerBackendAddressAdminState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LoadBalancerBackendAddress(
                name,
                virtualNetwork,
                subnet,
                ipAddress,
                networkInterfaceIPConfiguration,
                loadBalancerFrontendIPConfiguration,
                inboundNatRulesPortMapping ?? new ChangeTrackingList<NatRulePortMapping>(),
                adminState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoadBalancerBackendAddress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerBackendAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerBackendAddress)} does not support writing '{options.Format}' format.");
            }
        }

        LoadBalancerBackendAddress IPersistableModel<LoadBalancerBackendAddress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerBackendAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoadBalancerBackendAddress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerBackendAddress)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadBalancerBackendAddress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
