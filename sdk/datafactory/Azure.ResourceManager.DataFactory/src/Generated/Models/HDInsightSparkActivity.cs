// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> HDInsight Spark activity. </summary>
    public partial class HDInsightSparkActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of HDInsightSparkActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="rootPath"> The root path in &apos;sparkJobLinkedService&apos; for all the job’s files. Type: string (or Expression with resultType string). </param>
        /// <param name="entryFilePath"> The relative path to the root folder of the code/package to be executed. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="rootPath"/> or <paramref name="entryFilePath"/> is null. </exception>
        public HDInsightSparkActivity(string name, BinaryData rootPath, BinaryData entryFilePath) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (rootPath == null)
            {
                throw new ArgumentNullException(nameof(rootPath));
            }
            if (entryFilePath == null)
            {
                throw new ArgumentNullException(nameof(entryFilePath));
            }

            RootPath = rootPath;
            EntryFilePath = entryFilePath;
            Arguments = new ChangeTrackingList<BinaryData>();
            SparkConfig = new ChangeTrackingDictionary<string, BinaryData>();
            ActivityType = "HDInsightSpark";
        }

        /// <summary> Initializes a new instance of HDInsightSparkActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="rootPath"> The root path in &apos;sparkJobLinkedService&apos; for all the job’s files. Type: string (or Expression with resultType string). </param>
        /// <param name="entryFilePath"> The relative path to the root folder of the code/package to be executed. Type: string (or Expression with resultType string). </param>
        /// <param name="arguments"> The user-specified arguments to HDInsightSparkActivity. </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="sparkJobLinkedService"> The storage linked service for uploading the entry file and dependencies, and for receiving logs. </param>
        /// <param name="className"> The application&apos;s Java/Spark main class. </param>
        /// <param name="proxyUser"> The user to impersonate that will execute the job. Type: string (or Expression with resultType string). </param>
        /// <param name="sparkConfig"> Spark configuration property. </param>
        internal HDInsightSparkActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, BinaryData rootPath, BinaryData entryFilePath, IList<BinaryData> arguments, HDInsightActivityDebugInfoOptionSetting? getDebugInfo, FactoryLinkedServiceReference sparkJobLinkedService, string className, BinaryData proxyUser, IDictionary<string, BinaryData> sparkConfig) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            RootPath = rootPath;
            EntryFilePath = entryFilePath;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            SparkJobLinkedService = sparkJobLinkedService;
            ClassName = className;
            ProxyUser = proxyUser;
            SparkConfig = sparkConfig;
            ActivityType = activityType ?? "HDInsightSpark";
        }

        /// <summary>
        /// The root path in &apos;sparkJobLinkedService&apos; for all the job’s files. Type: string (or Expression with resultType string).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData RootPath { get; set; }
        /// <summary>
        /// The relative path to the root folder of the code/package to be executed. Type: string (or Expression with resultType string).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData EntryFilePath { get; set; }
        /// <summary> The user-specified arguments to HDInsightSparkActivity. </summary>
        public IList<BinaryData> Arguments { get; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOptionSetting? GetDebugInfo { get; set; }
        /// <summary> The storage linked service for uploading the entry file and dependencies, and for receiving logs. </summary>
        public FactoryLinkedServiceReference SparkJobLinkedService { get; set; }
        /// <summary> The application&apos;s Java/Spark main class. </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// The user to impersonate that will execute the job. Type: string (or Expression with resultType string).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData ProxyUser { get; set; }
        /// <summary> Spark configuration property. </summary>
        public IDictionary<string, BinaryData> SparkConfig { get; }
    }
}
