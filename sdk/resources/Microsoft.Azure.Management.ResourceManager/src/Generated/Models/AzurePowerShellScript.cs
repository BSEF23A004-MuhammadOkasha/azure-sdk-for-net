// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Object model for the Azure PowerShell script.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzurePowerShell")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzurePowerShellScript : DeploymentScript
    {
        /// <summary>
        /// Initializes a new instance of the AzurePowerShellScript class.
        /// </summary>
        public AzurePowerShellScript()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzurePowerShellScript class.
        /// </summary>
        /// <param name="identity">Managed identity to be used for this
        /// deployment script. Currently, only user-assigned MSI is
        /// supported.</param>
        /// <param name="location">The location of the ACI and the storage
        /// account for the deployment script.</param>
        /// <param name="retentionInterval">Interval for which the service
        /// retains the script resource after it reaches a terminal state.
        /// Resource will be deleted when this duration expires. Duration is
        /// based on ISO 8601 pattern (for example P7D means one week).</param>
        /// <param name="azPowerShellVersion">Azure PowerShell module version
        /// to be used.</param>
        /// <param name="id">String Id used to locate any resource on
        /// Azure.</param>
        /// <param name="name">Name of this resource.</param>
        /// <param name="type">Type of this resource.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="systemData">The system metadata related to this
        /// resource.</param>
        /// <param name="containerSettings">Container settings.</param>
        /// <param name="storageAccountSettings">Storage Account
        /// settings.</param>
        /// <param name="cleanupPreference">The clean up preference when the
        /// script execution gets in a terminal state. Default setting is
        /// 'Always'. Possible values include: 'Always', 'OnSuccess',
        /// 'OnExpiration'</param>
        /// <param name="provisioningState">State of the script execution. This
        /// only appears in the response. Possible values include: 'Creating',
        /// 'ProvisioningResources', 'Running', 'Succeeded', 'Failed',
        /// 'Canceled'</param>
        /// <param name="status">Contains the results of script
        /// execution.</param>
        /// <param name="outputs">List of script outputs.</param>
        /// <param name="primaryScriptUri">Uri for the script. This is the
        /// entry point for the external script.</param>
        /// <param name="supportingScriptUris">Supporting files for the
        /// external script.</param>
        /// <param name="scriptContent">Script body.</param>
        /// <param name="arguments">Command line arguments to pass to the
        /// script. Arguments are separated by spaces. ex: -Name blue*
        /// -Location 'West US 2' </param>
        /// <param name="environmentVariables">The environment variables to
        /// pass over to the script.</param>
        /// <param name="forceUpdateTag">Gets or sets how the deployment script
        /// should be forced to execute even if the script resource has not
        /// changed. Can be current time stamp or a GUID.</param>
        /// <param name="timeout">Maximum allowed script execution time
        /// specified in ISO 8601 format. Default value is PT1H</param>
        public AzurePowerShellScript(ManagedServiceIdentity identity, string location, System.TimeSpan retentionInterval, string azPowerShellVersion, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), ContainerConfiguration containerSettings = default(ContainerConfiguration), StorageAccountConfiguration storageAccountSettings = default(StorageAccountConfiguration), string cleanupPreference = default(string), string provisioningState = default(string), ScriptStatus status = default(ScriptStatus), IDictionary<string, object> outputs = default(IDictionary<string, object>), string primaryScriptUri = default(string), IList<string> supportingScriptUris = default(IList<string>), string scriptContent = default(string), string arguments = default(string), IList<EnvironmentVariable> environmentVariables = default(IList<EnvironmentVariable>), string forceUpdateTag = default(string), System.TimeSpan? timeout = default(System.TimeSpan?))
            : base(identity, location, id, name, type, tags, systemData)
        {
            ContainerSettings = containerSettings;
            StorageAccountSettings = storageAccountSettings;
            CleanupPreference = cleanupPreference;
            ProvisioningState = provisioningState;
            Status = status;
            Outputs = outputs;
            PrimaryScriptUri = primaryScriptUri;
            SupportingScriptUris = supportingScriptUris;
            ScriptContent = scriptContent;
            Arguments = arguments;
            EnvironmentVariables = environmentVariables;
            ForceUpdateTag = forceUpdateTag;
            RetentionInterval = retentionInterval;
            Timeout = timeout;
            AzPowerShellVersion = azPowerShellVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets container settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containerSettings")]
        public ContainerConfiguration ContainerSettings { get; set; }

        /// <summary>
        /// Gets or sets storage Account settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountSettings")]
        public StorageAccountConfiguration StorageAccountSettings { get; set; }

        /// <summary>
        /// Gets or sets the clean up preference when the script execution gets
        /// in a terminal state. Default setting is 'Always'. Possible values
        /// include: 'Always', 'OnSuccess', 'OnExpiration'
        /// </summary>
        [JsonProperty(PropertyName = "properties.cleanupPreference")]
        public string CleanupPreference { get; set; }

        /// <summary>
        /// Gets state of the script execution. This only appears in the
        /// response. Possible values include: 'Creating',
        /// 'ProvisioningResources', 'Running', 'Succeeded', 'Failed',
        /// 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets contains the results of script execution.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public ScriptStatus Status { get; private set; }

        /// <summary>
        /// Gets list of script outputs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputs")]
        public IDictionary<string, object> Outputs { get; private set; }

        /// <summary>
        /// Gets or sets uri for the script. This is the entry point for the
        /// external script.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryScriptUri")]
        public string PrimaryScriptUri { get; set; }

        /// <summary>
        /// Gets or sets supporting files for the external script.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportingScriptUris")]
        public IList<string> SupportingScriptUris { get; set; }

        /// <summary>
        /// Gets or sets script body.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scriptContent")]
        public string ScriptContent { get; set; }

        /// <summary>
        /// Gets or sets command line arguments to pass to the script.
        /// Arguments are separated by spaces. ex: -Name blue* -Location 'West
        /// US 2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.arguments")]
        public string Arguments { get; set; }

        /// <summary>
        /// Gets or sets the environment variables to pass over to the script.
        /// </summary>
        [JsonProperty(PropertyName = "properties.environmentVariables")]
        public IList<EnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// Gets or sets how the deployment script should be forced to execute
        /// even if the script resource has not changed. Can be current time
        /// stamp or a GUID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.forceUpdateTag")]
        public string ForceUpdateTag { get; set; }

        /// <summary>
        /// Gets or sets interval for which the service retains the script
        /// resource after it reaches a terminal state. Resource will be
        /// deleted when this duration expires. Duration is based on ISO 8601
        /// pattern (for example P7D means one week).
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionInterval")]
        public System.TimeSpan RetentionInterval { get; set; }

        /// <summary>
        /// Gets or sets maximum allowed script execution time specified in ISO
        /// 8601 format. Default value is PT1H
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeout")]
        public System.TimeSpan? Timeout { get; set; }

        /// <summary>
        /// Gets or sets azure PowerShell module version to be used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azPowerShellVersion")]
        public string AzPowerShellVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (AzPowerShellVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AzPowerShellVersion");
            }
            if (ContainerSettings != null)
            {
                ContainerSettings.Validate();
            }
            if (ScriptContent != null)
            {
                if (ScriptContent.Length > 32000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ScriptContent", 32000);
                }
            }
            if (EnvironmentVariables != null)
            {
                foreach (var element in EnvironmentVariables)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
