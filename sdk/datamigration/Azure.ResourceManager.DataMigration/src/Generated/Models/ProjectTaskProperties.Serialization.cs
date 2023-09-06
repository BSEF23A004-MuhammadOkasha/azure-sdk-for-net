// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ProjectTaskProperties : IUtf8JsonSerializable, IModelJsonSerializable<ProjectTaskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProjectTaskProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProjectTaskProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProjectTaskProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
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
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ProjectTaskProperties DeserializeProjectTaskProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

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

            // Unknown type found so we will deserialize the base properties only
            TaskType taskType = default;
            Optional<IReadOnlyList<ODataError>> errors = default;
            Optional<TaskState> state = default;
            Optional<IReadOnlyList<CommandProperties>> commands = default;
            Optional<IDictionary<string, string>> clientData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownProjectTaskProperties(taskType, Optional.ToList(errors), Optional.ToNullable(state), Optional.ToList(commands), Optional.ToDictionary(clientData), rawData);
        }

        ProjectTaskProperties IModelJsonSerializable<ProjectTaskProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProjectTaskProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProjectTaskProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProjectTaskProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProjectTaskProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProjectTaskProperties IModelSerializable<ProjectTaskProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProjectTaskProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProjectTaskProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProjectTaskProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProjectTaskProperties"/> to convert. </param>
        public static implicit operator RequestContent(ProjectTaskProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProjectTaskProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProjectTaskProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProjectTaskProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
