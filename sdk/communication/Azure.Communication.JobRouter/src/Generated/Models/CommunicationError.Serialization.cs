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

namespace Azure.Communication.JobRouter.Models
{
    internal partial class CommunicationError : IUtf8JsonSerializable, IModelJsonSerializable<CommunicationError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CommunicationError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CommunicationError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommunicationError>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("code"u8);
            writer.WriteStringValue(Code);
            writer.WritePropertyName("message"u8);
            writer.WriteStringValue(Message);
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

        internal static CommunicationError DeserializeCommunicationError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<CommunicationError>> details = default;
            Optional<CommunicationError> innererror = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommunicationError> array = new List<CommunicationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeCommunicationError(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("innererror"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    innererror = DeserializeCommunicationError(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CommunicationError(code, message, target.Value, Optional.ToList(details), innererror.Value, rawData);
        }

        CommunicationError IModelJsonSerializable<CommunicationError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommunicationError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunicationError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CommunicationError>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommunicationError>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CommunicationError IModelSerializable<CommunicationError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommunicationError>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCommunicationError(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CommunicationError"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CommunicationError"/> to convert. </param>
        public static implicit operator RequestContent(CommunicationError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CommunicationError"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CommunicationError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCommunicationError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
