// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    [ModelReaderProxy(typeof(UnknownWorkflowModelCustomProperties))]
    public partial class WorkflowModelCustomProperties : IUtf8JsonSerializable, IJsonModel<WorkflowModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkflowModelCustomProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<WorkflowModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(AffectedObjectDetails))
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

        WorkflowModelCustomProperties IJsonModel<WorkflowModelCustomProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkflowModelCustomProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkflowModelCustomProperties(document.RootElement, options);
        }

        internal static WorkflowModelCustomProperties DeserializeWorkflowModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

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

        BinaryData IModel<WorkflowModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkflowModelCustomProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WorkflowModelCustomProperties IModel<WorkflowModelCustomProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkflowModelCustomProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWorkflowModelCustomProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<WorkflowModelCustomProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
