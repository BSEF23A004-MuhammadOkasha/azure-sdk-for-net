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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class LocalUserRegeneratePasswordResult : IUtf8JsonSerializable, IJsonModel<LocalUserRegeneratePasswordResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LocalUserRegeneratePasswordResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LocalUserRegeneratePasswordResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalUserRegeneratePasswordResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocalUserRegeneratePasswordResult)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(SshPassword))
            {
                writer.WritePropertyName("sshPassword"u8);
                writer.WriteStringValue(SshPassword);
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

        LocalUserRegeneratePasswordResult IJsonModel<LocalUserRegeneratePasswordResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalUserRegeneratePasswordResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocalUserRegeneratePasswordResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLocalUserRegeneratePasswordResult(document.RootElement, options);
        }

        internal static LocalUserRegeneratePasswordResult DeserializeLocalUserRegeneratePasswordResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sshPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sshPassword"u8))
                {
                    sshPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LocalUserRegeneratePasswordResult(sshPassword, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SshPassword), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sshPassword: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SshPassword))
                {
                    builder.Append("  sshPassword: ");
                    if (SshPassword.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SshPassword}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SshPassword}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<LocalUserRegeneratePasswordResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalUserRegeneratePasswordResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LocalUserRegeneratePasswordResult)} does not support writing '{options.Format}' format.");
            }
        }

        LocalUserRegeneratePasswordResult IPersistableModel<LocalUserRegeneratePasswordResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalUserRegeneratePasswordResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLocalUserRegeneratePasswordResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LocalUserRegeneratePasswordResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LocalUserRegeneratePasswordResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
