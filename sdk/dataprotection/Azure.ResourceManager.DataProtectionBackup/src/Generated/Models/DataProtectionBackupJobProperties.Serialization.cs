// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupJobProperties : IUtf8JsonSerializable, IJsonModel<DataProtectionBackupJobProperties>, IPersistableModel<DataProtectionBackupJobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProtectionBackupJobProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataProtectionBackupJobProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupJobProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("activityID"u8);
            writer.WriteStringValue(ActivityId);
            writer.WritePropertyName("backupInstanceFriendlyName"u8);
            writer.WriteStringValue(BackupInstanceFriendlyName);
            if (options.Format != "W" && Optional.IsDefined(BackupInstanceId))
            {
                writer.WritePropertyName("backupInstanceId"u8);
                writer.WriteStringValue(BackupInstanceId);
            }
            writer.WritePropertyName("dataSourceId"u8);
            writer.WriteStringValue(DataSourceId);
            writer.WritePropertyName("dataSourceLocation"u8);
            writer.WriteStringValue(DataSourceLocation);
            writer.WritePropertyName("dataSourceName"u8);
            writer.WriteStringValue(DataSourceName);
            if (Optional.IsDefined(DataSourceSetName))
            {
                writer.WritePropertyName("dataSourceSetName"u8);
                writer.WriteStringValue(DataSourceSetName);
            }
            writer.WritePropertyName("dataSourceType"u8);
            writer.WriteStringValue(DataSourceType);
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "c");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ErrorDetails))
            {
                writer.WritePropertyName("errorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ErrorDetails)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
            }
            writer.WritePropertyName("isUserTriggered"u8);
            writer.WriteBooleanValue(IsUserTriggered);
            writer.WritePropertyName("operation"u8);
            writer.WriteStringValue(Operation);
            writer.WritePropertyName("operationCategory"u8);
            writer.WriteStringValue(OperationCategory);
            if (options.Format != "W" && Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (options.Format != "W" && Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName"u8);
                writer.WriteStringValue(PolicyName);
            }
            writer.WritePropertyName("progressEnabled"u8);
            writer.WriteBooleanValue(IsProgressEnabled);
            if (options.Format != "W" && Optional.IsDefined(ProgressUri))
            {
                writer.WritePropertyName("progressUrl"u8);
                writer.WriteStringValue(ProgressUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(RehydrationPriority))
            {
                writer.WritePropertyName("rehydrationPriority"u8);
                writer.WriteStringValue(RehydrationPriority);
            }
            if (options.Format != "W" && Optional.IsDefined(RestoreType))
            {
                writer.WritePropertyName("restoreType"u8);
                writer.WriteStringValue(RestoreType);
            }
            writer.WritePropertyName("sourceResourceGroup"u8);
            writer.WriteStringValue(SourceResourceGroup);
            writer.WritePropertyName("sourceSubscriptionID"u8);
            writer.WriteStringValue(SourceSubscriptionId);
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status);
            writer.WritePropertyName("subscriptionId"u8);
            writer.WriteStringValue(SubscriptionId);
            writer.WritePropertyName("supportedActions"u8);
            writer.WriteStartArray();
            foreach (var item in SupportedActions)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("vaultName"u8);
            writer.WriteStringValue(VaultName);
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(SourceDataStoreName))
            {
                writer.WritePropertyName("sourceDataStoreName"u8);
                writer.WriteStringValue(SourceDataStoreName);
            }
            if (Optional.IsDefined(DestinationDataStoreName))
            {
                writer.WritePropertyName("destinationDataStoreName"u8);
                writer.WriteStringValue(DestinationDataStoreName);
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

        DataProtectionBackupJobProperties IJsonModel<DataProtectionBackupJobProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupJobProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupJobProperties(document.RootElement, options);
        }

        internal static DataProtectionBackupJobProperties DeserializeDataProtectionBackupJobProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activityId = default;
            string backupInstanceFriendlyName = default;
            Optional<ResourceIdentifier> backupInstanceId = default;
            ResourceIdentifier dataSourceId = default;
            AzureLocation dataSourceLocation = default;
            string dataSourceName = default;
            Optional<string> dataSourceSetName = default;
            string dataSourceType = default;
            Optional<TimeSpan> duration = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<IReadOnlyList<ResponseError>> errorDetails = default;
            Optional<BackupJobExtendedInfo> extendedInfo = default;
            bool isUserTriggered = default;
            string operation = default;
            string operationCategory = default;
            Optional<ResourceIdentifier> policyId = default;
            Optional<string> policyName = default;
            bool progressEnabled = default;
            Optional<Uri> progressUrl = default;
            Optional<string> rehydrationPriority = default;
            Optional<string> restoreType = default;
            string sourceResourceGroup = default;
            string sourceSubscriptionId = default;
            DateTimeOffset startTime = default;
            string status = default;
            string subscriptionId = default;
            IList<string> supportedActions = default;
            string vaultName = default;
            Optional<ETag> etag = default;
            Optional<string> sourceDataStoreName = default;
            Optional<string> destinationDataStoreName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activityID"u8))
                {
                    activityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupInstanceFriendlyName"u8))
                {
                    backupInstanceFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupInstanceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupInstanceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceId"u8))
                {
                    dataSourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceLocation"u8))
                {
                    dataSourceLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceName"u8))
                {
                    dataSourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceSetName"u8))
                {
                    dataSourceSetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceType"u8))
                {
                    dataSourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("c");
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
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseError> array = new List<ResponseError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ResponseError>(item.GetRawText()));
                    }
                    errorDetails = array;
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = BackupJobExtendedInfo.DeserializeBackupJobExtendedInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("isUserTriggered"u8))
                {
                    isUserTriggered = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationCategory"u8))
                {
                    operationCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("progressEnabled"u8))
                {
                    progressEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("progressUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rehydrationPriority"u8))
                {
                    rehydrationPriority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreType"u8))
                {
                    restoreType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceResourceGroup"u8))
                {
                    sourceResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceSubscriptionID"u8))
                {
                    sourceSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedActions"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedActions = array;
                    continue;
                }
                if (property.NameEquals("vaultName"u8))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceDataStoreName"u8))
                {
                    sourceDataStoreName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationDataStoreName"u8))
                {
                    destinationDataStoreName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataProtectionBackupJobProperties(activityId, backupInstanceFriendlyName, backupInstanceId.Value, dataSourceId, dataSourceLocation, dataSourceName, dataSourceSetName.Value, dataSourceType, Optional.ToNullable(duration), Optional.ToNullable(endTime), Optional.ToList(errorDetails), extendedInfo.Value, isUserTriggered, operation, operationCategory, policyId.Value, policyName.Value, progressEnabled, progressUrl.Value, rehydrationPriority.Value, restoreType.Value, sourceResourceGroup, sourceSubscriptionId, startTime, status, subscriptionId, supportedActions, vaultName, Optional.ToNullable(etag), sourceDataStoreName.Value, destinationDataStoreName.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ActivityId))
            {
                builder.Append("  activityID:");
                builder.AppendLine($" '{ActivityId}'");
            }

            if (Optional.IsDefined(BackupInstanceFriendlyName))
            {
                builder.Append("  backupInstanceFriendlyName:");
                builder.AppendLine($" '{BackupInstanceFriendlyName}'");
            }

            if (Optional.IsDefined(BackupInstanceId))
            {
                builder.Append("  backupInstanceId:");
                builder.AppendLine($" '{BackupInstanceId.ToString()}'");
            }

            if (Optional.IsDefined(DataSourceId))
            {
                builder.Append("  dataSourceId:");
                builder.AppendLine($" '{DataSourceId.ToString()}'");
            }

            if (Optional.IsDefined(DataSourceLocation))
            {
                builder.Append("  dataSourceLocation:");
                builder.AppendLine($" '{DataSourceLocation.ToString()}'");
            }

            if (Optional.IsDefined(DataSourceName))
            {
                builder.Append("  dataSourceName:");
                builder.AppendLine($" '{DataSourceName}'");
            }

            if (Optional.IsDefined(DataSourceSetName))
            {
                builder.Append("  dataSourceSetName:");
                builder.AppendLine($" '{DataSourceSetName}'");
            }

            if (Optional.IsDefined(DataSourceType))
            {
                builder.Append("  dataSourceType:");
                builder.AppendLine($" '{DataSourceType}'");
            }

            if (Optional.IsDefined(Duration))
            {
                builder.Append("  duration:");
                var formattedTimeSpan = XmlConvert.ToString(Duration.Value);
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(EndOn))
            {
                builder.Append("  endTime:");
                builder.AppendLine($" '{EndOn.Value.ToString()}'");
            }

            if (Optional.IsCollectionDefined(ErrorDetails))
            {
                builder.Append("  errorDetails:");
                builder.AppendLine(" [");
                foreach (var item in ErrorDetails)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(ExtendedInfo))
            {
                builder.Append("  extendedInfo:");
                AppendChildObject(builder, ExtendedInfo, options, 2);
            }

            if (Optional.IsDefined(IsUserTriggered))
            {
                builder.Append("  isUserTriggered:");
                var boolValue = IsUserTriggered == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(Operation))
            {
                builder.Append("  operation:");
                builder.AppendLine($" '{Operation}'");
            }

            if (Optional.IsDefined(OperationCategory))
            {
                builder.Append("  operationCategory:");
                builder.AppendLine($" '{OperationCategory}'");
            }

            if (Optional.IsDefined(PolicyId))
            {
                builder.Append("  policyId:");
                builder.AppendLine($" '{PolicyId.ToString()}'");
            }

            if (Optional.IsDefined(PolicyName))
            {
                builder.Append("  policyName:");
                builder.AppendLine($" '{PolicyName}'");
            }

            if (Optional.IsDefined(IsProgressEnabled))
            {
                builder.Append("  progressEnabled:");
                var boolValue = IsProgressEnabled == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(ProgressUri))
            {
                builder.Append("  progressUrl:");
                builder.AppendLine($" '{ProgressUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(RehydrationPriority))
            {
                builder.Append("  rehydrationPriority:");
                builder.AppendLine($" '{RehydrationPriority}'");
            }

            if (Optional.IsDefined(RestoreType))
            {
                builder.Append("  restoreType:");
                builder.AppendLine($" '{RestoreType}'");
            }

            if (Optional.IsDefined(SourceResourceGroup))
            {
                builder.Append("  sourceResourceGroup:");
                builder.AppendLine($" '{SourceResourceGroup}'");
            }

            if (Optional.IsDefined(SourceSubscriptionId))
            {
                builder.Append("  sourceSubscriptionID:");
                builder.AppendLine($" '{SourceSubscriptionId}'");
            }

            if (Optional.IsDefined(StartOn))
            {
                builder.Append("  startTime:");
                builder.AppendLine($" '{StartOn.ToString()}'");
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status}'");
            }

            if (Optional.IsDefined(SubscriptionId))
            {
                builder.Append("  subscriptionId:");
                builder.AppendLine($" '{SubscriptionId}'");
            }

            if (Optional.IsCollectionDefined(SupportedActions))
            {
                builder.Append("  supportedActions:");
                builder.AppendLine(" [");
                foreach (var item in SupportedActions)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(VaultName))
            {
                builder.Append("  vaultName:");
                builder.AppendLine($" '{VaultName}'");
            }

            if (Optional.IsDefined(ETag))
            {
                builder.Append("  etag:");
                builder.AppendLine($" '{ETag.Value.ToString()}'");
            }

            if (Optional.IsDefined(SourceDataStoreName))
            {
                builder.Append("  sourceDataStoreName:");
                builder.AppendLine($" '{SourceDataStoreName}'");
            }

            if (Optional.IsDefined(DestinationDataStoreName))
            {
                builder.Append("  destinationDataStoreName:");
                builder.AppendLine($" '{DestinationDataStoreName}'");
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

        BinaryData IPersistableModel<DataProtectionBackupJobProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupJobProperties)} does not support '{options.Format}' format.");
            }
        }

        DataProtectionBackupJobProperties IPersistableModel<DataProtectionBackupJobProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProtectionBackupJobProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupJobProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProtectionBackupJobProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
