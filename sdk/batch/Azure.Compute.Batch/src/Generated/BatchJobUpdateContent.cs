// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> Parameters for updating an Azure Batch Job. </summary>
    public partial class BatchJobUpdateContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchJobUpdateContent"/>. </summary>
        public BatchJobUpdateContent()
        {
            Metadata = new ChangeTrackingList<MetadataItem>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobUpdateContent"/>. </summary>
        /// <param name="priority"> The priority of the Job. Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. If omitted, the priority of the Job is left unchanged. </param>
        /// <param name="allowTaskPreemption"> Whether Tasks in this job can be preempted by other high priority jobs. If the value is set to True, other high priority jobs submitted to the system will take precedence and will be able requeue tasks from this job. You can update a job's allowTaskPreemption after it has been created using the update job API. </param>
        /// <param name="maxParallelTasks"> The maximum number of tasks that can be executed in parallel for the job. The value of maxParallelTasks must be -1 or greater than 0 if specified. If not specified, the default value is -1, which means there's no limit to the number of tasks that can be run at once. You can update a job's maxParallelTasks after it has been created using the update job API. </param>
        /// <param name="constraints"> The execution constraints for the Job. If omitted, the existing execution constraints are left unchanged. </param>
        /// <param name="poolInfo"> The Pool on which the Batch service runs the Job's Tasks. You may change the Pool for a Job only when the Job is disabled. The Patch Job call will fail if you include the poolInfo element and the Job is not disabled. If you specify an autoPoolSpecification in the poolInfo, only the keepAlive property of the autoPoolSpecification can be updated, and then only if the autoPoolSpecification has a poolLifetimeOption of Job (other job properties can be updated as normal). If omitted, the Job continues to run on its current Pool. </param>
        /// <param name="onAllTasksComplete"> The action the Batch service should take when all Tasks in the Job are in the completed state. If omitted, the completion behavior is left unchanged. You may not change the value from terminatejob to noaction - that is, once you have engaged automatic Job termination, you cannot turn it off again. If you try to do this, the request fails with an 'invalid property value' error response; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="metadata"> A list of name-value pairs associated with the Job as metadata. If omitted, the existing Job metadata is left unchanged. </param>
        /// <param name="networkConfiguration"> The network configuration for the Job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchJobUpdateContent(int? priority, bool? allowTaskPreemption, int? maxParallelTasks, BatchJobConstraints constraints, BatchPoolInfo poolInfo, OnAllBatchTasksComplete? onAllTasksComplete, IList<MetadataItem> metadata, BatchJobNetworkConfiguration networkConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Priority = priority;
            AllowTaskPreemption = allowTaskPreemption;
            MaxParallelTasks = maxParallelTasks;
            Constraints = constraints;
            PoolInfo = poolInfo;
            OnAllTasksComplete = onAllTasksComplete;
            Metadata = metadata;
            NetworkConfiguration = networkConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The priority of the Job. Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. If omitted, the priority of the Job is left unchanged. </summary>
        public int? Priority { get; set; }
        /// <summary> Whether Tasks in this job can be preempted by other high priority jobs. If the value is set to True, other high priority jobs submitted to the system will take precedence and will be able requeue tasks from this job. You can update a job's allowTaskPreemption after it has been created using the update job API. </summary>
        public bool? AllowTaskPreemption { get; set; }
        /// <summary> The maximum number of tasks that can be executed in parallel for the job. The value of maxParallelTasks must be -1 or greater than 0 if specified. If not specified, the default value is -1, which means there's no limit to the number of tasks that can be run at once. You can update a job's maxParallelTasks after it has been created using the update job API. </summary>
        public int? MaxParallelTasks { get; set; }
        /// <summary> The execution constraints for the Job. If omitted, the existing execution constraints are left unchanged. </summary>
        public BatchJobConstraints Constraints { get; set; }
        /// <summary> The Pool on which the Batch service runs the Job's Tasks. You may change the Pool for a Job only when the Job is disabled. The Patch Job call will fail if you include the poolInfo element and the Job is not disabled. If you specify an autoPoolSpecification in the poolInfo, only the keepAlive property of the autoPoolSpecification can be updated, and then only if the autoPoolSpecification has a poolLifetimeOption of Job (other job properties can be updated as normal). If omitted, the Job continues to run on its current Pool. </summary>
        public BatchPoolInfo PoolInfo { get; set; }
        /// <summary> The action the Batch service should take when all Tasks in the Job are in the completed state. If omitted, the completion behavior is left unchanged. You may not change the value from terminatejob to noaction - that is, once you have engaged automatic Job termination, you cannot turn it off again. If you try to do this, the request fails with an 'invalid property value' error response; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public OnAllBatchTasksComplete? OnAllTasksComplete { get; set; }
        /// <summary> A list of name-value pairs associated with the Job as metadata. If omitted, the existing Job metadata is left unchanged. </summary>
        public IList<MetadataItem> Metadata { get; }
        /// <summary> The network configuration for the Job. </summary>
        public BatchJobNetworkConfiguration NetworkConfiguration { get; set; }
    }
}
