// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The list of intermediate cluster code versions for an upgrade or downgrade. Or minimum and maximum upgradable version if no target was given. </summary>
    public partial class UpgradableVersionPathResult
    {
        /// <summary> Initializes a new instance of UpgradableVersionPathResult. </summary>
        internal UpgradableVersionPathResult()
        {
            SupportedPath = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of UpgradableVersionPathResult. </summary>
        /// <param name="supportedPath"></param>
        internal UpgradableVersionPathResult(IReadOnlyList<string> supportedPath)
        {
            SupportedPath = supportedPath;
        }

        /// <summary> Gets the supported path. </summary>
        public IReadOnlyList<string> SupportedPath { get; }
    }
}
