// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.VoiceServices.Models;

namespace Azure.ResourceManager.VoiceServices
{
    public partial class VoiceServicesCommunicationsGatewayData : IUtf8JsonSerializable, IJsonModel<VoiceServicesCommunicationsGatewayData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VoiceServicesCommunicationsGatewayData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VoiceServicesCommunicationsGatewayData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesCommunicationsGatewayData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VoiceServicesCommunicationsGatewayData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (!(ServiceLocations is ChangeTrackingList<VoiceServicesServiceRegionProperties> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("serviceLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLocations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Connectivity))
            {
                writer.WritePropertyName("connectivity"u8);
                writer.WriteStringValue(Connectivity.Value.ToString());
            }
            if (!(Codecs is ChangeTrackingList<VoiceServicesTeamsCodec> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("codecs"u8);
                writer.WriteStartArray();
                foreach (var item in Codecs)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(E911Type))
            {
                writer.WritePropertyName("e911Type"u8);
                writer.WriteStringValue(E911Type.Value.ToString());
            }
            if (!(Platforms is ChangeTrackingList<VoiceServicesCommunicationsPlatform> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("platforms"u8);
                writer.WriteStartArray();
                foreach (var item in Platforms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ApiBridge))
            {
                writer.WritePropertyName("apiBridge"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ApiBridge);
#else
                using (JsonDocument document = JsonDocument.Parse(ApiBridge))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(AutoGeneratedDomainNameLabelScope))
            {
                writer.WritePropertyName("autoGeneratedDomainNameLabelScope"u8);
                writer.WriteStringValue(AutoGeneratedDomainNameLabelScope.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AutoGeneratedDomainNameLabel))
            {
                writer.WritePropertyName("autoGeneratedDomainNameLabel"u8);
                writer.WriteStringValue(AutoGeneratedDomainNameLabel);
            }
            if (Optional.IsDefined(TeamsVoicemailPilotNumber))
            {
                writer.WritePropertyName("teamsVoicemailPilotNumber"u8);
                writer.WriteStringValue(TeamsVoicemailPilotNumber);
            }
            if (Optional.IsDefined(IsOnPremMcpEnabled))
            {
                writer.WritePropertyName("onPremMcpEnabled"u8);
                writer.WriteBooleanValue(IsOnPremMcpEnabled.Value);
            }
            if (!(EmergencyDialStrings is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("emergencyDialStrings"u8);
                writer.WriteStartArray();
                foreach (var item in EmergencyDialStrings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        VoiceServicesCommunicationsGatewayData IJsonModel<VoiceServicesCommunicationsGatewayData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesCommunicationsGatewayData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VoiceServicesCommunicationsGatewayData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVoiceServicesCommunicationsGatewayData(document.RootElement, options);
        }

        internal static VoiceServicesCommunicationsGatewayData DeserializeVoiceServicesCommunicationsGatewayData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<VoiceServicesProvisioningState> provisioningState = default;
            Optional<VoiceServicesCommunicationsGatewayStatus> status = default;
            Optional<IList<VoiceServicesServiceRegionProperties>> serviceLocations = default;
            Optional<VoiceServicesCommunicationsGatewayConnectivity> connectivity = default;
            Optional<IList<VoiceServicesTeamsCodec>> codecs = default;
            Optional<VoiceServicesEmergencyCallType> e911Type = default;
            Optional<IList<VoiceServicesCommunicationsPlatform>> platforms = default;
            Optional<BinaryData> apiBridge = default;
            Optional<VoiceServicesAutoGeneratedDomainNameLabelScope> autoGeneratedDomainNameLabelScope = default;
            Optional<string> autoGeneratedDomainNameLabel = default;
            Optional<string> teamsVoicemailPilotNumber = default;
            Optional<bool> onPremMcpEnabled = default;
            Optional<IList<string>> emergencyDialStrings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                            provisioningState = new VoiceServicesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new VoiceServicesCommunicationsGatewayStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceLocations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VoiceServicesServiceRegionProperties> array = new List<VoiceServicesServiceRegionProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VoiceServicesServiceRegionProperties.DeserializeVoiceServicesServiceRegionProperties(item, options));
                            }
                            serviceLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("connectivity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectivity = new VoiceServicesCommunicationsGatewayConnectivity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("codecs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VoiceServicesTeamsCodec> array = new List<VoiceServicesTeamsCodec>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new VoiceServicesTeamsCodec(item.GetString()));
                            }
                            codecs = array;
                            continue;
                        }
                        if (property0.NameEquals("e911Type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            e911Type = new VoiceServicesEmergencyCallType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("platforms"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VoiceServicesCommunicationsPlatform> array = new List<VoiceServicesCommunicationsPlatform>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new VoiceServicesCommunicationsPlatform(item.GetString()));
                            }
                            platforms = array;
                            continue;
                        }
                        if (property0.NameEquals("apiBridge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiBridge = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("autoGeneratedDomainNameLabelScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoGeneratedDomainNameLabelScope = new VoiceServicesAutoGeneratedDomainNameLabelScope(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("autoGeneratedDomainNameLabel"u8))
                        {
                            autoGeneratedDomainNameLabel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("teamsVoicemailPilotNumber"u8))
                        {
                            teamsVoicemailPilotNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("onPremMcpEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            onPremMcpEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("emergencyDialStrings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            emergencyDialStrings = array;
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
            return new VoiceServicesCommunicationsGatewayData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), Optional.ToNullable(status), Optional.ToList(serviceLocations), Optional.ToNullable(connectivity), Optional.ToList(codecs), Optional.ToNullable(e911Type), Optional.ToList(platforms), apiBridge.Value, Optional.ToNullable(autoGeneratedDomainNameLabelScope), autoGeneratedDomainNameLabel.Value, teamsVoicemailPilotNumber.Value, Optional.ToNullable(onPremMcpEnabled), Optional.ToList(emergencyDialStrings), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VoiceServicesCommunicationsGatewayData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesCommunicationsGatewayData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VoiceServicesCommunicationsGatewayData)} does not support '{options.Format}' format.");
            }
        }

        VoiceServicesCommunicationsGatewayData IPersistableModel<VoiceServicesCommunicationsGatewayData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesCommunicationsGatewayData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVoiceServicesCommunicationsGatewayData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VoiceServicesCommunicationsGatewayData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VoiceServicesCommunicationsGatewayData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
