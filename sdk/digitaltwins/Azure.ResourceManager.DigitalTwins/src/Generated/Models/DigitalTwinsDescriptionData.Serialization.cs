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
using Azure.ResourceManager.DigitalTwins.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    public partial class DigitalTwinsDescriptionData : IUtf8JsonSerializable, IModelJsonSerializable<DigitalTwinsDescriptionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DigitalTwinsDescriptionData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DigitalTwinsDescriptionData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                if (PrivateEndpointConnections != null)
                {
                    writer.WritePropertyName("privateEndpointConnections"u8);
                    writer.WriteStartArray();
                    foreach (var item in PrivateEndpointConnections)
                    {
                        if (item is null)
                        {
                            writer.WriteNullValue();
                        }
                        else
                        {
                            ((IModelJsonSerializable<DigitalTwinsPrivateEndpointConnectionData>)item).Serialize(writer, options);
                        }
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("privateEndpointConnections");
                }
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                if (PublicNetworkAccess != null)
                {
                    writer.WritePropertyName("publicNetworkAccess"u8);
                    writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
                }
                else
                {
                    writer.WriteNull("publicNetworkAccess");
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

        internal static DigitalTwinsDescriptionData DeserializeDigitalTwinsDescriptionData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> lastUpdatedTime = default;
            Optional<DigitalTwinsProvisioningState> provisioningState = default;
            Optional<string> hostName = default;
            Optional<IList<DigitalTwinsPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<DigitalTwinsPublicNetworkAccess?> publicNetworkAccess = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
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
                        if (property0.NameEquals("createdTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DigitalTwinsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                hostName = null;
                                continue;
                            }
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                privateEndpointConnections = null;
                                continue;
                            }
                            List<DigitalTwinsPrivateEndpointConnectionData> array = new List<DigitalTwinsPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DigitalTwinsPrivateEndpointConnectionData.DeserializeDigitalTwinsPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                publicNetworkAccess = null;
                                continue;
                            }
                            publicNetworkAccess = new DigitalTwinsPublicNetworkAccess(property0.Value.GetString());
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
            return new DigitalTwinsDescriptionData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(createdTime), Optional.ToNullable(lastUpdatedTime), Optional.ToNullable(provisioningState), hostName.Value, Optional.ToList(privateEndpointConnections), Optional.ToNullable(publicNetworkAccess), identity, rawData);
        }

        DigitalTwinsDescriptionData IModelJsonSerializable<DigitalTwinsDescriptionData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsDescriptionData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DigitalTwinsDescriptionData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DigitalTwinsDescriptionData IModelSerializable<DigitalTwinsDescriptionData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDigitalTwinsDescriptionData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DigitalTwinsDescriptionData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DigitalTwinsDescriptionData"/> to convert. </param>
        public static implicit operator RequestContent(DigitalTwinsDescriptionData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DigitalTwinsDescriptionData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DigitalTwinsDescriptionData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDigitalTwinsDescriptionData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
