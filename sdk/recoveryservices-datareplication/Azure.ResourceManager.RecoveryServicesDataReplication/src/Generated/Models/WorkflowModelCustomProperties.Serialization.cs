// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    [PersistableModelProxy(typeof(UnknownWorkflowModelCustomProperties))]
    public partial class WorkflowModelCustomProperties : IUtf8JsonSerializable, IJsonModel<WorkflowModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkflowModelCustomProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkflowModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(WorkflowModelCustomProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (options.Format != "W" && Optional.IsCollectionDefined(AffectedObjectDetails))
            {
                writer.WritePropertyName("affectedObjectDetails"u8);
                writer.WriteStartObject();
                foreach (var item in AffectedObjectDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        WorkflowModelCustomProperties IJsonModel<WorkflowModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(WorkflowModelCustomProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkflowModelCustomProperties(document.RootElement, options);
        }

        internal static WorkflowModelCustomProperties DeserializeWorkflowModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FailoverWorkflowDetails": return FailoverWorkflowModelCustomProperties.DeserializeFailoverWorkflowModelCustomProperties(element);
                    case "TestFailoverCleanupWorkflowDetails": return TestFailoverCleanupWorkflowModelCustomProperties.DeserializeTestFailoverCleanupWorkflowModelCustomProperties(element);
                    case "TestFailoverWorkflowDetails": return TestFailoverWorkflowModelCustomProperties.DeserializeTestFailoverWorkflowModelCustomProperties(element);
                }
            }
            return UnknownWorkflowModelCustomProperties.DeserializeUnknownWorkflowModelCustomProperties(element);
        }

        BinaryData IPersistableModel<WorkflowModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(WorkflowModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        WorkflowModelCustomProperties IPersistableModel<WorkflowModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkflowModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(WorkflowModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkflowModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
