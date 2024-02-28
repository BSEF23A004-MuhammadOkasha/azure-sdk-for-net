// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class SystemCreatedStorageAccount : IUtf8JsonSerializable, IJsonModel<SystemCreatedStorageAccount>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SystemCreatedStorageAccount>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SystemCreatedStorageAccount>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SystemCreatedStorageAccount)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AllowBlobPublicAccess.HasValue)
            {
                writer.WritePropertyName("allowBlobPublicAccess"u8);
                writer.WriteBooleanValue(AllowBlobPublicAccess.Value);
            }
            if (ArmResourceIdentifier != null)
            {
                if (ArmResourceIdentifier != null)
                {
                    writer.WritePropertyName("armResourceId"u8);
                    writer.WriteObjectValue(ArmResourceIdentifier);
                }
                else
                {
                    writer.WriteNull("armResourceId");
                }
            }
            if (StorageAccountHnsEnabled.HasValue)
            {
                writer.WritePropertyName("storageAccountHnsEnabled"u8);
                writer.WriteBooleanValue(StorageAccountHnsEnabled.Value);
            }
            if (StorageAccountName != null)
            {
                if (StorageAccountName != null)
                {
                    writer.WritePropertyName("storageAccountName"u8);
                    writer.WriteStringValue(StorageAccountName);
                }
                else
                {
                    writer.WriteNull("storageAccountName");
                }
            }
            if (StorageAccountType != null)
            {
                if (StorageAccountType != null)
                {
                    writer.WritePropertyName("storageAccountType"u8);
                    writer.WriteStringValue(StorageAccountType);
                }
                else
                {
                    writer.WriteNull("storageAccountType");
                }
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

        SystemCreatedStorageAccount IJsonModel<SystemCreatedStorageAccount>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SystemCreatedStorageAccount)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSystemCreatedStorageAccount(document.RootElement, options);
        }

        internal static SystemCreatedStorageAccount DeserializeSystemCreatedStorageAccount(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? allowBlobPublicAccess = default;
            ArmResourceId armResourceId = default;
            bool? storageAccountHnsEnabled = default;
            string storageAccountName = default;
            string storageAccountType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowBlobPublicAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowBlobPublicAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("armResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        armResourceId = null;
                        continue;
                    }
                    armResourceId = Models.ArmResourceId.DeserializeArmResourceId(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageAccountHnsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountHnsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("storageAccountName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        storageAccountName = null;
                        continue;
                    }
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        storageAccountType = null;
                        continue;
                    }
                    storageAccountType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SystemCreatedStorageAccount(
                allowBlobPublicAccess,
                armResourceId,
                storageAccountHnsEnabled,
                storageAccountName,
                storageAccountType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SystemCreatedStorageAccount>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SystemCreatedStorageAccount)} does not support '{options.Format}' format.");
            }
        }

        SystemCreatedStorageAccount IPersistableModel<SystemCreatedStorageAccount>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSystemCreatedStorageAccount(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SystemCreatedStorageAccount)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SystemCreatedStorageAccount>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
