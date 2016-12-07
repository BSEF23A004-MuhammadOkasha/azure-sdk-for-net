// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Application logs azure blob storage configuration.
    /// </summary>
    public partial class AzureBlobStorageApplicationLogsConfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureBlobStorageApplicationLogsConfig class.
        /// </summary>
        public AzureBlobStorageApplicationLogsConfig() { }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureBlobStorageApplicationLogsConfig class.
        /// </summary>
        /// <param name="level">Log level. Possible values include: 'Off',
        /// 'Verbose', 'Information', 'Warning', 'Error'</param>
        /// <param name="sasUrl">SAS url to a azure blob container with
        /// read/write/list/delete permissions.</param>
        /// <param name="retentionInDays">Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.</param>
        public AzureBlobStorageApplicationLogsConfig(LogLevel? level = default(LogLevel?), string sasUrl = default(string), int? retentionInDays = default(int?))
        {
            Level = level;
            SasUrl = sasUrl;
            RetentionInDays = retentionInDays;
        }

        /// <summary>
        /// Gets or sets log level. Possible values include: 'Off', 'Verbose',
        /// 'Information', 'Warning', 'Error'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "level")]
        public LogLevel? Level { get; set; }

        /// <summary>
        /// Gets or sets SAS url to a azure blob container with
        /// read/write/list/delete permissions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sasUrl")]
        public string SasUrl { get; set; }

        /// <summary>
        /// Gets or sets retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retentionInDays")]
        public int? RetentionInDays { get; set; }

    }
}
