// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class FrontDoorOriginGroupPatch : IUtf8JsonSerializable, IJsonModel<FrontDoorOriginGroupPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorOriginGroupPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorOriginGroupPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorOriginGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorOriginGroupPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProfileName))
            {
                writer.WritePropertyName("profileName"u8);
                writer.WriteStringValue(ProfileName);
            }
            if (Optional.IsDefined(LoadBalancingSettings))
            {
                writer.WritePropertyName("loadBalancingSettings"u8);
                writer.WriteObjectValue(LoadBalancingSettings);
            }
            if (Optional.IsDefined(HealthProbeSettings))
            {
                writer.WritePropertyName("healthProbeSettings"u8);
                writer.WriteObjectValue(HealthProbeSettings);
            }
            if (Optional.IsDefined(TrafficRestorationTimeInMinutes))
            {
                if (TrafficRestorationTimeInMinutes != null)
                {
                    writer.WritePropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"u8);
                    writer.WriteNumberValue(TrafficRestorationTimeInMinutes.Value);
                }
                else
                {
                    writer.WriteNull("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                }
            }
            if (Optional.IsDefined(SessionAffinityState))
            {
                writer.WritePropertyName("sessionAffinityState"u8);
                writer.WriteStringValue(SessionAffinityState.Value.ToString());
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

        FrontDoorOriginGroupPatch IJsonModel<FrontDoorOriginGroupPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorOriginGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorOriginGroupPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorOriginGroupPatch(document.RootElement, options);
        }

        internal static FrontDoorOriginGroupPatch DeserializeFrontDoorOriginGroupPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string profileName = default;
            LoadBalancingSettings loadBalancingSettings = default;
            HealthProbeSettings healthProbeSettings = default;
            int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes = default;
            EnabledState? sessionAffinityState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("profileName"u8))
                        {
                            profileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadBalancingSettings = LoadBalancingSettings.DeserializeLoadBalancingSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("healthProbeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthProbeSettings = HealthProbeSettings.DeserializeHealthProbeSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                trafficRestorationTimeToHealedOrNewEndpointsInMinutes = null;
                                continue;
                            }
                            trafficRestorationTimeToHealedOrNewEndpointsInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sessionAffinityState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessionAffinityState = new EnabledState(property0.Value.GetString());
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
            return new FrontDoorOriginGroupPatch(
                profileName,
                loadBalancingSettings,
                healthProbeSettings,
                trafficRestorationTimeToHealedOrNewEndpointsInMinutes,
                sessionAffinityState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorOriginGroupPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorOriginGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorOriginGroupPatch)} does not support '{options.Format}' format.");
            }
        }

        FrontDoorOriginGroupPatch IPersistableModel<FrontDoorOriginGroupPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorOriginGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorOriginGroupPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorOriginGroupPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorOriginGroupPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
