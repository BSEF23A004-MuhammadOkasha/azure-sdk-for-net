// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The parameters used to update a virtual network rule while updating a Data Lake Store account. </summary>
    public partial class VirtualNetworkRuleForDataLakeStoreAccountUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="VirtualNetworkRuleForDataLakeStoreAccountUpdateContent"/>. </summary>
        /// <param name="name"> The unique name of the virtual network rule to update. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public VirtualNetworkRuleForDataLakeStoreAccountUpdateContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> The unique name of the virtual network rule to update. </summary>
        public string Name { get; }
        /// <summary> The resource identifier for the subnet. </summary>
        public ResourceIdentifier SubnetId { get; set; }
    }
}
