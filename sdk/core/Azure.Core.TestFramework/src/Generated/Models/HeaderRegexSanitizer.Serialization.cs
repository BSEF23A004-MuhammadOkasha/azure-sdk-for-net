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

namespace Azure.Core.TestFramework.Models
{
    public partial class HeaderRegexSanitizer : IUtf8JsonSerializable, IModelJsonSerializable<HeaderRegexSanitizer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HeaderRegexSanitizer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HeaderRegexSanitizer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HeaderRegexSanitizer>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            writer.WriteStringValue(Key);
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            if (Optional.IsDefined(Regex))
            {
                writer.WritePropertyName("regex"u8);
                writer.WriteStringValue(Regex);
            }
            if (Optional.IsDefined(GroupForReplace))
            {
                writer.WritePropertyName("groupForReplace"u8);
                writer.WriteStringValue(GroupForReplace);
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

        internal static HeaderRegexSanitizer DeserializeHeaderRegexSanitizer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            string value = default;
            Optional<string> regex = default;
            Optional<string> groupForReplace = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regex"u8))
                {
                    regex = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupForReplace"u8))
                {
                    groupForReplace = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HeaderRegexSanitizer(key, value, regex.Value, groupForReplace.Value, rawData);
        }

        HeaderRegexSanitizer IModelJsonSerializable<HeaderRegexSanitizer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HeaderRegexSanitizer>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHeaderRegexSanitizer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HeaderRegexSanitizer>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HeaderRegexSanitizer>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HeaderRegexSanitizer IModelSerializable<HeaderRegexSanitizer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HeaderRegexSanitizer>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHeaderRegexSanitizer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HeaderRegexSanitizer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HeaderRegexSanitizer"/> to convert. </param>
        public static implicit operator RequestContent(HeaderRegexSanitizer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HeaderRegexSanitizer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HeaderRegexSanitizer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHeaderRegexSanitizer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
