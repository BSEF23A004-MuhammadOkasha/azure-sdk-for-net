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

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class DailySchedule : IUtf8JsonSerializable, IModelJsonSerializable<DailySchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DailySchedule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DailySchedule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DailySchedule>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("intervalDays"u8);
            writer.WriteNumberValue(IntervalDays);
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

        internal static DailySchedule DeserializeDailySchedule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int intervalDays = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("intervalDays"u8))
                {
                    intervalDays = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DailySchedule(intervalDays, rawData);
        }

        DailySchedule IModelJsonSerializable<DailySchedule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DailySchedule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDailySchedule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DailySchedule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DailySchedule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DailySchedule IModelSerializable<DailySchedule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DailySchedule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDailySchedule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DailySchedule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DailySchedule"/> to convert. </param>
        public static implicit operator RequestContent(DailySchedule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DailySchedule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DailySchedule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDailySchedule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
