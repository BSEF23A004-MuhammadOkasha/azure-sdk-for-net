// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App container definition. </summary>
    public partial class ContainerAppContainer : ContainerAppBaseContainer
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppContainer"/>. </summary>
        public ContainerAppContainer()
        {
            Probes = new ChangeTrackingList<ContainerAppProbe>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppContainer"/>. </summary>
        /// <param name="image"> Container image tag. </param>
        /// <param name="name"> Custom container name. </param>
        /// <param name="command"> Container start command. </param>
        /// <param name="args"> Container start command arguments. </param>
        /// <param name="env"> Container environment variables. </param>
        /// <param name="resources"> Container resource requirements. </param>
        /// <param name="volumeMounts"> Container volume mounts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="probes"> List of probes for the container. </param>
        internal ContainerAppContainer(string image, string name, IList<string> command, IList<string> args, IList<ContainerAppEnvironmentVariable> env, AppContainerResources resources, IList<ContainerAppVolumeMount> volumeMounts, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<ContainerAppProbe> probes) : base(image, name, command, args, env, resources, volumeMounts, serializedAdditionalRawData)
        {
            Probes = probes;
        }

        /// <summary> List of probes for the container. </summary>
        public IList<ContainerAppProbe> Probes { get; }
    }
}
