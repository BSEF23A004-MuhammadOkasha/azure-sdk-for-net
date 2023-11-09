// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> The List Cluster Keys Results appliance. </summary>
    public partial class ApplianceClusterUserKeysResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplianceClusterUserKeysResult"/>. </summary>
        internal ApplianceClusterUserKeysResult()
        {
            ArtifactProfiles = new ChangeTrackingDictionary<string, ApplianceArtifactProfile>();
            Kubeconfigs = new ChangeTrackingList<ApplianceCredentialKubeconfig>();
            SshKeys = new ChangeTrackingDictionary<string, ApplianceSshKey>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplianceClusterUserKeysResult"/>. </summary>
        /// <param name="artifactProfiles"> Map of artifacts that contains a list of ArtifactProfile used to upload artifacts such as logs. </param>
        /// <param name="kubeconfigs"> The list of appliance kubeconfigs. </param>
        /// <param name="sshKeys"> Map of Customer User Public, Private SSH Keys and Certificate when available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplianceClusterUserKeysResult(IReadOnlyDictionary<string, ApplianceArtifactProfile> artifactProfiles, IReadOnlyList<ApplianceCredentialKubeconfig> kubeconfigs, IReadOnlyDictionary<string, ApplianceSshKey> sshKeys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ArtifactProfiles = artifactProfiles;
            Kubeconfigs = kubeconfigs;
            SshKeys = sshKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Map of artifacts that contains a list of ArtifactProfile used to upload artifacts such as logs. </summary>
        public IReadOnlyDictionary<string, ApplianceArtifactProfile> ArtifactProfiles { get; }
        /// <summary> The list of appliance kubeconfigs. </summary>
        public IReadOnlyList<ApplianceCredentialKubeconfig> Kubeconfigs { get; }
        /// <summary> Map of Customer User Public, Private SSH Keys and Certificate when available. </summary>
        public IReadOnlyDictionary<string, ApplianceSshKey> SshKeys { get; }
    }
}
