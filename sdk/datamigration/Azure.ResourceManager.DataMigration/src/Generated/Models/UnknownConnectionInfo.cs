// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The UnknownConnectionInfo. </summary>
    internal partial class UnknownConnectionInfo : ConnectionInfo
    {
        /// <summary> Initializes a new instance of <see cref="UnknownConnectionInfo"/>. </summary>
        /// <param name="connectionInfoType"> Type of connection info. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="password"> Password credential. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownConnectionInfo(string connectionInfoType, string userName, string password, Dictionary<string, BinaryData> rawData) : base(connectionInfoType, userName, password, rawData)
        {
            ConnectionInfoType = connectionInfoType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownConnectionInfo"/> for deserialization. </summary>
        internal UnknownConnectionInfo()
        {
        }
    }
}
