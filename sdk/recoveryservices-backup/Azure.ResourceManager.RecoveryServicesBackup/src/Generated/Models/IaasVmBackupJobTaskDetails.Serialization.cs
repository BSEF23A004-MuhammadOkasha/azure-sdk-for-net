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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IaasVmBackupJobTaskDetails : IUtf8JsonSerializable, IJsonModel<IaasVmBackupJobTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmBackupJobTaskDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<IaasVmBackupJobTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TaskId))
            {
                writer.WritePropertyName("taskId"u8);
                writer.WriteStringValue(TaskId);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(InstanceId))
            {
                writer.WritePropertyName("instanceId"u8);
                writer.WriteStringValue(InstanceId);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "P");
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(ProgressPercentage))
            {
                writer.WritePropertyName("progressPercentage"u8);
                writer.WriteNumberValue(ProgressPercentage.Value);
            }
            if (Optional.IsDefined(TaskExecutionDetails))
            {
                writer.WritePropertyName("taskExecutionDetails"u8);
                writer.WriteStringValue(TaskExecutionDetails);
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

        IaasVmBackupJobTaskDetails IJsonModel<IaasVmBackupJobTaskDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IaasVmBackupJobTaskDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmBackupJobTaskDetails(document.RootElement, options);
        }

        internal static IaasVmBackupJobTaskDetails DeserializeIaasVmBackupJobTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> taskId = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> instanceId = default;
            Optional<TimeSpan> duration = default;
            Optional<string> status = default;
            Optional<double> progressPercentage = default;
            Optional<string> taskExecutionDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("taskId"u8))
                {
                    taskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("instanceId"u8))
                {
                    instanceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("progressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressPercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("taskExecutionDetails"u8))
                {
                    taskExecutionDetails = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IaasVmBackupJobTaskDetails(taskId.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), instanceId.Value, Optional.ToNullable(duration), status.Value, Optional.ToNullable(progressPercentage), taskExecutionDetails.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<IaasVmBackupJobTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IaasVmBackupJobTaskDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IaasVmBackupJobTaskDetails IModel<IaasVmBackupJobTaskDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IaasVmBackupJobTaskDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIaasVmBackupJobTaskDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<IaasVmBackupJobTaskDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
