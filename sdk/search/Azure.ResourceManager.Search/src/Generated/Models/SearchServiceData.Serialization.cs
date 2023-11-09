// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    public partial class SearchServiceData : IUtf8JsonSerializable, IJsonModel<SearchServiceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchServiceData>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SearchServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ReplicaCount))
            {
                writer.WritePropertyName("replicaCount"u8);
                writer.WriteNumberValue(ReplicaCount.Value);
            }
            if (Optional.IsDefined(PartitionCount))
            {
                writer.WritePropertyName("partitionCount"u8);
                writer.WriteNumberValue(PartitionCount.Value);
            }
            if (Optional.IsDefined(HostingMode))
            {
                writer.WritePropertyName("hostingMode"u8);
                writer.WriteStringValue(HostingMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToSerialString());
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToSerialString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(StatusDetails))
                {
                    writer.WritePropertyName("statusDetails"u8);
                    writer.WriteStringValue(StatusDetails);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
                }
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                writer.WritePropertyName("networkRuleSet"u8);
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (Optional.IsDefined(EncryptionWithCmk))
            {
                writer.WritePropertyName("encryptionWithCmk"u8);
                writer.WriteObjectValue(EncryptionWithCmk);
            }
            if (Optional.IsDefined(IsLocalAuthDisabled))
            {
                if (IsLocalAuthDisabled != null)
                {
                    writer.WritePropertyName("disableLocalAuth"u8);
                    writer.WriteBooleanValue(IsLocalAuthDisabled.Value);
                }
                else
                {
                    writer.WriteNull("disableLocalAuth");
                }
            }
            if (Optional.IsDefined(AuthOptions))
            {
                writer.WritePropertyName("authOptions"u8);
                writer.WriteObjectValue(AuthOptions);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(PrivateEndpointConnections))
                {
                    writer.WritePropertyName("privateEndpointConnections"u8);
                    writer.WriteStartArray();
                    foreach (var item in PrivateEndpointConnections)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (Optional.IsDefined(SemanticSearch))
            {
                if (SemanticSearch != null)
                {
                    writer.WritePropertyName("semanticSearch"u8);
                    writer.WriteStringValue(SemanticSearch.Value.ToString());
                }
                else
                {
                    writer.WriteNull("semanticSearch");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(SharedPrivateLinkResources))
                {
                    writer.WritePropertyName("sharedPrivateLinkResources"u8);
                    writer.WriteStartArray();
                    foreach (var item in SharedPrivateLinkResources)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SearchServiceData IJsonModel<SearchServiceData>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchServiceData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchServiceData(document.RootElement, options);
        }

        internal static SearchServiceData DeserializeSearchServiceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SearchSku> sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> replicaCount = default;
            Optional<int> partitionCount = default;
            Optional<SearchServiceHostingMode> hostingMode = default;
            Optional<SearchServicePublicNetworkAccess> publicNetworkAccess = default;
            Optional<SearchServiceStatus> status = default;
            Optional<string> statusDetails = default;
            Optional<SearchServiceProvisioningState> provisioningState = default;
            Optional<NetworkRuleSet> networkRuleSet = default;
            Optional<SearchEncryptionWithCmk> encryptionWithCmk = default;
            Optional<bool?> disableLocalAuth = default;
            Optional<SearchAadAuthDataPlaneAuthOptions> authOptions = default;
            Optional<IReadOnlyList<SearchPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<SearchSemanticSearch?> semanticSearch = default;
            Optional<IReadOnlyList<SharedSearchServicePrivateLinkResourceData>> sharedPrivateLinkResources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SearchSku.DeserializeSearchSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("replicaCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicaCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("partitionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partitionCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("hostingMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostingMode = property0.Value.GetString().ToSearchServiceHostingMode();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = property0.Value.GetString().ToSearchServicePublicNetworkAccess();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToSearchServiceStatus();
                            continue;
                        }
                        if (property0.NameEquals("statusDetails"u8))
                        {
                            statusDetails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToSearchServiceProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("networkRuleSet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkRuleSet = NetworkRuleSet.DeserializeNetworkRuleSet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryptionWithCmk"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionWithCmk = SearchEncryptionWithCmk.DeserializeSearchEncryptionWithCmk(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                disableLocalAuth = null;
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("authOptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authOptions = SearchAadAuthDataPlaneAuthOptions.DeserializeSearchAadAuthDataPlaneAuthOptions(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SearchPrivateEndpointConnectionData> array = new List<SearchPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SearchPrivateEndpointConnectionData.DeserializeSearchPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("semanticSearch"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                semanticSearch = null;
                                continue;
                            }
                            semanticSearch = new SearchSemanticSearch(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SharedSearchServicePrivateLinkResourceData> array = new List<SharedSearchServicePrivateLinkResourceData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SharedSearchServicePrivateLinkResourceData.DeserializeSharedSearchServicePrivateLinkResourceData(item));
                            }
                            sharedPrivateLinkResources = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchServiceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, identity, Optional.ToNullable(replicaCount), Optional.ToNullable(partitionCount), Optional.ToNullable(hostingMode), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(status), statusDetails.Value, Optional.ToNullable(provisioningState), networkRuleSet.Value, encryptionWithCmk.Value, Optional.ToNullable(disableLocalAuth), authOptions.Value, Optional.ToList(privateEndpointConnections), Optional.ToNullable(semanticSearch), Optional.ToList(sharedPrivateLinkResources), serializedAdditionalRawData);
        }

        BinaryData IModel<SearchServiceData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchServiceData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SearchServiceData IModel<SearchServiceData>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchServiceData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSearchServiceData(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SearchServiceData>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
