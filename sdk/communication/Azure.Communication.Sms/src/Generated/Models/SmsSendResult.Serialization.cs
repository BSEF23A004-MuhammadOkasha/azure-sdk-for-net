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

namespace Azure.Communication.Sms
{
    public partial class SmsSendResult : IUtf8JsonSerializable, IModelJsonSerializable<SmsSendResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SmsSendResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SmsSendResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SmsSendResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("to"u8);
            writer.WriteStringValue(To);
            if (Optional.IsDefined(MessageId))
            {
                writer.WritePropertyName("messageId"u8);
                writer.WriteStringValue(MessageId);
            }
            writer.WritePropertyName("httpStatusCode"u8);
            writer.WriteNumberValue(HttpStatusCode);
            if (Optional.IsDefined(RepeatabilityResult))
            {
                writer.WritePropertyName("repeatabilityResult"u8);
                writer.WriteStringValue(RepeatabilityResult.Value.ToString());
            }
            writer.WritePropertyName("successful"u8);
            writer.WriteBooleanValue(Successful);
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
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

        internal static SmsSendResult DeserializeSmsSendResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string to = default;
            Optional<string> messageId = default;
            int httpStatusCode = default;
            Optional<SmsSendResponseItemRepeatabilityResult> repeatabilityResult = default;
            bool successful = default;
            Optional<string> errorMessage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpStatusCode"u8))
                {
                    httpStatusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("repeatabilityResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repeatabilityResult = new SmsSendResponseItemRepeatabilityResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("successful"u8))
                {
                    successful = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SmsSendResult(to, messageId.Value, httpStatusCode, Optional.ToNullable(repeatabilityResult), successful, errorMessage.Value, rawData);
        }

        SmsSendResult IModelJsonSerializable<SmsSendResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SmsSendResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSmsSendResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SmsSendResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SmsSendResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SmsSendResult IModelSerializable<SmsSendResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SmsSendResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSmsSendResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SmsSendResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SmsSendResult"/> to convert. </param>
        public static implicit operator RequestContent(SmsSendResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SmsSendResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SmsSendResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSmsSendResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
