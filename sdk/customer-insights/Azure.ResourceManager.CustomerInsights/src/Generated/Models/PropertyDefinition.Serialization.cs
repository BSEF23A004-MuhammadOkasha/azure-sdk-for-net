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
    public partial class PropertyDefinition : IUtf8JsonSerializable, IModelJsonSerializable<PropertyDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PropertyDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PropertyDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PropertyDefinition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ArrayValueSeparator))
            {
                writer.WritePropertyName("arrayValueSeparator"u8);
                writer.WriteStringValue(ArrayValueSeparator);
            }
            if (Optional.IsCollectionDefined(EnumValidValues))
            {
                writer.WritePropertyName("enumValidValues"u8);
                writer.WriteStartArray();
                foreach (var item in EnumValidValues)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ProfileEnumValidValuesFormat>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("fieldName"u8);
            writer.WriteStringValue(FieldName);
            writer.WritePropertyName("fieldType"u8);
            writer.WriteStringValue(FieldType);
            if (Optional.IsDefined(IsArray))
            {
                writer.WritePropertyName("isArray"u8);
                writer.WriteBooleanValue(IsArray.Value);
            }
            if (Optional.IsDefined(IsEnum))
            {
                writer.WritePropertyName("isEnum"u8);
                writer.WriteBooleanValue(IsEnum.Value);
            }
            if (Optional.IsDefined(IsFlagEnum))
            {
                writer.WritePropertyName("isFlagEnum"u8);
                writer.WriteBooleanValue(IsFlagEnum.Value);
            }
            if (Optional.IsDefined(IsImage))
            {
                writer.WritePropertyName("isImage"u8);
                writer.WriteBooleanValue(IsImage.Value);
            }
            if (Optional.IsDefined(IsLocalizedString))
            {
                writer.WritePropertyName("isLocalizedString"u8);
                writer.WriteBooleanValue(IsLocalizedString.Value);
            }
            if (Optional.IsDefined(IsName))
            {
                writer.WritePropertyName("isName"u8);
                writer.WriteBooleanValue(IsName.Value);
            }
            if (Optional.IsDefined(IsRequired))
            {
                writer.WritePropertyName("isRequired"u8);
                writer.WriteBooleanValue(IsRequired.Value);
            }
            if (Optional.IsDefined(PropertyId))
            {
                writer.WritePropertyName("propertyId"u8);
                writer.WriteStringValue(PropertyId);
            }
            if (Optional.IsDefined(SchemaItemPropLink))
            {
                writer.WritePropertyName("schemaItemPropLink"u8);
                writer.WriteStringValue(SchemaItemPropLink);
            }
            if (Optional.IsDefined(MaxLength))
            {
                writer.WritePropertyName("maxLength"u8);
                writer.WriteNumberValue(MaxLength.Value);
            }
            if (Optional.IsDefined(IsAvailableInGraph))
            {
                writer.WritePropertyName("isAvailableInGraph"u8);
                writer.WriteBooleanValue(IsAvailableInGraph.Value);
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

        internal static PropertyDefinition DeserializePropertyDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> arrayValueSeparator = default;
            Optional<IList<ProfileEnumValidValuesFormat>> enumValidValues = default;
            string fieldName = default;
            string fieldType = default;
            Optional<bool> isArray = default;
            Optional<bool> isEnum = default;
            Optional<bool> isFlagEnum = default;
            Optional<bool> isImage = default;
            Optional<bool> isLocalizedString = default;
            Optional<bool> isName = default;
            Optional<bool> isRequired = default;
            Optional<string> propertyId = default;
            Optional<string> schemaItemPropLink = default;
            Optional<int> maxLength = default;
            Optional<bool> isAvailableInGraph = default;
            Optional<IReadOnlyList<DataSourcePrecedence>> dataSourcePrecedenceRules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arrayValueSeparator"u8))
                {
                    arrayValueSeparator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enumValidValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProfileEnumValidValuesFormat> array = new List<ProfileEnumValidValuesFormat>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProfileEnumValidValuesFormat.DeserializeProfileEnumValidValuesFormat(item));
                    }
                    enumValidValues = array;
                    continue;
                }
                if (property.NameEquals("fieldName"u8))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fieldType"u8))
                {
                    fieldType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isArray"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArray = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnum = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isFlagEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isFlagEnum = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isImage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isImage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isLocalizedString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLocalizedString = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isName = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("propertyId"u8))
                {
                    propertyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaItemPropLink"u8))
                {
                    schemaItemPropLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isAvailableInGraph"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAvailableInGraph = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dataSourcePrecedenceRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataSourcePrecedence> array = new List<DataSourcePrecedence>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataSourcePrecedence.DeserializeDataSourcePrecedence(item));
                    }
                    dataSourcePrecedenceRules = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PropertyDefinition(arrayValueSeparator.Value, Optional.ToList(enumValidValues), fieldName, fieldType, Optional.ToNullable(isArray), Optional.ToNullable(isEnum), Optional.ToNullable(isFlagEnum), Optional.ToNullable(isImage), Optional.ToNullable(isLocalizedString), Optional.ToNullable(isName), Optional.ToNullable(isRequired), propertyId.Value, schemaItemPropLink.Value, Optional.ToNullable(maxLength), Optional.ToNullable(isAvailableInGraph), Optional.ToList(dataSourcePrecedenceRules), rawData);
        }

        PropertyDefinition IModelJsonSerializable<PropertyDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PropertyDefinition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePropertyDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PropertyDefinition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PropertyDefinition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PropertyDefinition IModelSerializable<PropertyDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PropertyDefinition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePropertyDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PropertyDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PropertyDefinition"/> to convert. </param>
        public static implicit operator RequestContent(PropertyDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PropertyDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PropertyDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePropertyDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
