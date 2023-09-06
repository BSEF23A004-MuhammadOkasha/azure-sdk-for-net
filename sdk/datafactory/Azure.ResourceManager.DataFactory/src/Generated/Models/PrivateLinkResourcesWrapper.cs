// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Wrapper for a collection of private link resources. </summary>
    internal partial class PrivateLinkResourcesWrapper
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourcesWrapper"/>. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PrivateLinkResourcesWrapper(IEnumerable<DataFactoryPrivateLinkResource> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourcesWrapper"/>. </summary>
        /// <param name="value"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkResourcesWrapper(IReadOnlyList<DataFactoryPrivateLinkResource> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourcesWrapper"/> for deserialization. </summary>
        internal PrivateLinkResourcesWrapper()
        {
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<DataFactoryPrivateLinkResource> Value { get; }
    }
}
