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
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class CertificateCollection : IUtf8JsonSerializable, IModelJsonSerializable<CertificateCollection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CertificateCollection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CertificateCollection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateCollection>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerAppCertificateData>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static CertificateCollection DeserializeCertificateCollection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ContainerAppCertificateData> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ContainerAppCertificateData> array = new List<ContainerAppCertificateData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppCertificateData.DeserializeContainerAppCertificateData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CertificateCollection(value, nextLink.Value, rawData);
        }

        CertificateCollection IModelJsonSerializable<CertificateCollection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateCollection>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCertificateCollection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CertificateCollection>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateCollection>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CertificateCollection IModelSerializable<CertificateCollection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateCollection>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCertificateCollection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CertificateCollection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CertificateCollection"/> to convert. </param>
        public static implicit operator RequestContent(CertificateCollection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CertificateCollection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CertificateCollection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCertificateCollection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
