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
    public partial class ShareDataSetData : IUtf8JsonSerializable, IJsonModel<ShareDataSetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ShareDataSetData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ShareDataSetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareDataSetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareDataSetData)} does not support '{format}' format.");
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

        ShareDataSetData IJsonModel<ShareDataSetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareDataSetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareDataSetData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeShareDataSetData(document.RootElement, options);
        }

        internal static ShareDataSetData DeserializeShareDataSetData(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "AdlsGen1File": return AdlsGen1FileDataSet.DeserializeAdlsGen1FileDataSet(element);
                    case "AdlsGen1Folder": return AdlsGen1FolderDataSet.DeserializeAdlsGen1FolderDataSet(element);
                    case "AdlsGen2File": return AdlsGen2FileDataSet.DeserializeAdlsGen2FileDataSet(element);
                    case "AdlsGen2FileSystem": return AdlsGen2FileSystemDataSet.DeserializeAdlsGen2FileSystemDataSet(element);
                    case "AdlsGen2Folder": return AdlsGen2FolderDataSet.DeserializeAdlsGen2FolderDataSet(element);
                    case "Blob": return BlobDataSet.DeserializeBlobDataSet(element);
                    case "BlobFolder": return BlobFolderDataSet.DeserializeBlobFolderDataSet(element);
                    case "Container": return BlobContainerDataSet.DeserializeBlobContainerDataSet(element);
                    case "KustoCluster": return KustoClusterDataSet.DeserializeKustoClusterDataSet(element);
                    case "KustoDatabase": return KustoDatabaseDataSet.DeserializeKustoDatabaseDataSet(element);
                    case "KustoTable": return KustoTableDataSet.DeserializeKustoTableDataSet(element);
                    case "SqlDBTable": return SqlDBTableDataSet.DeserializeSqlDBTableDataSet(element);
                    case "SqlDWTable": return SqlDWTableDataSet.DeserializeSqlDWTableDataSet(element);
                    case "SynapseWorkspaceSqlPoolTable": return SynapseWorkspaceSqlPoolTableDataSet.DeserializeSynapseWorkspaceSqlPoolTableDataSet(element);
                }
            }
            return UnknownDataSet.DeserializeUnknownDataSet(element);
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

        BinaryData IPersistableModel<ShareDataSetData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareDataSetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ShareDataSetData)} does not support '{options.Format}' format.");
            }
        }

        ShareDataSetData IPersistableModel<ShareDataSetData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareDataSetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeShareDataSetData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ShareDataSetData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ShareDataSetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
