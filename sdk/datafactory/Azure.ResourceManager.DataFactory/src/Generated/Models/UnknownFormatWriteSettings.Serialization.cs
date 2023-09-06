// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class UnknownFormatWriteSettings : IUtf8JsonSerializable, IModelJsonSerializable<FormatWriteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FormatWriteSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FormatWriteSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FormatWriteSettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FormatWriteSettingsType);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static FormatWriteSettings DeserializeUnknownFormatWriteSettings(JsonElement element, ModelSerializerOptions options = default) => DeserializeFormatWriteSettings(element, options);

        FormatWriteSettings IModelJsonSerializable<FormatWriteSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FormatWriteSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownFormatWriteSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FormatWriteSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FormatWriteSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FormatWriteSettings IModelSerializable<FormatWriteSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FormatWriteSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFormatWriteSettings(doc.RootElement, options);
        }
    }
}
