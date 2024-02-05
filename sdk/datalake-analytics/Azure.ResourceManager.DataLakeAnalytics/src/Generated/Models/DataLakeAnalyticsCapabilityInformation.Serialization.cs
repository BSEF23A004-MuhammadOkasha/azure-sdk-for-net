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

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class DataLakeAnalyticsCapabilityInformation : IUtf8JsonSerializable, IJsonModel<DataLakeAnalyticsCapabilityInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeAnalyticsCapabilityInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataLakeAnalyticsCapabilityInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsCapabilityInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsCapabilityInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MaxAccountCount))
            {
                writer.WritePropertyName("maxAccountCount"u8);
                writer.WriteNumberValue(MaxAccountCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AccountCount))
            {
                writer.WritePropertyName("accountCount"u8);
                writer.WriteNumberValue(AccountCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsUnderMigrationState))
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteBooleanValue(IsUnderMigrationState.Value);
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

        DataLakeAnalyticsCapabilityInformation IJsonModel<DataLakeAnalyticsCapabilityInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsCapabilityInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsCapabilityInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeAnalyticsCapabilityInformation(document.RootElement, options);
        }

        internal static DataLakeAnalyticsCapabilityInformation DeserializeDataLakeAnalyticsCapabilityInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> subscriptionId = default;
            Optional<DataLakeAnalyticsSubscriptionState> state = default;
            Optional<int> maxAccountCount = default;
            Optional<int> accountCount = default;
            Optional<bool> migrationState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new DataLakeAnalyticsSubscriptionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxAccountCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAccountCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("accountCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationState = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataLakeAnalyticsCapabilityInformation(Optional.ToNullable(subscriptionId), Optional.ToNullable(state), Optional.ToNullable(maxAccountCount), Optional.ToNullable(accountCount), Optional.ToNullable(migrationState), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SubscriptionId))
            {
                builder.Append("  subscriptionId:");
                builder.AppendLine($" '{SubscriptionId.Value.ToString()}'");
            }

            if (Optional.IsDefined(State))
            {
                builder.Append("  state:");
                builder.AppendLine($" '{State.ToString()}'");
            }

            if (Optional.IsDefined(MaxAccountCount))
            {
                builder.Append("  maxAccountCount:");
                builder.AppendLine($" {MaxAccountCount.Value}");
            }

            if (Optional.IsDefined(AccountCount))
            {
                builder.Append("  accountCount:");
                builder.AppendLine($" {AccountCount.Value}");
            }

            if (Optional.IsDefined(IsUnderMigrationState))
            {
                builder.Append("  migrationState:");
                var boolValue = IsUnderMigrationState.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
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

        BinaryData IPersistableModel<DataLakeAnalyticsCapabilityInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsCapabilityInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsCapabilityInformation)} does not support '{options.Format}' format.");
            }
        }

        DataLakeAnalyticsCapabilityInformation IPersistableModel<DataLakeAnalyticsCapabilityInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsCapabilityInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataLakeAnalyticsCapabilityInformation(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsCapabilityInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeAnalyticsCapabilityInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
