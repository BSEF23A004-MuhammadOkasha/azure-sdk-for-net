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
    /// <summary> A Room to be used as an output. </summary>
    public partial class RoomOutput : MediaOutput
    {
        /// <summary> Initializes a new instance of <see cref="RoomOutput"/>. </summary>
        /// <param name="id"> Room identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public RoomOutput(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            Kind = MediaOutputType.Room;
        }

        /// <summary> Initializes a new instance of <see cref="RoomOutput"/>. </summary>
        /// <param name="kind"> Kind of media output. </param>
        /// <param name="id"> Room identifier. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoomOutput(MediaOutputType kind, string id, Dictionary<string, BinaryData> rawData) : base(kind, rawData)
        {
            Id = id;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="RoomOutput"/> for deserialization. </summary>
        internal RoomOutput()
        {
        }

        /// <summary> Room identifier. </summary>
        public string Id { get; set; }
    }
}
