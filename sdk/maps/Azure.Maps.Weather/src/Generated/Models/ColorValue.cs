// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather.Models
{
    /// <summary> The ColorValue. </summary>
    public partial class ColorValue
    {
        /// <summary> Initializes a new instance of ColorValue. </summary>
        internal ColorValue()
        {
        }

        /// <summary> Initializes a new instance of ColorValue. </summary>
        /// <param name="red"> Red component of the RGB value. </param>
        /// <param name="green"> Green component of the RGB value. </param>
        /// <param name="blue"> Blue component of the RGB value. </param>
        /// <param name="hex"> Hexadecimal color value. </param>
        internal ColorValue(int? red, int? green, int? blue, string hex)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Hex = hex;
        }

        /// <summary> Red component of the RGB value. </summary>
        public int? Red { get; }
        /// <summary> Green component of the RGB value. </summary>
        public int? Green { get; }
        /// <summary> Blue component of the RGB value. </summary>
        public int? Blue { get; }
        /// <summary> Hexadecimal color value. </summary>
        public string Hex { get; }
    }
}
