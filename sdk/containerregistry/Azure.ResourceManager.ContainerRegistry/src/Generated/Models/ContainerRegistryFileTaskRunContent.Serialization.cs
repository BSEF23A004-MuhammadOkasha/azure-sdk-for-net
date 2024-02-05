// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryFileTaskRunContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryFileTaskRunContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryFileTaskRunContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryFileTaskRunContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryFileTaskRunContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryFileTaskRunContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("taskFilePath"u8);
            writer.WriteStringValue(TaskFilePath);
            if (Optional.IsDefined(ValuesFilePath))
            {
                writer.WritePropertyName("valuesFilePath"u8);
                writer.WriteStringValue(ValuesFilePath);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            writer.WritePropertyName("platform"u8);
            writer.WriteObjectValue(Platform);
            if (Optional.IsDefined(AgentConfiguration))
            {
                writer.WritePropertyName("agentConfiguration"u8);
                writer.WriteObjectValue(AgentConfiguration);
            }
            if (Optional.IsDefined(SourceLocation))
            {
                writer.WritePropertyName("sourceLocation"u8);
                writer.WriteStringValue(SourceLocation);
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RunRequestType);
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (Optional.IsDefined(AgentPoolName))
            {
                writer.WritePropertyName("agentPoolName"u8);
                writer.WriteStringValue(AgentPoolName);
            }
            if (Optional.IsDefined(LogTemplate))
            {
                writer.WritePropertyName("logTemplate"u8);
                writer.WriteStringValue(LogTemplate);
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

        ContainerRegistryFileTaskRunContent IJsonModel<ContainerRegistryFileTaskRunContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryFileTaskRunContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryFileTaskRunContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryFileTaskRunContent(document.RootElement, options);
        }

        internal static ContainerRegistryFileTaskRunContent DeserializeContainerRegistryFileTaskRunContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string taskFilePath = default;
            Optional<string> valuesFilePath = default;
            Optional<IList<ContainerRegistryTaskOverridableValue>> values = default;
            Optional<int> timeout = default;
            ContainerRegistryPlatformProperties platform = default;
            Optional<ContainerRegistryAgentProperties> agentConfiguration = default;
            Optional<string> sourceLocation = default;
            Optional<ContainerRegistryCredentials> credentials = default;
            string type = default;
            Optional<bool> isArchiveEnabled = default;
            Optional<string> agentPoolName = default;
            Optional<string> logTemplate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("taskFilePath"u8))
                {
                    taskFilePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valuesFilePath"u8))
                {
                    valuesFilePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTaskOverridableValue> array = new List<ContainerRegistryTaskOverridableValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTaskOverridableValue.DeserializeContainerRegistryTaskOverridableValue(item));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("platform"u8))
                {
                    platform = ContainerRegistryPlatformProperties.DeserializeContainerRegistryPlatformProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("agentConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentConfiguration = ContainerRegistryAgentProperties.DeserializeContainerRegistryAgentProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceLocation"u8))
                {
                    sourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = ContainerRegistryCredentials.DeserializeContainerRegistryCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("agentPoolName"u8))
                {
                    agentPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logTemplate"u8))
                {
                    logTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryFileTaskRunContent(type, Optional.ToNullable(isArchiveEnabled), agentPoolName.Value, logTemplate.Value, serializedAdditionalRawData, taskFilePath, valuesFilePath.Value, Optional.ToList(values), Optional.ToNullable(timeout), platform, agentConfiguration.Value, sourceLocation.Value, credentials.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(TaskFilePath))
            {
                builder.Append("  taskFilePath:");
                builder.AppendLine($" '{TaskFilePath}'");
            }

            if (Optional.IsDefined(ValuesFilePath))
            {
                builder.Append("  valuesFilePath:");
                builder.AppendLine($" '{ValuesFilePath}'");
            }

            if (Optional.IsCollectionDefined(Values))
            {
                if (Values.Any())
                {
                    builder.Append("  values:");
                    builder.AppendLine(" [");
                    foreach (var item in Values)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(TimeoutInSeconds))
            {
                builder.Append("  timeout:");
                builder.AppendLine($" {TimeoutInSeconds.Value}");
            }

            if (Optional.IsDefined(Platform))
            {
                builder.Append("  platform:");
                AppendChildObject(builder, Platform, options, 2, false);
            }

            if (Optional.IsDefined(AgentConfiguration))
            {
                builder.Append("  agentConfiguration:");
                AppendChildObject(builder, AgentConfiguration, options, 2, false);
            }

            if (Optional.IsDefined(SourceLocation))
            {
                builder.Append("  sourceLocation:");
                builder.AppendLine($" '{SourceLocation}'");
            }

            if (Optional.IsDefined(Credentials))
            {
                builder.Append("  credentials:");
                AppendChildObject(builder, Credentials, options, 2, false);
            }

            if (Optional.IsDefined(RunRequestType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{RunRequestType}'");
            }

            if (Optional.IsDefined(IsArchiveEnabled))
            {
                builder.Append("  isArchiveEnabled:");
                var boolValue = IsArchiveEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(AgentPoolName))
            {
                builder.Append("  agentPoolName:");
                builder.AppendLine($" '{AgentPoolName}'");
            }

            if (Optional.IsDefined(LogTemplate))
            {
                builder.Append("  logTemplate:");
                builder.AppendLine($" '{LogTemplate}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ContainerRegistryFileTaskRunContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryFileTaskRunContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryFileTaskRunContent)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryFileTaskRunContent IPersistableModel<ContainerRegistryFileTaskRunContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryFileTaskRunContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryFileTaskRunContent(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryFileTaskRunContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryFileTaskRunContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
