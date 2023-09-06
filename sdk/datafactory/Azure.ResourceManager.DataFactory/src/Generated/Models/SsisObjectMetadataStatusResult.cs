// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The status of the operation. </summary>
    public partial class SsisObjectMetadataStatusResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SsisObjectMetadataStatusResult"/>. </summary>
        internal SsisObjectMetadataStatusResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SsisObjectMetadataStatusResult"/>. </summary>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="name"> The operation name. </param>
        /// <param name="properties"> The operation properties. </param>
        /// <param name="error"> The operation error message. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SsisObjectMetadataStatusResult(string status, string name, string properties, string error, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            Name = name;
            Properties = properties;
            Error = error;
            _rawData = rawData;
        }

        /// <summary> The status of the operation. </summary>
        public string Status { get; }
        /// <summary> The operation name. </summary>
        public string Name { get; }
        /// <summary> The operation properties. </summary>
        public string Properties { get; }
        /// <summary> The operation error message. </summary>
        public string Error { get; }
    }
}
