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
    public partial class SourceCodeRepoProperties : IUtf8JsonSerializable, IModelJsonSerializable<SourceCodeRepoProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SourceCodeRepoProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SourceCodeRepoProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceCodeRepoProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceControlType"u8);
            writer.WriteStringValue(SourceControlType.ToString());
            writer.WritePropertyName("repositoryUrl"u8);
            writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch"u8);
                writer.WriteStringValue(Branch);
            }
            if (Optional.IsDefined(SourceControlAuthProperties))
            {
                writer.WritePropertyName("sourceControlAuthProperties"u8);
                if (SourceControlAuthProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SourceCodeRepoAuthInfo>)SourceControlAuthProperties).Serialize(writer, options);
                }
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

        internal static SourceCodeRepoProperties DeserializeSourceCodeRepoProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceControlType sourceControlType = default;
            Uri repositoryUrl = default;
            Optional<string> branch = default;
            Optional<SourceCodeRepoAuthInfo> sourceControlAuthProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceControlType"u8))
                {
                    sourceControlType = new SourceControlType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("repositoryUrl"u8))
                {
                    repositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("branch"u8))
                {
                    branch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceControlAuthProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceControlAuthProperties = SourceCodeRepoAuthInfo.DeserializeSourceCodeRepoAuthInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SourceCodeRepoProperties(sourceControlType, repositoryUrl, branch.Value, sourceControlAuthProperties.Value, rawData);
        }

        SourceCodeRepoProperties IModelJsonSerializable<SourceCodeRepoProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceCodeRepoProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceCodeRepoProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SourceCodeRepoProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceCodeRepoProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SourceCodeRepoProperties IModelSerializable<SourceCodeRepoProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceCodeRepoProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSourceCodeRepoProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SourceCodeRepoProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SourceCodeRepoProperties"/> to convert. </param>
        public static implicit operator RequestContent(SourceCodeRepoProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SourceCodeRepoProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SourceCodeRepoProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSourceCodeRepoProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
