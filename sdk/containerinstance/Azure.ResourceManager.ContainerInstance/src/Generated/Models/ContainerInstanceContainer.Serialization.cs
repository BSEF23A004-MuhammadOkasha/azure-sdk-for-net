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

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerInstanceContainer : IUtf8JsonSerializable, IJsonModel<ContainerInstanceContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerInstanceContainer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerInstanceContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerInstanceContainer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("image"u8);
            writer.WriteStringValue(Image);
            if (Optional.IsCollectionDefined(Command))
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStartArray();
                foreach (var item in Command)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports"u8);
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables"u8);
                writer.WriteStartArray();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceView))
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue(InstanceView);
            }
            writer.WritePropertyName("resources"u8);
            writer.WriteObjectValue(Resources);
            if (Optional.IsCollectionDefined(VolumeMounts))
            {
                writer.WritePropertyName("volumeMounts"u8);
                writer.WriteStartArray();
                foreach (var item in VolumeMounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LivenessProbe))
            {
                writer.WritePropertyName("livenessProbe"u8);
                writer.WriteObjectValue(LivenessProbe);
            }
            if (Optional.IsDefined(ReadinessProbe))
            {
                writer.WritePropertyName("readinessProbe"u8);
                writer.WriteObjectValue(ReadinessProbe);
            }
            if (Optional.IsDefined(SecurityContext))
            {
                writer.WritePropertyName("securityContext"u8);
                writer.WriteObjectValue(SecurityContext);
            }
            writer.WriteEndObject();
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

        ContainerInstanceContainer IJsonModel<ContainerInstanceContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerInstanceContainer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerInstanceContainer(document.RootElement, options);
        }

        internal static ContainerInstanceContainer DeserializeContainerInstanceContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string image = default;
            Optional<IList<string>> command = default;
            Optional<IList<ContainerPort>> ports = default;
            Optional<IList<ContainerEnvironmentVariable>> environmentVariables = default;
            Optional<ContainerInstanceView> instanceView = default;
            ContainerResourceRequirements resources = default;
            Optional<IList<ContainerVolumeMount>> volumeMounts = default;
            Optional<ContainerProbe> livenessProbe = default;
            Optional<ContainerProbe> readinessProbe = default;
            Optional<ContainerSecurityContextDefinition> securityContext = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("image"u8))
                        {
                            image = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("command"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            command = array;
                            continue;
                        }
                        if (property0.NameEquals("ports"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerPort> array = new List<ContainerPort>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerPort.DeserializeContainerPort(item));
                            }
                            ports = array;
                            continue;
                        }
                        if (property0.NameEquals("environmentVariables"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerEnvironmentVariable> array = new List<ContainerEnvironmentVariable>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerEnvironmentVariable.DeserializeContainerEnvironmentVariable(item));
                            }
                            environmentVariables = array;
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = ContainerInstanceView.DeserializeContainerInstanceView(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resources"u8))
                        {
                            resources = ContainerResourceRequirements.DeserializeContainerResourceRequirements(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("volumeMounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerVolumeMount> array = new List<ContainerVolumeMount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerVolumeMount.DeserializeContainerVolumeMount(item));
                            }
                            volumeMounts = array;
                            continue;
                        }
                        if (property0.NameEquals("livenessProbe"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            livenessProbe = ContainerProbe.DeserializeContainerProbe(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("readinessProbe"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readinessProbe = ContainerProbe.DeserializeContainerProbe(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("securityContext"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityContext = ContainerSecurityContextDefinition.DeserializeContainerSecurityContextDefinition(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerInstanceContainer(name, image, Optional.ToList(command), Optional.ToList(ports), Optional.ToList(environmentVariables), instanceView.Value, resources, Optional.ToList(volumeMounts), livenessProbe.Value, readinessProbe.Value, securityContext.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(Image))
            {
                builder.Append("    image:");
                builder.AppendLine($" '{Image}'");
            }

            if (Optional.IsCollectionDefined(Command))
            {
                if (Command.Any())
                {
                    builder.Append("    command:");
                    builder.AppendLine(" [");
                    foreach (var item in Command)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"      '{item}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(Ports))
            {
                if (Ports.Any())
                {
                    builder.Append("    ports:");
                    builder.AppendLine(" [");
                    foreach (var item in Ports)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                if (EnvironmentVariables.Any())
                {
                    builder.Append("    environmentVariables:");
                    builder.AppendLine(" [");
                    foreach (var item in EnvironmentVariables)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(InstanceView))
            {
                builder.Append("    instanceView:");
                AppendChildObject(builder, InstanceView, options, 4, false);
            }

            if (Optional.IsDefined(Resources))
            {
                builder.Append("    resources:");
                AppendChildObject(builder, Resources, options, 4, false);
            }

            if (Optional.IsCollectionDefined(VolumeMounts))
            {
                if (VolumeMounts.Any())
                {
                    builder.Append("    volumeMounts:");
                    builder.AppendLine(" [");
                    foreach (var item in VolumeMounts)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(LivenessProbe))
            {
                builder.Append("    livenessProbe:");
                AppendChildObject(builder, LivenessProbe, options, 4, false);
            }

            if (Optional.IsDefined(ReadinessProbe))
            {
                builder.Append("    readinessProbe:");
                AppendChildObject(builder, ReadinessProbe, options, 4, false);
            }

            if (Optional.IsDefined(SecurityContext))
            {
                builder.Append("    securityContext:");
                AppendChildObject(builder, SecurityContext, options, 4, false);
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<ContainerInstanceContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerInstanceContainer)} does not support '{options.Format}' format.");
            }
        }

        ContainerInstanceContainer IPersistableModel<ContainerInstanceContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerInstanceContainer(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerInstanceContainer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerInstanceContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
