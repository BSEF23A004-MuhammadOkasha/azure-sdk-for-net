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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeNodeMonitoringData : IUtf8JsonSerializable, IJsonModel<IntegrationRuntimeNodeMonitoringData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationRuntimeNodeMonitoringData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationRuntimeNodeMonitoringData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeNodeMonitoringData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(IntegrationRuntimeNodeMonitoringData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(NodeName))
            {
                writer.WritePropertyName("nodeName"u8);
                writer.WriteStringValue(NodeName);
            }
            if (options.Format != "W" && Optional.IsDefined(AvailableMemoryInMB))
            {
                writer.WritePropertyName("availableMemoryInMB"u8);
                writer.WriteNumberValue(AvailableMemoryInMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuUtilization))
            {
                writer.WritePropertyName("cpuUtilization"u8);
                writer.WriteNumberValue(CpuUtilization.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConcurrentJobsLimit))
            {
                writer.WritePropertyName("concurrentJobsLimit"u8);
                writer.WriteNumberValue(ConcurrentJobsLimit.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConcurrentJobsRunning))
            {
                writer.WritePropertyName("concurrentJobsRunning"u8);
                writer.WriteNumberValue(ConcurrentJobsRunning.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxConcurrentJobs))
            {
                writer.WritePropertyName("maxConcurrentJobs"u8);
                writer.WriteNumberValue(MaxConcurrentJobs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SentBytes))
            {
                writer.WritePropertyName("sentBytes"u8);
                writer.WriteNumberValue(SentBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReceivedBytes))
            {
                writer.WritePropertyName("receivedBytes"u8);
                writer.WriteNumberValue(ReceivedBytes.Value);
            }
            if (AdditionalProperties != null)
            {
                foreach (var item in AdditionalProperties)
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

        IntegrationRuntimeNodeMonitoringData IJsonModel<IntegrationRuntimeNodeMonitoringData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeNodeMonitoringData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(IntegrationRuntimeNodeMonitoringData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeNodeMonitoringData(document.RootElement, options);
        }

        internal static IntegrationRuntimeNodeMonitoringData DeserializeIntegrationRuntimeNodeMonitoringData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nodeName = default;
            Optional<int> availableMemoryInMB = default;
            Optional<int> cpuUtilization = default;
            Optional<int> concurrentJobsLimit = default;
            Optional<int> concurrentJobsRunning = default;
            Optional<int> maxConcurrentJobs = default;
            Optional<float> sentBytes = default;
            Optional<float> receivedBytes = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeName"u8))
                {
                    nodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availableMemoryInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableMemoryInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cpuUtilization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuUtilization = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("concurrentJobsLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("concurrentJobsRunning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsRunning = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentJobs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sentBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sentBytes = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("receivedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    receivedBytes = property.Value.GetSingle();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeNodeMonitoringData(nodeName.Value, Optional.ToNullable(availableMemoryInMB), Optional.ToNullable(cpuUtilization), Optional.ToNullable(concurrentJobsLimit), Optional.ToNullable(concurrentJobsRunning), Optional.ToNullable(maxConcurrentJobs), Optional.ToNullable(sentBytes), Optional.ToNullable(receivedBytes), additionalProperties);
        }

        BinaryData IPersistableModel<IntegrationRuntimeNodeMonitoringData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeNodeMonitoringData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(IntegrationRuntimeNodeMonitoringData)} does not support '{options.Format}' format.");
            }
        }

        IntegrationRuntimeNodeMonitoringData IPersistableModel<IntegrationRuntimeNodeMonitoringData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeNodeMonitoringData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationRuntimeNodeMonitoringData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(IntegrationRuntimeNodeMonitoringData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationRuntimeNodeMonitoringData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
