// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectivityHopInfo : IUtf8JsonSerializable, IJsonModel<ConnectivityHopInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectivityHopInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectivityHopInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityHopInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityHopInfo)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ConnectivityHopType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ConnectivityHopType);
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(NextHopIds))
            {
                writer.WritePropertyName("nextHopIds"u8);
                writer.WriteStartArray();
                foreach (var item in NextHopIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PreviousHopIds))
            {
                writer.WritePropertyName("previousHopIds"u8);
                writer.WriteStartArray();
                foreach (var item in PreviousHopIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Links))
            {
                writer.WritePropertyName("links"u8);
                writer.WriteStartArray();
                foreach (var item in Links)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PreviousLinks))
            {
                writer.WritePropertyName("previousLinks"u8);
                writer.WriteStartArray();
                foreach (var item in PreviousLinks)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Issues))
            {
                writer.WritePropertyName("issues"u8);
                writer.WriteStartArray();
                foreach (var item in Issues)
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

        ConnectivityHopInfo IJsonModel<ConnectivityHopInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityHopInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityHopInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectivityHopInfo(document.RootElement, options);
        }

        internal static ConnectivityHopInfo DeserializeConnectivityHopInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string id = default;
            string address = default;
            ResourceIdentifier resourceId = default;
            IReadOnlyList<string> nextHopIds = default;
            IReadOnlyList<string> previousHopIds = default;
            IReadOnlyList<HopLink> links = default;
            IReadOnlyList<HopLink> previousLinks = default;
            IReadOnlyList<ConnectivityIssueInfo> issues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nextHopIds"u8))
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
                    nextHopIds = array;
                    continue;
                }
                if (property.NameEquals("previousHopIds"u8))
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
                    previousHopIds = array;
                    continue;
                }
                if (property.NameEquals("links"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HopLink> array = new List<HopLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HopLink.DeserializeHopLink(item, options));
                    }
                    links = array;
                    continue;
                }
                if (property.NameEquals("previousLinks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HopLink> array = new List<HopLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HopLink.DeserializeHopLink(item, options));
                    }
                    previousLinks = array;
                    continue;
                }
                if (property.NameEquals("issues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectivityIssueInfo> array = new List<ConnectivityIssueInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityIssueInfo.DeserializeConnectivityIssueInfo(item, options));
                    }
                    issues = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectivityHopInfo(
                type,
                id,
                address,
                resourceId,
                nextHopIds ?? new ChangeTrackingList<string>(),
                previousHopIds ?? new ChangeTrackingList<string>(),
                links ?? new ChangeTrackingList<HopLink>(),
                previousLinks ?? new ChangeTrackingList<HopLink>(),
                issues ?? new ChangeTrackingList<ConnectivityIssueInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectivityHopInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityHopInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectivityHopInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectivityHopInfo IPersistableModel<ConnectivityHopInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityHopInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectivityHopInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectivityHopInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectivityHopInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
