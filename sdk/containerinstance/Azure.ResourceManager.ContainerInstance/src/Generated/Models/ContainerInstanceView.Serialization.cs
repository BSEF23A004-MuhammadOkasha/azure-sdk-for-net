// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerInstanceView : IUtf8JsonSerializable, IJsonModel<ContainerInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerInstanceView>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerInstanceView)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RestartCount))
            {
                writer.WritePropertyName("restartCount"u8);
                writer.WriteNumberValue(RestartCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentState))
            {
                writer.WritePropertyName("currentState"u8);
                writer.WriteObjectValue(CurrentState);
            }
            if (options.Format != "W" && Optional.IsDefined(PreviousState))
            {
                writer.WritePropertyName("previousState"u8);
                writer.WriteObjectValue(PreviousState);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ContainerInstanceView IJsonModel<ContainerInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerInstanceView)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerInstanceView(document.RootElement, options);
        }

        internal static ContainerInstanceView DeserializeContainerInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> restartCount = default;
            Optional<ContainerState> currentState = default;
            Optional<ContainerState> previousState = default;
            Optional<IReadOnlyList<ContainerEvent>> events = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restartCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restartCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentState = ContainerState.DeserializeContainerState(property.Value);
                    continue;
                }
                if (property.NameEquals("previousState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previousState = ContainerState.DeserializeContainerState(property.Value);
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerEvent> array = new List<ContainerEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerEvent.DeserializeContainerEvent(item));
                    }
                    events = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerInstanceView(Optional.ToNullable(restartCount), currentState.Value, previousState.Value, Optional.ToList(events), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(RestartCount))
            {
                builder.Append("  restartCount:");
                builder.AppendLine($" {RestartCount.Value}");
            }

            if (Optional.IsDefined(CurrentState))
            {
                builder.Append("  currentState:");
                AppendChildObject(builder, CurrentState, options, 2, false);
            }

            if (Optional.IsDefined(PreviousState))
            {
                builder.Append("  previousState:");
                AppendChildObject(builder, PreviousState, options, 2, false);
            }

            if (Optional.IsCollectionDefined(Events))
            {
                if (Events.Any())
                {
                    builder.Append("  events:");
                    builder.AppendLine(" [");
                    foreach (var item in Events)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
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

        BinaryData IPersistableModel<ContainerInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerInstanceView)} does not support '{options.Format}' format.");
            }
        }

        ContainerInstanceView IPersistableModel<ContainerInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerInstanceView(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerInstanceView)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
