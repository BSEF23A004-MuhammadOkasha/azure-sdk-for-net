// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the VM to check security groups for. </summary>
    public partial class SecurityGroupViewContent
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

        /// <summary> Initializes a new instance of <see cref="SecurityGroupViewContent"/>. </summary>
        /// <param name="targetResourceId"> ID of the target VM. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/> is null. </exception>
        public SecurityGroupViewContent(ResourceIdentifier targetResourceId)
        {
            Argument.AssertNotNull(targetResourceId, nameof(targetResourceId));

            TargetResourceId = targetResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityGroupViewContent"/>. </summary>
        /// <param name="targetResourceId"> ID of the target VM. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityGroupViewContent(ResourceIdentifier targetResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetResourceId = targetResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityGroupViewContent"/> for deserialization. </summary>
        internal SecurityGroupViewContent()
        {
        }

        /// <summary> ID of the target VM. </summary>
        public ResourceIdentifier TargetResourceId { get; }
    }
}
