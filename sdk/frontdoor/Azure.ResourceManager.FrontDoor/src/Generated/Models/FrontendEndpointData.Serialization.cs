// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor
{
    public partial class FrontendEndpointData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(SessionAffinityEnabledState))
            {
                writer.WritePropertyName("sessionAffinityEnabledState");
                writer.WriteStringValue(SessionAffinityEnabledState.Value.ToString());
            }
            if (Optional.IsDefined(SessionAffinityTtlSeconds))
            {
                writer.WritePropertyName("sessionAffinityTtlSeconds");
                writer.WriteNumberValue(SessionAffinityTtlSeconds.Value);
            }
            if (Optional.IsDefined(WebApplicationFirewallPolicyLink))
            {
                writer.WritePropertyName("webApplicationFirewallPolicyLink");
                JsonSerializer.Serialize(writer, WebApplicationFirewallPolicyLink);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FrontendEndpointData DeserializeFrontendEndpointData(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<string> hostName = default;
            Optional<SessionAffinityEnabledState> sessionAffinityEnabledState = default;
            Optional<int> sessionAffinityTtlSeconds = default;
            Optional<WritableSubResource> webApplicationFirewallPolicyLink = default;
            Optional<FrontDoorResourceState> resourceState = default;
            Optional<CustomHttpsProvisioningState> customHttpsProvisioningState = default;
            Optional<CustomHttpsProvisioningSubstate> customHttpsProvisioningSubstate = default;
            Optional<CustomHttpsConfiguration> customHttpsConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("hostName"))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sessionAffinityEnabledState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sessionAffinityEnabledState = new SessionAffinityEnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sessionAffinityTtlSeconds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sessionAffinityTtlSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("webApplicationFirewallPolicyLink"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            webApplicationFirewallPolicyLink = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceState = new FrontDoorResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customHttpsProvisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customHttpsProvisioningState = new CustomHttpsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customHttpsProvisioningSubstate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customHttpsProvisioningSubstate = new CustomHttpsProvisioningSubstate(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customHttpsConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customHttpsConfiguration = CustomHttpsConfiguration.DeserializeCustomHttpsConfiguration(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FrontendEndpointData(id.Value, name.Value, type.Value, hostName.Value, Optional.ToNullable(sessionAffinityEnabledState), Optional.ToNullable(sessionAffinityTtlSeconds), webApplicationFirewallPolicyLink, Optional.ToNullable(resourceState), Optional.ToNullable(customHttpsProvisioningState), Optional.ToNullable(customHttpsProvisioningSubstate), customHttpsConfiguration.Value);
        }
    }
}
