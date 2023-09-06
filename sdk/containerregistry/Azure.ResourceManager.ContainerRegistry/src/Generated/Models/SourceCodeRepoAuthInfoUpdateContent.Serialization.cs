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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class SourceCodeRepoAuthInfoUpdateContent : IUtf8JsonSerializable, IModelJsonSerializable<SourceCodeRepoAuthInfoUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SourceCodeRepoAuthInfoUpdateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SourceCodeRepoAuthInfoUpdateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceCodeRepoAuthInfoUpdateContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TokenType))
            {
                writer.WritePropertyName("tokenType"u8);
                writer.WriteStringValue(TokenType.Value.ToString());
            }
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            if (Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken"u8);
                writer.WriteStringValue(RefreshToken);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(ExpiresIn))
            {
                writer.WritePropertyName("expiresIn"u8);
                writer.WriteNumberValue(ExpiresIn.Value);
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

        internal static SourceCodeRepoAuthInfoUpdateContent DeserializeSourceCodeRepoAuthInfoUpdateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SourceCodeRepoAuthTokenType> tokenType = default;
            Optional<string> token = default;
            Optional<string> refreshToken = default;
            Optional<string> scope = default;
            Optional<int> expiresIn = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tokenType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tokenType = new SourceCodeRepoAuthTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshToken"u8))
                {
                    refreshToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiresIn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresIn = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SourceCodeRepoAuthInfoUpdateContent(Optional.ToNullable(tokenType), token.Value, refreshToken.Value, scope.Value, Optional.ToNullable(expiresIn), rawData);
        }

        SourceCodeRepoAuthInfoUpdateContent IModelJsonSerializable<SourceCodeRepoAuthInfoUpdateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceCodeRepoAuthInfoUpdateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceCodeRepoAuthInfoUpdateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SourceCodeRepoAuthInfoUpdateContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceCodeRepoAuthInfoUpdateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SourceCodeRepoAuthInfoUpdateContent IModelSerializable<SourceCodeRepoAuthInfoUpdateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceCodeRepoAuthInfoUpdateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSourceCodeRepoAuthInfoUpdateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SourceCodeRepoAuthInfoUpdateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SourceCodeRepoAuthInfoUpdateContent"/> to convert. </param>
        public static implicit operator RequestContent(SourceCodeRepoAuthInfoUpdateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SourceCodeRepoAuthInfoUpdateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SourceCodeRepoAuthInfoUpdateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSourceCodeRepoAuthInfoUpdateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
