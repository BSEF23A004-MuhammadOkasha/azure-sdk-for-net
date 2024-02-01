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
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppRevisionData : IUtf8JsonSerializable, IJsonModel<ContainerAppRevisionData>, IPersistableModel<ContainerAppRevisionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppRevisionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppRevisionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRevisionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppRevisionData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastActiveOn))
            {
                writer.WritePropertyName("lastActiveTime"u8);
                writer.WriteStringValue(LastActiveOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (options.Format != "W" && Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template"u8);
                writer.WriteObjectValue(Template);
            }
            if (options.Format != "W" && Optional.IsDefined(IsActive))
            {
                writer.WritePropertyName("active"u8);
                writer.WriteBooleanValue(IsActive.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Replicas))
            {
                writer.WritePropertyName("replicas"u8);
                writer.WriteNumberValue(Replicas.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TrafficWeight))
            {
                writer.WritePropertyName("trafficWeight"u8);
                writer.WriteNumberValue(TrafficWeight.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningError))
            {
                writer.WritePropertyName("provisioningError"u8);
                writer.WriteStringValue(ProvisioningError);
            }
            if (options.Format != "W" && Optional.IsDefined(HealthState))
            {
                writer.WritePropertyName("healthState"u8);
                writer.WriteStringValue(HealthState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RunningState))
            {
                writer.WritePropertyName("runningState"u8);
                writer.WriteStringValue(RunningState.Value.ToString());
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

        ContainerAppRevisionData IJsonModel<ContainerAppRevisionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRevisionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppRevisionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppRevisionData(document.RootElement, options);
        }

        internal static ContainerAppRevisionData DeserializeContainerAppRevisionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> lastActiveTime = default;
            Optional<string> fqdn = default;
            Optional<ContainerAppTemplate> template = default;
            Optional<bool> active = default;
            Optional<int> replicas = default;
            Optional<int> trafficWeight = default;
            Optional<string> provisioningError = default;
            Optional<ContainerAppRevisionHealthState> healthState = default;
            Optional<ContainerAppRevisionProvisioningState> provisioningState = default;
            Optional<RevisionRunningState> runningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("createdTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastActiveTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastActiveTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("fqdn"u8))
                        {
                            fqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("template"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            template = ContainerAppTemplate.DeserializeContainerAppTemplate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("active"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            active = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("replicas"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicas = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("trafficWeight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trafficWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningError"u8))
                        {
                            provisioningError = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("healthState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthState = new ContainerAppRevisionHealthState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ContainerAppRevisionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("runningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runningState = new RevisionRunningState(property0.Value.GetString());
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
            return new ContainerAppRevisionData(id, name, type, systemData.Value, Optional.ToNullable(createdTime), Optional.ToNullable(lastActiveTime), fqdn.Value, template.Value, Optional.ToNullable(active), Optional.ToNullable(replicas), Optional.ToNullable(trafficWeight), provisioningError.Value, Optional.ToNullable(healthState), Optional.ToNullable(provisioningState), Optional.ToNullable(runningState), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(CreatedOn))
            {
                builder.Append("  createdTime:");
                builder.AppendLine($" '{CreatedOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(LastActiveOn))
            {
                builder.Append("  lastActiveTime:");
                builder.AppendLine($" '{LastActiveOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(Fqdn))
            {
                builder.Append("  fqdn:");
                builder.AppendLine($" '{Fqdn}'");
            }

            if (Optional.IsDefined(Template))
            {
                builder.Append("  template:");
                AppendChildObject(builder, Template, options, 2);
            }

            if (Optional.IsDefined(IsActive))
            {
                builder.Append("  active:");
                var boolValue = IsActive.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(Replicas))
            {
                builder.Append("  replicas:");
                builder.AppendLine($" '{Replicas.Value.ToString()}'");
            }

            if (Optional.IsDefined(TrafficWeight))
            {
                builder.Append("  trafficWeight:");
                builder.AppendLine($" '{TrafficWeight.Value.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningError))
            {
                builder.Append("  provisioningError:");
                builder.AppendLine($" '{ProvisioningError}'");
            }

            if (Optional.IsDefined(HealthState))
            {
                builder.Append("  healthState:");
                builder.AppendLine($" '{HealthState.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(RunningState))
            {
                builder.Append("  runningState:");
                builder.AppendLine($" '{RunningState.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
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

        BinaryData IPersistableModel<ContainerAppRevisionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRevisionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppRevisionData)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppRevisionData IPersistableModel<ContainerAppRevisionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRevisionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppRevisionData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppRevisionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppRevisionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
