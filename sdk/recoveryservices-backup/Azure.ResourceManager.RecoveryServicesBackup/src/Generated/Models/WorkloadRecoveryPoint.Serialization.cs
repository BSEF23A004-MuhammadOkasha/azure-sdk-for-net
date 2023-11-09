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
    public partial class WorkloadRecoveryPoint : IUtf8JsonSerializable, IJsonModel<WorkloadRecoveryPoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadRecoveryPoint>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<WorkloadRecoveryPoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointCreatedOn))
            {
                writer.WritePropertyName("recoveryPointTimeInUTC"u8);
                writer.WriteStringValue(RecoveryPointCreatedOn.Value, "O");
            }
            if (Optional.IsDefined(RestorePointType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RestorePointType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RecoveryPointTierDetails))
            {
                writer.WritePropertyName("recoveryPointTierDetails"u8);
                writer.WriteStartArray();
                foreach (var item in RecoveryPointTierDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RecoveryPointMoveReadinessInfo))
            {
                writer.WritePropertyName("recoveryPointMoveReadinessInfo"u8);
                writer.WriteStartObject();
                foreach (var item in RecoveryPointMoveReadinessInfo)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(RecoveryPointProperties))
            {
                writer.WritePropertyName("recoveryPointProperties"u8);
                writer.WriteObjectValue(RecoveryPointProperties);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        WorkloadRecoveryPoint IJsonModel<WorkloadRecoveryPoint>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkloadRecoveryPoint)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadRecoveryPoint(document.RootElement, options);
        }

        internal static WorkloadRecoveryPoint DeserializeWorkloadRecoveryPoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureWorkloadPointInTimeRecoveryPoint": return WorkloadPointInTimeRecoveryPoint.DeserializeWorkloadPointInTimeRecoveryPoint(element);
                    case "AzureWorkloadSAPHanaPointInTimeRecoveryPoint": return WorkloadSapHanaPointInTimeRecoveryPoint.DeserializeWorkloadSapHanaPointInTimeRecoveryPoint(element);
                    case "AzureWorkloadSAPHanaRecoveryPoint": return WorkloadSapHanaRecoveryPoint.DeserializeWorkloadSapHanaRecoveryPoint(element);
                    case "AzureWorkloadSQLPointInTimeRecoveryPoint": return WorkloadSqlPointInTimeRecoveryPoint.DeserializeWorkloadSqlPointInTimeRecoveryPoint(element);
                    case "AzureWorkloadSQLRecoveryPoint": return WorkloadSqlRecoveryPoint.DeserializeWorkloadSqlRecoveryPoint(element);
                }
            }
            Optional<DateTimeOffset> recoveryPointTimeInUTC = default;
            Optional<RestorePointType> type = default;
            Optional<IList<RecoveryPointTierInformationV2>> recoveryPointTierDetails = default;
            Optional<IDictionary<string, RecoveryPointMoveReadinessInfo>> recoveryPointMoveReadinessInfo = default;
            Optional<RecoveryPointProperties> recoveryPointProperties = default;
            string objectType = "AzureWorkloadRecoveryPoint";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new RestorePointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryPointTierDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPointTierInformationV2> array = new List<RecoveryPointTierInformationV2>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPointTierInformationV2.DeserializeRecoveryPointTierInformationV2(item));
                    }
                    recoveryPointTierDetails = array;
                    continue;
                }
                if (property.NameEquals("recoveryPointMoveReadinessInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RecoveryPointMoveReadinessInfo> dictionary = new Dictionary<string, RecoveryPointMoveReadinessInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.RecoveryPointMoveReadinessInfo.DeserializeRecoveryPointMoveReadinessInfo(property0.Value));
                    }
                    recoveryPointMoveReadinessInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("recoveryPointProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointProperties = RecoveryPointProperties.DeserializeRecoveryPointProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkloadRecoveryPoint(objectType, serializedAdditionalRawData, Optional.ToNullable(recoveryPointTimeInUTC), Optional.ToNullable(type), Optional.ToList(recoveryPointTierDetails), Optional.ToDictionary(recoveryPointMoveReadinessInfo), recoveryPointProperties.Value);
        }

        BinaryData IModel<WorkloadRecoveryPoint>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkloadRecoveryPoint)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WorkloadRecoveryPoint IModel<WorkloadRecoveryPoint>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkloadRecoveryPoint)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWorkloadRecoveryPoint(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<WorkloadRecoveryPoint>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
