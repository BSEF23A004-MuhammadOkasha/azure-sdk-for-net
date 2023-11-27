// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact. </summary>
    public partial class EncryptionImages
    {
        /// <summary> Initializes a new instance of <see cref="EncryptionImages"/>. </summary>
        public EncryptionImages()
        {
            DataDiskImages = new ChangeTrackingList<DataDiskImageEncryption>();
        }

        /// <summary> Initializes a new instance of <see cref="EncryptionImages"/>. </summary>
        /// <param name="osDiskImage"> Contains encryption settings for an OS disk image. </param>
        /// <param name="dataDiskImages"> A list of encryption specifications for data disk images. </param>
        internal EncryptionImages(OSDiskImageEncryption osDiskImage, IList<DataDiskImageEncryption> dataDiskImages)
        {
            OSDiskImage = osDiskImage;
            DataDiskImages = dataDiskImages;
        }

        /// <summary> Contains encryption settings for an OS disk image. </summary>
        public OSDiskImageEncryption OSDiskImage { get; set; }
        /// <summary> A list of encryption specifications for data disk images. </summary>
        public IList<DataDiskImageEncryption> DataDiskImages { get; }
    }
}
