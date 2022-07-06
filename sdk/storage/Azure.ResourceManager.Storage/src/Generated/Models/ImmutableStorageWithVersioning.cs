// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Object level immutability properties of the container. </summary>
    public partial class ImmutableStorageWithVersioning
    {
        /// <summary> Initializes a new instance of ImmutableStorageWithVersioning. </summary>
        public ImmutableStorageWithVersioning()
        {
        }

        /// <summary> Initializes a new instance of ImmutableStorageWithVersioning. </summary>
        /// <param name="enabled"> This is an immutable property, when set to true it enables object level immutability at the container level. </param>
        /// <param name="timeStamp"> Returns the date and time the object level immutability was enabled. </param>
        /// <param name="migrationState"> This property denotes the container level immutability to object level immutability migration state. </param>
        internal ImmutableStorageWithVersioning(bool? enabled, DateTimeOffset? timeStamp, StorageMigrationState? migrationState)
        {
            Enabled = enabled;
            TimeStamp = timeStamp;
            MigrationState = migrationState;
        }

        /// <summary> This is an immutable property, when set to true it enables object level immutability at the container level. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Returns the date and time the object level immutability was enabled. </summary>
        public DateTimeOffset? TimeStamp { get; }
        /// <summary> This property denotes the container level immutability to object level immutability migration state. </summary>
        public StorageMigrationState? MigrationState { get; }
    }
}
