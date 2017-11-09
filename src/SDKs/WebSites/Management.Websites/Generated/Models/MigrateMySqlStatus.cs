// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// MySQL migration status.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MigrateMySqlStatus : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the MigrateMySqlStatus class.
        /// </summary>
        public MigrateMySqlStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrateMySqlStatus class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="migrationOperationStatus">Status of the migration
        /// task. Possible values include: 'InProgress', 'Failed', 'Succeeded',
        /// 'TimedOut', 'Created'</param>
        /// <param name="operationId">Operation ID for the migration
        /// task.</param>
        /// <param name="localMySqlEnabled">True if the web app has in app
        /// MySql enabled</param>
        public MigrateMySqlStatus(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), OperationStatus? migrationOperationStatus = default(OperationStatus?), string operationId = default(string), bool? localMySqlEnabled = default(bool?))
            : base(id, name, kind, type)
        {
            MigrationOperationStatus = migrationOperationStatus;
            OperationId = operationId;
            LocalMySqlEnabled = localMySqlEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets status of the migration task. Possible values include:
        /// 'InProgress', 'Failed', 'Succeeded', 'TimedOut', 'Created'
        /// </summary>
        [JsonProperty(PropertyName = "properties.migrationOperationStatus")]
        public OperationStatus? MigrationOperationStatus { get; private set; }

        /// <summary>
        /// Gets operation ID for the migration task.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationId")]
        public string OperationId { get; private set; }

        /// <summary>
        /// Gets true if the web app has in app MySql enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.localMySqlEnabled")]
        public bool? LocalMySqlEnabled { get; private set; }

    }
}
