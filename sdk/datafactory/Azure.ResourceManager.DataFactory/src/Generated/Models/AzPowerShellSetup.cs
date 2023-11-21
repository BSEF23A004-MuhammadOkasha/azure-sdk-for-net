// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The express custom setup of installing Azure PowerShell. </summary>
    public partial class AzPowerShellSetup : CustomSetupBase
    {
        /// <summary> Initializes a new instance of <see cref="AzPowerShellSetup"/>. </summary>
        /// <param name="version"> The required version of Azure PowerShell to install. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public AzPowerShellSetup(string version)
        {
            Argument.AssertNotNull(version, nameof(version));

            Version = version;
            CustomSetupBaseType = "AzPowerShellSetup";
        }

        /// <summary> Initializes a new instance of <see cref="AzPowerShellSetup"/>. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="version"> The required version of Azure PowerShell to install. </param>
        internal AzPowerShellSetup(string customSetupBaseType, IDictionary<string, BinaryData> serializedAdditionalRawData, string version) : base(customSetupBaseType, serializedAdditionalRawData)
        {
            Version = version;
            CustomSetupBaseType = customSetupBaseType ?? "AzPowerShellSetup";
        }

        /// <summary> Initializes a new instance of <see cref="AzPowerShellSetup"/> for deserialization. </summary>
        internal AzPowerShellSetup()
        {
        }

        /// <summary> The required version of Azure PowerShell to install. </summary>
        public string Version { get; set; }
    }
}
