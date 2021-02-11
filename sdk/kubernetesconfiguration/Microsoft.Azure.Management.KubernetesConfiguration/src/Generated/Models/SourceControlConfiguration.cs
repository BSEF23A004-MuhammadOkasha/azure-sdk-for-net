// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The SourceControl Configuration object returned in Get &amp; Put
    /// response.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SourceControlConfiguration : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SourceControlConfiguration class.
        /// </summary>
        public SourceControlConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceControlConfiguration class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="repositoryUrl">Url of the SourceControl
        /// Repository.</param>
        /// <param name="operatorNamespace">The namespace to which this
        /// operator is installed to. Maximum of 253 lower case alphanumeric
        /// characters, hyphen and period only.</param>
        /// <param name="operatorInstanceName">Instance name of the operator -
        /// identifying the specific configuration.</param>
        /// <param name="operatorType">Type of the operator. Possible values
        /// include: 'Flux'</param>
        /// <param name="operatorParams">Any Parameters for the Operator
        /// instance in string format.</param>
        /// <param name="configurationProtectedSettings">Name-value pairs of
        /// protected configuration settings for the configuration</param>
        /// <param name="operatorScope">Scope at which the operator will be
        /// installed. Possible values include: 'cluster', 'namespace'</param>
        /// <param name="repositoryPublicKey">Public Key associated with this
        /// SourceControl configuration (either generated within the cluster or
        /// provided by the user).</param>
        /// <param name="sshKnownHostsContents">Base64-encoded known_hosts
        /// contents containing public SSH keys required to access private Git
        /// instances</param>
        /// <param name="enableHelmOperator">Option to enable Helm Operator for
        /// this git configuration.</param>
        /// <param name="helmOperatorProperties">Properties for Helm
        /// operator.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource provider. Possible values include: 'Accepted', 'Deleting',
        /// 'Running', 'Succeeded', 'Failed'</param>
        /// <param name="complianceStatus">Compliance Status of the
        /// Configuration</param>
        /// <param name="systemData">Top level metadata
        /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources</param>
        public SourceControlConfiguration(string id = default(string), string name = default(string), string type = default(string), string repositoryUrl = default(string), string operatorNamespace = default(string), string operatorInstanceName = default(string), OperatorType? operatorType = default(OperatorType?), string operatorParams = default(string), IDictionary<string, string> configurationProtectedSettings = default(IDictionary<string, string>), OperatorScopeType? operatorScope = default(OperatorScopeType?), string repositoryPublicKey = default(string), string sshKnownHostsContents = default(string), bool? enableHelmOperator = default(bool?), HelmOperatorProperties helmOperatorProperties = default(HelmOperatorProperties), ProvisioningStateType? provisioningState = default(ProvisioningStateType?), ComplianceStatus complianceStatus = default(ComplianceStatus), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            RepositoryUrl = repositoryUrl;
            OperatorNamespace = operatorNamespace;
            OperatorInstanceName = operatorInstanceName;
            OperatorType = operatorType;
            OperatorParams = operatorParams;
            ConfigurationProtectedSettings = configurationProtectedSettings;
            OperatorScope = operatorScope;
            RepositoryPublicKey = repositoryPublicKey;
            SshKnownHostsContents = sshKnownHostsContents;
            EnableHelmOperator = enableHelmOperator;
            HelmOperatorProperties = helmOperatorProperties;
            ProvisioningState = provisioningState;
            ComplianceStatus = complianceStatus;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets url of the SourceControl Repository.
        /// </summary>
        [JsonProperty(PropertyName = "properties.repositoryUrl")]
        public string RepositoryUrl { get; set; }

        /// <summary>
        /// Gets or sets the namespace to which this operator is installed to.
        /// Maximum of 253 lower case alphanumeric characters, hyphen and
        /// period only.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operatorNamespace")]
        public string OperatorNamespace { get; set; }

        /// <summary>
        /// Gets or sets instance name of the operator - identifying the
        /// specific configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operatorInstanceName")]
        public string OperatorInstanceName { get; set; }

        /// <summary>
        /// Gets or sets type of the operator. Possible values include: 'Flux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.operatorType")]
        public OperatorType? OperatorType { get; set; }

        /// <summary>
        /// Gets or sets any Parameters for the Operator instance in string
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operatorParams")]
        public string OperatorParams { get; set; }

        /// <summary>
        /// Gets or sets name-value pairs of protected configuration settings
        /// for the configuration
        /// </summary>
        [JsonProperty(PropertyName = "properties.configurationProtectedSettings")]
        public IDictionary<string, string> ConfigurationProtectedSettings { get; set; }

        /// <summary>
        /// Gets or sets scope at which the operator will be installed.
        /// Possible values include: 'cluster', 'namespace'
        /// </summary>
        [JsonProperty(PropertyName = "properties.operatorScope")]
        public OperatorScopeType? OperatorScope { get; set; }

        /// <summary>
        /// Gets public Key associated with this SourceControl configuration
        /// (either generated within the cluster or provided by the user).
        /// </summary>
        [JsonProperty(PropertyName = "properties.repositoryPublicKey")]
        public string RepositoryPublicKey { get; private set; }

        /// <summary>
        /// Gets or sets base64-encoded known_hosts contents containing public
        /// SSH keys required to access private Git instances
        /// </summary>
        [JsonProperty(PropertyName = "properties.sshKnownHostsContents")]
        public string SshKnownHostsContents { get; set; }

        /// <summary>
        /// Gets or sets option to enable Helm Operator for this git
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableHelmOperator")]
        public bool? EnableHelmOperator { get; set; }

        /// <summary>
        /// Gets or sets properties for Helm operator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.helmOperatorProperties")]
        public HelmOperatorProperties HelmOperatorProperties { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource provider. Possible
        /// values include: 'Accepted', 'Deleting', 'Running', 'Succeeded',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningStateType? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets compliance Status of the Configuration
        /// </summary>
        [JsonProperty(PropertyName = "properties.complianceStatus")]
        public ComplianceStatus ComplianceStatus { get; private set; }

        /// <summary>
        /// Gets or sets top level metadata
        /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}
