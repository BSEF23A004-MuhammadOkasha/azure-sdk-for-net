// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class for NoEncryption scheme. </summary>
    internal partial class NoEncryption
    {
        /// <summary> Initializes a new instance of NoEncryption. </summary>
        public NoEncryption()
        {
        }

        /// <summary> Initializes a new instance of NoEncryption. </summary>
        /// <param name="enabledProtocols"> Representing supported protocols. </param>
        internal NoEncryption(MediaEnabledProtocols enabledProtocols)
        {
            EnabledProtocols = enabledProtocols;
        }

        /// <summary> Representing supported protocols. </summary>
        public MediaEnabledProtocols EnabledProtocols { get; set; }
    }
}
