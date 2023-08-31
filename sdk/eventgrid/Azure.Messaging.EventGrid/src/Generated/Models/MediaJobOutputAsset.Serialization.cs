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

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MediaJobOutputAsset : IUtf8JsonSerializable, IModelJsonSerializable<MediaJobOutputAsset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaJobOutputAsset>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaJobOutputAsset>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobOutputAsset>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AssetName))
            {
                writer.WritePropertyName("assetName"u8);
                writer.WriteStringValue(AssetName);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                if (Error is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MediaJobError>)Error).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            writer.WritePropertyName("progress"u8);
            writer.WriteNumberValue(Progress);
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State.ToSerialString());
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

        internal static MediaJobOutputAsset DeserializeMediaJobOutputAsset(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> assetName = default;
            string odataType = default;
            Optional<MediaJobError> error = default;
            Optional<string> label = default;
            long progress = default;
            MediaJobState state = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetName"u8))
                {
                    assetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = MediaJobError.DeserializeMediaJobError(property.Value);
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("progress"u8))
                {
                    progress = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaJobOutputAsset(odataType, error.Value, label.Value, progress, state, assetName.Value, rawData);
        }

        MediaJobOutputAsset IModelJsonSerializable<MediaJobOutputAsset>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobOutputAsset>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobOutputAsset(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaJobOutputAsset>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobOutputAsset>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaJobOutputAsset IModelSerializable<MediaJobOutputAsset>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobOutputAsset>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaJobOutputAsset(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaJobOutputAsset"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaJobOutputAsset"/> to convert. </param>
        public static implicit operator RequestContent(MediaJobOutputAsset model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaJobOutputAsset"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaJobOutputAsset(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaJobOutputAsset(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
