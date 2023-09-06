// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Volume mount for the Container App. </summary>
    public partial class ContainerAppVolumeMount
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppVolumeMount"/>. </summary>
        public ContainerAppVolumeMount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppVolumeMount"/>. </summary>
        /// <param name="volumeName"> This must match the Name of a Volume. </param>
        /// <param name="mountPath"> Path within the container at which the volume should be mounted.Must not contain ':'. </param>
        /// <param name="subPath"> Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppVolumeMount(string volumeName, string mountPath, string subPath, Dictionary<string, BinaryData> rawData)
        {
            VolumeName = volumeName;
            MountPath = mountPath;
            SubPath = subPath;
            _rawData = rawData;
        }

        /// <summary> This must match the Name of a Volume. </summary>
        public string VolumeName { get; set; }
        /// <summary> Path within the container at which the volume should be mounted.Must not contain ':'. </summary>
        public string MountPath { get; set; }
        /// <summary> Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root). </summary>
        public string SubPath { get; set; }
    }
}
