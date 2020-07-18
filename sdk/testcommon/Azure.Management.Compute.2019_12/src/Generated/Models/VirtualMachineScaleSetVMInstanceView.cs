// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> The instance view of a virtual machine scale set VM. </summary>
    public partial class VirtualMachineScaleSetVMInstanceView
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMInstanceView. </summary>
        public VirtualMachineScaleSetVMInstanceView()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMInstanceView. </summary>
        /// <param name="platformUpdateDomain"> The Update Domain count. </param>
        /// <param name="platformFaultDomain"> The Fault Domain count. </param>
        /// <param name="rdpThumbPrint"> The Remote desktop certificate thumbprint. </param>
        /// <param name="vmAgent"> The VM Agent running on the virtual machine. </param>
        /// <param name="maintenanceRedeployStatus"> The Maintenance Operation status on the virtual machine. </param>
        /// <param name="disks"> The disks information. </param>
        /// <param name="extensions"> The extensions information. </param>
        /// <param name="vmHealth"> The health status for the VM. </param>
        /// <param name="bootDiagnostics"> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. &lt;br&gt;&lt;br&gt; You can easily view the output of your console log. &lt;br&gt;&lt;br&gt; Azure also enables you to see a screenshot of the VM from the hypervisor. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="placementGroupId"> The placement group in which the VM is running. If the VM is deallocated it will not have a placementGroupId. </param>
        internal VirtualMachineScaleSetVMInstanceView(int? platformUpdateDomain, int? platformFaultDomain, string rdpThumbPrint, VirtualMachineAgentInstanceView vmAgent, MaintenanceRedeployStatus maintenanceRedeployStatus, IList<DiskInstanceView> disks, IList<VirtualMachineExtensionInstanceView> extensions, VirtualMachineHealthStatus vmHealth, BootDiagnosticsInstanceView bootDiagnostics, IList<InstanceViewStatus> statuses, string placementGroupId)
        {
            PlatformUpdateDomain = platformUpdateDomain;
            PlatformFaultDomain = platformFaultDomain;
            RdpThumbPrint = rdpThumbPrint;
            VmAgent = vmAgent;
            MaintenanceRedeployStatus = maintenanceRedeployStatus;
            Disks = disks;
            Extensions = extensions;
            VmHealth = vmHealth;
            BootDiagnostics = bootDiagnostics;
            Statuses = statuses;
            PlacementGroupId = placementGroupId;
        }

        /// <summary> The Update Domain count. </summary>
        public int? PlatformUpdateDomain { get; set; }
        /// <summary> The Fault Domain count. </summary>
        public int? PlatformFaultDomain { get; set; }
        /// <summary> The Remote desktop certificate thumbprint. </summary>
        public string RdpThumbPrint { get; set; }
        /// <summary> The VM Agent running on the virtual machine. </summary>
        public VirtualMachineAgentInstanceView VmAgent { get; set; }
        /// <summary> The Maintenance Operation status on the virtual machine. </summary>
        public MaintenanceRedeployStatus MaintenanceRedeployStatus { get; set; }
        /// <summary> The disks information. </summary>
        public IList<DiskInstanceView> Disks { get; set; }
        /// <summary> The extensions information. </summary>
        public IList<VirtualMachineExtensionInstanceView> Extensions { get; set; }
        /// <summary> The health status for the VM. </summary>
        public VirtualMachineHealthStatus VmHealth { get; }
        /// <summary> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. &lt;br&gt;&lt;br&gt; You can easily view the output of your console log. &lt;br&gt;&lt;br&gt; Azure also enables you to see a screenshot of the VM from the hypervisor. </summary>
        public BootDiagnosticsInstanceView BootDiagnostics { get; set; }
        /// <summary> The resource status information. </summary>
        public IList<InstanceViewStatus> Statuses { get; set; }
        /// <summary> The placement group in which the VM is running. If the VM is deallocated it will not have a placementGroupId. </summary>
        public string PlacementGroupId { get; set; }
    }
}
