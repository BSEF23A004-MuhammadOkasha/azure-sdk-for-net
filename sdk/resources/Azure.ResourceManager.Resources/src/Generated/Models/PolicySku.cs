// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The policy sku. This property is optional, obsolete, and will be ignored. </summary>
    public partial class PolicySku
    {
        /// <summary> Initializes a new instance of PolicySku. </summary>
        /// <param name="name"> The name of the policy sku. Possible values are A0 and A1. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PolicySku(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of PolicySku. </summary>
        /// <param name="name"> The name of the policy sku. Possible values are A0 and A1. </param>
        /// <param name="tier"> The policy sku tier. Possible values are Free and Standard. </param>
        internal PolicySku(string name, string tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> The name of the policy sku. Possible values are A0 and A1. </summary>
        public string Name { get; set; }
        /// <summary> The policy sku tier. Possible values are Free and Standard. </summary>
        public string Tier { get; set; }
    }
}
