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
    [JsonConverter(typeof(HealthcareDicomImageDeletedEventDataConverter))]
    public partial class HealthcareDicomImageDeletedEventData : IUtf8JsonSerializable, IModelJsonSerializable<HealthcareDicomImageDeletedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HealthcareDicomImageDeletedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HealthcareDicomImageDeletedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionName))
            {
                writer.WritePropertyName("partitionName"u8);
                writer.WriteStringValue(PartitionName);
            }
            if (Optional.IsDefined(ImageStudyInstanceUid))
            {
                writer.WritePropertyName("imageStudyInstanceUid"u8);
                writer.WriteStringValue(ImageStudyInstanceUid);
            }
            if (Optional.IsDefined(ImageSeriesInstanceUid))
            {
                writer.WritePropertyName("imageSeriesInstanceUid"u8);
                writer.WriteStringValue(ImageSeriesInstanceUid);
            }
            if (Optional.IsDefined(ImageSopInstanceUid))
            {
                writer.WritePropertyName("imageSopInstanceUid"u8);
                writer.WriteStringValue(ImageSopInstanceUid);
            }
            if (Optional.IsDefined(ServiceHostName))
            {
                writer.WritePropertyName("serviceHostName"u8);
                writer.WriteStringValue(ServiceHostName);
            }
            if (Optional.IsDefined(SequenceNumber))
            {
                writer.WritePropertyName("sequenceNumber"u8);
                writer.WriteNumberValue(SequenceNumber.Value);
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

        internal static HealthcareDicomImageDeletedEventData DeserializeHealthcareDicomImageDeletedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> partitionName = default;
            Optional<string> imageStudyInstanceUid = default;
            Optional<string> imageSeriesInstanceUid = default;
            Optional<string> imageSopInstanceUid = default;
            Optional<string> serviceHostName = default;
            Optional<long> sequenceNumber = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionName"u8))
                {
                    partitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageStudyInstanceUid"u8))
                {
                    imageStudyInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSeriesInstanceUid"u8))
                {
                    imageSeriesInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSopInstanceUid"u8))
                {
                    imageSopInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceHostName"u8))
                {
                    serviceHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HealthcareDicomImageDeletedEventData(partitionName.Value, imageStudyInstanceUid.Value, imageSeriesInstanceUid.Value, imageSopInstanceUid.Value, serviceHostName.Value, Optional.ToNullable(sequenceNumber), rawData);
        }

        HealthcareDicomImageDeletedEventData IModelJsonSerializable<HealthcareDicomImageDeletedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareDicomImageDeletedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HealthcareDicomImageDeletedEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HealthcareDicomImageDeletedEventData IModelSerializable<HealthcareDicomImageDeletedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHealthcareDicomImageDeletedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HealthcareDicomImageDeletedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HealthcareDicomImageDeletedEventData"/> to convert. </param>
        public static implicit operator RequestContent(HealthcareDicomImageDeletedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HealthcareDicomImageDeletedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HealthcareDicomImageDeletedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHealthcareDicomImageDeletedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class HealthcareDicomImageDeletedEventDataConverter : JsonConverter<HealthcareDicomImageDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, HealthcareDicomImageDeletedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HealthcareDicomImageDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHealthcareDicomImageDeletedEventData(document.RootElement);
            }
        }
    }
}
