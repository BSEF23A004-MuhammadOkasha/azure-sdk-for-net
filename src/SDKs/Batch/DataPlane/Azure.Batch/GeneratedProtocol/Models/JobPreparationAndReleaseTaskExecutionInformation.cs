// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The status of the Job Preparation and Job Release tasks on a compute
    /// node.
    /// </summary>
    public partial class JobPreparationAndReleaseTaskExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// JobPreparationAndReleaseTaskExecutionInformation class.
        /// </summary>
        public JobPreparationAndReleaseTaskExecutionInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// JobPreparationAndReleaseTaskExecutionInformation class.
        /// </summary>
        /// <param name="poolId">The ID of the pool containing the compute node
        /// to which this entry refers.</param>
        /// <param name="nodeId">The ID of the compute node to which this entry
        /// refers.</param>
        /// <param name="nodeUrl">The URL of the compute node to which this
        /// entry refers.</param>
        /// <param name="jobPreparationTaskExecutionInfo">Information about the
        /// execution status of the Job Preparation task on this compute
        /// node.</param>
        /// <param name="jobReleaseTaskExecutionInfo">Information about the
        /// execution status of the Job Release task on this compute
        /// node.</param>
        public JobPreparationAndReleaseTaskExecutionInformation(string poolId = default(string), string nodeId = default(string), string nodeUrl = default(string), JobPreparationTaskExecutionInformation jobPreparationTaskExecutionInfo = default(JobPreparationTaskExecutionInformation), JobReleaseTaskExecutionInformation jobReleaseTaskExecutionInfo = default(JobReleaseTaskExecutionInformation))
        {
            PoolId = poolId;
            NodeId = nodeId;
            NodeUrl = nodeUrl;
            JobPreparationTaskExecutionInfo = jobPreparationTaskExecutionInfo;
            JobReleaseTaskExecutionInfo = jobReleaseTaskExecutionInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the pool containing the compute node to
        /// which this entry refers.
        /// </summary>
        [JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the compute node to which this entry refers.
        /// </summary>
        [JsonProperty(PropertyName = "nodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets the URL of the compute node to which this entry
        /// refers.
        /// </summary>
        [JsonProperty(PropertyName = "nodeUrl")]
        public string NodeUrl { get; set; }

        /// <summary>
        /// Gets or sets information about the execution status of the Job
        /// Preparation task on this compute node.
        /// </summary>
        [JsonProperty(PropertyName = "jobPreparationTaskExecutionInfo")]
        public JobPreparationTaskExecutionInformation JobPreparationTaskExecutionInfo { get; set; }

        /// <summary>
        /// Gets or sets information about the execution status of the Job
        /// Release task on this compute node.
        /// </summary>
        /// <remarks>
        /// This property is set only if the Job Release task has run on the
        /// node.
        /// </remarks>
        [JsonProperty(PropertyName = "jobReleaseTaskExecutionInfo")]
        public JobReleaseTaskExecutionInformation JobReleaseTaskExecutionInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (JobPreparationTaskExecutionInfo != null)
            {
                JobPreparationTaskExecutionInfo.Validate();
            }
            if (JobReleaseTaskExecutionInfo != null)
            {
                JobReleaseTaskExecutionInfo.Validate();
            }
        }
    }
}
