// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Describes a role on the cluster. </summary>
    public partial class HDInsightClusterRole
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

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterRole"/>. </summary>
        public HDInsightClusterRole()
        {
            DataDisksGroups = new ChangeTrackingList<HDInsightClusterDataDiskGroup>();
            ScriptActions = new ChangeTrackingList<ScriptAction>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterRole"/>. </summary>
        /// <param name="name"> The name of the role. </param>
        /// <param name="minInstanceCount"> The minimum instance count of the cluster. </param>
        /// <param name="targetInstanceCount"> The instance count of the cluster. </param>
        /// <param name="vmGroupName"> The name of the virtual machine group. </param>
        /// <param name="autoScaleConfiguration"> The autoscale configurations. </param>
        /// <param name="hardwareProfile"> The hardware profile. </param>
        /// <param name="osProfile"> The operating system profile. </param>
        /// <param name="virtualNetworkProfile"> The virtual network profile. </param>
        /// <param name="dataDisksGroups"> The data disks groups for the role. </param>
        /// <param name="scriptActions"> The list of script actions on the role. </param>
        /// <param name="encryptDataDisks"> Indicates whether encrypt the data disks. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterRole(string name, int? minInstanceCount, int? targetInstanceCount, string vmGroupName, HDInsightAutoScaleConfiguration autoScaleConfiguration, HardwareProfile hardwareProfile, OSProfile osProfile, HDInsightVirtualNetworkProfile virtualNetworkProfile, IList<HDInsightClusterDataDiskGroup> dataDisksGroups, IList<ScriptAction> scriptActions, bool? encryptDataDisks, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            MinInstanceCount = minInstanceCount;
            TargetInstanceCount = targetInstanceCount;
            VmGroupName = vmGroupName;
            AutoScaleConfiguration = autoScaleConfiguration;
            HardwareProfile = hardwareProfile;
            OSProfile = osProfile;
            VirtualNetworkProfile = virtualNetworkProfile;
            DataDisksGroups = dataDisksGroups;
            ScriptActions = scriptActions;
            EncryptDataDisks = encryptDataDisks;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the role. </summary>
        public string Name { get; set; }
        /// <summary> The minimum instance count of the cluster. </summary>
        public int? MinInstanceCount { get; set; }
        /// <summary> The instance count of the cluster. </summary>
        public int? TargetInstanceCount { get; set; }
        /// <summary> The name of the virtual machine group. </summary>
        public string VmGroupName { get; set; }
        /// <summary> The autoscale configurations. </summary>
        public HDInsightAutoScaleConfiguration AutoScaleConfiguration { get; set; }
        /// <summary> The hardware profile. </summary>
        internal HardwareProfile HardwareProfile { get; set; }
        /// <summary> The size of the VM. </summary>
        public string HardwareVmSize
        {
            get => HardwareProfile is null ? default : HardwareProfile.VmSize;
            set
            {
                if (HardwareProfile is null)
                    HardwareProfile = new HardwareProfile();
                HardwareProfile.VmSize = value;
            }
        }

        /// <summary> The operating system profile. </summary>
        internal OSProfile OSProfile { get; set; }
        /// <summary> The Linux OS profile. </summary>
        public HDInsightLinuxOSProfile OSLinuxProfile
        {
            get => OSProfile is null ? default : OSProfile.LinuxProfile;
            set
            {
                if (OSProfile is null)
                    OSProfile = new OSProfile();
                OSProfile.LinuxProfile = value;
            }
        }

        /// <summary> The virtual network profile. </summary>
        public HDInsightVirtualNetworkProfile VirtualNetworkProfile { get; set; }
        /// <summary> The data disks groups for the role. </summary>
        public IList<HDInsightClusterDataDiskGroup> DataDisksGroups { get; }
        /// <summary> The list of script actions on the role. </summary>
        public IList<ScriptAction> ScriptActions { get; }
        /// <summary> Indicates whether encrypt the data disks. </summary>
        public bool? EncryptDataDisks { get; set; }
    }
}
