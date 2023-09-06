// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the DataTransferJobGetResult data model.
    /// A Cosmos DB Data Transfer Job
    /// </summary>
    public partial class DataTransferJobGetResultData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataTransferJobGetResultData"/>. </summary>
        public DataTransferJobGetResultData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataTransferJobGetResultData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="jobName"> Job Name. </param>
        /// <param name="source">
        /// Source DataStore details
        /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
        /// </param>
        /// <param name="destination">
        /// Destination DataStore details
        /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
        /// </param>
        /// <param name="status"> Job Status. </param>
        /// <param name="processedCount"> Processed Count. </param>
        /// <param name="totalCount"> Total Count. </param>
        /// <param name="lastUpdatedUtcOn"> Last Updated Time (ISO-8601 format). </param>
        /// <param name="workerCount"> Worker count. </param>
        /// <param name="error"> Error response for Faulted job. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataTransferJobGetResultData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string jobName, DataTransferDataSourceSink source, DataTransferDataSourceSink destination, string status, long? processedCount, long? totalCount, DateTimeOffset? lastUpdatedUtcOn, int? workerCount, ErrorResponse error, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            JobName = jobName;
            Source = source;
            Destination = destination;
            Status = status;
            ProcessedCount = processedCount;
            TotalCount = totalCount;
            LastUpdatedUtcOn = lastUpdatedUtcOn;
            WorkerCount = workerCount;
            Error = error;
            _rawData = rawData;
        }

        /// <summary> Job Name. </summary>
        public string JobName { get; }
        /// <summary>
        /// Source DataStore details
        /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
        /// </summary>
        public DataTransferDataSourceSink Source { get; set; }
        /// <summary>
        /// Destination DataStore details
        /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
        /// </summary>
        public DataTransferDataSourceSink Destination { get; set; }
        /// <summary> Job Status. </summary>
        public string Status { get; }
        /// <summary> Processed Count. </summary>
        public long? ProcessedCount { get; }
        /// <summary> Total Count. </summary>
        public long? TotalCount { get; }
        /// <summary> Last Updated Time (ISO-8601 format). </summary>
        public DateTimeOffset? LastUpdatedUtcOn { get; }
        /// <summary> Worker count. </summary>
        public int? WorkerCount { get; set; }
        /// <summary> Error response for Faulted job. </summary>
        public ErrorResponse Error { get; }
    }
}
