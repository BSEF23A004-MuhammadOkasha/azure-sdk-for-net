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

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class DataLakeAnalyticsSasTokenInformation : IUtf8JsonSerializable, IModelJsonSerializable<DataLakeAnalyticsSasTokenInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataLakeAnalyticsSasTokenInformation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataLakeAnalyticsSasTokenInformation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeAnalyticsSasTokenInformation>(this, options.Format);

            writer.WriteStartObject();
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

        internal static DataLakeAnalyticsSasTokenInformation DeserializeDataLakeAnalyticsSasTokenInformation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> accessToken = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataLakeAnalyticsSasTokenInformation(accessToken.Value, rawData);
        }

        DataLakeAnalyticsSasTokenInformation IModelJsonSerializable<DataLakeAnalyticsSasTokenInformation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeAnalyticsSasTokenInformation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeAnalyticsSasTokenInformation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataLakeAnalyticsSasTokenInformation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeAnalyticsSasTokenInformation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataLakeAnalyticsSasTokenInformation IModelSerializable<DataLakeAnalyticsSasTokenInformation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeAnalyticsSasTokenInformation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataLakeAnalyticsSasTokenInformation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataLakeAnalyticsSasTokenInformation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataLakeAnalyticsSasTokenInformation"/> to convert. </param>
        public static implicit operator RequestContent(DataLakeAnalyticsSasTokenInformation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataLakeAnalyticsSasTokenInformation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataLakeAnalyticsSasTokenInformation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataLakeAnalyticsSasTokenInformation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
