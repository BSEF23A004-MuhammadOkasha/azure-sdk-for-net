// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SqlVirtualMachine;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class AvailabilityGroupReplica : IUtf8JsonSerializable, IJsonModel<AvailabilityGroupReplica>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailabilityGroupReplica>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvailabilityGroupReplica>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupReplica>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupReplica)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SqlVmInstanceId))
            {
                writer.WritePropertyName("sqlVirtualMachineInstanceId"u8);
                writer.WriteStringValue(SqlVmInstanceId);
            }
            if (Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToString());
            }
            if (Optional.IsDefined(Commit))
            {
                writer.WritePropertyName("commit"u8);
                writer.WriteStringValue(Commit.Value.ToString());
            }
            if (Optional.IsDefined(Failover))
            {
                writer.WritePropertyName("failover"u8);
                writer.WriteStringValue(Failover.Value.ToString());
            }
            if (Optional.IsDefined(ReadableSecondary))
            {
                writer.WritePropertyName("readableSecondary"u8);
                writer.WriteStringValue(ReadableSecondary.Value.ToString());
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
            writer.WriteEndObject();
        }

        AvailabilityGroupReplica IJsonModel<AvailabilityGroupReplica>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupReplica>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupReplica)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilityGroupReplica(document.RootElement, options);
        }

        internal static AvailabilityGroupReplica DeserializeAvailabilityGroupReplica(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier sqlVmInstanceId = default;
            AvailabilityGroupReplicaRole? role = default;
            AvailabilityGroupReplicaCommitMode? commit = default;
            AvailabilityGroupReplicaFailoverMode? failover = default;
            ReadableSecondaryMode? readableSecondary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlVirtualMachineInstanceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlVmInstanceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    role = new AvailabilityGroupReplicaRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commit = new AvailabilityGroupReplicaCommitMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failover = new AvailabilityGroupReplicaFailoverMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("readableSecondary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readableSecondary = new ReadableSecondaryMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailabilityGroupReplica(
                sqlVmInstanceId,
                role,
                commit,
                failover,
                readableSecondary,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailabilityGroupReplica>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupReplica>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvailabilityGroupReplica)} does not support '{options.Format}' format.");
            }
        }

        AvailabilityGroupReplica IPersistableModel<AvailabilityGroupReplica>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupReplica>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvailabilityGroupReplica(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailabilityGroupReplica)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailabilityGroupReplica>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
