// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication.MediaComposition.Models;

namespace Azure.Communication.MediaComposition
{
    /// <summary> The DominantSpeaker. </summary>
    public partial class DominantSpeaker : MediaInput
    {
        /// <summary> Initializes a new instance of <see cref="DominantSpeaker"/>. </summary>
        /// <param name="call"> The id of the teams meeting or call. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="call"/> is null. </exception>
        public DominantSpeaker(string call)
        {
            if (call == null)
            {
                throw new ArgumentNullException(nameof(call));
            }

            Call = call;
            Kind = MediaInputType.DominantSpeaker;
        }

        /// <summary> Initializes a new instance of <see cref="DominantSpeaker"/>. </summary>
        /// <param name="kind"> Kind of media input. </param>
        /// <param name="placeholderImageUri"> Image url to be used if participant has no video stream. </param>
        /// <param name="call"> The id of the teams meeting or call. </param>
        internal DominantSpeaker(MediaInputType kind, string placeholderImageUri, string call) : base(kind, placeholderImageUri)
        {
            Call = call;
            Kind = kind;
        }

        /// <summary> The id of the teams meeting or call. </summary>
        public string Call { get; set; }
    }
}
