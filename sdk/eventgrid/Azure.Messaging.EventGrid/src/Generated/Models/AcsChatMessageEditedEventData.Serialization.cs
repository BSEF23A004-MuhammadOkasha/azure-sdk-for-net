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
    [JsonConverter(typeof(AcsChatMessageEditedEventDataConverter))]
    public partial class AcsChatMessageEditedEventData : IUtf8JsonSerializable, IModelJsonSerializable<AcsChatMessageEditedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AcsChatMessageEditedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AcsChatMessageEditedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AcsChatMessageEditedEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MessageBody))
            {
                writer.WritePropertyName("messageBody"u8);
                writer.WriteStringValue(MessageBody);
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(EditTime))
            {
                writer.WritePropertyName("editTime"u8);
                writer.WriteStringValue(EditTime.Value, "O");
            }
            if (Optional.IsDefined(MessageId))
            {
                writer.WritePropertyName("messageId"u8);
                writer.WriteStringValue(MessageId);
            }
            if (Optional.IsDefined(SenderCommunicationIdentifier))
            {
                writer.WritePropertyName("senderCommunicationIdentifier"u8);
                if (SenderCommunicationIdentifier is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationIdentifierModel>)SenderCommunicationIdentifier).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SenderDisplayName))
            {
                writer.WritePropertyName("senderDisplayName"u8);
                writer.WriteStringValue(SenderDisplayName);
            }
            if (Optional.IsDefined(ComposeTime))
            {
                writer.WritePropertyName("composeTime"u8);
                writer.WriteStringValue(ComposeTime.Value, "O");
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(RecipientCommunicationIdentifier))
            {
                writer.WritePropertyName("recipientCommunicationIdentifier"u8);
                if (RecipientCommunicationIdentifier is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationIdentifierModel>)RecipientCommunicationIdentifier).Serialize(writer, options);
                }
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

        internal static AcsChatMessageEditedEventData DeserializeAcsChatMessageEditedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> messageBody = default;
            Optional<IReadOnlyDictionary<string, string>> metadata = default;
            Optional<DateTimeOffset> editTime = default;
            Optional<string> messageId = default;
            Optional<CommunicationIdentifierModel> senderCommunicationIdentifier = default;
            Optional<string> senderDisplayName = default;
            Optional<DateTimeOffset> composeTime = default;
            Optional<string> type = default;
            Optional<long> version = default;
            Optional<CommunicationIdentifierModel> recipientCommunicationIdentifier = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageBody"u8))
                {
                    messageBody = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
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
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("editTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    editTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    senderCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("senderDisplayName"u8))
                {
                    senderDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("composeTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    composeTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                if (property.NameEquals("recipientCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recipientCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
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
            return new AcsChatMessageEditedEventData(recipientCommunicationIdentifier.Value, transactionId.Value, threadId.Value, messageId.Value, senderCommunicationIdentifier.Value, senderDisplayName.Value, Optional.ToNullable(composeTime), type.Value, Optional.ToNullable(version), messageBody.Value, Optional.ToDictionary(metadata), Optional.ToNullable(editTime), rawData);
        }

        AcsChatMessageEditedEventData IModelJsonSerializable<AcsChatMessageEditedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AcsChatMessageEditedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsChatMessageEditedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AcsChatMessageEditedEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AcsChatMessageEditedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AcsChatMessageEditedEventData IModelSerializable<AcsChatMessageEditedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AcsChatMessageEditedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAcsChatMessageEditedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AcsChatMessageEditedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AcsChatMessageEditedEventData"/> to convert. </param>
        public static implicit operator RequestContent(AcsChatMessageEditedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AcsChatMessageEditedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AcsChatMessageEditedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAcsChatMessageEditedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class AcsChatMessageEditedEventDataConverter : JsonConverter<AcsChatMessageEditedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatMessageEditedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsChatMessageEditedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatMessageEditedEventData(document.RootElement);
            }
        }
    }
}
