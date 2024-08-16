// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    /// <summary> The updatable properties of the Pool. </summary>
    public partial class PoolUpdateProperties
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

        /// <summary> Initializes a new instance of <see cref="PoolUpdateProperties"/>. </summary>
        public PoolUpdateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PoolUpdateProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the current operation. </param>
        /// <param name="maximumConcurrency"> Defines how many resources can there be created at any given time. </param>
        /// <param name="organizationProfile">
        /// Defines the organization in which the pool will be used.
        /// Please note <see cref="DevOpsOrganizationProfile"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DevOpsAzureOrganizationProfile"/> and <see cref="DevOpsGitHubOrganizationProfile"/>.
        /// </param>
        /// <param name="agentProfile">
        /// Defines how the machine will be handled once it executed a job.
        /// Please note <see cref="DevOpsPoolAgentProfile"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DevOpsStateful"/> and <see cref="DevOpsStatelessAgentProfile"/>.
        /// </param>
        /// <param name="fabricProfile">
        /// Defines the type of fabric the agent will run on.
        /// Please note <see cref="DevOpsFabricProfile"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DevOpsVmssFabricProfile"/>.
        /// </param>
        /// <param name="devCenterProjectResourceId"> The resource id of the DevCenter Project the pool belongs to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PoolUpdateProperties(DevOpsInfrastructureProvisioningState? provisioningState, int? maximumConcurrency, DevOpsOrganizationProfile organizationProfile, DevOpsPoolAgentProfile agentProfile, DevOpsFabricProfile fabricProfile, string devCenterProjectResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            MaximumConcurrency = maximumConcurrency;
            OrganizationProfile = organizationProfile;
            AgentProfile = agentProfile;
            FabricProfile = fabricProfile;
            DevCenterProjectResourceId = devCenterProjectResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of the current operation. </summary>
        public DevOpsInfrastructureProvisioningState? ProvisioningState { get; set; }
        /// <summary> Defines how many resources can there be created at any given time. </summary>
        public int? MaximumConcurrency { get; set; }
        /// <summary>
        /// Defines the organization in which the pool will be used.
        /// Please note <see cref="DevOpsOrganizationProfile"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DevOpsAzureOrganizationProfile"/> and <see cref="DevOpsGitHubOrganizationProfile"/>.
        /// </summary>
        public DevOpsOrganizationProfile OrganizationProfile { get; set; }
        /// <summary>
        /// Defines how the machine will be handled once it executed a job.
        /// Please note <see cref="DevOpsPoolAgentProfile"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DevOpsStateful"/> and <see cref="DevOpsStatelessAgentProfile"/>.
        /// </summary>
        public DevOpsPoolAgentProfile AgentProfile { get; set; }
        /// <summary>
        /// Defines the type of fabric the agent will run on.
        /// Please note <see cref="DevOpsFabricProfile"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DevOpsVmssFabricProfile"/>.
        /// </summary>
        public DevOpsFabricProfile FabricProfile { get; set; }
        /// <summary> The resource id of the DevCenter Project the pool belongs to. </summary>
        public string DevCenterProjectResourceId { get; set; }
    }
}
