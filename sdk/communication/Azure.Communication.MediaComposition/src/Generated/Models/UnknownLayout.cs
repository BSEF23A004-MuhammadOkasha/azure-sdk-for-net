// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.MediaComposition.Models;

namespace Azure.Communication.MediaComposition
{
    /// <summary> The UnknownLayout. </summary>
    internal partial class UnknownLayout : MediaCompositionLayout
    {
        /// <summary> Initializes a new instance of <see cref="UnknownLayout"/>. </summary>
        /// <param name="kind"> Kind of layout. </param>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="placeholderImageUri"> Set global placeholder image. </param>
        /// <param name="scalingMode"> The scaling mode for the view of a video stream in a cell. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownLayout(LayoutType kind, LayoutResolution resolution, string placeholderImageUri, ScalingMode? scalingMode, Dictionary<string, BinaryData> rawData) : base(kind, resolution, placeholderImageUri, scalingMode, rawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownLayout"/> for deserialization. </summary>
        internal UnknownLayout()
        {
        }
    }
}
