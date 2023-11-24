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

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppReplicationObject : IUtf8JsonSerializable, IJsonModel<NetAppReplicationObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppReplicationObject>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppReplicationObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppReplicationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(NetAppReplicationObject)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ReplicationId))
            {
                writer.WritePropertyName("replicationId"u8);
                writer.WriteStringValue(ReplicationId);
            }
            if (Optional.IsDefined(EndpointType))
            {
                writer.WritePropertyName("endpointType"u8);
                writer.WriteStringValue(EndpointType.Value.ToString());
            }
            if (Optional.IsDefined(ReplicationSchedule))
            {
                writer.WritePropertyName("replicationSchedule"u8);
                writer.WriteStringValue(ReplicationSchedule.Value.ToString());
            }
            writer.WritePropertyName("remoteVolumeResourceId"u8);
            writer.WriteStringValue(RemoteVolumeResourceId);
            if (Optional.IsDefined(RemoteVolumeRegion))
            {
                writer.WritePropertyName("remoteVolumeRegion"u8);
                writer.WriteStringValue(RemoteVolumeRegion);
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

        NetAppReplicationObject IJsonModel<NetAppReplicationObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppReplicationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(NetAppReplicationObject)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppReplicationObject(document.RootElement, options);
        }

        internal static NetAppReplicationObject DeserializeNetAppReplicationObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> replicationId = default;
            Optional<NetAppEndpointType> endpointType = default;
            Optional<NetAppReplicationSchedule> replicationSchedule = default;
            ResourceIdentifier remoteVolumeResourceId = default;
            Optional<string> remoteVolumeRegion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicationId"u8))
                {
                    replicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpointType = new NetAppEndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationSchedule = new NetAppReplicationSchedule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteVolumeResourceId"u8))
                {
                    remoteVolumeResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteVolumeRegion"u8))
                {
                    remoteVolumeRegion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppReplicationObject(replicationId.Value, Optional.ToNullable(endpointType), Optional.ToNullable(replicationSchedule), remoteVolumeResourceId, remoteVolumeRegion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppReplicationObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppReplicationObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(NetAppReplicationObject)} does not support '{options.Format}' format.");
            }
        }

        NetAppReplicationObject IPersistableModel<NetAppReplicationObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppReplicationObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppReplicationObject(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(NetAppReplicationObject)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppReplicationObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
