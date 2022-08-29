// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Specifies the parameters for the auto user that runs a task on the Batch service. </summary>
    public partial class BatchAutoUserSpecification
    {
        /// <summary> Initializes a new instance of BatchAutoUserSpecification. </summary>
        public BatchAutoUserSpecification()
        {
        }

        /// <summary> Initializes a new instance of BatchAutoUserSpecification. </summary>
        /// <param name="scope"> The default value is Pool. If the pool is running Windows a value of Task should be specified if stricter isolation between tasks is required. For example, if the task mutates the registry in a way which could impact other tasks, or if certificates have been specified on the pool which should not be accessible by normal tasks but should be accessible by start tasks. </param>
        /// <param name="elevationLevel"> The default value is nonAdmin. </param>
        internal BatchAutoUserSpecification(BatchAutoUserScope? scope, BatchUserAccountElevationLevel? elevationLevel)
        {
            Scope = scope;
            ElevationLevel = elevationLevel;
        }

        /// <summary> The default value is Pool. If the pool is running Windows a value of Task should be specified if stricter isolation between tasks is required. For example, if the task mutates the registry in a way which could impact other tasks, or if certificates have been specified on the pool which should not be accessible by normal tasks but should be accessible by start tasks. </summary>
        public BatchAutoUserScope? Scope { get; set; }
        /// <summary> The default value is nonAdmin. </summary>
        public BatchUserAccountElevationLevel? ElevationLevel { get; set; }
    }
}
