// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the Security profile settings for the virtual machine or virtual machine scale set. </summary>
    public partial class SecurityProfile
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

        /// <summary> Initializes a new instance of <see cref="SecurityProfile"/>. </summary>
        public SecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityProfile"/>. </summary>
        /// <param name="uefiSettings"> Specifies the security settings like secure boot and vTPM used while creating the virtual machine. Minimum api-version: 2020-12-01. </param>
        /// <param name="encryptionAtHost"> This property can be used by user in the request to enable or disable the Host Encryption for the virtual machine or virtual machine scale set. This will enable the encryption for all the disks including Resource/Temp disk at host itself. The default behavior is: The Encryption at host will be disabled unless this property is set to true for the resource. </param>
        /// <param name="securityType"> Specifies the SecurityType of the virtual machine. It has to be set to any specified value to enable UefiSettings. The default behavior is: UefiSettings will not be enabled unless this property is set. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityProfile(UefiSettings uefiSettings, bool? encryptionAtHost, SecurityType? securityType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UefiSettings = uefiSettings;
            EncryptionAtHost = encryptionAtHost;
            SecurityType = securityType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the security settings like secure boot and vTPM used while creating the virtual machine. Minimum api-version: 2020-12-01. </summary>
        public UefiSettings UefiSettings { get; set; }
        /// <summary> This property can be used by user in the request to enable or disable the Host Encryption for the virtual machine or virtual machine scale set. This will enable the encryption for all the disks including Resource/Temp disk at host itself. The default behavior is: The Encryption at host will be disabled unless this property is set to true for the resource. </summary>
        public bool? EncryptionAtHost { get; set; }
        /// <summary> Specifies the SecurityType of the virtual machine. It has to be set to any specified value to enable UefiSettings. The default behavior is: UefiSettings will not be enabled unless this property is set. </summary>
        public SecurityType? SecurityType { get; set; }
    }
}
