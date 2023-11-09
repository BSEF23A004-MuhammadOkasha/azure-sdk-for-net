// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    public partial class JobDetails : IUtf8JsonSerializable, IJsonModel<JobDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<JobDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("containerUri"u8);
            writer.WriteStringValue(ContainerUri);
            if (Optional.IsDefined(InputDataUri))
            {
                writer.WritePropertyName("inputDataUri"u8);
                writer.WriteStringValue(InputDataUri);
            }
            writer.WritePropertyName("inputDataFormat"u8);
            writer.WriteStringValue(InputDataFormat);
            if (Optional.IsDefined(InputParams))
            {
                writer.WritePropertyName("inputParams"u8);
                writer.WriteObjectValue(InputParams);
            }
            writer.WritePropertyName("providerId"u8);
            writer.WriteStringValue(ProviderId);
            writer.WritePropertyName("target"u8);
            writer.WriteStringValue(Target);
            if (Optional.IsCollectionDefined(Metadata))
            {
                if (Metadata != null)
                {
                    writer.WritePropertyName("metadata"u8);
                    writer.WriteStartObject();
                    foreach (var item in Metadata)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("metadata");
                }
            }
            if (Optional.IsDefined(OutputDataUri))
            {
                writer.WritePropertyName("outputDataUri"u8);
                writer.WriteStringValue(OutputDataUri);
            }
            if (Optional.IsDefined(OutputDataFormat))
            {
                writer.WritePropertyName("outputDataFormat"u8);
                writer.WriteStringValue(OutputDataFormat);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CreationTime))
                {
                    writer.WritePropertyName("creationTime"u8);
                    writer.WriteStringValue(CreationTime.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(BeginExecutionTime))
                {
                    if (BeginExecutionTime != null)
                    {
                        writer.WritePropertyName("beginExecutionTime"u8);
                        writer.WriteStringValue(BeginExecutionTime.Value, "O");
                    }
                    else
                    {
                        writer.WriteNull("beginExecutionTime");
                    }
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(EndExecutionTime))
                {
                    if (EndExecutionTime != null)
                    {
                        writer.WritePropertyName("endExecutionTime"u8);
                        writer.WriteStringValue(EndExecutionTime.Value, "O");
                    }
                    else
                    {
                        writer.WriteNull("endExecutionTime");
                    }
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CancellationTime))
                {
                    if (CancellationTime != null)
                    {
                        writer.WritePropertyName("cancellationTime"u8);
                        writer.WriteStringValue(CancellationTime.Value, "O");
                    }
                    else
                    {
                        writer.WriteNull("cancellationTime");
                    }
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CostEstimate))
                {
                    if (CostEstimate != null)
                    {
                        writer.WritePropertyName("costEstimate"u8);
                        writer.WriteObjectValue(CostEstimate);
                    }
                    else
                    {
                        writer.WriteNull("costEstimate");
                    }
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ErrorData))
                {
                    if (ErrorData != null)
                    {
                        writer.WritePropertyName("errorData"u8);
                        writer.WriteObjectValue(ErrorData);
                    }
                    else
                    {
                        writer.WriteNull("errorData");
                    }
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartArray();
                    foreach (var item in Tags)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("tags");
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        JobDetails IJsonModel<JobDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(JobDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobDetails(document.RootElement, options);
        }

        internal static JobDetails DeserializeJobDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            string containerUri = default;
            Optional<string> inputDataUri = default;
            string inputDataFormat = default;
            Optional<object> inputParams = default;
            string providerId = default;
            string target = default;
            Optional<IDictionary<string, string>> metadata = default;
            Optional<string> outputDataUri = default;
            Optional<string> outputDataFormat = default;
            Optional<JobStatus> status = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset?> beginExecutionTime = default;
            Optional<DateTimeOffset?> endExecutionTime = default;
            Optional<DateTimeOffset?> cancellationTime = default;
            Optional<CostEstimate> costEstimate = default;
            Optional<ErrorData> errorData = default;
            Optional<IList<string>> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerUri"u8))
                {
                    containerUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDataUri"u8))
                {
                    inputDataUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDataFormat"u8))
                {
                    inputDataFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputParams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inputParams = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("providerId"u8))
                {
                    providerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("outputDataUri"u8))
                {
                    outputDataUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputDataFormat"u8))
                {
                    outputDataFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new JobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("beginExecutionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beginExecutionTime = null;
                        continue;
                    }
                    beginExecutionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endExecutionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endExecutionTime = null;
                        continue;
                    }
                    endExecutionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cancellationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cancellationTime = null;
                        continue;
                    }
                    cancellationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("costEstimate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        costEstimate = null;
                        continue;
                    }
                    costEstimate = CostEstimate.DeserializeCostEstimate(property.Value);
                    continue;
                }
                if (property.NameEquals("errorData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errorData = null;
                        continue;
                    }
                    errorData = ErrorData.DeserializeErrorData(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JobDetails(id.Value, name.Value, containerUri, inputDataUri.Value, inputDataFormat, inputParams.Value, providerId, target, Optional.ToDictionary(metadata), outputDataUri.Value, outputDataFormat.Value, Optional.ToNullable(status), Optional.ToNullable(creationTime), Optional.ToNullable(beginExecutionTime), Optional.ToNullable(endExecutionTime), Optional.ToNullable(cancellationTime), costEstimate.Value, errorData.Value, Optional.ToList(tags), serializedAdditionalRawData);
        }

        BinaryData IModel<JobDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(JobDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        JobDetails IModel<JobDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(JobDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeJobDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<JobDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
