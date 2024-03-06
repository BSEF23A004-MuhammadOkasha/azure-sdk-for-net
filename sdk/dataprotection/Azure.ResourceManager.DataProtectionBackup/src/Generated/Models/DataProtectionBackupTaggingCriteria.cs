// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataProtectionBackup;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Tagging criteria. </summary>
    public partial class DataProtectionBackupTaggingCriteria
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

        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupTaggingCriteria"/>. </summary>
        /// <param name="isDefault"> Specifies if tag is default. </param>
        /// <param name="taggingPriority"> Retention Tag priority. </param>
        /// <param name="tagInfo"> Retention tag information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tagInfo"/> is null. </exception>
        public DataProtectionBackupTaggingCriteria(bool isDefault, long taggingPriority, DataProtectionBackupRetentionTag tagInfo)
        {
            if (tagInfo == null)
            {
                throw new ArgumentNullException(nameof(tagInfo));
            }

            Criteria = new ChangeTrackingList<DataProtectionBackupCriteria>();
            IsDefault = isDefault;
            TaggingPriority = taggingPriority;
            TagInfo = tagInfo;
        }

        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupTaggingCriteria"/>. </summary>
        /// <param name="criteria">
        /// Criteria which decides whether the tag can be applied to a triggered backup.
        /// Please note <see cref="DataProtectionBackupCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ScheduleBasedBackupCriteria"/>.
        /// </param>
        /// <param name="isDefault"> Specifies if tag is default. </param>
        /// <param name="taggingPriority"> Retention Tag priority. </param>
        /// <param name="tagInfo"> Retention tag information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataProtectionBackupTaggingCriteria(IList<DataProtectionBackupCriteria> criteria, bool isDefault, long taggingPriority, DataProtectionBackupRetentionTag tagInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Criteria = criteria;
            IsDefault = isDefault;
            TaggingPriority = taggingPriority;
            TagInfo = tagInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupTaggingCriteria"/> for deserialization. </summary>
        internal DataProtectionBackupTaggingCriteria()
        {
        }

        /// <summary>
        /// Criteria which decides whether the tag can be applied to a triggered backup.
        /// Please note <see cref="DataProtectionBackupCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ScheduleBasedBackupCriteria"/>.
        /// </summary>
        public IList<DataProtectionBackupCriteria> Criteria { get; }
        /// <summary> Specifies if tag is default. </summary>
        public bool IsDefault { get; set; }
        /// <summary> Retention Tag priority. </summary>
        public long TaggingPriority { get; set; }
        /// <summary> Retention tag information. </summary>
        public DataProtectionBackupRetentionTag TagInfo { get; set; }
    }
}
