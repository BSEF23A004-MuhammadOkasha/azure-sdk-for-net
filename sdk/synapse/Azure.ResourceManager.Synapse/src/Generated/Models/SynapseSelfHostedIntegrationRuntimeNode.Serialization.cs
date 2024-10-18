// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSelfHostedIntegrationRuntimeNode : IUtf8JsonSerializable, IJsonModel<SynapseSelfHostedIntegrationRuntimeNode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSelfHostedIntegrationRuntimeNode>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseSelfHostedIntegrationRuntimeNode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeNode)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(NodeName))
            {
                writer.WritePropertyName("nodeName"u8);
                writer.WriteStringValue(NodeName);
            }
            if (options.Format != "W" && Optional.IsDefined(MachineName))
            {
                writer.WritePropertyName("machineName"u8);
                writer.WriteStringValue(MachineName);
            }
            if (options.Format != "W" && Optional.IsDefined(HostServiceUri))
            {
                writer.WritePropertyName("hostServiceUri"u8);
                writer.WriteStringValue(HostServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartObject();
                foreach (var item in Capabilities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(VersionStatus))
            {
                writer.WritePropertyName("versionStatus"u8);
                writer.WriteStringValue(VersionStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(RegisterOn))
            {
                writer.WritePropertyName("registerTime"u8);
                writer.WriteStringValue(RegisterOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastConnectedOn))
            {
                writer.WritePropertyName("lastConnectTime"u8);
                writer.WriteStringValue(LastConnectedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastStartedOn))
            {
                writer.WritePropertyName("lastStartTime"u8);
                writer.WriteStringValue(LastStartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastStopOn))
            {
                writer.WritePropertyName("lastStopTime"u8);
                writer.WriteStringValue(LastStopOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastUpdateResult))
            {
                writer.WritePropertyName("lastUpdateResult"u8);
                writer.WriteStringValue(LastUpdateResult.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastStartUpdateOn))
            {
                writer.WritePropertyName("lastStartUpdateTime"u8);
                writer.WriteStringValue(LastStartUpdateOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastEndUpdateOn))
            {
                writer.WritePropertyName("lastEndUpdateTime"u8);
                writer.WriteStringValue(LastEndUpdateOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(IsActiveDispatcher))
            {
                writer.WritePropertyName("isActiveDispatcher"u8);
                writer.WriteBooleanValue(IsActiveDispatcher.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConcurrentJobsLimit))
            {
                writer.WritePropertyName("concurrentJobsLimit"u8);
                writer.WriteNumberValue(ConcurrentJobsLimit.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxConcurrentJobs))
            {
                writer.WritePropertyName("maxConcurrentJobs"u8);
                writer.WriteNumberValue(MaxConcurrentJobs.Value);
            }
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

        SynapseSelfHostedIntegrationRuntimeNode IJsonModel<SynapseSelfHostedIntegrationRuntimeNode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeNode)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSelfHostedIntegrationRuntimeNode(document.RootElement, options);
        }

        internal static SynapseSelfHostedIntegrationRuntimeNode DeserializeSynapseSelfHostedIntegrationRuntimeNode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nodeName = default;
            string machineName = default;
            Uri hostServiceUri = default;
            SynapseSelfHostedIntegrationRuntimeNodeStatus? status = default;
            IReadOnlyDictionary<string, string> capabilities = default;
            string versionStatus = default;
            string version = default;
            DateTimeOffset? registerTime = default;
            DateTimeOffset? lastConnectTime = default;
            DateTimeOffset? expiryTime = default;
            DateTimeOffset? lastStartTime = default;
            DateTimeOffset? lastStopTime = default;
            SynapseIntegrationRuntimeUpdateResult? lastUpdateResult = default;
            DateTimeOffset? lastStartUpdateTime = default;
            DateTimeOffset? lastEndUpdateTime = default;
            bool? isActiveDispatcher = default;
            int? concurrentJobsLimit = default;
            int? maxConcurrentJobs = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeName"u8))
                {
                    nodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SynapseSelfHostedIntegrationRuntimeNodeStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    capabilities = dictionary;
                    continue;
                }
                if (property.NameEquals("versionStatus"u8))
                {
                    versionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastConnectTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConnectTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStopTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStopTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateResult = new SynapseIntegrationRuntimeUpdateResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastStartUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastEndUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEndUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isActiveDispatcher"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isActiveDispatcher = property.Value.GetBoolean();
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
                if (property.NameEquals("maxConcurrentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentJobs = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseSelfHostedIntegrationRuntimeNode(
                nodeName,
                machineName,
                hostServiceUri,
                status,
                capabilities ?? new ChangeTrackingDictionary<string, string>(),
                versionStatus,
                version,
                registerTime,
                lastConnectTime,
                expiryTime,
                lastStartTime,
                lastStopTime,
                lastUpdateResult,
                lastStartUpdateTime,
                lastEndUpdateTime,
                isActiveDispatcher,
                concurrentJobsLimit,
                maxConcurrentJobs,
                additionalProperties);
        }

        BinaryData IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeNode)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseSelfHostedIntegrationRuntimeNode IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSelfHostedIntegrationRuntimeNode(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeNode)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
