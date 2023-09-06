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
    internal partial class TransportAvailabilityResponse : IUtf8JsonSerializable, IModelJsonSerializable<TransportAvailabilityResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TransportAvailabilityResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TransportAvailabilityResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportAvailabilityResponse>(this, options.Format);

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

        internal static TransportAvailabilityResponse DeserializeTransportAvailabilityResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<TransportAvailabilityDetails>> transportAvailabilityDetails = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transportAvailabilityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TransportAvailabilityDetails> array = new List<TransportAvailabilityDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.TransportAvailabilityDetails.DeserializeTransportAvailabilityDetails(item));
                    }
                    transportAvailabilityDetails = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TransportAvailabilityResponse(Optional.ToList(transportAvailabilityDetails), rawData);
        }

        TransportAvailabilityResponse IModelJsonSerializable<TransportAvailabilityResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportAvailabilityResponse>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTransportAvailabilityResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TransportAvailabilityResponse>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportAvailabilityResponse>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TransportAvailabilityResponse IModelSerializable<TransportAvailabilityResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportAvailabilityResponse>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTransportAvailabilityResponse(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TransportAvailabilityResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TransportAvailabilityResponse"/> to convert. </param>
        public static implicit operator RequestContent(TransportAvailabilityResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TransportAvailabilityResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TransportAvailabilityResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTransportAvailabilityResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
