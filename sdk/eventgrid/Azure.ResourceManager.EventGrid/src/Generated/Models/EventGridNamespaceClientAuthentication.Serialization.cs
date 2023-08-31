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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridNamespaceClientAuthentication : IUtf8JsonSerializable, IModelJsonSerializable<EventGridNamespaceClientAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventGridNamespaceClientAuthentication>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventGridNamespaceClientAuthentication>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateThumbprint))
            {
                writer.WritePropertyName("certificateThumbprint"u8);
                if (CertificateThumbprint is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClientCertificateThumbprint>)CertificateThumbprint).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CertificateSubject))
            {
                writer.WritePropertyName("certificateSubject"u8);
                if (CertificateSubject is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClientCertificateSubjectDistinguishedName>)CertificateSubject).Serialize(writer, options);
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

        internal static EventGridNamespaceClientAuthentication DeserializeEventGridNamespaceClientAuthentication(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ClientCertificateThumbprint> certificateThumbprint = default;
            Optional<ClientCertificateSubjectDistinguishedName> certificateSubject = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateThumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateThumbprint = ClientCertificateThumbprint.DeserializeClientCertificateThumbprint(property.Value);
                    continue;
                }
                if (property.NameEquals("certificateSubject"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateSubject = ClientCertificateSubjectDistinguishedName.DeserializeClientCertificateSubjectDistinguishedName(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EventGridNamespaceClientAuthentication(certificateThumbprint.Value, certificateSubject.Value, rawData);
        }

        EventGridNamespaceClientAuthentication IModelJsonSerializable<EventGridNamespaceClientAuthentication>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridNamespaceClientAuthentication(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventGridNamespaceClientAuthentication>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventGridNamespaceClientAuthentication IModelSerializable<EventGridNamespaceClientAuthentication>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventGridNamespaceClientAuthentication(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventGridNamespaceClientAuthentication"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventGridNamespaceClientAuthentication"/> to convert. </param>
        public static implicit operator RequestContent(EventGridNamespaceClientAuthentication model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventGridNamespaceClientAuthentication"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventGridNamespaceClientAuthentication(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventGridNamespaceClientAuthentication(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
