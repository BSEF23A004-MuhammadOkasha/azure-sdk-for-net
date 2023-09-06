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

namespace Azure.Communication.Email
{
    public partial class EmailContent : IUtf8JsonSerializable, IModelJsonSerializable<EmailContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EmailContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EmailContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EmailContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("subject"u8);
            writer.WriteStringValue(Subject);
            if (Optional.IsDefined(PlainText))
            {
                writer.WritePropertyName("plainText"u8);
                writer.WriteStringValue(PlainText);
            }
            if (Optional.IsDefined(Html))
            {
                writer.WritePropertyName("html"u8);
                writer.WriteStringValue(Html);
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

        internal static EmailContent DeserializeEmailContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string subject = default;
            Optional<string> plainText = default;
            Optional<string> html = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("plainText"u8))
                {
                    plainText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("html"u8))
                {
                    html = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EmailContent(subject, plainText.Value, html.Value, rawData);
        }

        EmailContent IModelJsonSerializable<EmailContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EmailContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEmailContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EmailContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EmailContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EmailContent IModelSerializable<EmailContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EmailContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEmailContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EmailContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EmailContent"/> to convert. </param>
        public static implicit operator RequestContent(EmailContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EmailContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EmailContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEmailContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
