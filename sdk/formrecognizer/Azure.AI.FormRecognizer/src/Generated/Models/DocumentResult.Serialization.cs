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

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class DocumentResult : IUtf8JsonSerializable, IModelJsonSerializable<DocumentResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("docType"u8);
            writer.WriteStringValue(DocType);
            if (Optional.IsDefined(ModelId))
            {
                writer.WritePropertyName("modelId"u8);
                writer.WriteStringValue(ModelId.Value);
            }
            writer.WritePropertyName("pageRange"u8);
            writer.WriteStartArray();
            foreach (var item in PageRange)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(DocTypeConfidence))
            {
                writer.WritePropertyName("docTypeConfidence"u8);
                writer.WriteNumberValue(DocTypeConfidence.Value);
            }
            writer.WritePropertyName("fields"u8);
            writer.WriteStartObject();
            foreach (var item in Fields)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<FieldValue_internal>)item.Value).Serialize(writer, options);
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

        internal static DocumentResult DeserializeDocumentResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string docType = default;
            Optional<Guid> modelId = default;
            IReadOnlyList<int> pageRange = default;
            Optional<float> docTypeConfidence = default;
            IReadOnlyDictionary<string, FieldValue_internal> fields = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("docType"u8))
                {
                    docType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modelId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("pageRange"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    pageRange = array;
                    continue;
                }
                if (property.NameEquals("docTypeConfidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    docTypeConfidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    Dictionary<string, FieldValue_internal> dictionary = new Dictionary<string, FieldValue_internal>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, FieldValue_internal.DeserializeFieldValue_internal(property0.Value));
                    }
                    fields = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentResult(docType, Optional.ToNullable(modelId), pageRange, Optional.ToNullable(docTypeConfidence), fields, rawData);
        }

        DocumentResult IModelJsonSerializable<DocumentResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentResult IModelSerializable<DocumentResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DocumentResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DocumentResult"/> to convert. </param>
        public static implicit operator RequestContent(DocumentResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DocumentResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DocumentResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
