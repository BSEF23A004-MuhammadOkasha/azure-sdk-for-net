// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The configuration for container-enabled pools. </summary>
    public partial class BatchVmContainerConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="BatchVmContainerConfiguration"/>. </summary>
        /// <param name="containerType"> The container technology to be used. </param>
        public BatchVmContainerConfiguration(BatchVmContainerType containerType)
        {
            ContainerType = containerType;
            ContainerImageNames = new ChangeTrackingList<string>();
            ContainerRegistries = new ChangeTrackingList<BatchVmContainerRegistry>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchVmContainerConfiguration"/>. </summary>
        /// <param name="containerType"> The container technology to be used. </param>
        /// <param name="containerImageNames"> This is the full image reference, as would be specified to "docker pull". An image will be sourced from the default Docker registry unless the image is fully qualified with an alternative registry. </param>
        /// <param name="containerRegistries"> If any images must be downloaded from a private registry which requires credentials, then those credentials must be provided here. </param>
        internal BatchVmContainerConfiguration(BatchVmContainerType containerType, IList<string> containerImageNames, IList<BatchVmContainerRegistry> containerRegistries)
        {
            ContainerType = containerType;
            ContainerImageNames = containerImageNames;
            ContainerRegistries = containerRegistries;
        }
        /// <summary> This is the full image reference, as would be specified to "docker pull". An image will be sourced from the default Docker registry unless the image is fully qualified with an alternative registry. </summary>
        public IList<string> ContainerImageNames { get; }
        /// <summary> If any images must be downloaded from a private registry which requires credentials, then those credentials must be provided here. </summary>
        public IList<BatchVmContainerRegistry> ContainerRegistries { get; }
    }
}
