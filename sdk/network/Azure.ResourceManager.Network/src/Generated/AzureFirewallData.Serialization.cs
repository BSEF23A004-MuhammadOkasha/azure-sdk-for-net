// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class AzureFirewallData : IUtf8JsonSerializable, IJsonModel<AzureFirewallData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureFirewallData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureFirewallData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureFirewallData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ApplicationRuleCollections))
            {
                writer.WritePropertyName("applicationRuleCollections"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationRuleCollections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NatRuleCollections))
            {
                writer.WritePropertyName("natRuleCollections"u8);
                writer.WriteStartArray();
                foreach (var item in NatRuleCollections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NetworkRuleCollections))
            {
                writer.WritePropertyName("networkRuleCollections"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkRuleCollections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ManagementIPConfiguration))
            {
                writer.WritePropertyName("managementIpConfiguration"u8);
                writer.WriteObjectValue(ManagementIPConfiguration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ThreatIntelMode))
            {
                writer.WritePropertyName("threatIntelMode"u8);
                writer.WriteStringValue(ThreatIntelMode.Value.ToString());
            }
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub"u8);
                JsonSerializer.Serialize(writer, VirtualHub);
            }
            if (Optional.IsDefined(FirewallPolicy))
            {
                writer.WritePropertyName("firewallPolicy"u8);
                JsonSerializer.Serialize(writer, FirewallPolicy);
            }
            if (Optional.IsDefined(HubIPAddresses))
            {
                writer.WritePropertyName("hubIPAddresses"u8);
                writer.WriteObjectValue(HubIPAddresses, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(IPGroups))
            {
                writer.WritePropertyName("ipGroups"u8);
                writer.WriteStartArray();
                foreach (var item in IPGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsCollectionDefined(AdditionalProperties))
            {
                writer.WritePropertyName("additionalProperties"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(AutoscaleConfiguration))
            {
                writer.WritePropertyName("autoscaleConfiguration"u8);
                writer.WriteObjectValue(AutoscaleConfiguration, options);
            }
            writer.WriteEndObject();
        }

        AzureFirewallData IJsonModel<AzureFirewallData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureFirewallData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureFirewallData(document.RootElement, options);
        }

        internal static AzureFirewallData DeserializeAzureFirewallData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> zones = default;
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            IList<AzureFirewallApplicationRuleCollectionData> applicationRuleCollections = default;
            IList<AzureFirewallNatRuleCollectionData> natRuleCollections = default;
            IList<AzureFirewallNetworkRuleCollectionData> networkRuleCollections = default;
            IList<AzureFirewallIPConfiguration> ipConfigurations = default;
            AzureFirewallIPConfiguration managementIPConfiguration = default;
            NetworkProvisioningState? provisioningState = default;
            AzureFirewallThreatIntelMode? threatIntelMode = default;
            WritableSubResource virtualHub = default;
            WritableSubResource firewallPolicy = default;
            HubIPAddresses hubIPAddresses = default;
            IReadOnlyList<AzureFirewallIPGroups> ipGroups = default;
            AzureFirewallSku sku = default;
            IDictionary<string, string> additionalProperties = default;
            AzureFirewallAutoscaleConfiguration autoscaleConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("applicationRuleCollections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallApplicationRuleCollectionData> array = new List<AzureFirewallApplicationRuleCollectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallApplicationRuleCollectionData.DeserializeAzureFirewallApplicationRuleCollectionData(item, options));
                            }
                            applicationRuleCollections = array;
                            continue;
                        }
                        if (property0.NameEquals("natRuleCollections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallNatRuleCollectionData> array = new List<AzureFirewallNatRuleCollectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallNatRuleCollectionData.DeserializeAzureFirewallNatRuleCollectionData(item, options));
                            }
                            natRuleCollections = array;
                            continue;
                        }
                        if (property0.NameEquals("networkRuleCollections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallNetworkRuleCollectionData> array = new List<AzureFirewallNetworkRuleCollectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallNetworkRuleCollectionData.DeserializeAzureFirewallNetworkRuleCollectionData(item, options));
                            }
                            networkRuleCollections = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallIPConfiguration> array = new List<AzureFirewallIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallIPConfiguration.DeserializeAzureFirewallIPConfiguration(item, options));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("managementIpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementIPConfiguration = AzureFirewallIPConfiguration.DeserializeAzureFirewallIPConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("threatIntelMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            threatIntelMode = new AzureFirewallThreatIntelMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualHub"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualHub = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("firewallPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallPolicy = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hubIPAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hubIPAddresses = HubIPAddresses.DeserializeHubIPAddresses(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ipGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallIPGroups> array = new List<AzureFirewallIPGroups>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallIPGroups.DeserializeAzureFirewallIPGroups(item, options));
                            }
                            ipGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = AzureFirewallSku.DeserializeAzureFirewallSku(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("additionalProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            additionalProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("autoscaleConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoscaleConfiguration = AzureFirewallAutoscaleConfiguration.DeserializeAzureFirewallAutoscaleConfiguration(property0.Value, options);
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
            return new AzureFirewallData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                zones ?? new ChangeTrackingList<string>(),
                etag,
                applicationRuleCollections ?? new ChangeTrackingList<AzureFirewallApplicationRuleCollectionData>(),
                natRuleCollections ?? new ChangeTrackingList<AzureFirewallNatRuleCollectionData>(),
                networkRuleCollections ?? new ChangeTrackingList<AzureFirewallNetworkRuleCollectionData>(),
                ipConfigurations ?? new ChangeTrackingList<AzureFirewallIPConfiguration>(),
                managementIPConfiguration,
                provisioningState,
                threatIntelMode,
                virtualHub,
                firewallPolicy,
                hubIPAddresses,
                ipGroups ?? new ChangeTrackingList<AzureFirewallIPGroups>(),
                sku,
                additionalProperties ?? new ChangeTrackingDictionary<string, string>(),
                autoscaleConfiguration);
        }

        BinaryData IPersistableModel<AzureFirewallData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureFirewallData)} does not support writing '{options.Format}' format.");
            }
        }

        AzureFirewallData IPersistableModel<AzureFirewallData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureFirewallData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureFirewallData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureFirewallData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
