// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The Interface. </summary>
    internal partial class PnpInterface
    {
        /// <summary> Initializes a new instance of PnpInterface. </summary>
        internal PnpInterface()
        {
        }

        /// <summary> Initializes a new instance of PnpInterface. </summary>
        /// <param name="name"> Full name of digital twin interface. </param>
        /// <param name="properties"> List of all properties in an interface. </param>
        internal PnpInterface(string name, IReadOnlyDictionary<string, PnpProperty> properties)
        {
            Name = name;
            Properties = properties;
        }

        /// <summary> Full name of digital twin interface. </summary>
        public string Name { get; }
        /// <summary> List of all properties in an interface. </summary>
        public IReadOnlyDictionary<string, PnpProperty> Properties { get; }
    }
}
