// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> List of GuestAgent. </summary>
    internal partial class GuestAgentList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GuestAgentList"/>. </summary>
        /// <param name="value"> Array of GuestAgent. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal GuestAgentList(IEnumerable<GuestAgentData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GuestAgentList"/>. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of GuestAgent. </param>
        /// <param name="value"> Array of GuestAgent. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GuestAgentList(string nextLink, IReadOnlyList<GuestAgentData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GuestAgentList"/> for deserialization. </summary>
        internal GuestAgentList()
        {
        }

        /// <summary> Url to follow for getting next page of GuestAgent. </summary>
        public string NextLink { get; }
        /// <summary> Array of GuestAgent. </summary>
        public IReadOnlyList<GuestAgentData> Value { get; }
    }
}
