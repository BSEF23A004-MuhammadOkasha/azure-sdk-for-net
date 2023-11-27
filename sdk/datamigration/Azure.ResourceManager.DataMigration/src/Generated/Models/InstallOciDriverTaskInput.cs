// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the service task to install an OCI driver. </summary>
    internal partial class InstallOciDriverTaskInput
    {
        /// <summary> Initializes a new instance of <see cref="InstallOciDriverTaskInput"/>. </summary>
        public InstallOciDriverTaskInput()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InstallOciDriverTaskInput"/>. </summary>
        /// <param name="driverPackageName"> Name of the uploaded driver package to install. </param>
        internal InstallOciDriverTaskInput(string driverPackageName)
        {
            DriverPackageName = driverPackageName;
        }

        /// <summary> Name of the uploaded driver package to install. </summary>
        public string DriverPackageName { get; set; }
    }
}
