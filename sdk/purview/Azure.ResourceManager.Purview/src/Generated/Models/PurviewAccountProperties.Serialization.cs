// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    public partial class PurviewAccountProperties : IUtf8JsonSerializable, IJsonModel<PurviewAccountProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PurviewAccountProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PurviewAccountProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurviewAccountProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(AccountStatus))
            {
                writer.WritePropertyName("accountStatus"u8);
                writer.WriteObjectValue(AccountStatus, options);
            }
            if (Optional.IsDefined(CloudConnectors))
            {
                writer.WritePropertyName("cloudConnectors"u8);
                writer.WriteObjectValue(CloudConnectors, options);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedByObjectId))
            {
                writer.WritePropertyName("createdByObjectId"u8);
                writer.WriteStringValue(CreatedByObjectId);
            }
            if (options.Format != "W" && Optional.IsDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteObjectValue(Endpoints, options);
            }
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(IngestionStorage))
            {
                writer.WritePropertyName("ingestionStorage"u8);
                writer.WriteObjectValue(IngestionStorage, options);
            }
            if (Optional.IsDefined(ManagedEventHubState))
            {
                writer.WritePropertyName("managedEventHubState"u8);
                writer.WriteStringValue(ManagedEventHubState.Value.ToString());
            }
            if (Optional.IsDefined(ManagedResourceGroupName))
            {
                writer.WritePropertyName("managedResourceGroupName"u8);
                writer.WriteStringValue(ManagedResourceGroupName);
            }
            if (options.Format != "W" && Optional.IsDefined(ManagedResources))
            {
                writer.WritePropertyName("managedResources"u8);
                writer.WriteObjectValue(ManagedResources, options);
            }
            if (Optional.IsDefined(ManagedResourcesPublicNetworkAccess))
            {
                writer.WritePropertyName("managedResourcesPublicNetworkAccess"u8);
                writer.WriteStringValue(ManagedResourcesPublicNetworkAccess.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
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
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
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

        PurviewAccountProperties IJsonModel<PurviewAccountProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurviewAccountProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePurviewAccountProperties(document.RootElement, options);
        }

        internal static PurviewAccountProperties DeserializePurviewAccountProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PurviewAccountStatus accountStatus = default;
            CloudConnectors cloudConnectors = default;
            DateTimeOffset? createdAt = default;
            string createdBy = default;
            string createdByObjectId = default;
            PurviewAccountEndpoint endpoints = default;
            string friendlyName = default;
            PurviewIngestionStorage ingestionStorage = default;
            PurviewManagedEventHubState? managedEventHubState = default;
            string managedResourceGroupName = default;
            PurviewManagedResource managedResources = default;
            ManagedResourcesPublicNetworkAccess? managedResourcesPublicNetworkAccess = default;
            IReadOnlyList<PurviewPrivateEndpointConnectionData> privateEndpointConnections = default;
            PurviewProvisioningState? provisioningState = default;
            PurviewPublicNetworkAccess? publicNetworkAccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountStatus = PurviewAccountStatus.DeserializePurviewAccountStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("cloudConnectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudConnectors = CloudConnectors.DeserializeCloudConnectors(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdByObjectId"u8))
                {
                    createdByObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpoints = PurviewAccountEndpoint.DeserializePurviewAccountEndpoint(property.Value, options);
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ingestionStorage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingestionStorage = PurviewIngestionStorage.DeserializePurviewIngestionStorage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("managedEventHubState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedEventHubState = new PurviewManagedEventHubState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedResourceGroupName"u8))
                {
                    managedResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedResources = PurviewManagedResource.DeserializePurviewManagedResource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("managedResourcesPublicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedResourcesPublicNetworkAccess = new ManagedResourcesPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PurviewPrivateEndpointConnectionData> array = new List<PurviewPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PurviewPrivateEndpointConnectionData.DeserializePurviewPrivateEndpointConnectionData(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new PurviewProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PurviewPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PurviewAccountProperties(
                accountStatus,
                cloudConnectors,
                createdAt,
                createdBy,
                createdByObjectId,
                endpoints,
                friendlyName,
                ingestionStorage,
                managedEventHubState,
                managedResourceGroupName,
                managedResources,
                managedResourcesPublicNetworkAccess,
                privateEndpointConnections ?? new ChangeTrackingList<PurviewPrivateEndpointConnectionData>(),
                provisioningState,
                publicNetworkAccess,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PurviewAccountProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PurviewAccountProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PurviewAccountProperties IPersistableModel<PurviewAccountProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePurviewAccountProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PurviewAccountProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PurviewAccountProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
