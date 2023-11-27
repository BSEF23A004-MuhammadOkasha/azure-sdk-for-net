// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters used to create a new compute policy.
    /// Serialized Name: CreateOrUpdateComputePolicyParameters
    /// </summary>
    public partial class DataLakeAnalyticsComputePolicyCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsComputePolicyCreateOrUpdateContent"/>. </summary>
        /// <param name="objectId">
        /// The AAD object identifier for the entity to create a policy for.
        /// Serialized Name: CreateOrUpdateComputePolicyParameters.properties.objectId
        /// </param>
        /// <param name="objectType">
        /// The type of AAD object the object identifier refers to.
        /// Serialized Name: CreateOrUpdateComputePolicyParameters.properties.objectType
        /// </param>
        public DataLakeAnalyticsComputePolicyCreateOrUpdateContent(Guid objectId, AadObjectIdentifierType objectType)
        {
            ObjectId = objectId;
            ObjectType = objectType;
        }

        /// <summary>
        /// The AAD object identifier for the entity to create a policy for.
        /// Serialized Name: CreateOrUpdateComputePolicyParameters.properties.objectId
        /// </summary>
        public Guid ObjectId { get; }
        /// <summary>
        /// The type of AAD object the object identifier refers to.
        /// Serialized Name: CreateOrUpdateComputePolicyParameters.properties.objectType
        /// </summary>
        public AadObjectIdentifierType ObjectType { get; }
        /// <summary>
        /// The maximum degree of parallelism per job this user can use to submit jobs. This property, the min priority per job property, or both must be passed.
        /// Serialized Name: CreateOrUpdateComputePolicyParameters.properties.maxDegreeOfParallelismPerJob
        /// </summary>
        public int? MaxDegreeOfParallelismPerJob { get; set; }
        /// <summary>
        /// The minimum priority per job this user can use to submit jobs. This property, the max degree of parallelism per job property, or both must be passed.
        /// Serialized Name: CreateOrUpdateComputePolicyParameters.properties.minPriorityPerJob
        /// </summary>
        public int? MinPriorityPerJob { get; set; }
    }
}
