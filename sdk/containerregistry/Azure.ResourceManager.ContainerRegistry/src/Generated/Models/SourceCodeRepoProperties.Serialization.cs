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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class SourceCodeRepoProperties : IUtf8JsonSerializable, IJsonModel<SourceCodeRepoProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceCodeRepoProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SourceCodeRepoProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceCodeRepoProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourceControlType"u8);
            writer.WriteStringValue(SourceControlType.ToString());
            writer.WritePropertyName("repositoryUrl"u8);
            writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch"u8);
                writer.WriteStringValue(Branch);
            }
            if (Optional.IsDefined(SourceControlAuthProperties))
            {
                writer.WritePropertyName("sourceControlAuthProperties"u8);
                writer.WriteObjectValue(SourceControlAuthProperties);
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

        SourceCodeRepoProperties IJsonModel<SourceCodeRepoProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceCodeRepoProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceCodeRepoProperties(document.RootElement, options);
        }

        internal static SourceCodeRepoProperties DeserializeSourceCodeRepoProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceControlType sourceControlType = default;
            Uri repositoryUrl = default;
            Optional<string> branch = default;
            Optional<SourceCodeRepoAuthInfo> sourceControlAuthProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceControlType"u8))
                {
                    sourceControlType = new SourceControlType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("repositoryUrl"u8))
                {
                    repositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("branch"u8))
                {
                    branch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceControlAuthProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceControlAuthProperties = SourceCodeRepoAuthInfo.DeserializeSourceCodeRepoAuthInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SourceCodeRepoProperties(sourceControlType, repositoryUrl, branch.Value, sourceControlAuthProperties.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SourceControlType))
            {
                builder.Append("  sourceControlType:");
                builder.AppendLine($" '{SourceControlType.ToString()}'");
            }

            if (Optional.IsDefined(RepositoryUri))
            {
                builder.Append("  repositoryUrl:");
                builder.AppendLine($" '{RepositoryUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(Branch))
            {
                builder.Append("  branch:");
                builder.AppendLine($" '{Branch}'");
            }

            if (Optional.IsDefined(SourceControlAuthProperties))
            {
                builder.Append("  sourceControlAuthProperties:");
                AppendChildObject(builder, SourceControlAuthProperties, options, 2, false);
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

        BinaryData IPersistableModel<SourceCodeRepoProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SourceCodeRepoProperties)} does not support '{options.Format}' format.");
            }
        }

        SourceCodeRepoProperties IPersistableModel<SourceCodeRepoProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceCodeRepoProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SourceCodeRepoProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceCodeRepoProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
