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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceOSOptionProperty : IUtf8JsonSerializable, IModelJsonSerializable<ContainerServiceOSOptionProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerServiceOSOptionProperty>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerServiceOSOptionProperty>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerServiceOSOptionProperty>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("os-type"u8);
            writer.WriteStringValue(OSType);
            writer.WritePropertyName("enable-fips-image"u8);
            writer.WriteBooleanValue(EnableFipsImage);
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

        internal static ContainerServiceOSOptionProperty DeserializeContainerServiceOSOptionProperty(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string osType = default;
            bool enableFipsImage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("os-type"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enable-fips-image"u8))
                {
                    enableFipsImage = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerServiceOSOptionProperty(osType, enableFipsImage, rawData);
        }

        ContainerServiceOSOptionProperty IModelJsonSerializable<ContainerServiceOSOptionProperty>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerServiceOSOptionProperty>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceOSOptionProperty(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerServiceOSOptionProperty>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerServiceOSOptionProperty>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerServiceOSOptionProperty IModelSerializable<ContainerServiceOSOptionProperty>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerServiceOSOptionProperty>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerServiceOSOptionProperty(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerServiceOSOptionProperty"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerServiceOSOptionProperty"/> to convert. </param>
        public static implicit operator RequestContent(ContainerServiceOSOptionProperty model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerServiceOSOptionProperty"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerServiceOSOptionProperty(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerServiceOSOptionProperty(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
