// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Defender CSPM CIEM AWS OIDC (open id connect) configuration. </summary>
    public partial class DefenderCspmAwsOfferingCiemOidc
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

        /// <summary> Initializes a new instance of <see cref="DefenderCspmAwsOfferingCiemOidc"/>. </summary>
        public DefenderCspmAwsOfferingCiemOidc()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderCspmAwsOfferingCiemOidc"/>. </summary>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS for CIEM oidc connection. </param>
        /// <param name="azureActiveDirectoryAppName"> the azure active directory app name used of authenticating against AWS. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DefenderCspmAwsOfferingCiemOidc(string cloudRoleArn, string azureActiveDirectoryAppName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CloudRoleArn = cloudRoleArn;
            AzureActiveDirectoryAppName = azureActiveDirectoryAppName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The cloud role ARN in AWS for CIEM oidc connection. </summary>
        public string CloudRoleArn { get; set; }
        /// <summary> the azure active directory app name used of authenticating against AWS. </summary>
        public string AzureActiveDirectoryAppName { get; set; }
    }
}
