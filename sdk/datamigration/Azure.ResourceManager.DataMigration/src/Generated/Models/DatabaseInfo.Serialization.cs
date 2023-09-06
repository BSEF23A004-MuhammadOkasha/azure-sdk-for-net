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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseInfo : IUtf8JsonSerializable, IModelJsonSerializable<DatabaseInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DatabaseInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DatabaseInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatabaseInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceDatabaseName"u8);
            writer.WriteStringValue(SourceDatabaseName);
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

        internal static DatabaseInfo DeserializeDatabaseInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceDatabaseName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceDatabaseName"u8))
                {
                    sourceDatabaseName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DatabaseInfo(sourceDatabaseName, rawData);
        }

        DatabaseInfo IModelJsonSerializable<DatabaseInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatabaseInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DatabaseInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatabaseInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DatabaseInfo IModelSerializable<DatabaseInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatabaseInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDatabaseInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DatabaseInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DatabaseInfo"/> to convert. </param>
        public static implicit operator RequestContent(DatabaseInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DatabaseInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DatabaseInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDatabaseInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
