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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class TargetCopySetting : IUtf8JsonSerializable, IModelJsonSerializable<TargetCopySetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TargetCopySetting>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TargetCopySetting>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("copyAfter"u8);
            if (CopyAfter is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DataProtectionBackupCopySetting>)CopyAfter).Serialize(writer, options);
            }
            writer.WritePropertyName("dataStore"u8);
            if (DataStore is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DataStoreInfoBase>)DataStore).Serialize(writer, options);
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

        internal static TargetCopySetting DeserializeTargetCopySetting(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataProtectionBackupCopySetting copyAfter = default;
            DataStoreInfoBase dataStore = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyAfter"u8))
                {
                    copyAfter = DataProtectionBackupCopySetting.DeserializeDataProtectionBackupCopySetting(property.Value);
                    continue;
                }
                if (property.NameEquals("dataStore"u8))
                {
                    dataStore = DataStoreInfoBase.DeserializeDataStoreInfoBase(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TargetCopySetting(copyAfter, dataStore, rawData);
        }

        TargetCopySetting IModelJsonSerializable<TargetCopySetting>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetCopySetting(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TargetCopySetting>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TargetCopySetting IModelSerializable<TargetCopySetting>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTargetCopySetting(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TargetCopySetting"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TargetCopySetting"/> to convert. </param>
        public static implicit operator RequestContent(TargetCopySetting model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TargetCopySetting"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TargetCopySetting(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTargetCopySetting(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
