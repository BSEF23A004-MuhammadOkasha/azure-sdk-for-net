// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryJobProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryJobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryJobProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SiteRecoveryJobProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActivityId))
            {
                writer.WritePropertyName("activityId"u8);
                writer.WriteStringValue(ActivityId);
            }
            if (Optional.IsDefined(ScenarioName))
            {
                writer.WritePropertyName("scenarioName"u8);
                writer.WriteStringValue(ScenarioName);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(StateDescription))
            {
                writer.WritePropertyName("stateDescription"u8);
                writer.WriteStringValue(StateDescription);
            }
            if (Optional.IsCollectionDefined(Tasks))
            {
                writer.WritePropertyName("tasks"u8);
                writer.WriteStartArray();
                foreach (var item in Tasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(AllowedActions))
            {
                writer.WritePropertyName("allowedActions"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetObjectId))
            {
                writer.WritePropertyName("targetObjectId"u8);
                writer.WriteStringValue(TargetObjectId);
            }
            if (Optional.IsDefined(TargetObjectName))
            {
                writer.WritePropertyName("targetObjectName"u8);
                writer.WriteStringValue(TargetObjectName);
            }
            if (Optional.IsDefined(TargetInstanceType))
            {
                writer.WritePropertyName("targetInstanceType"u8);
                writer.WriteStringValue(TargetInstanceType);
            }
            if (Optional.IsDefined(CustomDetails))
            {
                writer.WritePropertyName("customDetails"u8);
                writer.WriteObjectValue(CustomDetails);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SiteRecoveryJobProperties IJsonModel<SiteRecoveryJobProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryJobProperties(document.RootElement, options);
        }

        internal static SiteRecoveryJobProperties DeserializeSiteRecoveryJobProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> activityId = default;
            Optional<string> scenarioName = default;
            Optional<string> friendlyName = default;
            Optional<string> state = default;
            Optional<string> stateDescription = default;
            Optional<IReadOnlyList<AsrTask>> tasks = default;
            Optional<IReadOnlyList<SiteRecoveryJobErrorDetails>> errors = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<IReadOnlyList<string>> allowedActions = default;
            Optional<string> targetObjectId = default;
            Optional<string> targetObjectName = default;
            Optional<string> targetInstanceType = default;
            Optional<SiteRecoveryJobDetails> customDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activityId"u8))
                {
                    activityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scenarioName"u8))
                {
                    scenarioName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateDescription"u8))
                {
                    stateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AsrTask> array = new List<AsrTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AsrTask.DeserializeAsrTask(item));
                    }
                    tasks = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryJobErrorDetails> array = new List<SiteRecoveryJobErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryJobErrorDetails.DeserializeSiteRecoveryJobErrorDetails(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("allowedActions"u8))
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
                    allowedActions = array;
                    continue;
                }
                if (property.NameEquals("targetObjectId"u8))
                {
                    targetObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetObjectName"u8))
                {
                    targetObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetInstanceType"u8))
                {
                    targetInstanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDetails = SiteRecoveryJobDetails.DeserializeSiteRecoveryJobDetails(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryJobProperties(activityId.Value, scenarioName.Value, friendlyName.Value, state.Value, stateDescription.Value, Optional.ToList(tasks), Optional.ToList(errors), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToList(allowedActions), targetObjectId.Value, targetObjectName.Value, targetInstanceType.Value, customDetails.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<SiteRecoveryJobProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SiteRecoveryJobProperties IModel<SiteRecoveryJobProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryJobProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SiteRecoveryJobProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
