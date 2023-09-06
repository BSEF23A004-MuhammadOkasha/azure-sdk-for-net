// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List disk access operation response. </summary>
    internal partial class DiskAccessList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DiskAccessList"/>. </summary>
        /// <param name="value"> A list of disk access resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DiskAccessList(IEnumerable<DiskAccessData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DiskAccessList"/>. </summary>
        /// <param name="value"> A list of disk access resources. </param>
        /// <param name="nextLink"> The uri to fetch the next page of disk access resources. Call ListNext() with this to fetch the next page of disk access resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskAccessList(IReadOnlyList<DiskAccessData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiskAccessList"/> for deserialization. </summary>
        internal DiskAccessList()
        {
        }

        /// <summary> A list of disk access resources. </summary>
        public IReadOnlyList<DiskAccessData> Value { get; }
        /// <summary> The uri to fetch the next page of disk access resources. Call ListNext() with this to fetch the next page of disk access resources. </summary>
        public string NextLink { get; }
    }
}
