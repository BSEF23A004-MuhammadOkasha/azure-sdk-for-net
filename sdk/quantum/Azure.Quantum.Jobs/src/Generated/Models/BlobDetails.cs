// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> Blob details. </summary>
    public partial class BlobDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlobDetails"/>. </summary>
        /// <param name="containerName"> The container name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public BlobDetails(string containerName)
        {
            Argument.AssertNotNull(containerName, nameof(containerName));

            ContainerName = containerName;
        }

        /// <summary> Initializes a new instance of <see cref="BlobDetails"/>. </summary>
        /// <param name="containerName"> The container name. </param>
        /// <param name="blobName"> The blob name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobDetails(string containerName, string blobName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContainerName = containerName;
            BlobName = blobName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BlobDetails"/> for deserialization. </summary>
        internal BlobDetails()
        {
        }

        /// <summary> The container name. </summary>
        public string ContainerName { get; }
        /// <summary> The blob name. </summary>
        public string BlobName { get; set; }
    }
}
