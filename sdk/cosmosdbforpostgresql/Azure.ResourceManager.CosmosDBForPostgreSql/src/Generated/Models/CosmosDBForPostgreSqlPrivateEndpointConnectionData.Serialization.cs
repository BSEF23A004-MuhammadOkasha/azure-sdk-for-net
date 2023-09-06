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
using Azure.ResourceManager.CosmosDBForPostgreSql.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    public partial class CosmosDBForPostgreSqlPrivateEndpointConnectionData : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBForPostgreSqlPrivateEndpointConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBForPostgreSqlPrivateEndpointConnectionData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBForPostgreSqlPrivateEndpointConnectionData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBForPostgreSqlPrivateEndpointConnectionData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                if (ConnectionState is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>)ConnectionState).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
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

        internal static CosmosDBForPostgreSqlPrivateEndpointConnectionData DeserializeCosmosDBForPostgreSqlPrivateEndpointConnectionData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<string>> groupIds = default;
            Optional<SubResource> privateEndpoint = default;
            Optional<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState> privateLinkServiceConnectionState = default;
            Optional<CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("groupIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            groupIds = array;
                            continue;
                        }
                        if (property0.NameEquals("privateEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateEndpoint = JsonSerializer.Deserialize<SubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceConnectionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkServiceConnectionState = CosmosDBForPostgreSqlPrivateLinkServiceConnectionState.DeserializeCosmosDBForPostgreSqlPrivateLinkServiceConnectionState(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBForPostgreSqlPrivateEndpointConnectionData(id, name, type, systemData.Value, Optional.ToList(groupIds), privateEndpoint, privateLinkServiceConnectionState.Value, Optional.ToNullable(provisioningState), rawData);
        }

        CosmosDBForPostgreSqlPrivateEndpointConnectionData IModelJsonSerializable<CosmosDBForPostgreSqlPrivateEndpointConnectionData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBForPostgreSqlPrivateEndpointConnectionData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBForPostgreSqlPrivateEndpointConnectionData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBForPostgreSqlPrivateEndpointConnectionData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBForPostgreSqlPrivateEndpointConnectionData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBForPostgreSqlPrivateEndpointConnectionData IModelSerializable<CosmosDBForPostgreSqlPrivateEndpointConnectionData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBForPostgreSqlPrivateEndpointConnectionData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBForPostgreSqlPrivateEndpointConnectionData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionData"/> to convert. </param>
        public static implicit operator RequestContent(CosmosDBForPostgreSqlPrivateEndpointConnectionData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CosmosDBForPostgreSqlPrivateEndpointConnectionData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBForPostgreSqlPrivateEndpointConnectionData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
