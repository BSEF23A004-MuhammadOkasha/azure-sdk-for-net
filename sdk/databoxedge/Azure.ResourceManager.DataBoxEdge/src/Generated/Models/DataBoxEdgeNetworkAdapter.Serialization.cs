// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeNetworkAdapter : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxEdgeNetworkAdapter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxEdgeNetworkAdapter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxEdgeNetworkAdapter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeNetworkAdapter>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RdmaStatus))
            {
                writer.WritePropertyName("rdmaStatus"u8);
                writer.WriteStringValue(RdmaStatus.Value.ToString());
            }
            if (Optional.IsDefined(DhcpStatus))
            {
                writer.WritePropertyName("dhcpStatus"u8);
                writer.WriteStringValue(DhcpStatus.Value.ToString());
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static DataBoxEdgeNetworkAdapter DeserializeDataBoxEdgeNetworkAdapter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> adapterId = default;
            Optional<DataBoxEdgeNetworkAdapterPosition> adapterPosition = default;
            Optional<int> index = default;
            Optional<Guid> nodeId = default;
            Optional<string> networkAdapterName = default;
            Optional<string> label = default;
            Optional<string> macAddress = default;
            Optional<long> linkSpeed = default;
            Optional<DataBoxEdgeNetworkAdapterStatus> status = default;
            Optional<DataBoxEdgeNetworkAdapterRdmaStatus> rdmaStatus = default;
            Optional<DataBoxEdgeNetworkAdapterDhcpStatus> dhcpStatus = default;
            Optional<DataBoxEdgeIPv4Config> ipv4Configuration = default;
            Optional<DataBoxEdgeIPv6Config> ipv6Configuration = default;
            Optional<string> ipv6LinkLocalAddress = default;
            Optional<IReadOnlyList<string>> dnsServers = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adapterId"u8))
                {
                    adapterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adapterPosition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    adapterPosition = DataBoxEdgeNetworkAdapterPosition.DeserializeDataBoxEdgeNetworkAdapterPosition(property.Value);
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("networkAdapterName"u8))
                {
                    networkAdapterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkSpeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkSpeed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataBoxEdgeNetworkAdapterStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rdmaStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rdmaStatus = new DataBoxEdgeNetworkAdapterRdmaStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dhcpStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dhcpStatus = new DataBoxEdgeNetworkAdapterDhcpStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipv4Configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv4Configuration = DataBoxEdgeIPv4Config.DeserializeDataBoxEdgeIPv4Config(property.Value);
                    continue;
                }
                if (property.NameEquals("ipv6Configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv6Configuration = DataBoxEdgeIPv6Config.DeserializeDataBoxEdgeIPv6Config(property.Value);
                    continue;
                }
                if (property.NameEquals("ipv6LinkLocalAddress"u8))
                {
                    ipv6LinkLocalAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
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
                    dnsServers = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxEdgeNetworkAdapter(adapterId.Value, adapterPosition.Value, Optional.ToNullable(index), Optional.ToNullable(nodeId), networkAdapterName.Value, label.Value, macAddress.Value, Optional.ToNullable(linkSpeed), Optional.ToNullable(status), Optional.ToNullable(rdmaStatus), Optional.ToNullable(dhcpStatus), ipv4Configuration.Value, ipv6Configuration.Value, ipv6LinkLocalAddress.Value, Optional.ToList(dnsServers), rawData);
        }

        DataBoxEdgeNetworkAdapter IModelJsonSerializable<DataBoxEdgeNetworkAdapter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeNetworkAdapter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeNetworkAdapter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxEdgeNetworkAdapter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeNetworkAdapter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxEdgeNetworkAdapter IModelSerializable<DataBoxEdgeNetworkAdapter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeNetworkAdapter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxEdgeNetworkAdapter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataBoxEdgeNetworkAdapter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataBoxEdgeNetworkAdapter"/> to convert. </param>
        public static implicit operator RequestContent(DataBoxEdgeNetworkAdapter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataBoxEdgeNetworkAdapter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataBoxEdgeNetworkAdapter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxEdgeNetworkAdapter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
