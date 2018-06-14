// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.4.36.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HDInsight Spark activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsightSpark")]
    [Rest.Serialization.JsonTransformation]
    public partial class HDInsightSparkActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the HDInsightSparkActivity class.
        /// </summary>
        public HDInsightSparkActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HDInsightSparkActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="rootPath">The root path in 'sparkJobLinkedService' for
        /// all the job’s files. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="entryFilePath">The relative path to the root folder of
        /// the code/package to be executed. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="arguments">The user-specified arguments to
        /// HDInsightSparkActivity.</param>
        /// <param name="getDebugInfo">Debug info option. Possible values
        /// include: 'None', 'Always', 'Failure'</param>
        /// <param name="sparkJobLinkedService">The storage linked service for
        /// uploading the entry file and dependencies, and for receiving
        /// logs.</param>
        /// <param name="className">The application's Java/Spark main
        /// class.</param>
        /// <param name="proxyUser">The user to impersonate that will execute
        /// the job. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="sparkConfig">Spark configuration property.</param>
        public HDInsightSparkActivity(string name, object rootPath, object entryFilePath, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), IList<object> arguments = default(IList<object>), string getDebugInfo = default(string), LinkedServiceReference sparkJobLinkedService = default(LinkedServiceReference), string className = default(string), object proxyUser = default(object), IDictionary<string, object> sparkConfig = default(IDictionary<string, object>))
            : base(name, additionalProperties, description, dependsOn, linkedServiceName, policy)
        {
            RootPath = rootPath;
            EntryFilePath = entryFilePath;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            SparkJobLinkedService = sparkJobLinkedService;
            ClassName = className;
            ProxyUser = proxyUser;
            SparkConfig = sparkConfig;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the root path in 'sparkJobLinkedService' for all the
        /// job’s files. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.rootPath")]
        public object RootPath { get; set; }

        /// <summary>
        /// Gets or sets the relative path to the root folder of the
        /// code/package to be executed. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.entryFilePath")]
        public object EntryFilePath { get; set; }

        /// <summary>
        /// Gets or sets the user-specified arguments to
        /// HDInsightSparkActivity.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.arguments")]
        public IList<object> Arguments { get; set; }

        /// <summary>
        /// Gets or sets debug info option. Possible values include: 'None',
        /// 'Always', 'Failure'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.getDebugInfo")]
        public string GetDebugInfo { get; set; }

        /// <summary>
        /// Gets or sets the storage linked service for uploading the entry
        /// file and dependencies, and for receiving logs.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sparkJobLinkedService")]
        public LinkedServiceReference SparkJobLinkedService { get; set; }

        /// <summary>
        /// Gets or sets the application's Java/Spark main class.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.className")]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets the user to impersonate that will execute the job.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.proxyUser")]
        public object ProxyUser { get; set; }

        /// <summary>
        /// Gets or sets spark configuration property.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sparkConfig")]
        public IDictionary<string, object> SparkConfig { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (RootPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RootPath");
            }
            if (EntryFilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EntryFilePath");
            }
            if (SparkJobLinkedService != null)
            {
                SparkJobLinkedService.Validate();
            }
        }
    }
}
