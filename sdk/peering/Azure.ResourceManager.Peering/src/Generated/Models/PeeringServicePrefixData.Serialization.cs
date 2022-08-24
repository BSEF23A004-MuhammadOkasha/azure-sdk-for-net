// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    public partial class PeeringServicePrefixData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix");
                writer.WriteStringValue(Prefix);
            }
            if (Optional.IsDefined(PeeringServicePrefixKey))
            {
                writer.WritePropertyName("peeringServicePrefixKey");
                writer.WriteStringValue(PeeringServicePrefixKey);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PeeringServicePrefixData DeserializePeeringServicePrefixData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> prefix = default;
            Optional<PrefixValidationState> prefixValidationState = default;
            Optional<LearnedType> learnedType = default;
            Optional<string> errorMessage = default;
            Optional<IReadOnlyList<PeeringServicePrefixEvent>> events = default;
            Optional<string> peeringServicePrefixKey = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("prefix"))
                        {
                            prefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("prefixValidationState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            prefixValidationState = new PrefixValidationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("learnedType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            learnedType = new LearnedType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("events"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PeeringServicePrefixEvent> array = new List<PeeringServicePrefixEvent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PeeringServicePrefixEvent.DeserializePeeringServicePrefixEvent(item));
                            }
                            events = array;
                            continue;
                        }
                        if (property0.NameEquals("peeringServicePrefixKey"))
                        {
                            peeringServicePrefixKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PeeringServicePrefixData(id, name, type, systemData.Value, prefix.Value, Optional.ToNullable(prefixValidationState), Optional.ToNullable(learnedType), errorMessage.Value, Optional.ToList(events), peeringServicePrefixKey.Value, Optional.ToNullable(provisioningState));
        }
    }
}
