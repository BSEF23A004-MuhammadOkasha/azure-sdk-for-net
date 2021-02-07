// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> Settings for where to retrieve input files from and where to write output files. Supplied when creating the conversion. </summary>
    public partial class AssetConversionOptions
    {
        /// <summary> Initializes a new instance of AssetConversionOptions. </summary>
        /// <param name="inputOptions"> Settings for the conversion input. </param>
        /// <param name="outputOptions"> Settings for the conversion output. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputOptions"/> or <paramref name="outputOptions"/> is null. </exception>
        public AssetConversionOptions(AssetConversionInputOptions inputOptions, AssetConversionOutputOptions outputOptions)
        {
            if (inputOptions == null)
            {
                throw new ArgumentNullException(nameof(inputOptions));
            }
            if (outputOptions == null)
            {
                throw new ArgumentNullException(nameof(outputOptions));
            }

            InputOptions = inputOptions;
            OutputOptions = outputOptions;
        }
    }
}
