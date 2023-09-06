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

namespace Azure.ResourceManager.Communication.Models
{
    public partial class DomainsRecordVerificationContent : IUtf8JsonSerializable, IModelJsonSerializable<DomainsRecordVerificationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DomainsRecordVerificationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DomainsRecordVerificationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DomainsRecordVerificationContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("verificationType"u8);
            writer.WriteStringValue(VerificationType.ToString());
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

        internal static DomainsRecordVerificationContent DeserializeDomainsRecordVerificationContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DomainRecordVerificationType verificationType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verificationType"u8))
                {
                    verificationType = new DomainRecordVerificationType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DomainsRecordVerificationContent(verificationType, rawData);
        }

        DomainsRecordVerificationContent IModelJsonSerializable<DomainsRecordVerificationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DomainsRecordVerificationContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDomainsRecordVerificationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DomainsRecordVerificationContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DomainsRecordVerificationContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DomainsRecordVerificationContent IModelSerializable<DomainsRecordVerificationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DomainsRecordVerificationContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDomainsRecordVerificationContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DomainsRecordVerificationContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DomainsRecordVerificationContent"/> to convert. </param>
        public static implicit operator RequestContent(DomainsRecordVerificationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DomainsRecordVerificationContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DomainsRecordVerificationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDomainsRecordVerificationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
