// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> See [disable AAD Pod Identity for a specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/) for more details. </summary>
    public partial class ManagedClusterPodIdentityException
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPodIdentityException"/>. </summary>
        /// <param name="name"> The name of the pod identity exception. </param>
        /// <param name="namespace"> The namespace of the pod identity exception. </param>
        /// <param name="podLabels"> The pod labels to match. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="namespace"/> or <paramref name="podLabels"/> is null. </exception>
        public ManagedClusterPodIdentityException(string name, string @namespace, IDictionary<string, string> podLabels)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(@namespace, nameof(@namespace));
            Argument.AssertNotNull(podLabels, nameof(podLabels));

            Name = name;
            Namespace = @namespace;
            PodLabels = podLabels;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPodIdentityException"/>. </summary>
        /// <param name="name"> The name of the pod identity exception. </param>
        /// <param name="namespace"> The namespace of the pod identity exception. </param>
        /// <param name="podLabels"> The pod labels to match. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterPodIdentityException(string name, string @namespace, IDictionary<string, string> podLabels, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Namespace = @namespace;
            PodLabels = podLabels;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPodIdentityException"/> for deserialization. </summary>
        internal ManagedClusterPodIdentityException()
        {
        }

        /// <summary> The name of the pod identity exception. </summary>
        public string Name { get; set; }
        /// <summary> The namespace of the pod identity exception. </summary>
        public string Namespace { get; set; }
        /// <summary> The pod labels to match. </summary>
        public IDictionary<string, string> PodLabels { get; }
    }
}
