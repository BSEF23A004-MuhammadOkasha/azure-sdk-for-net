// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Common configuration settings for both Azure PowerShell and Azure CLI scripts. </summary>
    public partial class ScriptConfigurationBase
    {
        /// <summary> Initializes a new instance of ScriptConfigurationBase. </summary>
        /// <param name="retentionInterval"> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P7D means one week). </param>
        public ScriptConfigurationBase(TimeSpan retentionInterval)
        {
            SupportingScriptUris = new ChangeTrackingList<string>();
            EnvironmentVariables = new ChangeTrackingList<EnvironmentVariable>();
            RetentionInterval = retentionInterval;
        }

        /// <summary> Initializes a new instance of ScriptConfigurationBase. </summary>
        /// <param name="primaryScriptUri"> Uri for the script. This is the entry point for the external script. </param>
        /// <param name="supportingScriptUris"> Supporting files for the external script. </param>
        /// <param name="scriptContent"> Script body. </param>
        /// <param name="arguments"> Command line arguments to pass to the script. Arguments are separated by spaces. ex: -Name blue* -Location &apos;West US 2&apos;. </param>
        /// <param name="environmentVariables"> The environment variables to pass over to the script. </param>
        /// <param name="forceUpdateTag"> Gets or sets how the deployment script should be forced to execute even if the script resource has not changed. Can be current time stamp or a GUID. </param>
        /// <param name="retentionInterval"> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P7D means one week). </param>
        /// <param name="timeout"> Maximum allowed script execution time specified in ISO 8601 format. Default value is PT1H. </param>
        internal ScriptConfigurationBase(string primaryScriptUri, IList<string> supportingScriptUris, string scriptContent, string arguments, IList<EnvironmentVariable> environmentVariables, string forceUpdateTag, TimeSpan retentionInterval, TimeSpan? timeout)
        {
            PrimaryScriptUri = primaryScriptUri;
            SupportingScriptUris = supportingScriptUris;
            ScriptContent = scriptContent;
            Arguments = arguments;
            EnvironmentVariables = environmentVariables;
            ForceUpdateTag = forceUpdateTag;
            RetentionInterval = retentionInterval;
            Timeout = timeout;
        }

        /// <summary> Uri for the script. This is the entry point for the external script. </summary>
        public string PrimaryScriptUri { get; set; }
        /// <summary> Supporting files for the external script. </summary>
        public IList<string> SupportingScriptUris { get; }
        /// <summary> Script body. </summary>
        public string ScriptContent { get; set; }
        /// <summary> Command line arguments to pass to the script. Arguments are separated by spaces. ex: -Name blue* -Location &apos;West US 2&apos;. </summary>
        public string Arguments { get; set; }
        /// <summary> The environment variables to pass over to the script. </summary>
        public IList<EnvironmentVariable> EnvironmentVariables { get; }
        /// <summary> Gets or sets how the deployment script should be forced to execute even if the script resource has not changed. Can be current time stamp or a GUID. </summary>
        public string ForceUpdateTag { get; set; }
        /// <summary> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P7D means one week). </summary>
        public TimeSpan RetentionInterval { get; set; }
        /// <summary> Maximum allowed script execution time specified in ISO 8601 format. Default value is PT1H. </summary>
        public TimeSpan? Timeout { get; set; }
    }
}
