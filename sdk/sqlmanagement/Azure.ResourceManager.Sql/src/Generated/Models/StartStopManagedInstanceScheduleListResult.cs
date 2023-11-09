// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Managed instance's Start/Stop schedule list result. </summary>
    internal partial class StartStopManagedInstanceScheduleListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StartStopManagedInstanceScheduleListResult"/>. </summary>
        internal StartStopManagedInstanceScheduleListResult()
        {
            Value = new ChangeTrackingList<ManagedInstanceStartStopScheduleData>();
        }

        /// <summary> Initializes a new instance of <see cref="StartStopManagedInstanceScheduleListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StartStopManagedInstanceScheduleListResult(IReadOnlyList<ManagedInstanceStartStopScheduleData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedInstanceStartStopScheduleData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
