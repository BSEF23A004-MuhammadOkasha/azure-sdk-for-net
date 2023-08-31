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
    [JsonConverter(typeof(AcsChatParticipantRemovedFromThreadEventDataConverter))]
    public partial class AcsChatParticipantRemovedFromThreadEventData : IUtf8JsonSerializable, IModelJsonSerializable<AcsChatParticipantRemovedFromThreadEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AcsChatParticipantRemovedFromThreadEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AcsChatParticipantRemovedFromThreadEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AcsChatParticipantRemovedFromThreadEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time.Value, "O");
            }
            if (Optional.IsDefined(RemovedByCommunicationIdentifier))
            {
                writer.WritePropertyName("removedByCommunicationIdentifier"u8);
                if (RemovedByCommunicationIdentifier is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationIdentifierModel>)RemovedByCommunicationIdentifier).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ParticipantRemoved))
            {
                writer.WritePropertyName("participantRemoved"u8);
                if (ParticipantRemoved is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AcsChatThreadParticipantProperties>)ParticipantRemoved).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(TransactionId))
            {
                writer.WritePropertyName("transactionId"u8);
                writer.WriteStringValue(TransactionId);
            }
            if (Optional.IsDefined(ThreadId))
            {
                writer.WritePropertyName("threadId"u8);
                writer.WriteStringValue(ThreadId);
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

        internal static AcsChatParticipantRemovedFromThreadEventData DeserializeAcsChatParticipantRemovedFromThreadEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> time = default;
            Optional<CommunicationIdentifierModel> removedByCommunicationIdentifier = default;
            Optional<AcsChatThreadParticipantProperties> participantRemoved = default;
            Optional<long> version = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("removedByCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    removedByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("participantRemoved"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    participantRemoved = AcsChatThreadParticipantProperties.DeserializeAcsChatThreadParticipantProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transactionId"u8))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AcsChatParticipantRemovedFromThreadEventData(transactionId.Value, threadId.Value, Optional.ToNullable(time), removedByCommunicationIdentifier.Value, participantRemoved.Value, Optional.ToNullable(version), rawData);
        }

        AcsChatParticipantRemovedFromThreadEventData IModelJsonSerializable<AcsChatParticipantRemovedFromThreadEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AcsChatParticipantRemovedFromThreadEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsChatParticipantRemovedFromThreadEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AcsChatParticipantRemovedFromThreadEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AcsChatParticipantRemovedFromThreadEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AcsChatParticipantRemovedFromThreadEventData IModelSerializable<AcsChatParticipantRemovedFromThreadEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AcsChatParticipantRemovedFromThreadEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAcsChatParticipantRemovedFromThreadEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AcsChatParticipantRemovedFromThreadEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AcsChatParticipantRemovedFromThreadEventData"/> to convert. </param>
        public static implicit operator RequestContent(AcsChatParticipantRemovedFromThreadEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AcsChatParticipantRemovedFromThreadEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AcsChatParticipantRemovedFromThreadEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAcsChatParticipantRemovedFromThreadEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class AcsChatParticipantRemovedFromThreadEventDataConverter : JsonConverter<AcsChatParticipantRemovedFromThreadEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatParticipantRemovedFromThreadEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsChatParticipantRemovedFromThreadEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatParticipantRemovedFromThreadEventData(document.RootElement);
            }
        }
    }
}
