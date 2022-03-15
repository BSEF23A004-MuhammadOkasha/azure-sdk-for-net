// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> SkuSetting fulfills the need for stripped down SKU info in ARM contract. </summary>
    public partial class SkuSetting
    {
        /// <summary> Initializes a new instance of SkuSetting. </summary>
        /// <param name="name"> The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal SkuSetting(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of SkuSetting. </summary>
        /// <param name="name"> The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <param name="tier"> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </param>
        internal SkuSetting(string name, MachineLearningServicesSkuTier? tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> The name of the SKU. Ex - P3. It is typically a letter+number code. </summary>
        public string Name { get; }
        /// <summary> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </summary>
        public MachineLearningServicesSkuTier? Tier { get; }
    }
}
