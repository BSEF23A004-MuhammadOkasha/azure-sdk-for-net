// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto
{
    public partial class KustoScriptData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ScriptUri))
            {
                writer.WritePropertyName("scriptUrl");
                writer.WriteStringValue(ScriptUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ScriptUriSasToken))
            {
                writer.WritePropertyName("scriptUrlSasToken");
                writer.WriteStringValue(ScriptUriSasToken);
            }
            if (Optional.IsDefined(ScriptContent))
            {
                writer.WritePropertyName("scriptContent");
                writer.WriteStringValue(ScriptContent);
            }
            if (Optional.IsDefined(ForceUpdateTag))
            {
                writer.WritePropertyName("forceUpdateTag");
                writer.WriteStringValue(ForceUpdateTag);
            }
            if (Optional.IsDefined(ShouldContinueOnErrors))
            {
                writer.WritePropertyName("continueOnErrors");
                writer.WriteBooleanValue(ShouldContinueOnErrors.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static KustoScriptData DeserializeKustoScriptData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Uri> scriptUrl = default;
            Optional<string> scriptUrlSasToken = default;
            Optional<string> scriptContent = default;
            Optional<string> forceUpdateTag = default;
            Optional<bool> continueOnErrors = default;
            Optional<KustoProvisioningState> provisioningState = default;
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
                        if (property0.NameEquals("scriptUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                scriptUrl = null;
                                continue;
                            }
                            scriptUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scriptUrlSasToken"))
                        {
                            scriptUrlSasToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scriptContent"))
                        {
                            scriptContent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("forceUpdateTag"))
                        {
                            forceUpdateTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("continueOnErrors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            continueOnErrors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new KustoProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new KustoScriptData(id, name, type, systemData.Value, scriptUrl.Value, scriptUrlSasToken.Value, scriptContent.Value, forceUpdateTag.Value, Optional.ToNullable(continueOnErrors), Optional.ToNullable(provisioningState));
        }
    }
}
