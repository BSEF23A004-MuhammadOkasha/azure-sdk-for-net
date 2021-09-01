// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayUrlPathMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultBackendAddressPool))
            {
                writer.WritePropertyName("defaultBackendAddressPool");
                writer.WriteObjectValue(DefaultBackendAddressPool);
            }
            if (Optional.IsDefined(DefaultBackendHttpSettings))
            {
                writer.WritePropertyName("defaultBackendHttpSettings");
                writer.WriteObjectValue(DefaultBackendHttpSettings);
            }
            if (Optional.IsDefined(DefaultRewriteRuleSet))
            {
                writer.WritePropertyName("defaultRewriteRuleSet");
                writer.WriteObjectValue(DefaultRewriteRuleSet);
            }
            if (Optional.IsDefined(DefaultRedirectConfiguration))
            {
                writer.WritePropertyName("defaultRedirectConfiguration");
                writer.WriteObjectValue(DefaultRedirectConfiguration);
            }
            if (Optional.IsCollectionDefined(PathRules))
            {
                writer.WritePropertyName("pathRules");
                writer.WriteStartArray();
                foreach (var item in PathRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayUrlPathMap DeserializeApplicationGatewayUrlPathMap(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            ResourceIdentifier id = default;
            Optional<SubResource> defaultBackendAddressPool = default;
            Optional<SubResource> defaultBackendHttpSettings = default;
            Optional<SubResource> defaultRewriteRuleSet = default;
            Optional<SubResource> defaultRedirectConfiguration = default;
            Optional<IList<ApplicationGatewayPathRule>> pathRules = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
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
                        if (property0.NameEquals("defaultBackendAddressPool"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultBackendAddressPool = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultBackendHttpSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultBackendHttpSettings = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultRewriteRuleSet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultRewriteRuleSet = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultRedirectConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultRedirectConfiguration = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("pathRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationGatewayPathRule> array = new List<ApplicationGatewayPathRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationGatewayPathRule.DeserializeApplicationGatewayPathRule(item));
                            }
                            pathRules = array;
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
            return new ApplicationGatewayUrlPathMap(id, name.Value, etag.Value, type.Value, defaultBackendAddressPool.Value, defaultBackendHttpSettings.Value, defaultRewriteRuleSet.Value, defaultRedirectConfiguration.Value, Optional.ToList(pathRules), Optional.ToNullable(provisioningState));
        }
    }
}
