// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Communication.Identity;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.Identity.Models
{
    internal partial class CommunicationIdentityCreateRequest : IUtf8JsonSerializable, IModelJsonSerializable<CommunicationIdentityCreateRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CommunicationIdentityCreateRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CommunicationIdentityCreateRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommunicationIdentityCreateRequest>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CreateTokenWithScopes))
            {
                writer.WritePropertyName("createTokenWithScopes"u8);
                writer.WriteStartArray();
                foreach (var item in CreateTokenWithScopes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExpiresInMinutes))
            {
                writer.WritePropertyName("expiresInMinutes"u8);
                writer.WriteNumberValue(ExpiresInMinutes.Value);
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

        internal static CommunicationIdentityCreateRequest DeserializeCommunicationIdentityCreateRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<CommunicationTokenScope>> createTokenWithScopes = default;
            Optional<int> expiresInMinutes = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createTokenWithScopes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommunicationTokenScope> array = new List<CommunicationTokenScope>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new CommunicationTokenScope(item.GetString()));
                    }
                    createTokenWithScopes = array;
                    continue;
                }
                if (property.NameEquals("expiresInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CommunicationIdentityCreateRequest(Optional.ToList(createTokenWithScopes), Optional.ToNullable(expiresInMinutes), rawData);
        }

        CommunicationIdentityCreateRequest IModelJsonSerializable<CommunicationIdentityCreateRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommunicationIdentityCreateRequest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunicationIdentityCreateRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CommunicationIdentityCreateRequest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommunicationIdentityCreateRequest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CommunicationIdentityCreateRequest IModelSerializable<CommunicationIdentityCreateRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommunicationIdentityCreateRequest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCommunicationIdentityCreateRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CommunicationIdentityCreateRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CommunicationIdentityCreateRequest"/> to convert. </param>
        public static implicit operator RequestContent(CommunicationIdentityCreateRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CommunicationIdentityCreateRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CommunicationIdentityCreateRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCommunicationIdentityCreateRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
