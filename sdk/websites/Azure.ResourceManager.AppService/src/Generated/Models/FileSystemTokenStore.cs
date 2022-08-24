// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The configuration settings of the storage of the tokens if a file system is used.
    /// Serialized Name: FileSystemTokenStore
    /// </summary>
    internal partial class FileSystemTokenStore
    {
        /// <summary> Initializes a new instance of FileSystemTokenStore. </summary>
        public FileSystemTokenStore()
        {
        }

        /// <summary> Initializes a new instance of FileSystemTokenStore. </summary>
        /// <param name="directory">
        /// The directory in which the tokens will be stored.
        /// Serialized Name: FileSystemTokenStore.directory
        /// </param>
        internal FileSystemTokenStore(string directory)
        {
            Directory = directory;
        }

        /// <summary>
        /// The directory in which the tokens will be stored.
        /// Serialized Name: FileSystemTokenStore.directory
        /// </summary>
        public string Directory { get; set; }
    }
}
