// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class JobStepData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StepId))
            {
                writer.WritePropertyName("stepId");
                writer.WriteNumberValue(StepId.Value);
            }
            if (Optional.IsDefined(TargetGroup))
            {
                writer.WritePropertyName("targetGroup");
                writer.WriteStringValue(TargetGroup);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential");
                writer.WriteStringValue(Credential);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action");
                writer.WriteObjectValue(Action);
            }
            if (Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output");
                writer.WriteObjectValue(Output);
            }
            if (Optional.IsDefined(ExecutionOptions))
            {
                writer.WritePropertyName("executionOptions");
                writer.WriteObjectValue(ExecutionOptions);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static JobStepData DeserializeJobStepData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> stepId = default;
            Optional<string> targetGroup = default;
            Optional<string> credential = default;
            Optional<JobStepAction> action = default;
            Optional<JobStepOutput> output = default;
            Optional<JobStepExecutionOptions> executionOptions = default;
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
                        if (property0.NameEquals("stepId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            stepId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("targetGroup"))
                        {
                            targetGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("credential"))
                        {
                            credential = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("action"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            action = JobStepAction.DeserializeJobStepAction(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("output"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            output = JobStepOutput.DeserializeJobStepOutput(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("executionOptions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            executionOptions = JobStepExecutionOptions.DeserializeJobStepExecutionOptions(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new JobStepData(id, name, type, systemData.Value, Optional.ToNullable(stepId), targetGroup.Value, credential.Value, action.Value, output.Value, executionOptions.Value);
        }
    }
}
