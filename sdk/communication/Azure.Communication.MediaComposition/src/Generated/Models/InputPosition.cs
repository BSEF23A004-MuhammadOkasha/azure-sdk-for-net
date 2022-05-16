// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.MediaComposition.Models
{
    /// <summary> The Position. </summary>
    public partial class InputPosition
    {
        /// <summary> Initializes a new instance of InputPosition. </summary>
        public InputPosition()
        {
        }

        /// <summary> Initializes a new instance of InputPosition. </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        internal InputPosition(int? x, int? y)
        {
            X = x;
            Y = y;
        }

        /// <summary> Gets or sets the x. </summary>
        public int? X { get; set; }
        /// <summary> Gets or sets the y. </summary>
        public int? Y { get; set; }
    }
}
