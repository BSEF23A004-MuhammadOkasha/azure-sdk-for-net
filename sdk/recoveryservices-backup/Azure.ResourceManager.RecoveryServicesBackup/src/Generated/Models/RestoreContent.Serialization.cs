// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownRestoreRequest))]
    public partial class RestoreContent : IUtf8JsonSerializable, IJsonModel<RestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreContent)} does not support writing '{format}' format.");
            }

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
        }

        RestoreContent IJsonModel<RestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreContent(document.RootElement, options);
        }

        internal static RestoreContent DeserializeRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileShareRestoreRequest": return FileShareRestoreContent.DeserializeFileShareRestoreContent(element, options);
                    case "AzureWorkloadPointInTimeRestoreRequest": return WorkloadPointInTimeRestoreContent.DeserializeWorkloadPointInTimeRestoreContent(element, options);
                    case "AzureWorkloadRestoreRequest": return WorkloadRestoreContent.DeserializeWorkloadRestoreContent(element, options);
                    case "AzureWorkloadSAPHanaPointInTimeRestoreRequest": return WorkloadSapHanaPointInTimeRestoreContent.DeserializeWorkloadSapHanaPointInTimeRestoreContent(element, options);
                    case "AzureWorkloadSAPHanaPointInTimeRestoreWithRehydrateRequest": return WorkloadSapHanaPointInTimeRestoreWithRehydrateContent.DeserializeWorkloadSapHanaPointInTimeRestoreWithRehydrateContent(element, options);
                    case "AzureWorkloadSAPHanaRestoreRequest": return WorkloadSapHanaRestoreContent.DeserializeWorkloadSapHanaRestoreContent(element, options);
                    case "AzureWorkloadSAPHanaRestoreWithRehydrateRequest": return WorkloadSapHanaRestoreWithRehydrateContent.DeserializeWorkloadSapHanaRestoreWithRehydrateContent(element, options);
                    case "AzureWorkloadSQLPointInTimeRestoreRequest": return WorkloadSqlPointInTimeRestoreContent.DeserializeWorkloadSqlPointInTimeRestoreContent(element, options);
                    case "AzureWorkloadSQLPointInTimeRestoreWithRehydrateRequest": return WorkloadSqlPointInTimeRestoreWithRehydrateContent.DeserializeWorkloadSqlPointInTimeRestoreWithRehydrateContent(element, options);
                    case "AzureWorkloadSQLRestoreRequest": return WorkloadSqlRestoreContent.DeserializeWorkloadSqlRestoreContent(element, options);
                    case "AzureWorkloadSQLRestoreWithRehydrateRequest": return WorkloadSqlRestoreWithRehydrateContent.DeserializeWorkloadSqlRestoreWithRehydrateContent(element, options);
                    case "IaasVMRestoreRequest": return IaasVmRestoreContent.DeserializeIaasVmRestoreContent(element, options);
                    case "IaasVMRestoreWithRehydrationRequest": return IaasVmRestoreWithRehydrationContent.DeserializeIaasVmRestoreWithRehydrationContent(element, options);
                }
            }
            return UnknownRestoreRequest.DeserializeUnknownRestoreRequest(element, options);
        }

        BinaryData IPersistableModel<RestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestoreContent)} does not support writing '{options.Format}' format.");
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
                    throw new FormatException($"The model {nameof(RestoreContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
