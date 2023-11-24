// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines a data change detection policy that captures changes based on the value of a high water mark column. </summary>
    public partial class HighWaterMarkChangeDetectionPolicy : DataChangeDetectionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="HighWaterMarkChangeDetectionPolicy"/>. </summary>
        /// <param name="highWaterMarkColumnName"> The name of the high water mark column. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="highWaterMarkColumnName"/> is null. </exception>
        public HighWaterMarkChangeDetectionPolicy(string highWaterMarkColumnName)
        {
            Argument.AssertNotNull(highWaterMarkColumnName, nameof(highWaterMarkColumnName));

            HighWaterMarkColumnName = highWaterMarkColumnName;
            ODataType = "#Microsoft.Azure.Search.HighWaterMarkChangeDetectionPolicy";
        }

        /// <summary> Initializes a new instance of <see cref="HighWaterMarkChangeDetectionPolicy"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of data change detection policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="highWaterMarkColumnName"> The name of the high water mark column. </param>
        internal HighWaterMarkChangeDetectionPolicy(string oDataType, IDictionary<string, BinaryData> serializedAdditionalRawData, string highWaterMarkColumnName) : base(oDataType, serializedAdditionalRawData)
        {
            HighWaterMarkColumnName = highWaterMarkColumnName;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.HighWaterMarkChangeDetectionPolicy";
        }

        /// <summary> Initializes a new instance of <see cref="HighWaterMarkChangeDetectionPolicy"/> for deserialization. </summary>
        internal HighWaterMarkChangeDetectionPolicy()
        {
        }

        /// <summary> The name of the high water mark column. </summary>
        public string HighWaterMarkColumnName { get; set; }
    }
}
