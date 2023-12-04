// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> IaaS VM workload specific backup copy. </summary>
    public partial class IaasVmRecoveryPoint : BackupGenericRecoveryPoint
    {
        /// <summary> Initializes a new instance of <see cref="IaasVmRecoveryPoint"/>. </summary>
        public IaasVmRecoveryPoint()
        {
            RecoveryPointTierDetails = new ChangeTrackingList<RecoveryPointTierInformationV2>();
            Zones = new ChangeTrackingList<string>();
            RecoveryPointMoveReadinessInfo = new ChangeTrackingDictionary<string, RecoveryPointMoveReadinessInfo>();
            ObjectType = "IaasVMRecoveryPoint";
        }

        /// <summary> Initializes a new instance of <see cref="IaasVmRecoveryPoint"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryPointType"> Type of the backup copy. </param>
        /// <param name="recoveryPointOn"> Time at which this backup copy was created. </param>
        /// <param name="recoveryPointAdditionalInfo"> Additional information associated with this backup copy. </param>
        /// <param name="sourceVmStorageType"> Storage type of the VM whose backup copy is created. </param>
        /// <param name="isSourceVmEncrypted"> Identifies whether the VM was encrypted when the backup copy is created. </param>
        /// <param name="keyAndSecret"> Required details for recovering an encrypted VM. Applicable only when IsSourceVMEncrypted is true. </param>
        /// <param name="isInstantIlrSessionActive"> Is the session to recover items from this backup copy still active. </param>
        /// <param name="recoveryPointTierDetails"> Recovery point tier information. </param>
        /// <param name="isManagedVirtualMachine"> Whether VM is with Managed Disks. </param>
        /// <param name="virtualMachineSize"> Virtual Machine Size. </param>
        /// <param name="originalStorageAccountOption"> Original Storage Account Option. </param>
        /// <param name="osType"> OS type. </param>
        /// <param name="recoveryPointDiskConfiguration"> Disk configuration. </param>
        /// <param name="zones"> Identifies the zone of the VM at the time of backup. Applicable only for zone-pinned Vms. </param>
        /// <param name="recoveryPointMoveReadinessInfo"> Eligibility of RP to be moved to another tier. </param>
        /// <param name="securityType"> Security Type of the Disk. </param>
        /// <param name="recoveryPointProperties"> Properties of Recovery Point. </param>
        /// <param name="isPrivateAccessEnabledOnAnyDisk"> This flag denotes if any of the disks in the VM are using Private access network setting. </param>
        internal IaasVmRecoveryPoint(string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, string recoveryPointType, DateTimeOffset? recoveryPointOn, string recoveryPointAdditionalInfo, string sourceVmStorageType, bool? isSourceVmEncrypted, KeyAndSecretDetails keyAndSecret, bool? isInstantIlrSessionActive, IList<RecoveryPointTierInformationV2> recoveryPointTierDetails, bool? isManagedVirtualMachine, string virtualMachineSize, bool? originalStorageAccountOption, string osType, RecoveryPointDiskConfiguration recoveryPointDiskConfiguration, IList<string> zones, IDictionary<string, RecoveryPointMoveReadinessInfo> recoveryPointMoveReadinessInfo, string securityType, RecoveryPointProperties recoveryPointProperties, bool? isPrivateAccessEnabledOnAnyDisk) : base(objectType, serializedAdditionalRawData)
        {
            RecoveryPointType = recoveryPointType;
            RecoveryPointOn = recoveryPointOn;
            RecoveryPointAdditionalInfo = recoveryPointAdditionalInfo;
            SourceVmStorageType = sourceVmStorageType;
            IsSourceVmEncrypted = isSourceVmEncrypted;
            KeyAndSecret = keyAndSecret;
            IsInstantIlrSessionActive = isInstantIlrSessionActive;
            RecoveryPointTierDetails = recoveryPointTierDetails;
            IsManagedVirtualMachine = isManagedVirtualMachine;
            VirtualMachineSize = virtualMachineSize;
            OriginalStorageAccountOption = originalStorageAccountOption;
            OSType = osType;
            RecoveryPointDiskConfiguration = recoveryPointDiskConfiguration;
            Zones = zones;
            RecoveryPointMoveReadinessInfo = recoveryPointMoveReadinessInfo;
            SecurityType = securityType;
            RecoveryPointProperties = recoveryPointProperties;
            IsPrivateAccessEnabledOnAnyDisk = isPrivateAccessEnabledOnAnyDisk;
            ObjectType = objectType ?? "IaasVMRecoveryPoint";
        }

        /// <summary> Type of the backup copy. </summary>
        public string RecoveryPointType { get; set; }
        /// <summary> Time at which this backup copy was created. </summary>
        public DateTimeOffset? RecoveryPointOn { get; set; }
        /// <summary> Additional information associated with this backup copy. </summary>
        public string RecoveryPointAdditionalInfo { get; set; }
        /// <summary> Storage type of the VM whose backup copy is created. </summary>
        public string SourceVmStorageType { get; set; }
        /// <summary> Identifies whether the VM was encrypted when the backup copy is created. </summary>
        public bool? IsSourceVmEncrypted { get; set; }
        /// <summary> Required details for recovering an encrypted VM. Applicable only when IsSourceVMEncrypted is true. </summary>
        public KeyAndSecretDetails KeyAndSecret { get; set; }
        /// <summary> Is the session to recover items from this backup copy still active. </summary>
        public bool? IsInstantIlrSessionActive { get; set; }
        /// <summary> Recovery point tier information. </summary>
        public IList<RecoveryPointTierInformationV2> RecoveryPointTierDetails { get; }
        /// <summary> Whether VM is with Managed Disks. </summary>
        public bool? IsManagedVirtualMachine { get; set; }
        /// <summary> Virtual Machine Size. </summary>
        public string VirtualMachineSize { get; set; }
        /// <summary> Original Storage Account Option. </summary>
        public bool? OriginalStorageAccountOption { get; set; }
        /// <summary> OS type. </summary>
        public string OSType { get; set; }
        /// <summary> Disk configuration. </summary>
        public RecoveryPointDiskConfiguration RecoveryPointDiskConfiguration { get; set; }
        /// <summary> Identifies the zone of the VM at the time of backup. Applicable only for zone-pinned Vms. </summary>
        public IList<string> Zones { get; }
        /// <summary> Eligibility of RP to be moved to another tier. </summary>
        public IDictionary<string, RecoveryPointMoveReadinessInfo> RecoveryPointMoveReadinessInfo { get; }
        /// <summary> Security Type of the Disk. </summary>
        public string SecurityType { get; set; }
        /// <summary> Properties of Recovery Point. </summary>
        public RecoveryPointProperties RecoveryPointProperties { get; set; }
        /// <summary> This flag denotes if any of the disks in the VM are using Private access network setting. </summary>
        public bool? IsPrivateAccessEnabledOnAnyDisk { get; set; }
    }
}
