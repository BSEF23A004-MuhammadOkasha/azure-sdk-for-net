// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> Microsoft.Elastic SKU. </summary>
    internal partial class ResourceSku
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceSku"/>. </summary>
        /// <param name="name"> Name of the SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ResourceSku(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceSku"/>. </summary>
        /// <param name="name"> Name of the SKU. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceSku(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceSku"/> for deserialization. </summary>
        internal ResourceSku()
        {
        }

        /// <summary> Name of the SKU. </summary>
        public string Name { get; set; }
    }
}
