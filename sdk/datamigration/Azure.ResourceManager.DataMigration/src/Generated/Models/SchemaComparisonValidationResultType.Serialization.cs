// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SchemaComparisonValidationResultType : IUtf8JsonSerializable, IJsonModel<SchemaComparisonValidationResultType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SchemaComparisonValidationResultType>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SchemaComparisonValidationResultType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaComparisonValidationResultType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SchemaComparisonValidationResultType)} does not support '{format}' format.");
            }

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
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SchemaComparisonValidationResultType IJsonModel<SchemaComparisonValidationResultType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaComparisonValidationResultType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SchemaComparisonValidationResultType)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSchemaComparisonValidationResultType(document.RootElement, options);
        }

        internal static SchemaComparisonValidationResultType DeserializeSchemaComparisonValidationResultType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> objectName = default;
            Optional<ObjectType> objectType = default;
            Optional<UpdateActionType> updateAction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SchemaComparisonValidationResultType(objectName.Value, Optional.ToNullable(objectType), Optional.ToNullable(updateAction), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SchemaComparisonValidationResultType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaComparisonValidationResultType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SchemaComparisonValidationResultType)} does not support '{options.Format}' format.");
            }
        }

        SchemaComparisonValidationResultType IPersistableModel<SchemaComparisonValidationResultType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaComparisonValidationResultType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSchemaComparisonValidationResultType(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SchemaComparisonValidationResultType)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SchemaComparisonValidationResultType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
