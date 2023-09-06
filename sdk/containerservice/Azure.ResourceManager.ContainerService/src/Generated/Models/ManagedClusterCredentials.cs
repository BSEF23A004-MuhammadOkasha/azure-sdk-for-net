// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The list credential result response. </summary>
    public partial class ManagedClusterCredentials
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterCredentials"/>. </summary>
        internal ManagedClusterCredentials()
        {
            Kubeconfigs = new ChangeTrackingList<ManagedClusterCredential>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterCredentials"/>. </summary>
        /// <param name="kubeconfigs"> Base64-encoded Kubernetes configuration file. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterCredentials(IReadOnlyList<ManagedClusterCredential> kubeconfigs, Dictionary<string, BinaryData> rawData)
        {
            Kubeconfigs = kubeconfigs;
            _rawData = rawData;
        }

        /// <summary> Base64-encoded Kubernetes configuration file. </summary>
        public IReadOnlyList<ManagedClusterCredential> Kubeconfigs { get; }
    }
}
