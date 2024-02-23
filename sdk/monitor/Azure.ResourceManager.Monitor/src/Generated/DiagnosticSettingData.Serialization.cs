// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class DiagnosticSettingData : IUtf8JsonSerializable, IJsonModel<DiagnosticSettingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiagnosticSettingData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiagnosticSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticSettingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support '{format}' format.");
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
            if (StorageAccountId != null)
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (ServiceBusRuleId != null)
            {
                writer.WritePropertyName("serviceBusRuleId"u8);
                writer.WriteStringValue(ServiceBusRuleId);
            }
            if (EventHubAuthorizationRuleId != null)
            {
                writer.WritePropertyName("eventHubAuthorizationRuleId"u8);
                writer.WriteStringValue(EventHubAuthorizationRuleId);
            }
            if (EventHubName != null)
            {
                writer.WritePropertyName("eventHubName"u8);
                writer.WriteStringValue(EventHubName);
            }
            if (!(Metrics is ChangeTrackingList<MetricSettings> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Logs is ChangeTrackingList<LogSettings> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("logs"u8);
                writer.WriteStartArray();
                foreach (var item in Logs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (WorkspaceId != null)
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (MarketplacePartnerId != null)
            {
                writer.WritePropertyName("marketplacePartnerId"u8);
                writer.WriteStringValue(MarketplacePartnerId);
            }
            if (LogAnalyticsDestinationType != null)
            {
                writer.WritePropertyName("logAnalyticsDestinationType"u8);
                writer.WriteStringValue(LogAnalyticsDestinationType);
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

        DiagnosticSettingData IJsonModel<DiagnosticSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticSettingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticSettingData(document.RootElement, options);
        }

        internal static DiagnosticSettingData DeserializeDiagnosticSettingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<ResourceIdentifier> serviceBusRuleId = default;
            Optional<ResourceIdentifier> eventHubAuthorizationRuleId = default;
            Optional<string> eventHubName = default;
            IList<MetricSettings> metrics = default;
            IList<LogSettings> logs = default;
            Optional<ResourceIdentifier> workspaceId = default;
            Optional<ResourceIdentifier> marketplacePartnerId = default;
            Optional<string> logAnalyticsDestinationType = default;
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
                        if (property0.NameEquals("storageAccountId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceBusRuleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceBusRuleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventHubAuthorizationRuleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventHubAuthorizationRuleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventHubName"u8))
                        {
                            eventHubName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MetricSettings> array = new List<MetricSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MetricSettings.DeserializeMetricSettings(item, options));
                            }
                            metrics = array;
                            continue;
                        }
                        if (property0.NameEquals("logs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LogSettings> array = new List<LogSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LogSettings.DeserializeLogSettings(item, options));
                            }
                            logs = array;
                            continue;
                        }
                        if (property0.NameEquals("workspaceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplacePartnerId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketplacePartnerId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsDestinationType"u8))
                        {
                            logAnalyticsDestinationType = property0.Value.GetString();
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
            return new DiagnosticSettingData(id, name, type, systemData.Value, storageAccountId.Value, serviceBusRuleId.Value, eventHubAuthorizationRuleId.Value, eventHubName.Value, metrics ?? new ChangeTrackingList<MetricSettings>(), logs ?? new ChangeTrackingList<LogSettings>(), workspaceId.Value, marketplacePartnerId.Value, logAnalyticsDestinationType.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiagnosticSettingData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticSettingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support '{options.Format}' format.");
            }
        }

        DiagnosticSettingData IPersistableModel<DiagnosticSettingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticSettingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiagnosticSettingData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiagnosticSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
