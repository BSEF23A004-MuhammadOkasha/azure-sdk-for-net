// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The generic backup fabric class.
    /// </summary>
    public partial class GenericBackupFabric
    {
        /// <summary>
        /// Initializes a new instance of the GenericBackupFabric class.
        /// </summary>
        public GenericBackupFabric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenericBackupFabric class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the backup
        /// fabric.</param>
        /// <param name="version">Version of the backup fabric.</param>
        public GenericBackupFabric(string friendlyName = default(string), string version = default(string))
        {
            FriendlyName = friendlyName;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name of the backup fabric.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets version of the backup fabric.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
