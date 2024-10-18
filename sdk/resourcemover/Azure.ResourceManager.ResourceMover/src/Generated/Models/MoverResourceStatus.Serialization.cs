// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceStatus : IUtf8JsonSerializable, IJsonModel<MoverResourceStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverResourceStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MoverResourceStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverResourceStatus)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(MoveState))
            {
                writer.WritePropertyName("moveState"u8);
                writer.WriteStringValue(MoveState.Value.ToString());
            }
            if (Optional.IsDefined(JobStatus))
            {
                if (JobStatus != null)
                {
                    writer.WritePropertyName("jobStatus"u8);
                    writer.WriteObjectValue(JobStatus, options);
                }
                else
                {
                    writer.WriteNull("jobStatus");
                }
            }
            if (Optional.IsDefined(Errors))
            {
                if (Errors != null)
                {
                    writer.WritePropertyName("errors"u8);
                    writer.WriteObjectValue(Errors, options);
                }
                else
                {
                    writer.WriteNull("errors");
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
        }

        MoverResourceStatus IJsonModel<MoverResourceStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverResourceStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverResourceStatus(document.RootElement, options);
        }

        internal static MoverResourceStatus DeserializeMoverResourceStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MoverResourceMoveState? moveState = default;
            MoverResourceJobStatus jobStatus = default;
            MoveResourceError errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("moveState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveState = new MoverResourceMoveState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobStatus = null;
                        continue;
                    }
                    jobStatus = MoverResourceJobStatus.DeserializeMoverResourceJobStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errors = null;
                        continue;
                    }
                    errors = MoveResourceError.DeserializeMoveResourceError(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MoverResourceStatus(moveState, jobStatus, errors, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverResourceStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MoverResourceStatus)} does not support writing '{options.Format}' format.");
            }
        }

        MoverResourceStatus IPersistableModel<MoverResourceStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoverResourceStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoverResourceStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverResourceStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
