// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Offline configuration. </summary>
    internal partial class SqlDBOfflineConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SqlDBOfflineConfiguration"/>. </summary>
        internal SqlDBOfflineConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlDBOfflineConfiguration"/>. </summary>
        /// <param name="offline"> Offline migration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlDBOfflineConfiguration(bool? offline, Dictionary<string, BinaryData> rawData)
        {
            Offline = offline;
            _rawData = rawData;
        }

        /// <summary> Offline migration. </summary>
        public bool? Offline { get; }
    }
}
