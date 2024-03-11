// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Unknown version of OneLakeArtifact. </summary>
    internal partial class UnknownOneLakeArtifact : OneLakeArtifact
    {
        /// <summary> Initializes a new instance of <see cref="UnknownOneLakeArtifact"/>. </summary>
        /// <param name="artifactName"> [Required] OneLake artifact name. </param>
        /// <param name="artifactType"> [Required] OneLake artifact type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownOneLakeArtifact(string artifactName, OneLakeArtifactType artifactType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(artifactName, artifactType, serializedAdditionalRawData)
        {
            ArtifactType = artifactType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownOneLakeArtifact"/> for deserialization. </summary>
        internal UnknownOneLakeArtifact()
        {
        }
    }
}
