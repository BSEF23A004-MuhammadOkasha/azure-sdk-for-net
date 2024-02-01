// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownProjectTaskProperties))]
    public partial class ProjectTaskProperties : IUtf8JsonSerializable, IJsonModel<ProjectTaskProperties>, IPersistableModel<ProjectTaskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProjectTaskProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProjectTaskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProjectTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProjectTaskProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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

        ProjectTaskProperties IJsonModel<ProjectTaskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProjectTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProjectTaskProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProjectTaskProperties(document.RootElement, options);
        }

        internal static ProjectTaskProperties DeserializeProjectTaskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("taskType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Connect.MongoDb": return ConnectToMongoDBTaskProperties.DeserializeConnectToMongoDBTaskProperties(element);
                    case "ConnectToSource.MySql": return ConnectToSourceMySqlTaskProperties.DeserializeConnectToSourceMySqlTaskProperties(element);
                    case "ConnectToSource.Oracle.Sync": return ConnectToSourceOracleSyncTaskProperties.DeserializeConnectToSourceOracleSyncTaskProperties(element);
                    case "ConnectToSource.PostgreSql.Sync": return ConnectToSourcePostgreSqlSyncTaskProperties.DeserializeConnectToSourcePostgreSqlSyncTaskProperties(element);
                    case "ConnectToSource.SqlServer": return ConnectToSourceSqlServerTaskProperties.DeserializeConnectToSourceSqlServerTaskProperties(element);
                    case "ConnectToSource.SqlServer.Sync": return ConnectToSourceSqlServerSyncTaskProperties.DeserializeConnectToSourceSqlServerSyncTaskProperties(element);
                    case "ConnectToTarget.AzureDbForMySql": return ConnectToTargetAzureDBForMySqlTaskProperties.DeserializeConnectToTargetAzureDBForMySqlTaskProperties(element);
                    case "ConnectToTarget.AzureDbForPostgreSql.Sync": return ConnectToTargetAzureDBForPostgreSqlSyncTaskProperties.DeserializeConnectToTargetAzureDBForPostgreSqlSyncTaskProperties(element);
                    case "ConnectToTarget.AzureSqlDbMI": return ConnectToTargetSqlMITaskProperties.DeserializeConnectToTargetSqlMITaskProperties(element);
                    case "ConnectToTarget.AzureSqlDbMI.Sync.LRS": return ConnectToTargetSqlMISyncTaskProperties.DeserializeConnectToTargetSqlMISyncTaskProperties(element);
                    case "ConnectToTarget.Oracle.AzureDbForPostgreSql.Sync": return ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskProperties.DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskProperties(element);
                    case "ConnectToTarget.SqlDb": return ConnectToTargetSqlDBTaskProperties.DeserializeConnectToTargetSqlDBTaskProperties(element);
                    case "ConnectToTarget.SqlDb.Sync": return ConnectToTargetSqlDBSyncTaskProperties.DeserializeConnectToTargetSqlDBSyncTaskProperties(element);
                    case "GetTDECertificates.Sql": return GetTdeCertificatesSqlTaskProperties.DeserializeGetTdeCertificatesSqlTaskProperties(element);
                    case "GetUserTables.AzureSqlDb.Sync": return GetUserTablesSqlSyncTaskProperties.DeserializeGetUserTablesSqlSyncTaskProperties(element);
                    case "GetUserTables.Sql": return GetUserTablesSqlTaskProperties.DeserializeGetUserTablesSqlTaskProperties(element);
                    case "GetUserTablesMySql": return GetUserTablesMySqlTaskProperties.DeserializeGetUserTablesMySqlTaskProperties(element);
                    case "GetUserTablesOracle": return GetUserTablesOracleTaskProperties.DeserializeGetUserTablesOracleTaskProperties(element);
                    case "GetUserTablesPostgreSql": return GetUserTablesPostgreSqlTaskProperties.DeserializeGetUserTablesPostgreSqlTaskProperties(element);
                    case "Migrate.MongoDb": return MigrateMongoDBTaskProperties.DeserializeMigrateMongoDBTaskProperties(element);
                    case "Migrate.MySql.AzureDbForMySql": return MigrateMySqlAzureDBForMySqlOfflineTaskProperties.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskProperties(element);
                    case "Migrate.MySql.AzureDbForMySql.Sync": return MigrateMySqlAzureDBForMySqlSyncTaskProperties.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskProperties(element);
                    case "Migrate.Oracle.AzureDbForPostgreSql.Sync": return MigrateOracleAzureDBForPostgreSqlSyncTaskProperties.DeserializeMigrateOracleAzureDBForPostgreSqlSyncTaskProperties(element);
                    case "Migrate.PostgreSql.AzureDbForPostgreSql.SyncV2": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties(element);
                    case "Migrate.SqlServer.AzureSqlDb.Sync": return MigrateSqlServerSqlDBSyncTaskProperties.DeserializeMigrateSqlServerSqlDBSyncTaskProperties(element);
                    case "Migrate.SqlServer.AzureSqlDbMI": return MigrateSqlServerSqlMITaskProperties.DeserializeMigrateSqlServerSqlMITaskProperties(element);
                    case "Migrate.SqlServer.AzureSqlDbMI.Sync.LRS": return MigrateSqlServerSqlMISyncTaskProperties.DeserializeMigrateSqlServerSqlMISyncTaskProperties(element);
                    case "Migrate.SqlServer.SqlDb": return MigrateSqlServerSqlDBTaskProperties.DeserializeMigrateSqlServerSqlDBTaskProperties(element);
                    case "Migrate.Ssis": return MigrateSsisTaskProperties.DeserializeMigrateSsisTaskProperties(element);
                    case "MigrateSchemaSqlServerSqlDb": return MigrateSchemaSqlServerSqlDBTaskProperties.DeserializeMigrateSchemaSqlServerSqlDBTaskProperties(element);
                    case "Service.Check.OCI": return CheckOciDriverTaskProperties.DeserializeCheckOciDriverTaskProperties(element);
                    case "Service.Install.OCI": return InstallOciDriverTaskProperties.DeserializeInstallOciDriverTaskProperties(element);
                    case "Service.Upload.OCI": return UploadOciDriverTaskProperties.DeserializeUploadOciDriverTaskProperties(element);
                    case "Validate.MongoDb": return ValidateMongoDBTaskProperties.DeserializeValidateMongoDBTaskProperties(element);
                    case "Validate.Oracle.AzureDbPostgreSql.Sync": return ValidateOracleAzureDBForPostgreSqlSyncTaskProperties.DeserializeValidateOracleAzureDBForPostgreSqlSyncTaskProperties(element);
                    case "ValidateMigrationInput.SqlServer.AzureSqlDbMI": return ValidateMigrationInputSqlServerSqlMITaskProperties.DeserializeValidateMigrationInputSqlServerSqlMITaskProperties(element);
                    case "ValidateMigrationInput.SqlServer.AzureSqlDbMI.Sync.LRS": return ValidateMigrationInputSqlServerSqlMISyncTaskProperties.DeserializeValidateMigrationInputSqlServerSqlMISyncTaskProperties(element);
                    case "ValidateMigrationInput.SqlServer.SqlDb.Sync": return ValidateMigrationInputSqlServerSqlDBSyncTaskProperties.DeserializeValidateMigrationInputSqlServerSqlDBSyncTaskProperties(element);
                }
            }
            return UnknownProjectTaskProperties.DeserializeUnknownProjectTaskProperties(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(TaskType))
            {
                builder.Append("  taskType:");
                builder.AppendLine($" '{TaskType.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Errors))
            {
                builder.Append("  errors:");
                builder.AppendLine(" [");
                foreach (var item in Errors)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(State))
            {
                builder.Append("  state:");
                builder.AppendLine($" '{State.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Commands))
            {
                builder.Append("  commands:");
                builder.AppendLine(" [");
                foreach (var item in Commands)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(ClientData))
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

        BinaryData IPersistableModel<ProjectTaskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProjectTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ProjectTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        ProjectTaskProperties IPersistableModel<ProjectTaskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProjectTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProjectTaskProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ProjectTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProjectTaskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
