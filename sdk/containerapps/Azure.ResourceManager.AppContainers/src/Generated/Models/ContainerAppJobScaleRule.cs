// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Scaling rule. </summary>
    public partial class ContainerAppJobScaleRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobScaleRule"/>. </summary>
        public ContainerAppJobScaleRule()
        {
            Auth = new ChangeTrackingList<ContainerAppScaleRuleAuth>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobScaleRule"/>. </summary>
        /// <param name="name"> Scale Rule Name. </param>
        /// <param name="jobScaleRuleType">
        /// Type of the scale rule
        /// eg: azure-servicebus, redis etc.
        /// </param>
        /// <param name="metadata"> Metadata properties to describe the scale rule. </param>
        /// <param name="auth"> Authentication secrets for the scale rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppJobScaleRule(string name, string jobScaleRuleType, BinaryData metadata, IList<ContainerAppScaleRuleAuth> auth, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            JobScaleRuleType = jobScaleRuleType;
            Metadata = metadata;
            Auth = auth;
            _rawData = rawData;
        }

        /// <summary> Scale Rule Name. </summary>
        public string Name { get; set; }
        /// <summary>
        /// Type of the scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        public string JobScaleRuleType { get; set; }
        /// <summary>
        /// Metadata properties to describe the scale rule.
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
        public BinaryData Metadata { get; set; }
        /// <summary> Authentication secrets for the scale rule. </summary>
        public IList<ContainerAppScaleRuleAuth> Auth { get; }
    }
}
