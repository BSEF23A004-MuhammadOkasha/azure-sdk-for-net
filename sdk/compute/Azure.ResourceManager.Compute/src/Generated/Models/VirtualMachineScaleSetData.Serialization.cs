// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class VirtualMachineScaleSetData : IUtf8JsonSerializable, IModelJsonSerializable<VirtualMachineScaleSetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualMachineScaleSetData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualMachineScaleSetData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineScaleSetData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ComputeSku>)Sku).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                if (Plan is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ComputePlan>)Plan).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
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
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsCollectionDefined(Tags))
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(UpgradePolicy))
            {
                writer.WritePropertyName("upgradePolicy"u8);
                if (UpgradePolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VirtualMachineScaleSetUpgradePolicy>)UpgradePolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AutomaticRepairsPolicy))
            {
                writer.WritePropertyName("automaticRepairsPolicy"u8);
                if (AutomaticRepairsPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AutomaticRepairsPolicy>)AutomaticRepairsPolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(VirtualMachineProfile))
            {
                writer.WritePropertyName("virtualMachineProfile"u8);
                if (VirtualMachineProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VirtualMachineScaleSetVmProfile>)VirtualMachineProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Overprovision))
            {
                writer.WritePropertyName("overprovision"u8);
                writer.WriteBooleanValue(Overprovision.Value);
            }
            if (Optional.IsDefined(DoNotRunExtensionsOnOverprovisionedVms))
            {
                writer.WritePropertyName("doNotRunExtensionsOnOverprovisionedVMs"u8);
                writer.WriteBooleanValue(DoNotRunExtensionsOnOverprovisionedVms.Value);
            }
            if (Optional.IsDefined(SinglePlacementGroup))
            {
                writer.WritePropertyName("singlePlacementGroup"u8);
                writer.WriteBooleanValue(SinglePlacementGroup.Value);
            }
            if (Optional.IsDefined(ZoneBalance))
            {
                writer.WritePropertyName("zoneBalance"u8);
                writer.WriteBooleanValue(ZoneBalance.Value);
            }
            if (Optional.IsDefined(PlatformFaultDomainCount))
            {
                writer.WritePropertyName("platformFaultDomainCount"u8);
                writer.WriteNumberValue(PlatformFaultDomainCount.Value);
            }
            if (Optional.IsDefined(ProximityPlacementGroup))
            {
                writer.WritePropertyName("proximityPlacementGroup"u8);
                JsonSerializer.Serialize(writer, ProximityPlacementGroup);
            }
            if (Optional.IsDefined(HostGroup))
            {
                writer.WritePropertyName("hostGroup"u8);
                JsonSerializer.Serialize(writer, HostGroup);
            }
            if (Optional.IsDefined(AdditionalCapabilities))
            {
                writer.WritePropertyName("additionalCapabilities"u8);
                if (AdditionalCapabilities is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AdditionalCapabilities>)AdditionalCapabilities).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ScaleInPolicy))
            {
                writer.WritePropertyName("scaleInPolicy"u8);
                if (ScaleInPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ScaleInPolicy>)ScaleInPolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OrchestrationMode))
            {
                writer.WritePropertyName("orchestrationMode"u8);
                writer.WriteStringValue(OrchestrationMode.Value.ToString());
            }
            if (Optional.IsDefined(SpotRestorePolicy))
            {
                writer.WritePropertyName("spotRestorePolicy"u8);
                if (SpotRestorePolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SpotRestorePolicy>)SpotRestorePolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PriorityMixPolicy))
            {
                writer.WritePropertyName("priorityMixPolicy"u8);
                if (PriorityMixPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VirtualMachineScaleSetPriorityMixPolicy>)PriorityMixPolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IsMaximumCapacityConstrained))
            {
                writer.WritePropertyName("constrainedMaximumCapacity"u8);
                writer.WriteBooleanValue(IsMaximumCapacityConstrained.Value);
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetData DeserializeVirtualMachineScaleSetData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ComputeSku> sku = default;
            Optional<ComputePlan> plan = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IList<string>> zones = default;
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<VirtualMachineScaleSetUpgradePolicy> upgradePolicy = default;
            Optional<AutomaticRepairsPolicy> automaticRepairsPolicy = default;
            Optional<VirtualMachineScaleSetVmProfile> virtualMachineProfile = default;
            Optional<string> provisioningState = default;
            Optional<bool> overprovision = default;
            Optional<bool> doNotRunExtensionsOnOverprovisionedVms = default;
            Optional<string> uniqueId = default;
            Optional<bool> singlePlacementGroup = default;
            Optional<bool> zoneBalance = default;
            Optional<int> platformFaultDomainCount = default;
            Optional<WritableSubResource> proximityPlacementGroup = default;
            Optional<WritableSubResource> hostGroup = default;
            Optional<AdditionalCapabilities> additionalCapabilities = default;
            Optional<ScaleInPolicy> scaleInPolicy = default;
            Optional<OrchestrationMode> orchestrationMode = default;
            Optional<SpotRestorePolicy> spotRestorePolicy = default;
            Optional<VirtualMachineScaleSetPriorityMixPolicy> priorityMixPolicy = default;
            Optional<DateTimeOffset> timeCreated = default;
            Optional<bool> constrainedMaximumCapacity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ComputeSku.DeserializeComputeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("plan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    plan = ComputePlan.DeserializeComputePlan(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
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
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
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
                        if (property0.NameEquals("upgradePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradePolicy = VirtualMachineScaleSetUpgradePolicy.DeserializeVirtualMachineScaleSetUpgradePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("automaticRepairsPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            automaticRepairsPolicy = AutomaticRepairsPolicy.DeserializeAutomaticRepairsPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMachineProfile = VirtualMachineScaleSetVmProfile.DeserializeVirtualMachineScaleSetVmProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("overprovision"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overprovision = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("doNotRunExtensionsOnOverprovisionedVMs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            doNotRunExtensionsOnOverprovisionedVms = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("uniqueId"u8))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("singlePlacementGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            singlePlacementGroup = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("zoneBalance"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneBalance = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("platformFaultDomainCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platformFaultDomainCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            proximityPlacementGroup = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hostGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostGroup = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("additionalCapabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalCapabilities = AdditionalCapabilities.DeserializeAdditionalCapabilities(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("scaleInPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scaleInPolicy = ScaleInPolicy.DeserializeScaleInPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("orchestrationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            orchestrationMode = new OrchestrationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("spotRestorePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            spotRestorePolicy = SpotRestorePolicy.DeserializeSpotRestorePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("priorityMixPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priorityMixPolicy = VirtualMachineScaleSetPriorityMixPolicy.DeserializeVirtualMachineScaleSetPriorityMixPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("timeCreated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeCreated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("constrainedMaximumCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            constrainedMaximumCapacity = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualMachineScaleSetData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, plan.Value, identity, Optional.ToList(zones), extendedLocation, upgradePolicy.Value, automaticRepairsPolicy.Value, virtualMachineProfile.Value, provisioningState.Value, Optional.ToNullable(overprovision), Optional.ToNullable(doNotRunExtensionsOnOverprovisionedVms), uniqueId.Value, Optional.ToNullable(singlePlacementGroup), Optional.ToNullable(zoneBalance), Optional.ToNullable(platformFaultDomainCount), proximityPlacementGroup, hostGroup, additionalCapabilities.Value, scaleInPolicy.Value, Optional.ToNullable(orchestrationMode), spotRestorePolicy.Value, priorityMixPolicy.Value, Optional.ToNullable(timeCreated), Optional.ToNullable(constrainedMaximumCapacity), rawData);
        }

        VirtualMachineScaleSetData IModelJsonSerializable<VirtualMachineScaleSetData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineScaleSetData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualMachineScaleSetData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineScaleSetData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualMachineScaleSetData IModelSerializable<VirtualMachineScaleSetData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualMachineScaleSetData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualMachineScaleSetData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualMachineScaleSetData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualMachineScaleSetData"/> to convert. </param>
        public static implicit operator RequestContent(VirtualMachineScaleSetData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualMachineScaleSetData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualMachineScaleSetData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualMachineScaleSetData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
