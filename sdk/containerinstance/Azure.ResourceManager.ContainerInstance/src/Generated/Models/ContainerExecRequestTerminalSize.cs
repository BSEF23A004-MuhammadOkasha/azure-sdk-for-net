// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The size of the terminal. </summary>
    public partial class ContainerExecRequestTerminalSize
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerExecRequestTerminalSize"/>. </summary>
        public ContainerExecRequestTerminalSize()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerExecRequestTerminalSize"/>. </summary>
        /// <param name="rows"> The row size of the terminal. </param>
        /// <param name="cols"> The column size of the terminal. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerExecRequestTerminalSize(int? rows, int? cols, Dictionary<string, BinaryData> rawData)
        {
            Rows = rows;
            Cols = cols;
            _rawData = rawData;
        }

        /// <summary> The row size of the terminal. </summary>
        public int? Rows { get; set; }
        /// <summary> The column size of the terminal. </summary>
        public int? Cols { get; set; }
    }
}
