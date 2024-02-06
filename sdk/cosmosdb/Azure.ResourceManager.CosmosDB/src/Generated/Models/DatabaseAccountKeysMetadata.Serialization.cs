// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class DatabaseAccountKeysMetadata : IUtf8JsonSerializable, IJsonModel<DatabaseAccountKeysMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseAccountKeysMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatabaseAccountKeysMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseAccountKeysMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseAccountKeysMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PrimaryMasterKey))
            {
                writer.WritePropertyName("primaryMasterKey"u8);
                BinaryData data = ModelReaderWriter.Write(PrimaryMasterKey, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryMasterKey))
            {
                writer.WritePropertyName("secondaryMasterKey"u8);
                BinaryData data = ModelReaderWriter.Write(SecondaryMasterKey, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(PrimaryReadonlyMasterKey))
            {
                writer.WritePropertyName("primaryReadonlyMasterKey"u8);
                BinaryData data = ModelReaderWriter.Write(PrimaryReadonlyMasterKey, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryReadonlyMasterKey))
            {
                writer.WritePropertyName("secondaryReadonlyMasterKey"u8);
                BinaryData data = ModelReaderWriter.Write(SecondaryReadonlyMasterKey, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        DatabaseAccountKeysMetadata IJsonModel<DatabaseAccountKeysMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseAccountKeysMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseAccountKeysMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseAccountKeysMetadata(document.RootElement, options);
        }

        internal static DatabaseAccountKeysMetadata DeserializeDatabaseAccountKeysMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AccountKeyMetadata> primaryMasterKey = default;
            Optional<AccountKeyMetadata> secondaryMasterKey = default;
            Optional<AccountKeyMetadata> primaryReadonlyMasterKey = default;
            Optional<AccountKeyMetadata> secondaryReadonlyMasterKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMasterKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMasterKey = AccountKeyMetadata.DeserializeAccountKeyMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("secondaryMasterKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryMasterKey = AccountKeyMetadata.DeserializeAccountKeyMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryReadonlyMasterKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryReadonlyMasterKey = AccountKeyMetadata.DeserializeAccountKeyMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("secondaryReadonlyMasterKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryReadonlyMasterKey = AccountKeyMetadata.DeserializeAccountKeyMetadata(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DatabaseAccountKeysMetadata(primaryMasterKey.Value, secondaryMasterKey.Value, primaryReadonlyMasterKey.Value, secondaryReadonlyMasterKey.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DatabaseAccountKeysMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseAccountKeysMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatabaseAccountKeysMetadata)} does not support '{options.Format}' format.");
            }
        }

        DatabaseAccountKeysMetadata IPersistableModel<DatabaseAccountKeysMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseAccountKeysMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatabaseAccountKeysMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatabaseAccountKeysMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatabaseAccountKeysMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
