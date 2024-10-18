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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SourceControlWebhook : IUtf8JsonSerializable, IJsonModel<SourceControlWebhook>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceControlWebhook>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SourceControlWebhook>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlWebhook>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceControlWebhook)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(WebhookId))
            {
                writer.WritePropertyName("webhookId"u8);
                writer.WriteStringValue(WebhookId);
            }
            if (options.Format != "W" && Optional.IsDefined(WebhookUri))
            {
                writer.WritePropertyName("webhookUrl"u8);
                writer.WriteStringValue(WebhookUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(WebhookSecretUpdateOn))
            {
                writer.WritePropertyName("webhookSecretUpdateTime"u8);
                writer.WriteStringValue(WebhookSecretUpdateOn.Value, "O");
            }
            if (Optional.IsDefined(IsWebhookSecretRotated))
            {
                writer.WritePropertyName("rotateWebhookSecret"u8);
                writer.WriteBooleanValue(IsWebhookSecretRotated.Value);
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
        }

        SourceControlWebhook IJsonModel<SourceControlWebhook>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlWebhook>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceControlWebhook)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceControlWebhook(document.RootElement, options);
        }

        internal static SourceControlWebhook DeserializeSourceControlWebhook(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string webhookId = default;
            Uri webhookUrl = default;
            DateTimeOffset? webhookSecretUpdateTime = default;
            bool? rotateWebhookSecret = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("webhookId"u8))
                {
                    webhookId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webhookUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    webhookUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("webhookSecretUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    webhookSecretUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("rotateWebhookSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rotateWebhookSecret = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SourceControlWebhook(webhookId, webhookUrl, webhookSecretUpdateTime, rotateWebhookSecret, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WebhookId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  webhookId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WebhookId))
                {
                    builder.Append("  webhookId: ");
                    if (WebhookId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WebhookId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WebhookId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WebhookUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  webhookUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WebhookUri))
                {
                    builder.Append("  webhookUrl: ");
                    builder.AppendLine($"'{WebhookUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WebhookSecretUpdateOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  webhookSecretUpdateTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WebhookSecretUpdateOn))
                {
                    builder.Append("  webhookSecretUpdateTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(WebhookSecretUpdateOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsWebhookSecretRotated), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rotateWebhookSecret: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsWebhookSecretRotated))
                {
                    builder.Append("  rotateWebhookSecret: ");
                    var boolValue = IsWebhookSecretRotated.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SourceControlWebhook>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlWebhook>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SourceControlWebhook)} does not support writing '{options.Format}' format.");
            }
        }

        SourceControlWebhook IPersistableModel<SourceControlWebhook>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlWebhook>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceControlWebhook(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SourceControlWebhook)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceControlWebhook>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
