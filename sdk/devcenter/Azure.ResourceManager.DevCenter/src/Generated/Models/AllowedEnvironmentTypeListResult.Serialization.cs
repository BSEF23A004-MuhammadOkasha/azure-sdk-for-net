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
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    internal partial class AllowedEnvironmentTypeListResult : IUtf8JsonSerializable, IModelJsonSerializable<AllowedEnvironmentTypeListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AllowedEnvironmentTypeListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AllowedEnvironmentTypeListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static AllowedEnvironmentTypeListResult DeserializeAllowedEnvironmentTypeListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AllowedEnvironmentTypeData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AllowedEnvironmentTypeData> array = new List<AllowedEnvironmentTypeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AllowedEnvironmentTypeData.DeserializeAllowedEnvironmentTypeData(item));
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
            return new AllowedEnvironmentTypeListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        AllowedEnvironmentTypeListResult IModelJsonSerializable<AllowedEnvironmentTypeListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAllowedEnvironmentTypeListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AllowedEnvironmentTypeListResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AllowedEnvironmentTypeListResult IModelSerializable<AllowedEnvironmentTypeListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAllowedEnvironmentTypeListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AllowedEnvironmentTypeListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AllowedEnvironmentTypeListResult"/> to convert. </param>
        public static implicit operator RequestContent(AllowedEnvironmentTypeListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AllowedEnvironmentTypeListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AllowedEnvironmentTypeListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAllowedEnvironmentTypeListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
