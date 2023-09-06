// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.MediaComposition;
using Azure.Core.Serialization;

namespace Azure.Communication.MediaComposition.Models
{
    /// <summary>
    /// Configure a layout
    /// Please note <see cref="MediaCompositionLayout"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AutoGridLayout"/>, <see cref="CustomLayout"/>, <see cref="GridLayout"/>, <see cref="PresentationLayout"/> and <see cref="PresenterLayout"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownLayout))]
    public abstract partial class MediaCompositionLayout
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MediaCompositionLayout"/>. </summary>
        /// <param name="kind"> Kind of layout. </param>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="placeholderImageUri"> Set global placeholder image. </param>
        /// <param name="scalingMode"> The scaling mode for the view of a video stream in a cell. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaCompositionLayout(LayoutType kind, LayoutResolution resolution, string placeholderImageUri, ScalingMode? scalingMode, Dictionary<string, BinaryData> rawData)
        {
            Kind = kind;
            Resolution = resolution;
            PlaceholderImageUri = placeholderImageUri;
            ScalingMode = scalingMode;
            _rawData = rawData;
        }

        /// <summary> Kind of layout. </summary>
        internal LayoutType Kind { get; set; }
        /// <summary> The dimensions of the scene or objects in the scene. </summary>
        public LayoutResolution Resolution { get; set; }
        /// <summary> Set global placeholder image. </summary>
        public string PlaceholderImageUri { get; set; }
        /// <summary> The scaling mode for the view of a video stream in a cell. </summary>
        public ScalingMode? ScalingMode { get; set; }
    }
}
