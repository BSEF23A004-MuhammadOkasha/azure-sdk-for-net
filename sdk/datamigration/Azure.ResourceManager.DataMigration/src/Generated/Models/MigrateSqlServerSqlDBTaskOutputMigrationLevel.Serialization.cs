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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDBTaskOutputMigrationLevel : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>, IPersistableModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputMigrationLevel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndedOn))
            {
                writer.WritePropertyName("endedOn"u8);
                writer.WriteStringValue(EndedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(DurationInSeconds))
            {
                writer.WritePropertyName("durationInSeconds"u8);
                writer.WriteNumberValue(DurationInSeconds.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StatusMessage))
            {
                writer.WritePropertyName("statusMessage"u8);
                writer.WriteStringValue(StatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsDefined(Databases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStringValue(Databases);
            }
            if (options.Format != "W" && Optional.IsDefined(DatabaseSummary))
            {
                writer.WritePropertyName("databaseSummary"u8);
                writer.WriteStringValue(DatabaseSummary);
            }
            if (Optional.IsDefined(MigrationValidationResult))
            {
                writer.WritePropertyName("migrationValidationResult"u8);
                writer.WriteObjectValue(MigrationValidationResult);
            }
            if (Optional.IsDefined(MigrationReportResult))
            {
                writer.WritePropertyName("migrationReportResult"u8);
                writer.WriteObjectValue(MigrationReportResult);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerVersion))
            {
                writer.WritePropertyName("sourceServerVersion"u8);
                writer.WriteStringValue(SourceServerVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerBrandVersion))
            {
                writer.WritePropertyName("sourceServerBrandVersion"u8);
                writer.WriteStringValue(SourceServerBrandVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetServerVersion))
            {
                writer.WritePropertyName("targetServerVersion"u8);
                writer.WriteStringValue(TargetServerVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetServerBrandVersion))
            {
                writer.WritePropertyName("targetServerBrandVersion"u8);
                writer.WriteStringValue(TargetServerBrandVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExceptionsAndWarnings))
            {
                writer.WritePropertyName("exceptionsAndWarnings"u8);
                writer.WriteStartArray();
                foreach (var item in ExceptionsAndWarnings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateSqlServerSqlDBTaskOutputMigrationLevel IJsonModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputMigrationLevel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBTaskOutputMigrationLevel(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlDBTaskOutputMigrationLevel DeserializeMigrateSqlServerSqlDBTaskOutputMigrationLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<long> durationInSeconds = default;
            Optional<MigrationStatus> status = default;
            Optional<string> statusMessage = default;
            Optional<string> message = default;
            Optional<string> databases = default;
            Optional<string> databaseSummary = default;
            Optional<MigrationValidationResult> migrationValidationResult = default;
            Optional<MigrationReportResult> migrationReportResult = default;
            Optional<string> sourceServerVersion = default;
            Optional<string> sourceServerBrandVersion = default;
            Optional<string> targetServerVersion = default;
            Optional<string> targetServerBrandVersion = default;
            Optional<IReadOnlyList<ReportableException>> exceptionsAndWarnings = default;
            Optional<string> id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("durationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MigrationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databases"u8))
                {
                    databases = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseSummary"u8))
                {
                    databaseSummary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationValidationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationValidationResult = MigrationValidationResult.DeserializeMigrationValidationResult(property.Value);
                    continue;
                }
                if (property.NameEquals("migrationReportResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationReportResult = MigrationReportResult.DeserializeMigrationReportResult(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceServerVersion"u8))
                {
                    sourceServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerBrandVersion"u8))
                {
                    sourceServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerVersion"u8))
                {
                    targetServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerBrandVersion"u8))
                {
                    targetServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exceptionsAndWarnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    exceptionsAndWarnings = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSqlServerSqlDBTaskOutputMigrationLevel(id.Value, resultType, serializedAdditionalRawData, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), Optional.ToNullable(durationInSeconds), Optional.ToNullable(status), statusMessage.Value, message.Value, databases.Value, databaseSummary.Value, migrationValidationResult.Value, migrationReportResult.Value, sourceServerVersion.Value, sourceServerBrandVersion.Value, targetServerVersion.Value, targetServerBrandVersion.Value, Optional.ToList(exceptionsAndWarnings));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(StartedOn))
            {
                builder.Append("  startedOn:");
                builder.AppendLine($" '{StartedOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(EndedOn))
            {
                builder.Append("  endedOn:");
                builder.AppendLine($" '{EndedOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(DurationInSeconds))
            {
                builder.Append("  durationInSeconds:");
                builder.AppendLine($" '{DurationInSeconds.Value.ToString()}'");
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status.ToString()}'");
            }

            if (Optional.IsDefined(StatusMessage))
            {
                builder.Append("  statusMessage:");
                builder.AppendLine($" '{StatusMessage}'");
            }

            if (Optional.IsDefined(Message))
            {
                builder.Append("  message:");
                builder.AppendLine($" '{Message}'");
            }

            if (Optional.IsDefined(Databases))
            {
                builder.Append("  databases:");
                builder.AppendLine($" '{Databases}'");
            }

            if (Optional.IsDefined(DatabaseSummary))
            {
                builder.Append("  databaseSummary:");
                builder.AppendLine($" '{DatabaseSummary}'");
            }

            if (Optional.IsDefined(MigrationValidationResult))
            {
                builder.Append("  migrationValidationResult:");
                AppendChildObject(builder, MigrationValidationResult, options, 2);
            }

            if (Optional.IsDefined(MigrationReportResult))
            {
                builder.Append("  migrationReportResult:");
                AppendChildObject(builder, MigrationReportResult, options, 2);
            }

            if (Optional.IsDefined(SourceServerVersion))
            {
                builder.Append("  sourceServerVersion:");
                builder.AppendLine($" '{SourceServerVersion}'");
            }

            if (Optional.IsDefined(SourceServerBrandVersion))
            {
                builder.Append("  sourceServerBrandVersion:");
                builder.AppendLine($" '{SourceServerBrandVersion}'");
            }

            if (Optional.IsDefined(TargetServerVersion))
            {
                builder.Append("  targetServerVersion:");
                builder.AppendLine($" '{TargetServerVersion}'");
            }

            if (Optional.IsDefined(TargetServerBrandVersion))
            {
                builder.Append("  targetServerBrandVersion:");
                builder.AppendLine($" '{TargetServerBrandVersion}'");
            }

            if (Optional.IsCollectionDefined(ExceptionsAndWarnings))
            {
                builder.Append("  exceptionsAndWarnings:");
                builder.AppendLine(" [");
                foreach (var item in ExceptionsAndWarnings)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id}'");
            }

            if (Optional.IsDefined(ResultType))
            {
                builder.Append("  resultType:");
                builder.AppendLine($" '{ResultType}'");
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

        BinaryData IPersistableModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputMigrationLevel)} does not support '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlDBTaskOutputMigrationLevel IPersistableModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlDBTaskOutputMigrationLevel(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputMigrationLevel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlDBTaskOutputMigrationLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
