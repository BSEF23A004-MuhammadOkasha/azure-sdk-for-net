// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DefenderEasm.Models
{
    public partial class EasmTask : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StartedAt))
            {
                writer.WritePropertyName("startedAt"u8);
                writer.WriteStringValue(StartedAt);
            }
            if (Optional.IsDefined(CompletedAt))
            {
                writer.WritePropertyName("completedAt"u8);
                writer.WriteStringValue(CompletedAt);
            }
            if (Optional.IsDefined(LastPolledAt))
            {
                writer.WritePropertyName("lastPolledAt"u8);
                writer.WriteStringValue(LastPolledAt);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(Phase))
            {
                writer.WritePropertyName("phase"u8);
                writer.WriteStringValue(Phase);
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata.ToString()))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static EasmTask DeserializeEasmTask(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<EasmResourceProvisioningState> provisioningState = default;
            Optional<string> startedAt = default;
            Optional<string> completedAt = default;
            Optional<string> lastPolledAt = default;
            Optional<string> state = default;
            Optional<string> phase = default;
            Optional<string> reason = default;
            Optional<BinaryData> metadata = default;
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
                            provisioningState = new EasmResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startedAt"u8))
                        {
                            startedAt = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("completedAt"u8))
                        {
                            completedAt = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastPolledAt"u8))
                        {
                            lastPolledAt = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("phase"u8))
                        {
                            phase = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reason"u8))
                        {
                            reason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new EasmTask(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), startedAt.Value, completedAt.Value, lastPolledAt.Value, state.Value, phase.Value, reason.Value, metadata.Value);
        }
    }
}
