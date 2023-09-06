// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Dapr component Secret for ListSecrets Action. </summary>
    public partial class ContainerAppDaprSecret
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppDaprSecret"/>. </summary>
        internal ContainerAppDaprSecret()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppDaprSecret"/>. </summary>
        /// <param name="name"> Secret Name. </param>
        /// <param name="value"> Secret Value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppDaprSecret(string name, string value, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Secret Name. </summary>
        public string Name { get; }
        /// <summary> Secret Value. </summary>
        public string Value { get; }
    }
}
