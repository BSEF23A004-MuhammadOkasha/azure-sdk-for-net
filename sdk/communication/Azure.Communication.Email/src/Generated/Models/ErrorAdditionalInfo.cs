// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Email
{
    /// <summary> The resource management error additional info. </summary>
    internal partial class ErrorAdditionalInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ErrorAdditionalInfo"/>. </summary>
        internal ErrorAdditionalInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ErrorAdditionalInfo"/>. </summary>
        /// <param name="type"> The additional info type. </param>
        /// <param name="info"> The additional info. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ErrorAdditionalInfo(string type, object info, Dictionary<string, BinaryData> rawData)
        {
            Type = type;
            Info = info;
            _rawData = rawData;
        }

        /// <summary> The additional info type. </summary>
        public string Type { get; }
        /// <summary> The additional info. </summary>
        public object Info { get; }
    }
}
