// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Structure of command payload. </summary>
    public partial class DataFlowDebugCommandPayload
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugCommandPayload"/>. </summary>
        /// <param name="streamName"> The stream name which is used for preview. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="streamName"/> is null. </exception>
        public DataFlowDebugCommandPayload(string streamName)
        {
            Argument.AssertNotNull(streamName, nameof(streamName));

            StreamName = streamName;
            Columns = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugCommandPayload"/>. </summary>
        /// <param name="streamName"> The stream name which is used for preview. </param>
        /// <param name="rowLimits"> Row limits for preview response. </param>
        /// <param name="columns"> Array of column names. </param>
        /// <param name="expression"> The expression which is used for preview. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFlowDebugCommandPayload(string streamName, int? rowLimits, IList<string> columns, string expression, Dictionary<string, BinaryData> rawData)
        {
            StreamName = streamName;
            RowLimits = rowLimits;
            Columns = columns;
            Expression = expression;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugCommandPayload"/> for deserialization. </summary>
        internal DataFlowDebugCommandPayload()
        {
        }

        /// <summary> The stream name which is used for preview. </summary>
        public string StreamName { get; }
        /// <summary> Row limits for preview response. </summary>
        public int? RowLimits { get; set; }
        /// <summary> Array of column names. </summary>
        public IList<string> Columns { get; }
        /// <summary> The expression which is used for preview. </summary>
        public string Expression { get; set; }
    }
}
