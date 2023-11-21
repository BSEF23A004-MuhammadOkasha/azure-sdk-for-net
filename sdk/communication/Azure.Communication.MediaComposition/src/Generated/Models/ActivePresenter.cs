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
    /// <summary> The ActivePresenter. </summary>
    public partial class ActivePresenter : MediaInput
    {
        /// <summary> Initializes a new instance of <see cref="ActivePresenter"/>. </summary>
        /// <param name="call"> The id of the teams meeting or call. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="call"/> is null. </exception>
        public ActivePresenter(string call)
        {
            Argument.AssertNotNull(call, nameof(call));

            Call = call;
            Kind = MediaInputType.ActivePresenter;
        }

        /// <summary> Initializes a new instance of <see cref="ActivePresenter"/>. </summary>
        /// <param name="kind"> Kind of media input. </param>
        /// <param name="placeholderImageUri"> Image url to be used if participant has no video stream. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="call"> The id of the teams meeting or call. </param>
        internal ActivePresenter(MediaInputType kind, string placeholderImageUri, IDictionary<string, BinaryData> serializedAdditionalRawData, string call) : base(kind, placeholderImageUri, serializedAdditionalRawData)
        {
            Call = call;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="ActivePresenter"/> for deserialization. </summary>
        internal ActivePresenter()
        {
        }

        /// <summary> The id of the teams meeting or call. </summary>
        public string Call { get; set; }
    }
}
