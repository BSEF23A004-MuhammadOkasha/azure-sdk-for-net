// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationJobData : IUtf8JsonSerializable, IJsonModel<AutomationJobData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationJobData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationJobData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationJobData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationJobData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Runbook != null)
            {
                writer.WritePropertyName("runbook"u8);
                writer.WriteObjectValue(Runbook);
            }
            if (StartedBy != null)
            {
                writer.WritePropertyName("startedBy"u8);
                writer.WriteStringValue(StartedBy);
            }
            if (RunOn != null)
            {
                writer.WritePropertyName("runOn"u8);
                writer.WriteStringValue(RunOn);
            }
            if (JobId.HasValue)
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId.Value);
            }
            if (CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (StatusDetails != null)
            {
                writer.WritePropertyName("statusDetails"u8);
                writer.WriteStringValue(StatusDetails);
            }
            if (StartOn.HasValue)
            {
                if (StartOn != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (EndOn.HasValue)
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (Exception != null)
            {
                writer.WritePropertyName("exception"u8);
                writer.WriteStringValue(Exception);
            }
            if (LastModifiedOn.HasValue)
            {
                if (LastModifiedOn != null)
                {
                    writer.WritePropertyName("lastModifiedTime"u8);
                    writer.WriteStringValue(LastModifiedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("lastModifiedTime");
                }
            }
            if (LastStatusModifiedOn.HasValue)
            {
                if (LastStatusModifiedOn != null)
                {
                    writer.WritePropertyName("lastStatusModifiedTime"u8);
                    writer.WriteStringValue(LastStatusModifiedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("lastStatusModifiedTime");
                }
            }
            if (!(Parameters is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        AutomationJobData IJsonModel<AutomationJobData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationJobData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationJobData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationJobData(document.RootElement, options);
        }

        internal static AutomationJobData DeserializeAutomationJobData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            RunbookAssociationProperty runbook = default;
            string startedBy = default;
            string runOn = default;
            Guid? jobId = default;
            DateTimeOffset? creationTime = default;
            AutomationJobStatus? status = default;
            string statusDetails = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            string exception = default;
            DateTimeOffset? lastModifiedTime = default;
            DateTimeOffset? lastStatusModifiedTime = default;
            IDictionary<string, string> parameters = default;
            JobProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("runbook"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runbook = RunbookAssociationProperty.DeserializeRunbookAssociationProperty(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("startedBy"u8))
                        {
                            startedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("runOn"u8))
                        {
                            runOn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("jobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jobId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new AutomationJobStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statusDetails"u8))
                        {
                            statusDetails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                startTime = null;
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                endTime = null;
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("exception"u8))
                        {
                            exception = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                lastModifiedTime = null;
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastStatusModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                lastStatusModifiedTime = null;
                                continue;
                            }
                            lastStatusModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new JobProvisioningState(property0.Value.GetString());
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
            return new AutomationJobData(
                id,
                name,
                type,
                systemData,
                runbook,
                startedBy,
                runOn,
                jobId,
                creationTime,
                status,
                statusDetails,
                startTime,
                endTime,
                exception,
                lastModifiedTime,
                lastStatusModifiedTime,
                parameters ?? new ChangeTrackingDictionary<string, string>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationJobData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationJobData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationJobData)} does not support '{options.Format}' format.");
            }
        }

        AutomationJobData IPersistableModel<AutomationJobData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationJobData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationJobData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationJobData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationJobData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
