// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The MetastoreRegisterObject. </summary>
    public partial class MetastoreRegisterObject
    {
        /// <summary> Initializes a new instance of <see cref="MetastoreRegisterObject"/>. </summary>
        /// <param name="inputFolder"> The input folder containing CDM files. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputFolder"/> is null. </exception>
        public MetastoreRegisterObject(string inputFolder)
        {
            Argument.AssertNotNull(inputFolder, nameof(inputFolder));

            InputFolder = inputFolder;
        }

        /// <summary> The input folder containing CDM files. </summary>
        public string InputFolder { get; }
    }
}
