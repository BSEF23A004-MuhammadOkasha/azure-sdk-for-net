// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedRestorableSqlDatabaseResourceInfo : IUtf8JsonSerializable, IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>, IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Rid))
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(EventTimestamp))
            {
                writer.WritePropertyName("eventTimestamp"u8);
                writer.WriteStringValue(EventTimestamp);
            }
            if (options.Format != "W" && Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("ownerId"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(DatabaseId))
            {
                writer.WritePropertyName("ownerResourceId"u8);
                writer.WriteStringValue(DatabaseId);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                writer.WriteObjectValue(Database);
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

        ExtendedRestorableSqlDatabaseResourceInfo IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedRestorableSqlDatabaseResourceInfo(document.RootElement, options);
        }

        internal static ExtendedRestorableSqlDatabaseResourceInfo DeserializeExtendedRestorableSqlDatabaseResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rid = default;
            Optional<CosmosDBOperationType> operationType = default;
            Optional<string> eventTimestamp = default;
            Optional<string> ownerId = default;
            Optional<string> ownerResourceId = default;
            Optional<RestorableSqlDatabasePropertiesResourceDatabase> database = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new CosmosDBOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventTimestamp"u8))
                {
                    eventTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerId"u8))
                {
                    ownerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerResourceId"u8))
                {
                    ownerResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    database = RestorableSqlDatabasePropertiesResourceDatabase.DeserializeRestorableSqlDatabasePropertiesResourceDatabase(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExtendedRestorableSqlDatabaseResourceInfo(rid.Value, Optional.ToNullable(operationType), eventTimestamp.Value, ownerId.Value, ownerResourceId.Value, database.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Rid))
            {
                builder.Append("  _rid:");
                builder.AppendLine($" '{Rid}'");
            }

            if (Optional.IsDefined(OperationType))
            {
                builder.Append("  operationType:");
                builder.AppendLine($" '{OperationType.ToString()}'");
            }

            if (Optional.IsDefined(EventTimestamp))
            {
                builder.Append("  eventTimestamp:");
                builder.AppendLine($" '{EventTimestamp}'");
            }

            if (Optional.IsDefined(DatabaseName))
            {
                builder.Append("  ownerId:");
                builder.AppendLine($" '{DatabaseName}'");
            }

            if (Optional.IsDefined(DatabaseId))
            {
                builder.Append("  ownerResourceId:");
                builder.AppendLine($" '{DatabaseId}'");
            }

            if (Optional.IsDefined(Database))
            {
                builder.Append("  database:");
                AppendChildObject(builder, Database, options, 2);
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        ExtendedRestorableSqlDatabaseResourceInfo IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedRestorableSqlDatabaseResourceInfo(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
