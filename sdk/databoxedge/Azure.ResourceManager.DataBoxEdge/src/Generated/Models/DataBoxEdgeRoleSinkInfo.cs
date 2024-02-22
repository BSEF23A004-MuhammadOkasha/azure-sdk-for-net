// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Compute role against which events will be raised. </summary>
    public partial class DataBoxEdgeRoleSinkInfo
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

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeRoleSinkInfo"/>. </summary>
        /// <param name="roleId"> Compute role ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleId"/> is null. </exception>
        public DataBoxEdgeRoleSinkInfo(ResourceIdentifier roleId)
        {
            if (roleId == null)
            {
                throw new ArgumentNullException(nameof(roleId));
            }

            RoleId = roleId;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeRoleSinkInfo"/>. </summary>
        /// <param name="roleId"> Compute role ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeRoleSinkInfo(ResourceIdentifier roleId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RoleId = roleId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeRoleSinkInfo"/> for deserialization. </summary>
        internal DataBoxEdgeRoleSinkInfo()
        {
        }

        /// <summary> Compute role ID. </summary>
        public ResourceIdentifier RoleId { get; set; }
    }
}
