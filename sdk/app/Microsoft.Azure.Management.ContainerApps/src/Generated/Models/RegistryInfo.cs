// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Container App registry information.
    /// </summary>
    public partial class RegistryInfo
    {
        /// <summary>
        /// Initializes a new instance of the RegistryInfo class.
        /// </summary>
        public RegistryInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegistryInfo class.
        /// </summary>
        /// <param name="registryUrl">registry server Url.</param>
        /// <param name="registryUserName">registry username.</param>
        /// <param name="registryPassword">registry secret.</param>
        public RegistryInfo(string registryUrl = default(string), string registryUserName = default(string), string registryPassword = default(string))
        {
            RegistryUrl = registryUrl;
            RegistryUserName = registryUserName;
            RegistryPassword = registryPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets registry server Url.
        /// </summary>
        [JsonProperty(PropertyName = "registryUrl")]
        public string RegistryUrl { get; set; }

        /// <summary>
        /// Gets or sets registry username.
        /// </summary>
        [JsonProperty(PropertyName = "registryUserName")]
        public string RegistryUserName { get; set; }

        /// <summary>
        /// Gets or sets registry secret.
        /// </summary>
        [JsonProperty(PropertyName = "registryPassword")]
        public string RegistryPassword { get; set; }

    }
}
