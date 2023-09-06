// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> List of manifest attributes. </summary>
    internal partial class ManifestAttributesManifest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManifestAttributesManifest"/>. </summary>
        internal ManifestAttributesManifest()
        {
            References = new ChangeTrackingList<ArtifactManifestPlatform>();
        }

        /// <summary> Initializes a new instance of <see cref="ManifestAttributesManifest"/>. </summary>
        /// <param name="references"> List of manifest attributes details. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManifestAttributesManifest(IReadOnlyList<ArtifactManifestPlatform> references, Dictionary<string, BinaryData> rawData)
        {
            References = references;
            _rawData = rawData;
        }

        /// <summary> List of manifest attributes details. </summary>
        public IReadOnlyList<ArtifactManifestPlatform> References { get; }
    }
}
