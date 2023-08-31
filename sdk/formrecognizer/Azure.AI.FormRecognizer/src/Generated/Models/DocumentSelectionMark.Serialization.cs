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
    public partial class DocumentSelectionMark : IUtf8JsonSerializable, IModelJsonSerializable<DocumentSelectionMark>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentSelectionMark>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentSelectionMark>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(StatePrivate.ToString());
            if (Optional.IsCollectionDefined(Polygon))
            {
                writer.WritePropertyName("polygon"u8);
                writer.WriteStartArray();
                foreach (var item in Polygon)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("span"u8);
            if (Span is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DocumentSpan>)Span).Serialize(writer, options);
            }
            writer.WritePropertyName("confidence"u8);
            writer.WriteNumberValue(Confidence);
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

        internal static DocumentSelectionMark DeserializeDocumentSelectionMark(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            V3SelectionMarkState state = default;
            Optional<IReadOnlyList<float>> polygon = default;
            DocumentSpan span = default;
            float confidence = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    state = new V3SelectionMarkState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("polygon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    polygon = array;
                    continue;
                }
                if (property.NameEquals("span"u8))
                {
                    span = DocumentSpan.DeserializeDocumentSpan(property.Value);
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentSelectionMark(state, Optional.ToList(polygon), span, confidence, rawData);
        }

        DocumentSelectionMark IModelJsonSerializable<DocumentSelectionMark>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentSelectionMark(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentSelectionMark>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentSelectionMark IModelSerializable<DocumentSelectionMark>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentSelectionMark(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DocumentSelectionMark"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DocumentSelectionMark"/> to convert. </param>
        public static implicit operator RequestContent(DocumentSelectionMark model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DocumentSelectionMark"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DocumentSelectionMark(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentSelectionMark(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
