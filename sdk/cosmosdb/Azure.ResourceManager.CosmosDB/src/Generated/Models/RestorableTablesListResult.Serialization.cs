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

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class RestorableTablesListResult : IUtf8JsonSerializable, IModelJsonSerializable<RestorableTablesListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RestorableTablesListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RestorableTablesListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestorableTablesListResult>(this, options.Format);

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

        internal static RestorableTablesListResult DeserializeRestorableTablesListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RestorableTable>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestorableTable> array = new List<RestorableTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableTable.DeserializeRestorableTable(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RestorableTablesListResult(Optional.ToList(value), rawData);
        }

        RestorableTablesListResult IModelJsonSerializable<RestorableTablesListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestorableTablesListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorableTablesListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RestorableTablesListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestorableTablesListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RestorableTablesListResult IModelSerializable<RestorableTablesListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestorableTablesListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRestorableTablesListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RestorableTablesListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RestorableTablesListResult"/> to convert. </param>
        public static implicit operator RequestContent(RestorableTablesListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RestorableTablesListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RestorableTablesListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRestorableTablesListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
