// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.FluidRelay;

namespace Azure.ResourceManager.FluidRelay.Models
{
    /// <summary> Paged response. </summary>
    internal partial class FluidRelayServerList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FluidRelayServerList"/>. </summary>
        /// <param name="value"> A sequence of FluidRelay servers. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal FluidRelayServerList(IEnumerable<FluidRelayServerData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="FluidRelayServerList"/>. </summary>
        /// <param name="value"> A sequence of FluidRelay servers. </param>
        /// <param name="nextLink"> A link to the next page of results, if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FluidRelayServerList(IReadOnlyList<FluidRelayServerData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="FluidRelayServerList"/> for deserialization. </summary>
        internal FluidRelayServerList()
        {
        }

        /// <summary> A sequence of FluidRelay servers. </summary>
        public IReadOnlyList<FluidRelayServerData> Value { get; }
        /// <summary> A link to the next page of results, if any. </summary>
        public string NextLink { get; }
    }
}
