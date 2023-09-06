// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Response body structure of data flow result for data preview, statistics or expression preview. </summary>
    public partial class DataFactoryDataFlowDebugCommandResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFactoryDataFlowDebugCommandResult"/>. </summary>
        internal DataFactoryDataFlowDebugCommandResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryDataFlowDebugCommandResult"/>. </summary>
        /// <param name="status"> The run status of data preview, statistics or expression preview. </param>
        /// <param name="data"> The result data of data preview, statistics or expression preview. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryDataFlowDebugCommandResult(string status, string data, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            Data = data;
            _rawData = rawData;
        }

        /// <summary> The run status of data preview, statistics or expression preview. </summary>
        public string Status { get; }
        /// <summary> The result data of data preview, statistics or expression preview. </summary>
        public string Data { get; }
    }
}
