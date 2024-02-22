// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The mapping between a particular user and the access type on the SMB share. </summary>
    public partial class UserAccessRight
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

        /// <summary> Initializes a new instance of <see cref="UserAccessRight"/>. </summary>
        /// <param name="userId"> User ID (already existing in the device). </param>
        /// <param name="accessType"> Type of access to be allowed for the user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public UserAccessRight(ResourceIdentifier userId, ShareAccessType accessType)
        {
            if (userId == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            UserId = userId;
            AccessType = accessType;
        }

        /// <summary> Initializes a new instance of <see cref="UserAccessRight"/>. </summary>
        /// <param name="userId"> User ID (already existing in the device). </param>
        /// <param name="accessType"> Type of access to be allowed for the user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserAccessRight(ResourceIdentifier userId, ShareAccessType accessType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserId = userId;
            AccessType = accessType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UserAccessRight"/> for deserialization. </summary>
        internal UserAccessRight()
        {
        }

        /// <summary> User ID (already existing in the device). </summary>
        public ResourceIdentifier UserId { get; set; }
        /// <summary> Type of access to be allowed for the user. </summary>
        public ShareAccessType AccessType { get; set; }
    }
}
