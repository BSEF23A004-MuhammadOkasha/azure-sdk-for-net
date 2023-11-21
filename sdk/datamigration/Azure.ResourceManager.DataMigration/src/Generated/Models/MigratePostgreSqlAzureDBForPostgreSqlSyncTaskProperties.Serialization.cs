// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties : IUtf8JsonSerializable, IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties)} does not support '{format}' format.");
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
            if (Optional.IsDefined(TaskId))
            {
                writer.WritePropertyName("taskId"u8);
                writer.WriteStringValue(TaskId);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdOn"u8);
                writer.WriteStringValue(CreatedOn);
            }
            if (Optional.IsDefined(IsCloneable))
            {
                writer.WritePropertyName("isCloneable"u8);
                writer.WriteBooleanValue(IsCloneable.Value);
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

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties(document.RootElement, options);
        }

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskInput> input = default;
            Optional<IReadOnlyList<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>> output = default;
            Optional<string> taskId = default;
            Optional<string> createdOn = default;
            Optional<bool> isCloneable = default;
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
                    input = MigratePostgreSqlAzureDBForPostgreSqlSyncTaskInput.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskInput(property.Value);
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput> array = new List<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(item));
                    }
                    output = array;
                    continue;
                }
                if (property.NameEquals("taskId"u8))
                {
                    taskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdOn"u8))
                {
                    createdOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCloneable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCloneable = property.Value.GetBoolean();
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
            return new MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties(taskType, Optional.ToList(errors), Optional.ToNullable(state), Optional.ToList(commands), Optional.ToDictionary(clientData), serializedAdditionalRawData, input.Value, Optional.ToList(output), taskId.Value, createdOn.Value, Optional.ToNullable(isCloneable));
        }

        BinaryData IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
