// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    /// <summary> Srt stream to be used as an input. </summary>
    public partial class SrtInput : MediaInput
    {
        /// <summary> Initializes a new instance of <see cref="SrtInput"/>. </summary>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="streamUrl"> The url of the stream. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resolution"/> or <paramref name="streamUrl"/> is null. </exception>
        public SrtInput(LayoutResolution resolution, string streamUrl)
        {
            Argument.AssertNotNull(resolution, nameof(resolution));
            Argument.AssertNotNull(streamUrl, nameof(streamUrl));

            Resolution = resolution;
            StreamUrl = streamUrl;
            Kind = MediaInputType.Srt;
        }

        /// <summary> Initializes a new instance of <see cref="SrtInput"/>. </summary>
        /// <param name="kind"> Kind of media input. </param>
        /// <param name="placeholderImageUri"> Image url to be used if participant has no video stream. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="streamUrl"> The url of the stream. </param>
        internal SrtInput(MediaInputType kind, string placeholderImageUri, IDictionary<string, BinaryData> serializedAdditionalRawData, LayoutResolution resolution, string streamUrl) : base(kind, placeholderImageUri, serializedAdditionalRawData)
        {
            Resolution = resolution;
            StreamUrl = streamUrl;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="SrtInput"/> for deserialization. </summary>
        internal SrtInput()
        {
        }

        /// <summary> The dimensions of the scene or objects in the scene. </summary>
        public LayoutResolution Resolution { get; set; }
        /// <summary> The url of the stream. </summary>
        public string StreamUrl { get; set; }
    }
}
