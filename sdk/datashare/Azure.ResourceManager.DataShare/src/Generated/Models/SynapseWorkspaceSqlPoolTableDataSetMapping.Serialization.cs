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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class SynapseWorkspaceSqlPoolTableDataSetMapping : IUtf8JsonSerializable, IJsonModel<SynapseWorkspaceSqlPoolTableDataSetMapping>, IPersistableModel<SynapseWorkspaceSqlPoolTableDataSetMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseWorkspaceSqlPoolTableDataSetMapping>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseWorkspaceSqlPoolTableDataSetMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseWorkspaceSqlPoolTableDataSetMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseWorkspaceSqlPoolTableDataSetMapping)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            writer.WritePropertyName("dataSetId"u8);
            writer.WriteStringValue(DataSetId);
            if (options.Format != "W" && Optional.IsDefined(DataSetMappingStatus))
            {
                writer.WritePropertyName("dataSetMappingStatus"u8);
                writer.WriteStringValue(DataSetMappingStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("synapseWorkspaceSqlPoolTableResourceId"u8);
            writer.WriteStringValue(SynapseWorkspaceSqlPoolTableResourceId);
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

        SynapseWorkspaceSqlPoolTableDataSetMapping IJsonModel<SynapseWorkspaceSqlPoolTableDataSetMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseWorkspaceSqlPoolTableDataSetMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseWorkspaceSqlPoolTableDataSetMapping)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseWorkspaceSqlPoolTableDataSetMapping(document.RootElement, options);
        }

        internal static SynapseWorkspaceSqlPoolTableDataSetMapping DeserializeSynapseWorkspaceSqlPoolTableDataSetMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataSetMappingKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Guid dataSetId = default;
            Optional<DataSetMappingStatus> dataSetMappingStatus = default;
            Optional<DataShareProvisioningState> provisioningState = default;
            ResourceIdentifier synapseWorkspaceSqlPoolTableResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataSetMappingKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("dataSetId"u8))
                        {
                            dataSetId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("dataSetMappingStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataSetMappingStatus = new DataSetMappingStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DataShareProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("synapseWorkspaceSqlPoolTableResourceId"u8))
                        {
                            synapseWorkspaceSqlPoolTableResourceId = new ResourceIdentifier(property0.Value.GetString());
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
            return new SynapseWorkspaceSqlPoolTableDataSetMapping(id, name, type, systemData.Value, kind, serializedAdditionalRawData, dataSetId, Optional.ToNullable(dataSetMappingStatus), Optional.ToNullable(provisioningState), synapseWorkspaceSqlPoolTableResourceId);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(DataSetId))
            {
                builder.Append("  dataSetId:");
                builder.AppendLine($" '{DataSetId.ToString()}'");
            }

            if (Optional.IsDefined(DataSetMappingStatus))
            {
                builder.Append("  dataSetMappingStatus:");
                builder.AppendLine($" '{DataSetMappingStatus.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(SynapseWorkspaceSqlPoolTableResourceId))
            {
                builder.Append("  synapseWorkspaceSqlPoolTableResourceId:");
                builder.AppendLine($" '{SynapseWorkspaceSqlPoolTableResourceId.ToString()}'");
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind.ToString()}'");
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

        BinaryData IPersistableModel<SynapseWorkspaceSqlPoolTableDataSetMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseWorkspaceSqlPoolTableDataSetMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SynapseWorkspaceSqlPoolTableDataSetMapping)} does not support '{options.Format}' format.");
            }
        }

        SynapseWorkspaceSqlPoolTableDataSetMapping IPersistableModel<SynapseWorkspaceSqlPoolTableDataSetMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseWorkspaceSqlPoolTableDataSetMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseWorkspaceSqlPoolTableDataSetMapping(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SynapseWorkspaceSqlPoolTableDataSetMapping)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseWorkspaceSqlPoolTableDataSetMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
