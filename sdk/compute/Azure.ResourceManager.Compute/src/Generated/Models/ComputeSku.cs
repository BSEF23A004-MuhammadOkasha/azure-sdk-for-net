// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is currently on, you need to deallocate the VMs in the scale set before you modify the SKU name. </summary>
    public partial class ComputeSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ComputeSku"/>. </summary>
        public ComputeSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeSku"/>. </summary>
        /// <param name="name"> The sku name. </param>
        /// <param name="tier"> Specifies the tier of virtual machines in a scale set.&lt;br /&gt;&lt;br /&gt; Possible Values:&lt;br /&gt;&lt;br /&gt; **Standard**&lt;br /&gt;&lt;br /&gt; **Basic**. </param>
        /// <param name="capacity"> Specifies the number of virtual machines in the scale set. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeSku(string name, string tier, long? capacity, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            _rawData = rawData;
        }

        /// <summary> The sku name. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the tier of virtual machines in a scale set.&lt;br /&gt;&lt;br /&gt; Possible Values:&lt;br /&gt;&lt;br /&gt; **Standard**&lt;br /&gt;&lt;br /&gt; **Basic**. </summary>
        public string Tier { get; set; }
        /// <summary> Specifies the number of virtual machines in the scale set. </summary>
        public long? Capacity { get; set; }
    }
}
