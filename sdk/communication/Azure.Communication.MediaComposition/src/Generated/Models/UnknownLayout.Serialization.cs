// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.MediaComposition
{
    internal partial class UnknownLayout : IUtf8JsonSerializable, IModelJsonSerializable<MediaCompositionLayout>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaCompositionLayout>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaCompositionLayout>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaCompositionLayout>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Resolution))
            {
                writer.WritePropertyName("resolution"u8);
                if (Resolution is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LayoutResolution>)Resolution).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PlaceholderImageUri))
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
            }
            if (Optional.IsDefined(ScalingMode))
            {
                writer.WritePropertyName("scalingMode"u8);
                writer.WriteStringValue(ScalingMode.Value.ToString());
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

        internal static MediaCompositionLayout DeserializeUnknownLayout(JsonElement element, ModelSerializerOptions options = default) => DeserializeMediaCompositionLayout(element, options);

        MediaCompositionLayout IModelJsonSerializable<MediaCompositionLayout>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaCompositionLayout>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownLayout(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaCompositionLayout>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaCompositionLayout>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaCompositionLayout IModelSerializable<MediaCompositionLayout>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaCompositionLayout>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaCompositionLayout(doc.RootElement, options);
        }
    }
}
