// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaJobCancelingEventDataConverter))]
    public partial class MediaJobCancelingEventData : IUtf8JsonSerializable, IModelJsonSerializable<MediaJobCancelingEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaJobCancelingEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaJobCancelingEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobCancelingEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CorrelationData))
            {
                writer.WritePropertyName("correlationData"u8);
                writer.WriteStartObject();
                foreach (var item in CorrelationData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static MediaJobCancelingEventData DeserializeMediaJobCancelingEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MediaJobState> previousState = default;
            Optional<MediaJobState> state = default;
            Optional<IReadOnlyDictionary<string, string>> correlationData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("previousState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previousState = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("correlationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    correlationData = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaJobCancelingEventData(Optional.ToNullable(previousState), Optional.ToNullable(state), Optional.ToDictionary(correlationData), rawData);
        }

        MediaJobCancelingEventData IModelJsonSerializable<MediaJobCancelingEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobCancelingEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobCancelingEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaJobCancelingEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobCancelingEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaJobCancelingEventData IModelSerializable<MediaJobCancelingEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobCancelingEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaJobCancelingEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaJobCancelingEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaJobCancelingEventData"/> to convert. </param>
        public static implicit operator RequestContent(MediaJobCancelingEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaJobCancelingEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaJobCancelingEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaJobCancelingEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MediaJobCancelingEventDataConverter : JsonConverter<MediaJobCancelingEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaJobCancelingEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaJobCancelingEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaJobCancelingEventData(document.RootElement);
            }
        }
    }
}
