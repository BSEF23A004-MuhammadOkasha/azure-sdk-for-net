// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The customer name to be printed on a letter of authorization. </summary>
    public partial class GenerateExpressRoutePortsLOAContent
    {
        /// <summary> Initializes a new instance of GenerateExpressRoutePortsLOAContent. </summary>
        /// <param name="customerName"> The customer name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customerName"/> is null. </exception>
        public GenerateExpressRoutePortsLOAContent(string customerName)
        {
            if (customerName == null)
            {
                throw new ArgumentNullException(nameof(customerName));
            }

            CustomerName = customerName;
        }

        /// <summary> The customer name. </summary>
        public string CustomerName { get; }
    }
}
