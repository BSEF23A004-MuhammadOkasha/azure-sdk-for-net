// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Execution policy for an activity. </summary>
    public partial class RetryPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RetryPolicy"/>. </summary>
        public RetryPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RetryPolicy"/>. </summary>
        /// <param name="count"> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="intervalInSeconds"> Interval between retries in seconds. Default is 30. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RetryPolicy(DataFactoryElement<int> count, int? intervalInSeconds, Dictionary<string, BinaryData> rawData)
        {
            Count = count;
            IntervalInSeconds = intervalInSeconds;
            _rawData = rawData;
        }

        /// <summary> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> Count { get; set; }
        /// <summary> Interval between retries in seconds. Default is 30. </summary>
        public int? IntervalInSeconds { get; set; }
    }
}
