// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes a MongoDB data source. </summary>
    public partial class MongoDbClusterInfo
    {
        /// <summary> Initializes a new instance of MongoDbClusterInfo. </summary>
        /// <param name="databases"> A list of non-system databases in the cluster. </param>
        /// <param name="supportsSharding"> Whether the cluster supports sharded collections. </param>
        /// <param name="clusterType"> The type of data source. </param>
        /// <param name="version"> The version of the data source in the form x.y.z (e.g. 3.6.7). Not used if Type is BlobContainer. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databases"/> or <paramref name="version"/> is null. </exception>
        internal MongoDbClusterInfo(IEnumerable<MongoDbDatabaseInfo> databases, bool supportsSharding, MongoDbClusterType clusterType, string version)
        {
            if (databases == null)
            {
                throw new ArgumentNullException(nameof(databases));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            Databases = databases.ToList();
            SupportsSharding = supportsSharding;
            ClusterType = clusterType;
            Version = version;
        }

        /// <summary> Initializes a new instance of MongoDbClusterInfo. </summary>
        /// <param name="databases"> A list of non-system databases in the cluster. </param>
        /// <param name="supportsSharding"> Whether the cluster supports sharded collections. </param>
        /// <param name="clusterType"> The type of data source. </param>
        /// <param name="version"> The version of the data source in the form x.y.z (e.g. 3.6.7). Not used if Type is BlobContainer. </param>
        internal MongoDbClusterInfo(IReadOnlyList<MongoDbDatabaseInfo> databases, bool supportsSharding, MongoDbClusterType clusterType, string version)
        {
            Databases = databases;
            SupportsSharding = supportsSharding;
            ClusterType = clusterType;
            Version = version;
        }

        /// <summary> A list of non-system databases in the cluster. </summary>
        public IReadOnlyList<MongoDbDatabaseInfo> Databases { get; }
        /// <summary> Whether the cluster supports sharded collections. </summary>
        public bool SupportsSharding { get; }
        /// <summary> The type of data source. </summary>
        public MongoDbClusterType ClusterType { get; }
        /// <summary> The version of the data source in the form x.y.z (e.g. 3.6.7). Not used if Type is BlobContainer. </summary>
        public string Version { get; }
    }
}
