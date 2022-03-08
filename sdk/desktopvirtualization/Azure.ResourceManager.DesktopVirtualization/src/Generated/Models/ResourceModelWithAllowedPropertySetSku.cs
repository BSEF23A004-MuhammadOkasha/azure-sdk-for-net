// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The ResourceModelWithAllowedPropertySetSku. </summary>
    public partial class ResourceModelWithAllowedPropertySetSku : Sku
    {
        /// <summary> Initializes a new instance of ResourceModelWithAllowedPropertySetSku. </summary>
        /// <param name="name"> The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ResourceModelWithAllowedPropertySetSku(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
        }

        /// <summary> Initializes a new instance of ResourceModelWithAllowedPropertySetSku. </summary>
        /// <param name="name"> The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <param name="tier"> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </param>
        /// <param name="size"> The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. </param>
        /// <param name="family"> If the service has different generations of hardware, for the same SKU, then that can be captured here. </param>
        /// <param name="capacity"> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </param>
        internal ResourceModelWithAllowedPropertySetSku(string name, SkuTier? tier, string size, string family, int? capacity) : base(name, tier, size, family, capacity)
        {
        }
    }
}
