// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Settings for the operating system disk of the virtual machine. </summary>
    internal partial class OSDisk
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

        /// <summary> Initializes a new instance of <see cref="OSDisk"/>. </summary>
        public OSDisk()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OSDisk"/>. </summary>
        /// <param name="ephemeralOSDiskSettings"> Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OSDisk(DiffDiskSettings ephemeralOSDiskSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EphemeralOSDiskSettings = ephemeralOSDiskSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine. </summary>
        internal DiffDiskSettings EphemeralOSDiskSettings { get; set; }
        /// <summary> This property can be used by user in the request to choose which location the operating system should be in. e.g., cache disk space for Ephemeral OS disk provisioning. For more information on Ephemeral OS disk size requirements, please refer to Ephemeral OS disk size requirements for Windows VMs at https://docs.microsoft.com/en-us/azure/virtual-machines/windows/ephemeral-os-disks#size-requirements and Linux VMs at https://docs.microsoft.com/en-us/azure/virtual-machines/linux/ephemeral-os-disks#size-requirements. </summary>
        public BatchDiffDiskPlacement? EphemeralOSDiskPlacement
        {
            get => EphemeralOSDiskSettings is null ? default : EphemeralOSDiskSettings.Placement;
            set
            {
                if (EphemeralOSDiskSettings is null)
                    EphemeralOSDiskSettings = new DiffDiskSettings();
                EphemeralOSDiskSettings.Placement = value;
            }
        }
    }
}
