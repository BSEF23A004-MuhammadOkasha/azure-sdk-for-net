// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare
{
    public partial class ShareDataSetMappingData : IUtf8JsonSerializable, IJsonModel<ShareDataSetMappingData>, IPersistableModel<ShareDataSetMappingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ShareDataSetMappingData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ShareDataSetMappingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareDataSetMappingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareDataSetMappingData)} does not support '{format}' format.");
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

        ShareDataSetMappingData IJsonModel<ShareDataSetMappingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareDataSetMappingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareDataSetMappingData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeShareDataSetMappingData(document.RootElement, options);
        }

        internal static ShareDataSetMappingData DeserializeShareDataSetMappingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AdlsGen2File": return AdlsGen2FileDataSetMapping.DeserializeAdlsGen2FileDataSetMapping(element);
                    case "AdlsGen2FileSystem": return AdlsGen2FileSystemDataSetMapping.DeserializeAdlsGen2FileSystemDataSetMapping(element);
                    case "AdlsGen2Folder": return AdlsGen2FolderDataSetMapping.DeserializeAdlsGen2FolderDataSetMapping(element);
                    case "Blob": return BlobDataSetMapping.DeserializeBlobDataSetMapping(element);
                    case "BlobFolder": return BlobFolderDataSetMapping.DeserializeBlobFolderDataSetMapping(element);
                    case "Container": return BlobContainerDataSetMapping.DeserializeBlobContainerDataSetMapping(element);
                    case "KustoCluster": return KustoClusterDataSetMapping.DeserializeKustoClusterDataSetMapping(element);
                    case "KustoDatabase": return KustoDatabaseDataSetMapping.DeserializeKustoDatabaseDataSetMapping(element);
                    case "KustoTable": return KustoTableDataSetMapping.DeserializeKustoTableDataSetMapping(element);
                    case "SqlDBTable": return SqlDBTableDataSetMapping.DeserializeSqlDBTableDataSetMapping(element);
                    case "SqlDWTable": return SqlDWTableDataSetMapping.DeserializeSqlDWTableDataSetMapping(element);
                    case "SynapseWorkspaceSqlPoolTable": return SynapseWorkspaceSqlPoolTableDataSetMapping.DeserializeSynapseWorkspaceSqlPoolTableDataSetMapping(element);
                }
            }
            return UnknownDataSetMapping.DeserializeUnknownDataSetMapping(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

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

        BinaryData IPersistableModel<ShareDataSetMappingData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareDataSetMappingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ShareDataSetMappingData)} does not support '{options.Format}' format.");
            }
        }

        ShareDataSetMappingData IPersistableModel<ShareDataSetMappingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareDataSetMappingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeShareDataSetMappingData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ShareDataSetMappingData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ShareDataSetMappingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
