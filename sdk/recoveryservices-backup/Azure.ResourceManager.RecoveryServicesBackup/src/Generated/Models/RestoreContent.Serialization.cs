// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownRestoreRequest))]
    public partial class RestoreContent : IUtf8JsonSerializable, IJsonModel<RestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RestoreContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        RestoreContent IJsonModel<RestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RestoreContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreContent(document.RootElement, options);
        }

        internal static RestoreContent DeserializeRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileShareRestoreRequest": return FileShareRestoreContent.DeserializeFileShareRestoreContent(element);
                    case "AzureWorkloadPointInTimeRestoreRequest": return WorkloadPointInTimeRestoreContent.DeserializeWorkloadPointInTimeRestoreContent(element);
                    case "AzureWorkloadRestoreRequest": return WorkloadRestoreContent.DeserializeWorkloadRestoreContent(element);
                    case "AzureWorkloadSAPHanaPointInTimeRestoreRequest": return WorkloadSapHanaPointInTimeRestoreContent.DeserializeWorkloadSapHanaPointInTimeRestoreContent(element);
                    case "AzureWorkloadSAPHanaPointInTimeRestoreWithRehydrateRequest": return WorkloadSapHanaPointInTimeRestoreWithRehydrateContent.DeserializeWorkloadSapHanaPointInTimeRestoreWithRehydrateContent(element);
                    case "AzureWorkloadSAPHanaRestoreRequest": return WorkloadSapHanaRestoreContent.DeserializeWorkloadSapHanaRestoreContent(element);
                    case "AzureWorkloadSAPHanaRestoreWithRehydrateRequest": return WorkloadSapHanaRestoreWithRehydrateContent.DeserializeWorkloadSapHanaRestoreWithRehydrateContent(element);
                    case "AzureWorkloadSQLPointInTimeRestoreRequest": return WorkloadSqlPointInTimeRestoreContent.DeserializeWorkloadSqlPointInTimeRestoreContent(element);
                    case "AzureWorkloadSQLPointInTimeRestoreWithRehydrateRequest": return WorkloadSqlPointInTimeRestoreWithRehydrateContent.DeserializeWorkloadSqlPointInTimeRestoreWithRehydrateContent(element);
                    case "AzureWorkloadSQLRestoreRequest": return WorkloadSqlRestoreContent.DeserializeWorkloadSqlRestoreContent(element);
                    case "AzureWorkloadSQLRestoreWithRehydrateRequest": return WorkloadSqlRestoreWithRehydrateContent.DeserializeWorkloadSqlRestoreWithRehydrateContent(element);
                    case "IaasVMRestoreRequest": return IaasVmRestoreContent.DeserializeIaasVmRestoreContent(element);
                    case "IaasVMRestoreWithRehydrationRequest": return IaasVmRestoreWithRehydrationContent.DeserializeIaasVmRestoreWithRehydrationContent(element);
                }
            }
            return UnknownRestoreRequest.DeserializeUnknownRestoreRequest(element);
        }

        BinaryData IPersistableModel<RestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RestoreContent)} does not support '{options.Format}' format.");
            }
        }

        RestoreContent IPersistableModel<RestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RestoreContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
