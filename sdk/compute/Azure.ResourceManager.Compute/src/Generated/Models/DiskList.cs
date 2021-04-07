// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Disks operation response. </summary>
    internal partial class DiskList
    {
        /// <summary> Initializes a new instance of DiskList. </summary>
        /// <param name="value"> A list of disks. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DiskList(IEnumerable<Disk> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DiskList. </summary>
        /// <param name="value"> A list of disks. </param>
        /// <param name="nextLink"> The uri to fetch the next page of disks. Call ListNext() with this to fetch the next page of disks. </param>
        internal DiskList(IReadOnlyList<Disk> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of disks. </summary>
        public IReadOnlyList<Disk> Value { get; }
        /// <summary> The uri to fetch the next page of disks. Call ListNext() with this to fetch the next page of disks. </summary>
        public string NextLink { get; }
    }
}
