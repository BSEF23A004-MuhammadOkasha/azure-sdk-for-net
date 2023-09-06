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

namespace Azure.Communication.MediaComposition
{
    public partial class ActivePresenter : IUtf8JsonSerializable, IModelJsonSerializable<ActivePresenter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ActivePresenter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ActivePresenter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ActivePresenter>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("call"u8);
            writer.WriteStringValue(Call);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(PlaceholderImageUri))
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
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

        internal static ActivePresenter DeserializeActivePresenter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string call = default;
            MediaInputType kind = default;
            Optional<string> placeholderImageUri = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("call"u8))
                {
                    call = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new MediaInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"u8))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ActivePresenter(kind, placeholderImageUri.Value, call, rawData);
        }

        ActivePresenter IModelJsonSerializable<ActivePresenter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ActivePresenter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeActivePresenter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ActivePresenter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ActivePresenter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ActivePresenter IModelSerializable<ActivePresenter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ActivePresenter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeActivePresenter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ActivePresenter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ActivePresenter"/> to convert. </param>
        public static implicit operator RequestContent(ActivePresenter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ActivePresenter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ActivePresenter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeActivePresenter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
