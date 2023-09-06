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
    public partial class IntegrationRuntimeConnectionInfo : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationRuntimeConnectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationRuntimeConnectionInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationRuntimeConnectionInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationRuntimeConnectionInfo>(this, options.Format);

            writer.WriteStartObject();
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

        internal static IntegrationRuntimeConnectionInfo DeserializeIntegrationRuntimeConnectionInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceToken = default;
            Optional<string> identityCertThumbprint = default;
            Optional<Uri> hostServiceUri = default;
            Optional<string> version = default;
            Optional<string> publicKey = default;
            Optional<bool> isIdentityCertExprired = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceToken"u8))
                {
                    serviceToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityCertThumbprint"u8))
                {
                    identityCertThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicKey"u8))
                {
                    publicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isIdentityCertExprired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isIdentityCertExprired = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeConnectionInfo(serviceToken.Value, identityCertThumbprint.Value, hostServiceUri.Value, version.Value, publicKey.Value, Optional.ToNullable(isIdentityCertExprired), additionalProperties);
        }

        IntegrationRuntimeConnectionInfo IModelJsonSerializable<IntegrationRuntimeConnectionInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationRuntimeConnectionInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeConnectionInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationRuntimeConnectionInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationRuntimeConnectionInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationRuntimeConnectionInfo IModelSerializable<IntegrationRuntimeConnectionInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationRuntimeConnectionInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationRuntimeConnectionInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IntegrationRuntimeConnectionInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IntegrationRuntimeConnectionInfo"/> to convert. </param>
        public static implicit operator RequestContent(IntegrationRuntimeConnectionInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IntegrationRuntimeConnectionInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IntegrationRuntimeConnectionInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationRuntimeConnectionInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
