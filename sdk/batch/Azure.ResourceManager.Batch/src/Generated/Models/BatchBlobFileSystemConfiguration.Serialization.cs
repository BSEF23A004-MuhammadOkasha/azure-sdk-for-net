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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchBlobFileSystemConfiguration : IUtf8JsonSerializable, IJsonModel<BatchBlobFileSystemConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchBlobFileSystemConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchBlobFileSystemConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchBlobFileSystemConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BatchBlobFileSystemConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("accountName"u8);
            writer.WriteStringValue(AccountName);
            writer.WritePropertyName("containerName"u8);
            writer.WriteStringValue(ContainerName);
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey"u8);
                writer.WriteStringValue(AccountKey);
            }
            if (Optional.IsDefined(SasKey))
            {
                writer.WritePropertyName("sasKey"u8);
                writer.WriteStringValue(SasKey);
            }
            if (Optional.IsDefined(BlobfuseOptions))
            {
                writer.WritePropertyName("blobfuseOptions"u8);
                writer.WriteStringValue(BlobfuseOptions);
            }
            writer.WritePropertyName("relativeMountPath"u8);
            writer.WriteStringValue(RelativeMountPath);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identityReference"u8);
                writer.WriteObjectValue(Identity);
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

        BatchBlobFileSystemConfiguration IJsonModel<BatchBlobFileSystemConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchBlobFileSystemConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BatchBlobFileSystemConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchBlobFileSystemConfiguration(document.RootElement, options);
        }

        internal static BatchBlobFileSystemConfiguration DeserializeBatchBlobFileSystemConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountName = default;
            string containerName = default;
            Optional<string> accountKey = default;
            Optional<string> sasKey = default;
            Optional<string> blobfuseOptions = default;
            string relativeMountPath = default;
            Optional<ComputeNodeIdentityReference> identityReference = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountKey"u8))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasKey"u8))
                {
                    sasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobfuseOptions"u8))
                {
                    blobfuseOptions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeMountPath"u8))
                {
                    relativeMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityReference = ComputeNodeIdentityReference.DeserializeComputeNodeIdentityReference(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchBlobFileSystemConfiguration(accountName, containerName, accountKey.Value, sasKey.Value, blobfuseOptions.Value, relativeMountPath, identityReference.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchBlobFileSystemConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchBlobFileSystemConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BatchBlobFileSystemConfiguration)} does not support '{options.Format}' format.");
            }
        }

        BatchBlobFileSystemConfiguration IPersistableModel<BatchBlobFileSystemConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchBlobFileSystemConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchBlobFileSystemConfiguration(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BatchBlobFileSystemConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchBlobFileSystemConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
