// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Pool health status detail. </summary>
    public partial class DevCenterHealthStatusDetail
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevCenterHealthStatusDetail"/>. </summary>
        internal DevCenterHealthStatusDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterHealthStatusDetail"/>. </summary>
        /// <param name="code"> An identifier for the issue. </param>
        /// <param name="message"> A message describing the issue, intended to be suitable for display in a user interface. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterHealthStatusDetail(string code, string message, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> An identifier for the issue. </summary>
        public string Code { get; }
        /// <summary> A message describing the issue, intended to be suitable for display in a user interface. </summary>
        public string Message { get; }
    }
}
