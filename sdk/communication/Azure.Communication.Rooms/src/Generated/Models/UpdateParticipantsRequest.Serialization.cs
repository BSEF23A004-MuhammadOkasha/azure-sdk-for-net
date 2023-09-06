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

namespace Azure.Communication.Rooms
{
    internal partial class UpdateParticipantsRequest : IUtf8JsonSerializable, IModelJsonSerializable<UpdateParticipantsRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UpdateParticipantsRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UpdateParticipantsRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateParticipantsRequest>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Participants))
            {
                writer.WritePropertyName("participants"u8);
                writer.WriteStartObject();
                foreach (var item in Participants)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ParticipantProperties>)item.Value).Serialize(writer, options);
                    }
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

        internal static UpdateParticipantsRequest DeserializeUpdateParticipantsRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, ParticipantProperties>> participants = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("participants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParticipantProperties> dictionary = new Dictionary<string, ParticipantProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParticipantProperties.DeserializeParticipantProperties(property0.Value));
                    }
                    participants = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UpdateParticipantsRequest(Optional.ToDictionary(participants), rawData);
        }

        UpdateParticipantsRequest IModelJsonSerializable<UpdateParticipantsRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateParticipantsRequest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateParticipantsRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UpdateParticipantsRequest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateParticipantsRequest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UpdateParticipantsRequest IModelSerializable<UpdateParticipantsRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateParticipantsRequest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUpdateParticipantsRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UpdateParticipantsRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UpdateParticipantsRequest"/> to convert. </param>
        public static implicit operator RequestContent(UpdateParticipantsRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UpdateParticipantsRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UpdateParticipantsRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUpdateParticipantsRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
