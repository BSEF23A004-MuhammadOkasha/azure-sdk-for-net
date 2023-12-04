// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> configuration for Microsoft Defender for Server VM scanning. </summary>
    public partial class DefenderCspmAwsOfferingVmScannersConfiguration
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

        /// <summary> Initializes a new instance of <see cref="DefenderCspmAwsOfferingVmScannersConfiguration"/>. </summary>
        public DefenderCspmAwsOfferingVmScannersConfiguration()
        {
            ExclusionTags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DefenderCspmAwsOfferingVmScannersConfiguration"/>. </summary>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS for this feature. </param>
        /// <param name="scanningMode"> The scanning mode for the vm scan. </param>
        /// <param name="exclusionTags"> VM tags that indicates that VM should not be scanned. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DefenderCspmAwsOfferingVmScannersConfiguration(string cloudRoleArn, DefenderForServersScanningMode? scanningMode, IDictionary<string, string> exclusionTags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CloudRoleArn = cloudRoleArn;
            ScanningMode = scanningMode;
            ExclusionTags = exclusionTags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The cloud role ARN in AWS for this feature. </summary>
        public string CloudRoleArn { get; set; }
        /// <summary> The scanning mode for the vm scan. </summary>
        public DefenderForServersScanningMode? ScanningMode { get; set; }
        /// <summary> VM tags that indicates that VM should not be scanned. </summary>
        public IDictionary<string, string> ExclusionTags { get; }
    }
}
