// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> A wrapper for a list of USProgramBrief entities. </summary>
    internal partial class USProgramBriefs
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

        /// <summary> Initializes a new instance of <see cref="USProgramBriefs"/>. </summary>
        internal USProgramBriefs()
        {
            ProgramBriefs = new ChangeTrackingList<USProgramBrief>();
        }

        /// <summary> Initializes a new instance of <see cref="USProgramBriefs"/>. </summary>
        /// <param name="programBriefs"> List of Program Briefs. </param>
        /// <param name="nextLink"> Represents the URL link to the next page. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal USProgramBriefs(IReadOnlyList<USProgramBrief> programBriefs, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProgramBriefs = programBriefs;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Program Briefs. </summary>
        public IReadOnlyList<USProgramBrief> ProgramBriefs { get; }
        /// <summary> Represents the URL link to the next page. </summary>
        public string NextLink { get; }
    }
}
