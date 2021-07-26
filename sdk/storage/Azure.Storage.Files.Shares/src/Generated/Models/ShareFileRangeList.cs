// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> The list of file ranges. </summary>
    internal partial class ShareFileRangeList
    {
        /// <summary> Initializes a new instance of ShareFileRangeList. </summary>
        internal ShareFileRangeList()
        {
            Ranges = new ChangeTrackingList<FileRange>();
            ClearRanges = new ChangeTrackingList<ClearRange>();
        }

        /// <summary> Initializes a new instance of ShareFileRangeList. </summary>
        /// <param name="ranges"></param>
        /// <param name="clearRanges"></param>
        internal ShareFileRangeList(IReadOnlyList<FileRange> ranges, IReadOnlyList<ClearRange> clearRanges)
        {
            Ranges = ranges;
            ClearRanges = clearRanges;
        }

        public IReadOnlyList<FileRange> Ranges { get; }
        public IReadOnlyList<ClearRange> ClearRanges { get; }
    }
}
