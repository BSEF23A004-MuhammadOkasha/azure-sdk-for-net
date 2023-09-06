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
    public partial class SchemaComparisonValidationResultType : IUtf8JsonSerializable, IModelJsonSerializable<SchemaComparisonValidationResultType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SchemaComparisonValidationResultType>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SchemaComparisonValidationResultType>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SchemaComparisonValidationResultType>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ObjectName))
            {
                writer.WritePropertyName("objectName"u8);
                writer.WriteStringValue(ObjectName);
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType"u8);
                writer.WriteStringValue(ObjectType.Value.ToString());
            }
            if (Optional.IsDefined(UpdateAction))
            {
                writer.WritePropertyName("updateAction"u8);
                writer.WriteStringValue(UpdateAction.Value.ToString());
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

        internal static SchemaComparisonValidationResultType DeserializeSchemaComparisonValidationResultType(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> objectName = default;
            Optional<ObjectType> objectType = default;
            Optional<UpdateActionType> updateAction = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectName"u8))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectType = new ObjectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateAction = new UpdateActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SchemaComparisonValidationResultType(objectName.Value, Optional.ToNullable(objectType), Optional.ToNullable(updateAction), rawData);
        }

        SchemaComparisonValidationResultType IModelJsonSerializable<SchemaComparisonValidationResultType>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SchemaComparisonValidationResultType>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSchemaComparisonValidationResultType(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SchemaComparisonValidationResultType>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SchemaComparisonValidationResultType>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SchemaComparisonValidationResultType IModelSerializable<SchemaComparisonValidationResultType>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SchemaComparisonValidationResultType>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSchemaComparisonValidationResultType(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SchemaComparisonValidationResultType"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SchemaComparisonValidationResultType"/> to convert. </param>
        public static implicit operator RequestContent(SchemaComparisonValidationResultType model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SchemaComparisonValidationResultType"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SchemaComparisonValidationResultType(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSchemaComparisonValidationResultType(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
