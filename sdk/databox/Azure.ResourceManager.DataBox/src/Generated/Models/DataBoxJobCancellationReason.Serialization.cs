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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxJobCancellationReason : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxJobCancellationReason>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxJobCancellationReason>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxJobCancellationReason>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxJobCancellationReason>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("reason"u8);
            writer.WriteStringValue(Reason);
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

        internal static DataBoxJobCancellationReason DeserializeDataBoxJobCancellationReason(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string reason = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxJobCancellationReason(reason, rawData);
        }

        DataBoxJobCancellationReason IModelJsonSerializable<DataBoxJobCancellationReason>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxJobCancellationReason>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxJobCancellationReason(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxJobCancellationReason>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxJobCancellationReason>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxJobCancellationReason IModelSerializable<DataBoxJobCancellationReason>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxJobCancellationReason>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxJobCancellationReason(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataBoxJobCancellationReason"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataBoxJobCancellationReason"/> to convert. </param>
        public static implicit operator RequestContent(DataBoxJobCancellationReason model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataBoxJobCancellationReason"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataBoxJobCancellationReason(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxJobCancellationReason(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
