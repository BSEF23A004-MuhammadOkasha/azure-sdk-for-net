// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerSecurityContextDefinition : IUtf8JsonSerializable, IJsonModel<ContainerSecurityContextDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerSecurityContextDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerSecurityContextDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerSecurityContextDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsPrivileged))
            {
                writer.WritePropertyName("privileged"u8);
                writer.WriteBooleanValue(IsPrivileged.Value);
            }
            if (Optional.IsDefined(AllowPrivilegeEscalation))
            {
                writer.WritePropertyName("allowPrivilegeEscalation"u8);
                writer.WriteBooleanValue(AllowPrivilegeEscalation.Value);
            }
            if (Optional.IsDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteObjectValue(Capabilities);
            }
            if (Optional.IsDefined(RunAsGroup))
            {
                writer.WritePropertyName("runAsGroup"u8);
                writer.WriteNumberValue(RunAsGroup.Value);
            }
            if (Optional.IsDefined(RunAsUser))
            {
                writer.WritePropertyName("runAsUser"u8);
                writer.WriteNumberValue(RunAsUser.Value);
            }
            if (Optional.IsDefined(SeccompProfile))
            {
                writer.WritePropertyName("seccompProfile"u8);
                writer.WriteStringValue(SeccompProfile);
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

        ContainerSecurityContextDefinition IJsonModel<ContainerSecurityContextDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerSecurityContextDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerSecurityContextDefinition(document.RootElement, options);
        }

        internal static ContainerSecurityContextDefinition DeserializeContainerSecurityContextDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> privileged = default;
            Optional<bool> allowPrivilegeEscalation = default;
            Optional<ContainerSecurityContextCapabilitiesDefinition> capabilities = default;
            Optional<int> runAsGroup = default;
            Optional<int> runAsUser = default;
            Optional<string> seccompProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privileged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privileged = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowPrivilegeEscalation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowPrivilegeEscalation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capabilities = ContainerSecurityContextCapabilitiesDefinition.DeserializeContainerSecurityContextCapabilitiesDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("runAsGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runAsGroup = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("runAsUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runAsUser = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("seccompProfile"u8))
                {
                    seccompProfile = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerSecurityContextDefinition(Optional.ToNullable(privileged), Optional.ToNullable(allowPrivilegeEscalation), capabilities.Value, Optional.ToNullable(runAsGroup), Optional.ToNullable(runAsUser), seccompProfile.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(IsPrivileged))
            {
                builder.Append("  privileged:");
                var boolValue = IsPrivileged.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(AllowPrivilegeEscalation))
            {
                builder.Append("  allowPrivilegeEscalation:");
                var boolValue = AllowPrivilegeEscalation.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(Capabilities))
            {
                builder.Append("  capabilities:");
                AppendChildObject(builder, Capabilities, options, 2, false);
            }

            if (Optional.IsDefined(RunAsGroup))
            {
                builder.Append("  runAsGroup:");
                builder.AppendLine($" {RunAsGroup.Value}");
            }

            if (Optional.IsDefined(RunAsUser))
            {
                builder.Append("  runAsUser:");
                builder.AppendLine($" {RunAsUser.Value}");
            }

            if (Optional.IsDefined(SeccompProfile))
            {
                builder.Append("  seccompProfile:");
                builder.AppendLine($" '{SeccompProfile}'");
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

        BinaryData IPersistableModel<ContainerSecurityContextDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerSecurityContextDefinition)} does not support '{options.Format}' format.");
            }
        }

        ContainerSecurityContextDefinition IPersistableModel<ContainerSecurityContextDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerSecurityContextDefinition(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerSecurityContextDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerSecurityContextDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
