// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AlertProcessingRuleRemoveAllGroupsAction : IUtf8JsonSerializable, IJsonModel<AlertProcessingRuleRemoveAllGroupsAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlertProcessingRuleRemoveAllGroupsAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AlertProcessingRuleRemoveAllGroupsAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AlertProcessingRuleRemoveAllGroupsAction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
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

        AlertProcessingRuleRemoveAllGroupsAction IJsonModel<AlertProcessingRuleRemoveAllGroupsAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AlertProcessingRuleRemoveAllGroupsAction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertProcessingRuleRemoveAllGroupsAction(document.RootElement, options);
        }

        internal static AlertProcessingRuleRemoveAllGroupsAction DeserializeAlertProcessingRuleRemoveAllGroupsAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertProcessingRuleActionType actionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new AlertProcessingRuleActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AlertProcessingRuleRemoveAllGroupsAction(actionType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AlertProcessingRuleRemoveAllGroupsAction)} does not support '{options.Format}' format.");
            }
        }

        AlertProcessingRuleRemoveAllGroupsAction IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAlertProcessingRuleRemoveAllGroupsAction(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AlertProcessingRuleRemoveAllGroupsAction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
