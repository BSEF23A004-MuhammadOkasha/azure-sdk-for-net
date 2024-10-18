// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetworkSiblingSet : IUtf8JsonSerializable, IJsonModel<NetworkSiblingSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSiblingSet>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkSiblingSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSiblingSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSiblingSet)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(NetworkSiblingSetId))
            {
                writer.WritePropertyName("networkSiblingSetId"u8);
                writer.WriteStringValue(NetworkSiblingSetId);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(NetworkSiblingSetStateId))
            {
                writer.WritePropertyName("networkSiblingSetStateId"u8);
                writer.WriteStringValue(NetworkSiblingSetStateId);
            }
            if (Optional.IsDefined(NetworkFeatures))
            {
                writer.WritePropertyName("networkFeatures"u8);
                writer.WriteStringValue(NetworkFeatures.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NicInfoList))
            {
                writer.WritePropertyName("nicInfoList"u8);
                writer.WriteStartArray();
                foreach (var item in NicInfoList)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        NetworkSiblingSet IJsonModel<NetworkSiblingSet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSiblingSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSiblingSet)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSiblingSet(document.RootElement, options);
        }

        internal static NetworkSiblingSet DeserializeNetworkSiblingSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string networkSiblingSetId = default;
            ResourceIdentifier subnetId = default;
            string networkSiblingSetStateId = default;
            NetAppNetworkFeature? networkFeatures = default;
            NetworkSiblingSetProvisioningState? provisioningState = default;
            IReadOnlyList<NicInfo> nicInfoList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkSiblingSetId"u8))
                {
                    networkSiblingSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkSiblingSetStateId"u8))
                {
                    networkSiblingSetStateId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkFeatures = new NetAppNetworkFeature(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new NetworkSiblingSetProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nicInfoList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NicInfo> array = new List<NicInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NicInfo.DeserializeNicInfo(item, options));
                    }
                    nicInfoList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkSiblingSet(
                networkSiblingSetId,
                subnetId,
                networkSiblingSetStateId,
                networkFeatures,
                provisioningState,
                nicInfoList ?? new ChangeTrackingList<NicInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkSiblingSet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSiblingSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSiblingSet)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkSiblingSet IPersistableModel<NetworkSiblingSet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSiblingSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkSiblingSet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSiblingSet)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSiblingSet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
