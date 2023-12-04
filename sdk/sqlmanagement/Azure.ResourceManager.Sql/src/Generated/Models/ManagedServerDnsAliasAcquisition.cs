// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A managed server DNS alias acquisition request. </summary>
    public partial class ManagedServerDnsAliasAcquisition
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

        /// <summary> Initializes a new instance of <see cref="ManagedServerDnsAliasAcquisition"/>. </summary>
        /// <param name="oldManagedServerDnsAliasResourceId"> The resource ID of the managed server DNS alias that will be acquired to point to this managed server instead. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="oldManagedServerDnsAliasResourceId"/> is null. </exception>
        public ManagedServerDnsAliasAcquisition(ResourceIdentifier oldManagedServerDnsAliasResourceId)
        {
            Argument.AssertNotNull(oldManagedServerDnsAliasResourceId, nameof(oldManagedServerDnsAliasResourceId));

            OldManagedServerDnsAliasResourceId = oldManagedServerDnsAliasResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServerDnsAliasAcquisition"/>. </summary>
        /// <param name="oldManagedServerDnsAliasResourceId"> The resource ID of the managed server DNS alias that will be acquired to point to this managed server instead. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedServerDnsAliasAcquisition(ResourceIdentifier oldManagedServerDnsAliasResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OldManagedServerDnsAliasResourceId = oldManagedServerDnsAliasResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServerDnsAliasAcquisition"/> for deserialization. </summary>
        internal ManagedServerDnsAliasAcquisition()
        {
        }

        /// <summary> The resource ID of the managed server DNS alias that will be acquired to point to this managed server instead. </summary>
        public ResourceIdentifier OldManagedServerDnsAliasResourceId { get; }
    }
}
