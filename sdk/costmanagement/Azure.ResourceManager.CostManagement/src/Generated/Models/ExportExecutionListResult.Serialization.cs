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

namespace Azure.ResourceManager.CostManagement.Models
{
    internal partial class ExportExecutionListResult : IUtf8JsonSerializable, IModelJsonSerializable<ExportExecutionListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExportExecutionListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExportExecutionListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExportExecutionListResult>(this, options.Format);

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

        internal static ExportExecutionListResult DeserializeExportExecutionListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ExportRun>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExportRun> array = new List<ExportRun>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExportRun.DeserializeExportRun(item));
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
            return new ExportExecutionListResult(Optional.ToList(value), rawData);
        }

        ExportExecutionListResult IModelJsonSerializable<ExportExecutionListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExportExecutionListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExportExecutionListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExportExecutionListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExportExecutionListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExportExecutionListResult IModelSerializable<ExportExecutionListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExportExecutionListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExportExecutionListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExportExecutionListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExportExecutionListResult"/> to convert. </param>
        public static implicit operator RequestContent(ExportExecutionListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExportExecutionListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExportExecutionListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExportExecutionListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
