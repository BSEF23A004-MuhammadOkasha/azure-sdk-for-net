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

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsEventGridProperties : IUtf8JsonSerializable, IModelJsonSerializable<DigitalTwinsEventGridProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DigitalTwinsEventGridProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DigitalTwinsEventGridProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DigitalTwinsEventGridProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("TopicEndpoint"u8);
            writer.WriteStringValue(TopicEndpoint);
            if (AccessKey1 != null)
            {
                writer.WritePropertyName("accessKey1"u8);
                writer.WriteStringValue(AccessKey1);
            }
            else
            {
                writer.WriteNull("accessKey1");
            }
            if (Optional.IsDefined(AccessKey2))
            {
                if (AccessKey2 != null)
                {
                    writer.WritePropertyName("accessKey2"u8);
                    writer.WriteStringValue(AccessKey2);
                }
                else
                {
                    writer.WriteNull("accessKey2");
                }
            }
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(DeadLetterSecret))
            {
                if (DeadLetterSecret != null)
                {
                    writer.WritePropertyName("deadLetterSecret"u8);
                    writer.WriteStringValue(DeadLetterSecret);
                }
                else
                {
                    writer.WriteNull("deadLetterSecret");
                }
            }
            if (Optional.IsDefined(DeadLetterUri))
            {
                if (DeadLetterUri != null)
                {
                    writer.WritePropertyName("deadLetterUri"u8);
                    writer.WriteStringValue(DeadLetterUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("deadLetterUri");
                }
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    if (Identity is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DigitalTwinsManagedIdentityReference>)Identity).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("identity");
                }
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

        internal static DigitalTwinsEventGridProperties DeserializeDigitalTwinsEventGridProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string topicEndpoint = default;
            string accessKey1 = default;
            Optional<string> accessKey2 = default;
            EndpointType endpointType = default;
            Optional<DigitalTwinsEndpointProvisioningState?> provisioningState = default;
            Optional<DateTimeOffset?> createdTime = default;
            Optional<DigitalTwinsAuthenticationType> authenticationType = default;
            Optional<string> deadLetterSecret = default;
            Optional<Uri> deadLetterUri = default;
            Optional<DigitalTwinsManagedIdentityReference> identity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("TopicEndpoint"u8))
                {
                    topicEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessKey1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accessKey1 = null;
                        continue;
                    }
                    accessKey1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessKey2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accessKey2 = null;
                        continue;
                    }
                    accessKey2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningState = null;
                        continue;
                    }
                    provisioningState = new DigitalTwinsEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        createdTime = null;
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new DigitalTwinsAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deadLetterSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterSecret = null;
                        continue;
                    }
                    deadLetterSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deadLetterUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterUri = null;
                        continue;
                    }
                    deadLetterUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = DigitalTwinsManagedIdentityReference.DeserializeDigitalTwinsManagedIdentityReference(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DigitalTwinsEventGridProperties(endpointType, Optional.ToNullable(provisioningState), Optional.ToNullable(createdTime), Optional.ToNullable(authenticationType), deadLetterSecret.Value, deadLetterUri.Value, identity.Value, topicEndpoint, accessKey1, accessKey2.Value, rawData);
        }

        DigitalTwinsEventGridProperties IModelJsonSerializable<DigitalTwinsEventGridProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DigitalTwinsEventGridProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsEventGridProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DigitalTwinsEventGridProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DigitalTwinsEventGridProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DigitalTwinsEventGridProperties IModelSerializable<DigitalTwinsEventGridProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DigitalTwinsEventGridProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDigitalTwinsEventGridProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DigitalTwinsEventGridProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DigitalTwinsEventGridProperties"/> to convert. </param>
        public static implicit operator RequestContent(DigitalTwinsEventGridProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DigitalTwinsEventGridProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DigitalTwinsEventGridProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDigitalTwinsEventGridProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
