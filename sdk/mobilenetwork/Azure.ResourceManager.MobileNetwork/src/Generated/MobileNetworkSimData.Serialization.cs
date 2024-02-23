// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class MobileNetworkSimData : IUtf8JsonSerializable, IJsonModel<MobileNetworkSimData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkSimData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MobileNetworkSimData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkSimData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkSimData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && SimState.HasValue)
            {
                writer.WritePropertyName("simState"u8);
                writer.WriteStringValue(SimState.Value.ToString());
            }
            if (options.Format != "W" && !(SiteProvisioningState is ChangeTrackingDictionary<string, MobileNetworkSiteProvisioningState> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("siteProvisioningState"u8);
                writer.WriteStartObject();
                foreach (var item in SiteProvisioningState)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value.ToString());
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("internationalMobileSubscriberIdentity"u8);
            writer.WriteStringValue(InternationalMobileSubscriberIdentity);
            if (IntegratedCircuitCardIdentifier != null)
            {
                writer.WritePropertyName("integratedCircuitCardIdentifier"u8);
                writer.WriteStringValue(IntegratedCircuitCardIdentifier);
            }
            if (DeviceType != null)
            {
                writer.WritePropertyName("deviceType"u8);
                writer.WriteStringValue(DeviceType);
            }
            if (SimPolicy != null)
            {
                writer.WritePropertyName("simPolicy"u8);
                JsonSerializer.Serialize(writer, SimPolicy);
            }
            if (!(StaticIPConfiguration is ChangeTrackingList<SimStaticIPProperties> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("staticIpConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in StaticIPConfiguration)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && VendorName != null)
            {
                writer.WritePropertyName("vendorName"u8);
                writer.WriteStringValue(VendorName);
            }
            if (options.Format != "W" && VendorKeyFingerprint != null)
            {
                writer.WritePropertyName("vendorKeyFingerprint"u8);
                writer.WriteStringValue(VendorKeyFingerprint);
            }
            if (AuthenticationKey != null)
            {
                writer.WritePropertyName("authenticationKey"u8);
                writer.WriteStringValue(AuthenticationKey);
            }
            if (OperatorKeyCode != null)
            {
                writer.WritePropertyName("operatorKeyCode"u8);
                writer.WriteStringValue(OperatorKeyCode);
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
            writer.WriteEndObject();
        }

        MobileNetworkSimData IJsonModel<MobileNetworkSimData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkSimData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkSimData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkSimData(document.RootElement, options);
        }

        internal static MobileNetworkSimData DeserializeMobileNetworkSimData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<MobileNetworkProvisioningState> provisioningState = default;
            Optional<MobileNetworkSimState> simState = default;
            Optional<IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState>> siteProvisioningState = default;
            string internationalMobileSubscriberIdentity = default;
            Optional<string> integratedCircuitCardIdentifier = default;
            Optional<string> deviceType = default;
            Optional<WritableSubResource> simPolicy = default;
            IList<SimStaticIPProperties> staticIPConfiguration = default;
            Optional<string> vendorName = default;
            Optional<string> vendorKeyFingerprint = default;
            Optional<string> authenticationKey = default;
            Optional<string> operatorKeyCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MobileNetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("simState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            simState = new MobileNetworkSimState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("siteProvisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, MobileNetworkSiteProvisioningState> dictionary = new Dictionary<string, MobileNetworkSiteProvisioningState>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, new MobileNetworkSiteProvisioningState(property1.Value.GetString()));
                            }
                            siteProvisioningState = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("internationalMobileSubscriberIdentity"u8))
                        {
                            internationalMobileSubscriberIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("integratedCircuitCardIdentifier"u8))
                        {
                            integratedCircuitCardIdentifier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceType"u8))
                        {
                            deviceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("simPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            simPolicy = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("staticIpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SimStaticIPProperties> array = new List<SimStaticIPProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SimStaticIPProperties.DeserializeSimStaticIPProperties(item, options));
                            }
                            staticIPConfiguration = array;
                            continue;
                        }
                        if (property0.NameEquals("vendorName"u8))
                        {
                            vendorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vendorKeyFingerprint"u8))
                        {
                            vendorKeyFingerprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationKey"u8))
                        {
                            authenticationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operatorKeyCode"u8))
                        {
                            operatorKeyCode = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkSimData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(simState), Optional.ToDictionary(siteProvisioningState), internationalMobileSubscriberIdentity, integratedCircuitCardIdentifier.Value, deviceType.Value, simPolicy, staticIPConfiguration ?? new ChangeTrackingList<SimStaticIPProperties>(), vendorName.Value, vendorKeyFingerprint.Value, authenticationKey.Value, operatorKeyCode.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobileNetworkSimData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkSimData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkSimData)} does not support '{options.Format}' format.");
            }
        }

        MobileNetworkSimData IPersistableModel<MobileNetworkSimData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkSimData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMobileNetworkSimData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkSimData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkSimData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
