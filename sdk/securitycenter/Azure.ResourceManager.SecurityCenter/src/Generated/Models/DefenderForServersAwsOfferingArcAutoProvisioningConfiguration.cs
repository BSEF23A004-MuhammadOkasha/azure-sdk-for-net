// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Configuration for servers Arc auto provisioning. </summary>
    public partial class DefenderForServersAwsOfferingArcAutoProvisioningConfiguration
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

        /// <summary> Initializes a new instance of <see cref="DefenderForServersAwsOfferingArcAutoProvisioningConfiguration"/>. </summary>
        public DefenderForServersAwsOfferingArcAutoProvisioningConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderForServersAwsOfferingArcAutoProvisioningConfiguration"/>. </summary>
        /// <param name="proxy"> Optional HTTP proxy endpoint to use for the Arc agent. </param>
        /// <param name="privateLinkScope"> Optional Arc private link scope resource id to link the Arc agent. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DefenderForServersAwsOfferingArcAutoProvisioningConfiguration(string proxy, string privateLinkScope, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Proxy = proxy;
            PrivateLinkScope = privateLinkScope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Optional HTTP proxy endpoint to use for the Arc agent. </summary>
        public string Proxy { get; set; }
        /// <summary> Optional Arc private link scope resource id to link the Arc agent. </summary>
        public string PrivateLinkScope { get; set; }
    }
}
