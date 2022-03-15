// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Reference to an asset via its path in a datastore. </summary>
    internal partial class PartialDataPathAssetReference : PartialAssetReferenceBase
    {
        /// <summary> Initializes a new instance of PartialDataPathAssetReference. </summary>
        public PartialDataPathAssetReference()
        {
            ReferenceType = ReferenceType.DataPath;
        }

        /// <summary> ARM resource ID of the datastore where the asset is located. </summary>
        public string DatastoreId { get; set; }
        /// <summary> The path of the file/directory in the datastore. </summary>
        public string Path { get; set; }
    }
}
