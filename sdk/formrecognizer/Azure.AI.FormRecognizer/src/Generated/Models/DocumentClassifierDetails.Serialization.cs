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

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentClassifierDetails : IUtf8JsonSerializable, IModelJsonSerializable<DocumentClassifierDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentClassifierDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentClassifierDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("classifierId"u8);
            writer.WriteStringValue(ClassifierId);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("createdDateTime"u8);
            writer.WriteStringValue(CreatedOn, "O");
            if (Optional.IsDefined(ExpiresOn))
            {
                writer.WritePropertyName("expirationDateTime"u8);
                writer.WriteStringValue(ExpiresOn.Value, "O");
            }
            writer.WritePropertyName("apiVersion"u8);
            writer.WriteStringValue(ServiceVersion);
            writer.WritePropertyName("docTypes"u8);
            writer.WriteStartObject();
            foreach (var item in DocumentTypes)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClassifierDocumentTypeDetails>)item.Value).Serialize(writer, options);
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

        internal static DocumentClassifierDetails DeserializeDocumentClassifierDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string classifierId = default;
            Optional<string> description = default;
            DateTimeOffset createdDateTime = default;
            Optional<DateTimeOffset> expirationDateTime = default;
            string apiVersion = default;
            IReadOnlyDictionary<string, ClassifierDocumentTypeDetails> docTypes = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("classifierId"u8))
                {
                    classifierId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("docTypes"u8))
                {
                    Dictionary<string, ClassifierDocumentTypeDetails> dictionary = new Dictionary<string, ClassifierDocumentTypeDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ClassifierDocumentTypeDetails.DeserializeClassifierDocumentTypeDetails(property0.Value));
                    }
                    docTypes = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentClassifierDetails(classifierId, description.Value, createdDateTime, Optional.ToNullable(expirationDateTime), apiVersion, docTypes, rawData);
        }

        DocumentClassifierDetails IModelJsonSerializable<DocumentClassifierDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentClassifierDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentClassifierDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentClassifierDetails IModelSerializable<DocumentClassifierDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentClassifierDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DocumentClassifierDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DocumentClassifierDetails"/> to convert. </param>
        public static implicit operator RequestContent(DocumentClassifierDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DocumentClassifierDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DocumentClassifierDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentClassifierDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
