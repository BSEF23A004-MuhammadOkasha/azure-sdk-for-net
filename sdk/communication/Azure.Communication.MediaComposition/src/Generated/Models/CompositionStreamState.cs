// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.MediaComposition
{
    /// <summary> Provides the state of the media composition. </summary>
    public partial class CompositionStreamState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CompositionStreamState"/>. </summary>
        public CompositionStreamState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CompositionStreamState"/>. </summary>
        /// <param name="status"> State of the composition stream. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CompositionStreamState(StreamStatus? status, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            _rawData = rawData;
        }

        /// <summary> State of the composition stream. </summary>
        public StreamStatus? Status { get; set; }
    }
}
