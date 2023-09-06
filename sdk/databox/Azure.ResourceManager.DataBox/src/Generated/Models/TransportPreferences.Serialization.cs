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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class TransportPreferences : IUtf8JsonSerializable, IModelJsonSerializable<TransportPreferences>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TransportPreferences>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TransportPreferences>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportPreferences>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("preferredShipmentType"u8);
            writer.WriteStringValue(PreferredShipmentType.ToSerialString());
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

        internal static TransportPreferences DeserializeTransportPreferences(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TransportShipmentType preferredShipmentType = default;
            Optional<bool> isUpdated = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preferredShipmentType"u8))
                {
                    preferredShipmentType = property.Value.GetString().ToTransportShipmentType();
                    continue;
                }
                if (property.NameEquals("isUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isUpdated = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TransportPreferences(preferredShipmentType, Optional.ToNullable(isUpdated), rawData);
        }

        TransportPreferences IModelJsonSerializable<TransportPreferences>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportPreferences>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTransportPreferences(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TransportPreferences>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportPreferences>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TransportPreferences IModelSerializable<TransportPreferences>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportPreferences>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTransportPreferences(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TransportPreferences"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TransportPreferences"/> to convert. </param>
        public static implicit operator RequestContent(TransportPreferences model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TransportPreferences"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TransportPreferences(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTransportPreferences(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
