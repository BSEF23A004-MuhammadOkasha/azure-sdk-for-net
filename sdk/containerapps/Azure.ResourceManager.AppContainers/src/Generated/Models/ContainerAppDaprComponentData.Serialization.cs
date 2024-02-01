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
    public partial class ContainerAppDaprComponentData : IUtf8JsonSerializable, IJsonModel<ContainerAppDaprComponentData>, IPersistableModel<ContainerAppDaprComponentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppDaprComponentData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppDaprComponentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDaprComponentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDaprComponentData)} does not support '{format}' format.");
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
            if (Optional.IsDefined(ComponentType))
            {
                writer.WritePropertyName("componentType"u8);
                writer.WriteStringValue(ComponentType);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(IgnoreErrors))
            {
                writer.WritePropertyName("ignoreErrors"u8);
                writer.WriteBooleanValue(IgnoreErrors.Value);
            }
            if (Optional.IsDefined(InitTimeout))
            {
                writer.WritePropertyName("initTimeout"u8);
                writer.WriteStringValue(InitTimeout);
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SecretStoreComponent))
            {
                writer.WritePropertyName("secretStoreComponent"u8);
                writer.WriteStringValue(SecretStoreComponent);
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Scopes))
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStartArray();
                foreach (var item in Scopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        ContainerAppDaprComponentData IJsonModel<ContainerAppDaprComponentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDaprComponentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDaprComponentData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppDaprComponentData(document.RootElement, options);
        }

        internal static ContainerAppDaprComponentData DeserializeContainerAppDaprComponentData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> componentType = default;
            Optional<string> version = default;
            Optional<bool> ignoreErrors = default;
            Optional<string> initTimeout = default;
            Optional<IList<ContainerAppWritableSecret>> secrets = default;
            Optional<string> secretStoreComponent = default;
            Optional<IList<ContainerAppDaprMetadata>> metadata = default;
            Optional<IList<string>> scopes = default;
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
                        if (property0.NameEquals("componentType"u8))
                        {
                            componentType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ignoreErrors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreErrors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("initTimeout"u8))
                        {
                            initTimeout = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secrets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerAppWritableSecret> array = new List<ContainerAppWritableSecret>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerAppWritableSecret.DeserializeContainerAppWritableSecret(item));
                            }
                            secrets = array;
                            continue;
                        }
                        if (property0.NameEquals("secretStoreComponent"u8))
                        {
                            secretStoreComponent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerAppDaprMetadata> array = new List<ContainerAppDaprMetadata>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerAppDaprMetadata.DeserializeContainerAppDaprMetadata(item));
                            }
                            metadata = array;
                            continue;
                        }
                        if (property0.NameEquals("scopes"u8))
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
                            scopes = array;
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
            return new ContainerAppDaprComponentData(id, name, type, systemData.Value, componentType.Value, version.Value, Optional.ToNullable(ignoreErrors), initTimeout.Value, Optional.ToList(secrets), secretStoreComponent.Value, Optional.ToList(metadata), Optional.ToList(scopes), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ComponentType))
            {
                builder.Append("  componentType:");
                builder.AppendLine($" '{ComponentType}'");
            }

            if (Optional.IsDefined(Version))
            {
                builder.Append("  version:");
                builder.AppendLine($" '{Version}'");
            }

            if (Optional.IsDefined(IgnoreErrors))
            {
                builder.Append("  ignoreErrors:");
                var boolValue = IgnoreErrors.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(InitTimeout))
            {
                builder.Append("  initTimeout:");
                builder.AppendLine($" '{InitTimeout}'");
            }

            if (Optional.IsCollectionDefined(Secrets))
            {
                builder.Append("  secrets:");
                builder.AppendLine(" [");
                foreach (var item in Secrets)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(SecretStoreComponent))
            {
                builder.Append("  secretStoreComponent:");
                builder.AppendLine($" '{SecretStoreComponent}'");
            }

            if (Optional.IsCollectionDefined(Metadata))
            {
                builder.Append("  metadata:");
                builder.AppendLine(" [");
                foreach (var item in Metadata)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(Scopes))
            {
                builder.Append("  scopes:");
                builder.AppendLine(" [");
                foreach (var item in Scopes)
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

        BinaryData IPersistableModel<ContainerAppDaprComponentData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDaprComponentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDaprComponentData)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppDaprComponentData IPersistableModel<ContainerAppDaprComponentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDaprComponentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppDaprComponentData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDaprComponentData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppDaprComponentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
