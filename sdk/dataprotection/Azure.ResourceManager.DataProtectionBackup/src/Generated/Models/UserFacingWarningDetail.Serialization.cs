// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class UserFacingWarningDetail : IUtf8JsonSerializable, IJsonModel<UserFacingWarningDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserFacingWarningDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UserFacingWarningDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserFacingWarningDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserFacingWarningDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resourceName"u8);
                writer.WriteStringValue(ResourceName);
            }
            writer.WritePropertyName("warning"u8);
            JsonSerializer.Serialize(writer, Warning);
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

        UserFacingWarningDetail IJsonModel<UserFacingWarningDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserFacingWarningDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserFacingWarningDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserFacingWarningDetail(document.RootElement, options);
        }

        internal static UserFacingWarningDetail DeserializeUserFacingWarningDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceName = default;
            ResponseError warning = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warning"u8))
                {
                    warning = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UserFacingWarningDetail(resourceName.Value, warning, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ResourceName))
            {
                builder.Append("  resourceName:");
                builder.AppendLine($" '{ResourceName}'");
            }

            if (Optional.IsDefined(Warning))
            {
                builder.Append("  warning:");
                AppendChildObject(builder, Warning, options, 2, false);
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

        BinaryData IPersistableModel<UserFacingWarningDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserFacingWarningDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(UserFacingWarningDetail)} does not support '{options.Format}' format.");
            }
        }

        UserFacingWarningDetail IPersistableModel<UserFacingWarningDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserFacingWarningDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserFacingWarningDetail(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(UserFacingWarningDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserFacingWarningDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
