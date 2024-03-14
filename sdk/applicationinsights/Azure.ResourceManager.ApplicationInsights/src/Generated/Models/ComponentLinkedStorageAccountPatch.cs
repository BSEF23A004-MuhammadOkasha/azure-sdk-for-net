// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An Application Insights component linked storage accounts patch. </summary>
    public partial class ComponentLinkedStorageAccountPatch
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

        /// <summary> Initializes a new instance of <see cref="ComponentLinkedStorageAccountPatch"/>. </summary>
        public ComponentLinkedStorageAccountPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComponentLinkedStorageAccountPatch"/>. </summary>
        /// <param name="linkedStorageAccount"> Linked storage account resource ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentLinkedStorageAccountPatch(string linkedStorageAccount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LinkedStorageAccount = linkedStorageAccount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Linked storage account resource ID. </summary>
        [WirePath("properties.linkedStorageAccount")]
        public string LinkedStorageAccount { get; set; }
    }
}
