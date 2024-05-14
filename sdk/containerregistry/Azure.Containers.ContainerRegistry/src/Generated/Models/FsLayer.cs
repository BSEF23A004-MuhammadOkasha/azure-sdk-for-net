// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Image layer information. </summary>
    internal partial class FsLayer
    {
        /// <summary> Initializes a new instance of <see cref="FsLayer"/>. </summary>
        internal FsLayer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FsLayer"/>. </summary>
        /// <param name="blobSum"> SHA of an image layer. </param>
        internal FsLayer(string blobSum)
        {
            BlobSum = blobSum;
        }

        /// <summary> SHA of an image layer. </summary>
        public string BlobSum { get; }
    }
}
