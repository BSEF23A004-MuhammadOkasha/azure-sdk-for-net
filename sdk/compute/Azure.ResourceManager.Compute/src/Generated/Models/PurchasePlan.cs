// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Used for establishing the purchase context of any 3rd Party artifact through MarketPlace. </summary>
    public partial class PurchasePlan
    {
        /// <summary> Initializes a new instance of PurchasePlan. </summary>
        /// <param name="publisher"> The publisher ID. </param>
        /// <param name="name"> The plan ID. </param>
        /// <param name="product"> Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisher"/>, <paramref name="name"/> or <paramref name="product"/> is null. </exception>
        public PurchasePlan(string publisher, string name, string product)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            Publisher = publisher;
            Name = name;
            Product = product;
        }

        /// <summary> The publisher ID. </summary>
        public string Publisher { get; set; }
        /// <summary> The plan ID. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element. </summary>
        public string Product { get; set; }
    }
}
