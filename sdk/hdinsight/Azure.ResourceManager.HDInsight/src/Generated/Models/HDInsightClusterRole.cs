// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// Describes a role on the cluster.
    /// Serialized Name: Role
    /// </summary>
    public partial class HDInsightClusterRole
    {
        /// <summary> Initializes a new instance of HDInsightClusterRole. </summary>
        public HDInsightClusterRole()
        {
            DataDisksGroups = new ChangeTrackingList<HDInsightClusterDataDisksGroup>();
            ScriptActions = new ChangeTrackingList<ScriptAction>();
        }

        /// <summary> Initializes a new instance of HDInsightClusterRole. </summary>
        /// <param name="name">
        /// The name of the role.
        /// Serialized Name: Role.name
        /// </param>
        /// <param name="minInstanceCount">
        /// The minimum instance count of the cluster.
        /// Serialized Name: Role.minInstanceCount
        /// </param>
        /// <param name="targetInstanceCount">
        /// The instance count of the cluster.
        /// Serialized Name: Role.targetInstanceCount
        /// </param>
        /// <param name="vmGroupName">
        /// The name of the virtual machine group.
        /// Serialized Name: Role.VMGroupName
        /// </param>
        /// <param name="autoScaleConfiguration">
        /// The autoscale configurations.
        /// Serialized Name: Role.autoscale
        /// </param>
        /// <param name="hardwareProfile">
        /// The hardware profile.
        /// Serialized Name: Role.hardwareProfile
        /// </param>
        /// <param name="osProfile">
        /// The operating system profile.
        /// Serialized Name: Role.osProfile
        /// </param>
        /// <param name="virtualNetworkProfile">
        /// The virtual network profile.
        /// Serialized Name: Role.virtualNetworkProfile
        /// </param>
        /// <param name="dataDisksGroups">
        /// The data disks groups for the role.
        /// Serialized Name: Role.dataDisksGroups
        /// </param>
        /// <param name="scriptActions">
        /// The list of script actions on the role.
        /// Serialized Name: Role.scriptActions
        /// </param>
        /// <param name="encryptDataDisks">
        /// Indicates whether encrypt the data disks.
        /// Serialized Name: Role.encryptDataDisks
        /// </param>
        internal HDInsightClusterRole(string name, int? minInstanceCount, int? targetInstanceCount, string vmGroupName, HDInsightAutoScaleConfiguration autoScaleConfiguration, HardwareProfile hardwareProfile, OSProfile osProfile, VirtualNetworkProfile virtualNetworkProfile, IList<HDInsightClusterDataDisksGroup> dataDisksGroups, IList<ScriptAction> scriptActions, bool? encryptDataDisks)
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
        }

        /// <summary>
        /// The name of the role.
        /// Serialized Name: Role.name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The minimum instance count of the cluster.
        /// Serialized Name: Role.minInstanceCount
        /// </summary>
        public int? MinInstanceCount { get; set; }
        /// <summary>
        /// The instance count of the cluster.
        /// Serialized Name: Role.targetInstanceCount
        /// </summary>
        public int? TargetInstanceCount { get; set; }
        /// <summary>
        /// The name of the virtual machine group.
        /// Serialized Name: Role.VMGroupName
        /// </summary>
        public string VmGroupName { get; set; }
        /// <summary>
        /// The autoscale configurations.
        /// Serialized Name: Role.autoscale
        /// </summary>
        public HDInsightAutoScaleConfiguration AutoScaleConfiguration { get; set; }
        /// <summary>
        /// The hardware profile.
        /// Serialized Name: Role.hardwareProfile
        /// </summary>
        internal HardwareProfile HardwareProfile { get; set; }
        /// <summary>
        /// The size of the VM
        /// Serialized Name: HardwareProfile.vmSize
        /// </summary>
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

        /// <summary>
        /// The operating system profile.
        /// Serialized Name: Role.osProfile
        /// </summary>
        internal OSProfile OSProfile { get; set; }
        /// <summary>
        /// The Linux OS profile.
        /// Serialized Name: OsProfile.linuxOperatingSystemProfile
        /// </summary>
        public LinuxOperatingSystemProfile OSLinuxOperatingSystemProfile
        {
            get => OSProfile is null ? default : OSProfile.LinuxOperatingSystemProfile;
            set
            {
                if (OSProfile is null)
                    OSProfile = new OSProfile();
                OSProfile.LinuxOperatingSystemProfile = value;
            }
        }

        /// <summary>
        /// The virtual network profile.
        /// Serialized Name: Role.virtualNetworkProfile
        /// </summary>
        public VirtualNetworkProfile VirtualNetworkProfile { get; set; }
        /// <summary>
        /// The data disks groups for the role.
        /// Serialized Name: Role.dataDisksGroups
        /// </summary>
        public IList<HDInsightClusterDataDisksGroup> DataDisksGroups { get; }
        /// <summary>
        /// The list of script actions on the role.
        /// Serialized Name: Role.scriptActions
        /// </summary>
        public IList<ScriptAction> ScriptActions { get; }
        /// <summary>
        /// Indicates whether encrypt the data disks.
        /// Serialized Name: Role.encryptDataDisks
        /// </summary>
        public bool? EncryptDataDisks { get; set; }
    }
}
