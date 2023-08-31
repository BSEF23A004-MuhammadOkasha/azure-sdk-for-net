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
    [JsonConverter(typeof(MediaJobOutputFinishedEventDataConverter))]
    public partial class MediaJobOutputFinishedEventData : IUtf8JsonSerializable, IModelJsonSerializable<MediaJobOutputFinishedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaJobOutputFinishedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaJobOutputFinishedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobOutputFinishedEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                if (Output is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MediaJobOutput>)Output).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(JobCorrelationData))
            {
                writer.WritePropertyName("jobCorrelationData"u8);
                writer.WriteStartObject();
                foreach (var item in JobCorrelationData)
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

        internal static MediaJobOutputFinishedEventData DeserializeMediaJobOutputFinishedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MediaJobState> previousState = default;
            Optional<MediaJobOutput> output = default;
            Optional<IReadOnlyDictionary<string, string>> jobCorrelationData = default;
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
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = MediaJobOutput.DeserializeMediaJobOutput(property.Value);
                    continue;
                }
                if (property.NameEquals("jobCorrelationData"u8))
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
                    jobCorrelationData = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaJobOutputFinishedEventData(Optional.ToNullable(previousState), output.Value, Optional.ToDictionary(jobCorrelationData), rawData);
        }

        MediaJobOutputFinishedEventData IModelJsonSerializable<MediaJobOutputFinishedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobOutputFinishedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobOutputFinishedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaJobOutputFinishedEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobOutputFinishedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaJobOutputFinishedEventData IModelSerializable<MediaJobOutputFinishedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobOutputFinishedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaJobOutputFinishedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaJobOutputFinishedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaJobOutputFinishedEventData"/> to convert. </param>
        public static implicit operator RequestContent(MediaJobOutputFinishedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaJobOutputFinishedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaJobOutputFinishedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaJobOutputFinishedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MediaJobOutputFinishedEventDataConverter : JsonConverter<MediaJobOutputFinishedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaJobOutputFinishedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaJobOutputFinishedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaJobOutputFinishedEventData(document.RootElement);
            }
        }
    }
}
