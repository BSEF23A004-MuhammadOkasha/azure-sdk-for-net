// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> VolumeClaimSpecSelector properties. </summary>
    public partial class VolumeClaimSpecSelector
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

        /// <summary> Initializes a new instance of <see cref="VolumeClaimSpecSelector"/>. </summary>
        public VolumeClaimSpecSelector()
        {
            MatchExpressions = new ChangeTrackingList<VolumeClaimSpecSelectorMatchExpressions>();
            MatchLabels = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="VolumeClaimSpecSelector"/>. </summary>
        /// <param name="matchExpressions"> MatchExpressions is a list of label selector requirements. The requirements are ANDed. </param>
        /// <param name="matchLabels"> MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VolumeClaimSpecSelector(IList<VolumeClaimSpecSelectorMatchExpressions> matchExpressions, IDictionary<string, string> matchLabels, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MatchExpressions = matchExpressions;
            MatchLabels = matchLabels;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> MatchExpressions is a list of label selector requirements. The requirements are ANDed. </summary>
        public IList<VolumeClaimSpecSelectorMatchExpressions> MatchExpressions { get; }
        /// <summary> MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed. </summary>
        public IDictionary<string, string> MatchLabels { get; }
    }
}
