// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Creator.Models
{
    /// <summary> Summary of the call. </summary>
    public partial class BufferResponseSummary
    {
        /// <summary> Initializes a new instance of BufferResponseSummary. </summary>
        internal BufferResponseSummary()
        {
        }

        /// <summary> Initializes a new instance of BufferResponseSummary. </summary>
        /// <param name="udid"> The udid for the user data if one exists. </param>
        /// <param name="information"> The information about what happened during the call. </param>
        internal BufferResponseSummary(string udid, string information)
        {
            Udid = udid;
            Information = information;
        }

        /// <summary> The udid for the user data if one exists. </summary>
        public string Udid { get; }
        /// <summary> The information about what happened during the call. </summary>
        public string Information { get; }
    }
}
