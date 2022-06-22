// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class SessionHostData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LastHeartBeat))
            {
                writer.WritePropertyName("lastHeartBeat");
                writer.WriteStringValue(LastHeartBeat.Value, "O");
            }
            if (Optional.IsDefined(Sessions))
            {
                writer.WritePropertyName("sessions");
                writer.WriteNumberValue(Sessions.Value);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion");
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(AllowNewSession))
            {
                writer.WritePropertyName("allowNewSession");
                writer.WriteBooleanValue(AllowNewSession.Value);
            }
            if (Optional.IsDefined(AssignedUser))
            {
                writer.WritePropertyName("assignedUser");
                writer.WriteStringValue(AssignedUser);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(OSVersion))
            {
                writer.WritePropertyName("osVersion");
                writer.WriteStringValue(OSVersion);
            }
            if (Optional.IsDefined(SxSStackVersion))
            {
                writer.WritePropertyName("sxSStackVersion");
                writer.WriteStringValue(SxSStackVersion);
            }
            if (Optional.IsDefined(UpdateState))
            {
                writer.WritePropertyName("updateState");
                writer.WriteStringValue(UpdateState.Value.ToString());
            }
            if (Optional.IsDefined(UpdateErrorMessage))
            {
                writer.WritePropertyName("updateErrorMessage");
                writer.WriteStringValue(UpdateErrorMessage);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SessionHostData DeserializeSessionHostData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> objectId = default;
            Optional<DateTimeOffset> lastHeartBeat = default;
            Optional<int> sessions = default;
            Optional<string> agentVersion = default;
            Optional<bool> allowNewSession = default;
            Optional<string> virtualMachineId = default;
            Optional<string> resourceId = default;
            Optional<string> assignedUser = default;
            Optional<SessionHostStatus> status = default;
            Optional<DateTimeOffset> statusTimestamp = default;
            Optional<string> osVersion = default;
            Optional<string> sxSStackVersion = default;
            Optional<UpdateState> updateState = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            Optional<string> updateErrorMessage = default;
            Optional<IReadOnlyList<SessionHostHealthCheckReport>> sessionHostHealthCheckResults = default;
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
                        if (property0.NameEquals("objectId"))
                        {
                            objectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastHeartBeat"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastHeartBeat = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sessions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sessions = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowNewSession"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowNewSession = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineId"))
                        {
                            virtualMachineId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"))
                        {
                            resourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("assignedUser"))
                        {
                            assignedUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new SessionHostStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statusTimestamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            statusTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("osVersion"))
                        {
                            osVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sxSStackVersion"))
                        {
                            sxSStackVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updateState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updateState = new UpdateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastUpdateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastUpdateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateErrorMessage"))
                        {
                            updateErrorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sessionHostHealthCheckResults"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SessionHostHealthCheckReport> array = new List<SessionHostHealthCheckReport>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SessionHostHealthCheckReport.DeserializeSessionHostHealthCheckReport(item));
                            }
                            sessionHostHealthCheckResults = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SessionHostData(id, name, type, systemData.Value, objectId.Value, Optional.ToNullable(lastHeartBeat), Optional.ToNullable(sessions), agentVersion.Value, Optional.ToNullable(allowNewSession), virtualMachineId.Value, resourceId.Value, assignedUser.Value, Optional.ToNullable(status), Optional.ToNullable(statusTimestamp), osVersion.Value, sxSStackVersion.Value, Optional.ToNullable(updateState), Optional.ToNullable(lastUpdateTime), updateErrorMessage.Value, Optional.ToList(sessionHostHealthCheckResults));
        }
    }
}
