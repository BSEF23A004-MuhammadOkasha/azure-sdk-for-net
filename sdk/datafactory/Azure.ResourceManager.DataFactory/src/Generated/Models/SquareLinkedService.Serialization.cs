// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SquareLinkedService : IUtf8JsonSerializable, IModelJsonSerializable<SquareLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SquareLinkedService>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SquareLinkedService>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SquareLinkedService>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                if (ConnectVia is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IntegrationRuntimeReference>)ConnectVia).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<EntityParameterSpecification>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionProperties))
            {
                writer.WritePropertyName("connectionProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ConnectionProperties);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ConnectionProperties.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                JsonSerializer.Serialize(writer, Host);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                JsonSerializer.Serialize(writer, ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                JsonSerializer.Serialize(writer, ClientSecret);
            }
            if (Optional.IsDefined(RedirectUri))
            {
                writer.WritePropertyName("redirectUri"u8);
                JsonSerializer.Serialize(writer, RedirectUri);
            }
            if (Optional.IsDefined(UseEncryptedEndpoints))
            {
                writer.WritePropertyName("useEncryptedEndpoints"u8);
                JsonSerializer.Serialize(writer, UseEncryptedEndpoints);
            }
            if (Optional.IsDefined(UseHostVerification))
            {
                writer.WritePropertyName("useHostVerification"u8);
                JsonSerializer.Serialize(writer, UseHostVerification);
            }
            if (Optional.IsDefined(UsePeerVerification))
            {
                writer.WritePropertyName("usePeerVerification"u8);
                JsonSerializer.Serialize(writer, UsePeerVerification);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static SquareLinkedService DeserializeSquareLinkedService(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<BinaryData> connectionProperties = default;
            Optional<DataFactoryElement<string>> host = default;
            Optional<DataFactoryElement<string>> clientId = default;
            Optional<DataFactorySecretBaseDefinition> clientSecret = default;
            Optional<DataFactoryElement<string>> redirectUri = default;
            Optional<DataFactoryElement<bool>> useEncryptedEndpoints = default;
            Optional<DataFactoryElement<bool>> useHostVerification = default;
            Optional<DataFactoryElement<bool>> usePeerVerification = default;
            Optional<string> encryptedCredential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("connectionProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("host"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            host = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientSecret = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("redirectUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redirectUri = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("useEncryptedEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useEncryptedEndpoints = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("useHostVerification"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useHostVerification = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("usePeerVerification"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePeerVerification = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SquareLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, connectionProperties.Value, host.Value, clientId.Value, clientSecret, redirectUri.Value, useEncryptedEndpoints.Value, useHostVerification.Value, usePeerVerification.Value, encryptedCredential.Value);
        }

        SquareLinkedService IModelJsonSerializable<SquareLinkedService>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SquareLinkedService>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSquareLinkedService(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SquareLinkedService>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SquareLinkedService>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SquareLinkedService IModelSerializable<SquareLinkedService>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SquareLinkedService>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSquareLinkedService(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SquareLinkedService"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SquareLinkedService"/> to convert. </param>
        public static implicit operator RequestContent(SquareLinkedService model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SquareLinkedService"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SquareLinkedService(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSquareLinkedService(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
