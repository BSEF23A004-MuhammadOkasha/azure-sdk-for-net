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
    public partial class ContainerRegistryDockerBuildStep : IUtf8JsonSerializable, IJsonModel<ContainerRegistryDockerBuildStep>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryDockerBuildStep>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryDockerBuildStep>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStep)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ImageNames))
            {
                writer.WritePropertyName("imageNames"u8);
                writer.WriteStartArray();
                foreach (var item in ImageNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsPushEnabled))
            {
                writer.WritePropertyName("isPushEnabled"u8);
                writer.WriteBooleanValue(IsPushEnabled.Value);
            }
            if (Optional.IsDefined(NoCache))
            {
                writer.WritePropertyName("noCache"u8);
                writer.WriteBooleanValue(NoCache.Value);
            }
            writer.WritePropertyName("dockerFilePath"u8);
            writer.WriteStringValue(DockerFilePath);
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ContainerRegistryTaskStepType.ToString());
            if (options.Format != "W" && Optional.IsCollectionDefined(BaseImageDependencies))
            {
                writer.WritePropertyName("baseImageDependencies"u8);
                writer.WriteStartArray();
                foreach (var item in BaseImageDependencies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(ContextAccessToken))
            {
                writer.WritePropertyName("contextAccessToken"u8);
                writer.WriteStringValue(ContextAccessToken);
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

        ContainerRegistryDockerBuildStep IJsonModel<ContainerRegistryDockerBuildStep>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStep)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryDockerBuildStep(document.RootElement, options);
        }

        internal static ContainerRegistryDockerBuildStep DeserializeContainerRegistryDockerBuildStep(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> imageNames = default;
            Optional<bool> isPushEnabled = default;
            Optional<bool> noCache = default;
            string dockerFilePath = default;
            Optional<string> target = default;
            Optional<IList<ContainerRegistryRunArgument>> arguments = default;
            ContainerRegistryTaskStepType type = default;
            Optional<IReadOnlyList<ContainerRegistryBaseImageDependency>> baseImageDependencies = default;
            Optional<string> contextPath = default;
            Optional<string> contextAccessToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageNames"u8))
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
                    imageNames = array;
                    continue;
                }
                if (property.NameEquals("isPushEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPushEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("noCache"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noCache = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dockerFilePath"u8))
                {
                    dockerFilePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryRunArgument> array = new List<ContainerRegistryRunArgument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryRunArgument.DeserializeContainerRegistryRunArgument(item));
                    }
                    arguments = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ContainerRegistryTaskStepType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("baseImageDependencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryBaseImageDependency> array = new List<ContainerRegistryBaseImageDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryBaseImageDependency.DeserializeContainerRegistryBaseImageDependency(item));
                    }
                    baseImageDependencies = array;
                    continue;
                }
                if (property.NameEquals("contextPath"u8))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contextAccessToken"u8))
                {
                    contextAccessToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryDockerBuildStep(type, Optional.ToList(baseImageDependencies), contextPath.Value, contextAccessToken.Value, serializedAdditionalRawData, Optional.ToList(imageNames), Optional.ToNullable(isPushEnabled), Optional.ToNullable(noCache), dockerFilePath, target.Value, Optional.ToList(arguments));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(ImageNames))
            {
                if (ImageNames.Any())
                {
                    builder.Append("  imageNames:");
                    builder.AppendLine(" [");
                    foreach (var item in ImageNames)
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
            }

            if (Optional.IsDefined(IsPushEnabled))
            {
                builder.Append("  isPushEnabled:");
                var boolValue = IsPushEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(NoCache))
            {
                builder.Append("  noCache:");
                var boolValue = NoCache.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(DockerFilePath))
            {
                builder.Append("  dockerFilePath:");
                builder.AppendLine($" '{DockerFilePath}'");
            }

            if (Optional.IsDefined(Target))
            {
                builder.Append("  target:");
                builder.AppendLine($" '{Target}'");
            }

            if (Optional.IsCollectionDefined(Arguments))
            {
                if (Arguments.Any())
                {
                    builder.Append("  arguments:");
                    builder.AppendLine(" [");
                    foreach (var item in Arguments)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(ContainerRegistryTaskStepType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ContainerRegistryTaskStepType.ToString()}'");
            }

            if (Optional.IsCollectionDefined(BaseImageDependencies))
            {
                if (BaseImageDependencies.Any())
                {
                    builder.Append("  baseImageDependencies:");
                    builder.AppendLine(" [");
                    foreach (var item in BaseImageDependencies)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(ContextPath))
            {
                builder.Append("  contextPath:");
                builder.AppendLine($" '{ContextPath}'");
            }

            if (Optional.IsDefined(ContextAccessToken))
            {
                builder.Append("  contextAccessToken:");
                builder.AppendLine($" '{ContextAccessToken}'");
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

        BinaryData IPersistableModel<ContainerRegistryDockerBuildStep>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStep)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryDockerBuildStep IPersistableModel<ContainerRegistryDockerBuildStep>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryDockerBuildStep(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStep)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryDockerBuildStep>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
