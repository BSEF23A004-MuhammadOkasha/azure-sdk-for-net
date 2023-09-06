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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class LinkedIntegrationRuntimeRbacAuthorization : IUtf8JsonSerializable, IModelJsonSerializable<LinkedIntegrationRuntimeRbacAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LinkedIntegrationRuntimeRbacAuthorization>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LinkedIntegrationRuntimeRbacAuthorization>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedIntegrationRuntimeRbacAuthorization>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("resourceId"u8);
            writer.WriteStringValue(ResourceId);
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                if (Credential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DataFactoryCredentialReference>)Credential).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
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

        internal static LinkedIntegrationRuntimeRbacAuthorization DeserializeLinkedIntegrationRuntimeRbacAuthorization(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier resourceId = default;
            Optional<DataFactoryCredentialReference> credential = default;
            string authorizationType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property.Value);
                    continue;
                }
                if (property.NameEquals("authorizationType"u8))
                {
                    authorizationType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LinkedIntegrationRuntimeRbacAuthorization(authorizationType, resourceId, credential.Value, rawData);
        }

        LinkedIntegrationRuntimeRbacAuthorization IModelJsonSerializable<LinkedIntegrationRuntimeRbacAuthorization>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedIntegrationRuntimeRbacAuthorization>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkedIntegrationRuntimeRbacAuthorization(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LinkedIntegrationRuntimeRbacAuthorization>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedIntegrationRuntimeRbacAuthorization>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LinkedIntegrationRuntimeRbacAuthorization IModelSerializable<LinkedIntegrationRuntimeRbacAuthorization>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedIntegrationRuntimeRbacAuthorization>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLinkedIntegrationRuntimeRbacAuthorization(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LinkedIntegrationRuntimeRbacAuthorization"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LinkedIntegrationRuntimeRbacAuthorization"/> to convert. </param>
        public static implicit operator RequestContent(LinkedIntegrationRuntimeRbacAuthorization model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LinkedIntegrationRuntimeRbacAuthorization"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LinkedIntegrationRuntimeRbacAuthorization(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLinkedIntegrationRuntimeRbacAuthorization(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
