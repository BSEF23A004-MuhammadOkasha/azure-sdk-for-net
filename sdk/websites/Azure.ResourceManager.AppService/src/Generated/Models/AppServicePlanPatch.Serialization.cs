// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServicePlanPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(WorkerTierName))
            {
                writer.WritePropertyName("workerTierName");
                writer.WriteStringValue(WorkerTierName);
            }
            if (Optional.IsDefined(HostingEnvironmentProfile))
            {
                writer.WritePropertyName("hostingEnvironmentProfile");
                writer.WriteObjectValue(HostingEnvironmentProfile);
            }
            if (Optional.IsDefined(IsPerSiteScaling))
            {
                writer.WritePropertyName("perSiteScaling");
                writer.WriteBooleanValue(IsPerSiteScaling.Value);
            }
            if (Optional.IsDefined(IsElasticScaleEnabled))
            {
                writer.WritePropertyName("elasticScaleEnabled");
                writer.WriteBooleanValue(IsElasticScaleEnabled.Value);
            }
            if (Optional.IsDefined(MaximumElasticWorkerCount))
            {
                writer.WritePropertyName("maximumElasticWorkerCount");
                writer.WriteNumberValue(MaximumElasticWorkerCount.Value);
            }
            if (Optional.IsDefined(IsSpot))
            {
                writer.WritePropertyName("isSpot");
                writer.WriteBooleanValue(IsSpot.Value);
            }
            if (Optional.IsDefined(SpotExpirationOn))
            {
                writer.WritePropertyName("spotExpirationTime");
                writer.WriteStringValue(SpotExpirationOn.Value, "O");
            }
            if (Optional.IsDefined(FreeOfferExpirationOn))
            {
                writer.WritePropertyName("freeOfferExpirationTime");
                writer.WriteStringValue(FreeOfferExpirationOn.Value, "O");
            }
            if (Optional.IsDefined(IsReserved))
            {
                writer.WritePropertyName("reserved");
                writer.WriteBooleanValue(IsReserved.Value);
            }
            if (Optional.IsDefined(IsXenon))
            {
                writer.WritePropertyName("isXenon");
                writer.WriteBooleanValue(IsXenon.Value);
            }
            if (Optional.IsDefined(IsHyperV))
            {
                writer.WritePropertyName("hyperV");
                writer.WriteBooleanValue(IsHyperV.Value);
            }
            if (Optional.IsDefined(TargetWorkerCount))
            {
                writer.WritePropertyName("targetWorkerCount");
                writer.WriteNumberValue(TargetWorkerCount.Value);
            }
            if (Optional.IsDefined(TargetWorkerSizeId))
            {
                writer.WritePropertyName("targetWorkerSizeId");
                writer.WriteNumberValue(TargetWorkerSizeId.Value);
            }
            if (Optional.IsDefined(KubeEnvironmentProfile))
            {
                writer.WritePropertyName("kubeEnvironmentProfile");
                writer.WriteObjectValue(KubeEnvironmentProfile);
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant");
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppServicePlanPatch DeserializeAppServicePlanPatch(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> workerTierName = default;
            Optional<AppServicePlanStatusOption> status = default;
            Optional<string> subscription = default;
            Optional<HostingEnvironmentProfile> hostingEnvironmentProfile = default;
            Optional<int> maximumNumberOfWorkers = default;
            Optional<string> geoRegion = default;
            Optional<bool> perSiteScaling = default;
            Optional<bool> elasticScaleEnabled = default;
            Optional<int> maximumElasticWorkerCount = default;
            Optional<int> numberOfSites = default;
            Optional<bool> isSpot = default;
            Optional<DateTimeOffset> spotExpirationTime = default;
            Optional<DateTimeOffset> freeOfferExpirationTime = default;
            Optional<string> resourceGroup = default;
            Optional<bool> reserved = default;
            Optional<bool> isXenon = default;
            Optional<bool> hyperV = default;
            Optional<int> targetWorkerCount = default;
            Optional<int> targetWorkerSizeId = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<KubeEnvironmentProfile> kubeEnvironmentProfile = default;
            Optional<bool> zoneRedundant = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("workerTierName"))
                        {
                            workerTierName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = property0.Value.GetString().ToAppServicePlanStatusOption();
                            continue;
                        }
                        if (property0.NameEquals("subscription"))
                        {
                            subscription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironmentProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hostingEnvironmentProfile = HostingEnvironmentProfile.DeserializeHostingEnvironmentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfWorkers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maximumNumberOfWorkers = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("geoRegion"))
                        {
                            geoRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("perSiteScaling"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            perSiteScaling = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("elasticScaleEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            elasticScaleEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("maximumElasticWorkerCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maximumElasticWorkerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfSites"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            numberOfSites = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isSpot"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isSpot = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("spotExpirationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            spotExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("freeOfferExpirationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            freeOfferExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reserved"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reserved = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isXenon"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isXenon = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hyperV"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hyperV = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("targetWorkerCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetWorkerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("targetWorkerSizeId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetWorkerSizeId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("kubeEnvironmentProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            kubeEnvironmentProfile = KubeEnvironmentProfile.DeserializeKubeEnvironmentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppServicePlanPatch(id, name, type, systemData.Value, workerTierName.Value, Optional.ToNullable(status), subscription.Value, hostingEnvironmentProfile.Value, Optional.ToNullable(maximumNumberOfWorkers), geoRegion.Value, Optional.ToNullable(perSiteScaling), Optional.ToNullable(elasticScaleEnabled), Optional.ToNullable(maximumElasticWorkerCount), Optional.ToNullable(numberOfSites), Optional.ToNullable(isSpot), Optional.ToNullable(spotExpirationTime), Optional.ToNullable(freeOfferExpirationTime), resourceGroup.Value, Optional.ToNullable(reserved), Optional.ToNullable(isXenon), Optional.ToNullable(hyperV), Optional.ToNullable(targetWorkerCount), Optional.ToNullable(targetWorkerSizeId), Optional.ToNullable(provisioningState), kubeEnvironmentProfile.Value, Optional.ToNullable(zoneRedundant), kind.Value);
        }
    }
}
