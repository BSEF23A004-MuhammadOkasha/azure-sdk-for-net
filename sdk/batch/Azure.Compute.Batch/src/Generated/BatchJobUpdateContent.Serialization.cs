// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchJobUpdateContent : IUtf8JsonSerializable, IJsonModel<BatchJobUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchJobUpdateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchJobUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchJobUpdateContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(AllowTaskPreemption))
            {
                writer.WritePropertyName("allowTaskPreemption"u8);
                writer.WriteBooleanValue(AllowTaskPreemption.Value);
            }
            if (Optional.IsDefined(MaxParallelTasks))
            {
                writer.WritePropertyName("maxParallelTasks"u8);
                writer.WriteNumberValue(MaxParallelTasks.Value);
            }
            if (Optional.IsDefined(Constraints))
            {
                writer.WritePropertyName("constraints"u8);
                writer.WriteObjectValue(Constraints, options);
            }
            if (Optional.IsDefined(PoolInfo))
            {
                writer.WritePropertyName("poolInfo"u8);
                writer.WriteObjectValue(PoolInfo, options);
            }
            if (Optional.IsDefined(OnAllTasksComplete))
            {
                writer.WritePropertyName("onAllTasksComplete"u8);
                writer.WriteStringValue(OnAllTasksComplete.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration, options);
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
        }

        BatchJobUpdateContent IJsonModel<BatchJobUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchJobUpdateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchJobUpdateContent(document.RootElement, options);
        }

        internal static BatchJobUpdateContent DeserializeBatchJobUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? priority = default;
            bool? allowTaskPreemption = default;
            int? maxParallelTasks = default;
            BatchJobConstraints constraints = default;
            BatchPoolInfo poolInfo = default;
            OnAllBatchTasksComplete? onAllTasksComplete = default;
            IList<MetadataItem> metadata = default;
            BatchJobNetworkConfiguration networkConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowTaskPreemption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowTaskPreemption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxParallelTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxParallelTasks = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("constraints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    constraints = BatchJobConstraints.DeserializeBatchJobConstraints(property.Value, options);
                    continue;
                }
                if (property.NameEquals("poolInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    poolInfo = BatchPoolInfo.DeserializeBatchPoolInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("onAllTasksComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onAllTasksComplete = new OnAllBatchTasksComplete(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetadataItem> array = new List<MetadataItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetadataItem.DeserializeMetadataItem(item, options));
                    }
                    metadata = array;
                    continue;
                }
                if (property.NameEquals("networkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkConfiguration = BatchJobNetworkConfiguration.DeserializeBatchJobNetworkConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchJobUpdateContent(
                priority,
                allowTaskPreemption,
                maxParallelTasks,
                constraints,
                poolInfo,
                onAllTasksComplete,
                metadata ?? new ChangeTrackingList<MetadataItem>(),
                networkConfiguration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchJobUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchJobUpdateContent)} does not support writing '{options.Format}' format.");
            }
        }

        BatchJobUpdateContent IPersistableModel<BatchJobUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchJobUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchJobUpdateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchJobUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchJobUpdateContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBatchJobUpdateContent(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
