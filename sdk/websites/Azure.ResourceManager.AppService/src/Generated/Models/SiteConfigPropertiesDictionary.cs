// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Site config properties dictionary.
    /// Serialized Name: SiteConfigPropertiesDictionary
    /// </summary>
    public partial class SiteConfigPropertiesDictionary
    {
        /// <summary> Initializes a new instance of SiteConfigPropertiesDictionary. </summary>
        internal SiteConfigPropertiesDictionary()
        {
        }

        /// <summary> Initializes a new instance of SiteConfigPropertiesDictionary. </summary>
        /// <param name="use32BitWorkerProcess">
        /// &lt;code&gt;true&lt;/code&gt; if use32BitWorkerProcess should be set to true for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: SiteConfigPropertiesDictionary.use32BitWorkerProcess
        /// </param>
        /// <param name="linuxFxVersion">
        /// LinuxFxVersion configuration setting.
        /// Serialized Name: SiteConfigPropertiesDictionary.linuxFxVersion
        /// </param>
        /// <param name="javaVersion">
        /// JavaVersion configuration setting.
        /// Serialized Name: SiteConfigPropertiesDictionary.javaVersion
        /// </param>
        /// <param name="powerShellVersion">
        /// PowerShellVersion configuration setting.
        /// Serialized Name: SiteConfigPropertiesDictionary.powerShellVersion
        /// </param>
        internal SiteConfigPropertiesDictionary(bool? use32BitWorkerProcess, string linuxFxVersion, string javaVersion, string powerShellVersion)
        {
            Use32BitWorkerProcess = use32BitWorkerProcess;
            LinuxFxVersion = linuxFxVersion;
            JavaVersion = javaVersion;
            PowerShellVersion = powerShellVersion;
        }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if use32BitWorkerProcess should be set to true for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: SiteConfigPropertiesDictionary.use32BitWorkerProcess
        /// </summary>
        public bool? Use32BitWorkerProcess { get; }
        /// <summary>
        /// LinuxFxVersion configuration setting.
        /// Serialized Name: SiteConfigPropertiesDictionary.linuxFxVersion
        /// </summary>
        public string LinuxFxVersion { get; }
        /// <summary>
        /// JavaVersion configuration setting.
        /// Serialized Name: SiteConfigPropertiesDictionary.javaVersion
        /// </summary>
        public string JavaVersion { get; }
        /// <summary>
        /// PowerShellVersion configuration setting.
        /// Serialized Name: SiteConfigPropertiesDictionary.powerShellVersion
        /// </summary>
        public string PowerShellVersion { get; }
    }
}
