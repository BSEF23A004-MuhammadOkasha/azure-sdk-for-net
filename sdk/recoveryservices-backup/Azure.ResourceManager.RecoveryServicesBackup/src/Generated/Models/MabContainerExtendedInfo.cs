// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information of the container. </summary>
    public partial class MabContainerExtendedInfo
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

        /// <summary> Initializes a new instance of <see cref="MabContainerExtendedInfo"/>. </summary>
        public MabContainerExtendedInfo()
        {
            BackupItems = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MabContainerExtendedInfo"/>. </summary>
        /// <param name="lastRefreshedOn"> Time stamp when this container was refreshed. </param>
        /// <param name="backupItemType"> Type of backup items associated with this container. </param>
        /// <param name="backupItems"> List of backup items associated with this container. </param>
        /// <param name="policyName"> Backup policy associated with this container. </param>
        /// <param name="lastBackupStatus"> Latest backup status of this container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MabContainerExtendedInfo(DateTimeOffset? lastRefreshedOn, BackupItemType? backupItemType, IList<string> backupItems, string policyName, string lastBackupStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LastRefreshedOn = lastRefreshedOn;
            BackupItemType = backupItemType;
            BackupItems = backupItems;
            PolicyName = policyName;
            LastBackupStatus = lastBackupStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Time stamp when this container was refreshed. </summary>
        public DateTimeOffset? LastRefreshedOn { get; set; }
        /// <summary> Type of backup items associated with this container. </summary>
        public BackupItemType? BackupItemType { get; set; }
        /// <summary> List of backup items associated with this container. </summary>
        public IList<string> BackupItems { get; }
        /// <summary> Backup policy associated with this container. </summary>
        public string PolicyName { get; set; }
        /// <summary> Latest backup status of this container. </summary>
        public string LastBackupStatus { get; set; }
    }
}
