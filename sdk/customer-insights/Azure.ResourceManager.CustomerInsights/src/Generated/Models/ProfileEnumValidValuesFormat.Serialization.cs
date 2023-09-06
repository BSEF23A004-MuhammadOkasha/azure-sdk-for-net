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

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ProfileEnumValidValuesFormat : IUtf8JsonSerializable, IModelJsonSerializable<ProfileEnumValidValuesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProfileEnumValidValuesFormat>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProfileEnumValidValuesFormat>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProfileEnumValidValuesFormat>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            if (Optional.IsCollectionDefined(LocalizedValueNames))
            {
                writer.WritePropertyName("localizedValueNames"u8);
                writer.WriteStartObject();
                foreach (var item in LocalizedValueNames)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static ProfileEnumValidValuesFormat DeserializeProfileEnumValidValuesFormat(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> value = default;
            Optional<IDictionary<string, string>> localizedValueNames = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("localizedValueNames"u8))
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
                    localizedValueNames = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProfileEnumValidValuesFormat(Optional.ToNullable(value), Optional.ToDictionary(localizedValueNames), rawData);
        }

        ProfileEnumValidValuesFormat IModelJsonSerializable<ProfileEnumValidValuesFormat>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProfileEnumValidValuesFormat>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProfileEnumValidValuesFormat(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProfileEnumValidValuesFormat>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProfileEnumValidValuesFormat>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProfileEnumValidValuesFormat IModelSerializable<ProfileEnumValidValuesFormat>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProfileEnumValidValuesFormat>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProfileEnumValidValuesFormat(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProfileEnumValidValuesFormat"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProfileEnumValidValuesFormat"/> to convert. </param>
        public static implicit operator RequestContent(ProfileEnumValidValuesFormat model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProfileEnumValidValuesFormat"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProfileEnumValidValuesFormat(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProfileEnumValidValuesFormat(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
