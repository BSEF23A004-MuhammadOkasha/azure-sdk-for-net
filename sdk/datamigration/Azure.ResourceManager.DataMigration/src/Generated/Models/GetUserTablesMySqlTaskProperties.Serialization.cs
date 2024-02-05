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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class GetUserTablesMySqlTaskProperties : IUtf8JsonSerializable, IJsonModel<GetUserTablesMySqlTaskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GetUserTablesMySqlTaskProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GetUserTablesMySqlTaskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesMySqlTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetUserTablesMySqlTaskProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStartArray();
                foreach (var item in Output)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            if (options.Format != "W" && Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Commands))
            {
                writer.WritePropertyName("commands"u8);
                writer.WriteStartArray();
                foreach (var item in Commands)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClientData))
            {
                writer.WritePropertyName("clientData"u8);
                writer.WriteStartObject();
                foreach (var item in ClientData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        GetUserTablesMySqlTaskProperties IJsonModel<GetUserTablesMySqlTaskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesMySqlTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetUserTablesMySqlTaskProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGetUserTablesMySqlTaskProperties(document.RootElement, options);
        }

        internal static GetUserTablesMySqlTaskProperties DeserializeGetUserTablesMySqlTaskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GetUserTablesMySqlTaskInput> input = default;
            Optional<IReadOnlyList<GetUserTablesMySqlTaskOutput>> output = default;
            TaskType taskType = default;
            Optional<IReadOnlyList<ODataError>> errors = default;
            Optional<TaskState> state = default;
            Optional<IReadOnlyList<CommandProperties>> commands = default;
            Optional<IDictionary<string, string>> clientData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = GetUserTablesMySqlTaskInput.DeserializeGetUserTablesMySqlTaskInput(property.Value);
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GetUserTablesMySqlTaskOutput> array = new List<GetUserTablesMySqlTaskOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GetUserTablesMySqlTaskOutput.DeserializeGetUserTablesMySqlTaskOutput(item));
                    }
                    output = array;
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ODataError> array = new List<ODataError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ODataError.DeserializeODataError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new TaskState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commands"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommandProperties> array = new List<CommandProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommandProperties.DeserializeCommandProperties(item));
                    }
                    commands = array;
                    continue;
                }
                if (property.NameEquals("clientData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    clientData = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GetUserTablesMySqlTaskProperties(taskType, Optional.ToList(errors), Optional.ToNullable(state), Optional.ToList(commands), Optional.ToDictionary(clientData), serializedAdditionalRawData, input.Value, Optional.ToList(output));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Input))
            {
                builder.Append("  input:");
                AppendChildObject(builder, Input, options, 2, false);
            }

            if (Optional.IsCollectionDefined(Output))
            {
                if (Output.Any())
                {
                    builder.Append("  output:");
                    builder.AppendLine(" [");
                    foreach (var item in Output)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(TaskType))
            {
                builder.Append("  taskType:");
                builder.AppendLine($" '{TaskType.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Errors))
            {
                if (Errors.Any())
                {
                    builder.Append("  errors:");
                    builder.AppendLine(" [");
                    foreach (var item in Errors)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(State))
            {
                builder.Append("  state:");
                builder.AppendLine($" '{State.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Commands))
            {
                if (Commands.Any())
                {
                    builder.Append("  commands:");
                    builder.AppendLine(" [");
                    foreach (var item in Commands)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(ClientData))
            {
                if (ClientData.Any())
                {
                    builder.Append("  clientData:");
                    builder.AppendLine(" {");
                    foreach (var item in ClientData)
                    {
                        builder.Append($"    {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value}'");
                    }
                    builder.AppendLine("  }");
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

        BinaryData IPersistableModel<GetUserTablesMySqlTaskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesMySqlTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GetUserTablesMySqlTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        GetUserTablesMySqlTaskProperties IPersistableModel<GetUserTablesMySqlTaskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesMySqlTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGetUserTablesMySqlTaskProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(GetUserTablesMySqlTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GetUserTablesMySqlTaskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
