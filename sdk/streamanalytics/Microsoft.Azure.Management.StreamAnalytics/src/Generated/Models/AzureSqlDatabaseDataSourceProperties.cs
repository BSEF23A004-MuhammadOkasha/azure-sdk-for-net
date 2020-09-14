// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties that are associated with an Azure SQL database data
    /// source.
    /// </summary>
    public partial class AzureSqlDatabaseDataSourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureSqlDatabaseDataSourceProperties class.
        /// </summary>
        public AzureSqlDatabaseDataSourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureSqlDatabaseDataSourceProperties class.
        /// </summary>
        /// <param name="server">The name of the SQL server containing the
        /// Azure SQL database. Required on PUT (CreateOrReplace)
        /// requests.</param>
        /// <param name="database">The name of the Azure SQL database. Required
        /// on PUT (CreateOrReplace) requests.</param>
        /// <param name="user">The user name that will be used to connect to
        /// the Azure SQL database. Required on PUT (CreateOrReplace)
        /// requests.</param>
        /// <param name="password">The password that will be used to connect to
        /// the Azure SQL database. Required on PUT (CreateOrReplace)
        /// requests.</param>
        /// <param name="table">The name of the table in the Azure SQL
        /// database. Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="maxBatchCount">Max Batch count for write to Sql
        /// database, the default value is 10,000. Optional on PUT
        /// requests.</param>
        /// <param name="maxWriterCount">Max Write r count, currently only
        /// 1(single writer) and 0(based on query partition) are available.
        /// Optional on PUT requests.</param>
        /// <param name="authenticationMode">Authentication Mode. Possible
        /// values include: 'Msi', 'UserToken', 'ConnectionString'</param>
        public AzureSqlDatabaseDataSourceProperties(string server = default(string), string database = default(string), string user = default(string), string password = default(string), string table = default(string), double? maxBatchCount = default(double?), double? maxWriterCount = default(double?), string authenticationMode = default(string))
        {
            Server = server;
            Database = database;
            User = user;
            Password = password;
            Table = table;
            MaxBatchCount = maxBatchCount;
            MaxWriterCount = maxWriterCount;
            AuthenticationMode = authenticationMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the SQL server containing the Azure SQL
        /// database. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string Server { get; set; }

        /// <summary>
        /// Gets or sets the name of the Azure SQL database. Required on PUT
        /// (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "database")]
        public string Database { get; set; }

        /// <summary>
        /// Gets or sets the user name that will be used to connect to the
        /// Azure SQL database. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the password that will be used to connect to the Azure
        /// SQL database. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the name of the table in the Azure SQL database.
        /// Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "table")]
        public string Table { get; set; }

        /// <summary>
        /// Gets or sets max Batch count for write to Sql database, the default
        /// value is 10,000. Optional on PUT requests.
        /// </summary>
        [JsonProperty(PropertyName = "maxBatchCount")]
        public double? MaxBatchCount { get; set; }

        /// <summary>
        /// Gets or sets max Write r count, currently only 1(single writer) and
        /// 0(based on query partition) are available. Optional on PUT
        /// requests.
        /// </summary>
        [JsonProperty(PropertyName = "maxWriterCount")]
        public double? MaxWriterCount { get; set; }

        /// <summary>
        /// Gets or sets authentication Mode. Possible values include: 'Msi',
        /// 'UserToken', 'ConnectionString'
        /// </summary>
        [JsonProperty(PropertyName = "authenticationMode")]
        public string AuthenticationMode { get; set; }

    }
}
