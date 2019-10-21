// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// App resource properties payload
    /// </summary>
    public partial class AppResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the AppResourceProperties class.
        /// </summary>
        public AppResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppResourceProperties class.
        /// </summary>
        /// <param name="publicProperty">Indicates whether the App exposes
        /// public endpoint</param>
        /// <param name="url">URL of the App</param>
        /// <param name="provisioningState">Provisioning state of the App.
        /// Possible values include: 'Succeeded', 'Failed'</param>
        /// <param name="activeDeploymentName">Name of the active deployment of
        /// the App</param>
        /// <param name="createdTime">Date time when the resource is
        /// created</param>
        /// <param name="temporaryDisk">Temporary disk settings</param>
        /// <param name="persistentDisk">Persistent disk settings</param>
        public AppResourceProperties(bool? publicProperty = default(bool?), string url = default(string), string provisioningState = default(string), string activeDeploymentName = default(string), System.DateTime? createdTime = default(System.DateTime?), TemporaryDisk temporaryDisk = default(TemporaryDisk), PersistentDisk persistentDisk = default(PersistentDisk))
        {
            PublicProperty = publicProperty;
            Url = url;
            ProvisioningState = provisioningState;
            ActiveDeploymentName = activeDeploymentName;
            CreatedTime = createdTime;
            TemporaryDisk = temporaryDisk;
            PersistentDisk = persistentDisk;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether the App exposes public endpoint
        /// </summary>
        [JsonProperty(PropertyName = "public")]
        public bool? PublicProperty { get; set; }

        /// <summary>
        /// Gets URL of the App
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

        /// <summary>
        /// Gets provisioning state of the App. Possible values include:
        /// 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets name of the active deployment of the App
        /// </summary>
        [JsonProperty(PropertyName = "activeDeploymentName")]
        public string ActiveDeploymentName { get; set; }

        /// <summary>
        /// Gets date time when the resource is created
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets or sets temporary disk settings
        /// </summary>
        [JsonProperty(PropertyName = "temporaryDisk")]
        public TemporaryDisk TemporaryDisk { get; set; }

        /// <summary>
        /// Gets or sets persistent disk settings
        /// </summary>
        [JsonProperty(PropertyName = "persistentDisk")]
        public PersistentDisk PersistentDisk { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TemporaryDisk != null)
            {
                TemporaryDisk.Validate();
            }
            if (PersistentDisk != null)
            {
                PersistentDisk.Validate();
            }
        }
    }
}
