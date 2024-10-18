// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicMonitoredSubscriptionProperties : IUtf8JsonSerializable, IJsonModel<NewRelicMonitoredSubscriptionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicMonitoredSubscriptionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NewRelicMonitoredSubscriptionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicMonitoredSubscriptionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicMonitoredSubscriptionProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PatchOperation))
            {
                writer.WritePropertyName("patchOperation"u8);
                writer.WriteStringValue(PatchOperation.Value.ToString());
            }
            if (Optional.IsCollectionDefined(MonitoredSubscriptionList))
            {
                writer.WritePropertyName("monitoredSubscriptionList"u8);
                writer.WriteStartArray();
                foreach (var item in MonitoredSubscriptionList)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
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
        }

        NewRelicMonitoredSubscriptionProperties IJsonModel<NewRelicMonitoredSubscriptionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicMonitoredSubscriptionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicMonitoredSubscriptionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicMonitoredSubscriptionProperties(document.RootElement, options);
        }

        internal static NewRelicMonitoredSubscriptionProperties DeserializeNewRelicMonitoredSubscriptionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitoredSubscriptionPatchOperation? patchOperation = default;
            IList<NewRelicMonitoredSubscriptionInfo> monitoredSubscriptionList = default;
            NewRelicProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchOperation = new MonitoredSubscriptionPatchOperation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitoredSubscriptionList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NewRelicMonitoredSubscriptionInfo> array = new List<NewRelicMonitoredSubscriptionInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewRelicMonitoredSubscriptionInfo.DeserializeNewRelicMonitoredSubscriptionInfo(item, options));
                    }
                    monitoredSubscriptionList = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new NewRelicProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NewRelicMonitoredSubscriptionProperties(patchOperation, monitoredSubscriptionList ?? new ChangeTrackingList<NewRelicMonitoredSubscriptionInfo>(), provisioningState, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PatchOperation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  patchOperation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PatchOperation))
                {
                    builder.Append("  patchOperation: ");
                    builder.AppendLine($"'{PatchOperation.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MonitoredSubscriptionList), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  monitoredSubscriptionList: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(MonitoredSubscriptionList))
                {
                    if (MonitoredSubscriptionList.Any())
                    {
                        builder.Append("  monitoredSubscriptionList: ");
                        builder.AppendLine("[");
                        foreach (var item in MonitoredSubscriptionList)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  monitoredSubscriptionList: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NewRelicMonitoredSubscriptionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicMonitoredSubscriptionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicMonitoredSubscriptionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NewRelicMonitoredSubscriptionProperties IPersistableModel<NewRelicMonitoredSubscriptionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicMonitoredSubscriptionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewRelicMonitoredSubscriptionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicMonitoredSubscriptionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicMonitoredSubscriptionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
