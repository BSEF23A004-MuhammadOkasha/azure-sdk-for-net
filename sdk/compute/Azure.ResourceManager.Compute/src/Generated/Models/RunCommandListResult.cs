// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Virtual Machine operation response. </summary>
    internal partial class RunCommandListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RunCommandListResult"/>. </summary>
        /// <param name="value"> The list of virtual machine run commands. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RunCommandListResult(IEnumerable<RunCommandDocumentBase> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RunCommandListResult"/>. </summary>
        /// <param name="value"> The list of virtual machine run commands. </param>
        /// <param name="nextLink"> The uri to fetch the next page of run commands. Call ListNext() with this to fetch the next page of run commands. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RunCommandListResult(IReadOnlyList<RunCommandDocumentBase> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunCommandListResult"/> for deserialization. </summary>
        internal RunCommandListResult()
        {
        }

        /// <summary> The list of virtual machine run commands. </summary>
        public IReadOnlyList<RunCommandDocumentBase> Value { get; }
        /// <summary> The uri to fetch the next page of run commands. Call ListNext() with this to fetch the next page of run commands. </summary>
        public string NextLink { get; }
    }
}
