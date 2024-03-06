// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Query result. </summary>
    public partial class IdpsSignatureListResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IdpsSignatureListResult"/>. </summary>
        internal IdpsSignatureListResult()
        {
            Signatures = new ChangeTrackingList<IdpsSignatureResult>();
        }

        /// <summary> Initializes a new instance of <see cref="IdpsSignatureListResult"/>. </summary>
        /// <param name="matchingRecordsCount"> Number of total records matching the query. </param>
        /// <param name="signatures"> Array containing the results of the query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IdpsSignatureListResult(long? matchingRecordsCount, IReadOnlyList<IdpsSignatureResult> signatures, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MatchingRecordsCount = matchingRecordsCount;
            Signatures = signatures;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Number of total records matching the query. </summary>
        public long? MatchingRecordsCount { get; }
        /// <summary> Array containing the results of the query. </summary>
        public IReadOnlyList<IdpsSignatureResult> Signatures { get; }
    }
}
