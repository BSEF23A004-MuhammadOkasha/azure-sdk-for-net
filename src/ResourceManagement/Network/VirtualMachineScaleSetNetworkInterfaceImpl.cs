﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Network.Fluent
{
    using System;
    using System.Collections.Generic;
    using Models;
    using ResourceManager.Fluent.Core;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Linq;

    internal partial class VirtualMachineScaleSetNetworkInterfaceImpl :
        ResourceBase<IVirtualMachineScaleSetNetworkInterface,
            NetworkInterfaceInner,
            VirtualMachineScaleSetNetworkInterfaceImpl,
            object,
            object,
            object>,
        IVirtualMachineScaleSetNetworkInterface
    {
        private INetworkManager networkManager;
        private string scaleSetName;
        private string resourceGroupName;

        internal INetworkManager Manager()
        {
            return networkManager;
        }

        internal VirtualMachineScaleSetNetworkInterfaceImpl(
            string name,
            string scaleSetName,
            string resourceGroupName,
            NetworkInterfaceInner innerObject,
            INetworkManager networkManager) : base(name, innerObject)
        {
            this.scaleSetName = scaleSetName;
            this.resourceGroupName = resourceGroupName;
            this.networkManager = networkManager;
        }

        ///GENMHASH:FC029B56426CB2BA739B4DBD40ECED47:38C266FAF73EE2B36653A8316233F345
        public bool IsAcceleratedNetworkingEnabled()
        {
            return (Inner.EnableAcceleratedNetworking.HasValue) ? Inner.EnableAcceleratedNetworking.Value : false;
        }

        internal bool IsIPForwardingEnabled()
        {
            if (Inner.EnableIPForwarding.HasValue)
            {
                return Inner.EnableIPForwarding.Value;
            }
            return false;
        }

        internal string MacAddress()
        {
            return Inner.MacAddress;
        }

        internal string InternalDnsNameLabel()
        {
            if (Inner.DnsSettings == null)
            {
                return null;
            }
            return Inner.DnsSettings.InternalDnsNameLabel;
        }

        internal string InternalFqdn()
        {
            if (Inner.DnsSettings == null)
            {
                return null;
            }
            return Inner.DnsSettings.InternalFqdn;
        }

        internal string InternalDomainNameSuffix()
        {
            if (Inner.DnsSettings == null)
            {
                return null;
            }
            return Inner.DnsSettings.InternalDomainNameSuffix;
        }

        internal IReadOnlyList<string> DnsServers()
        {
            if (Inner.DnsSettings == null || Inner.DnsSettings.DnsServers == null)
            {
                return new List<string>();
            }
            return Inner.DnsSettings.DnsServers?.ToList();
        }

        internal IReadOnlyList<string> AppliedDnsServers()
        {
            if (Inner.DnsSettings == null || Inner.DnsSettings.AppliedDnsServers == null)
            {
                return new List<string>();
            }
            return Inner.DnsSettings.AppliedDnsServers?.ToList();
        }

        internal string PrimaryPrivateIP()
        {
            IVirtualMachineScaleSetNicIPConfiguration primaryIPConfig = this.PrimaryIPConfiguration();
            if (primaryIPConfig == null)
            {
                return null;
            }
            return primaryIPConfig.PrivateIPAddress;
        }

        internal IPAllocationMethod PrimaryPrivateIPAllocationMethod()
        {
            IVirtualMachineScaleSetNicIPConfiguration primaryIPConfig = this.PrimaryIPConfiguration();
            if (primaryIPConfig == null)
            {
                return null;
            }
            return primaryIPConfig.PrivateIPAllocationMethod;
        }

        internal IReadOnlyDictionary<string, IVirtualMachineScaleSetNicIPConfiguration> IPConfigurations()
        {
            var inners = Inner.IpConfigurations;
            if (inners == null || inners.Count == 0)
            {
                return new Dictionary<string, IVirtualMachineScaleSetNicIPConfiguration>(); 
            }
            Dictionary<string, IVirtualMachineScaleSetNicIPConfiguration> nicIPConfigurations = new Dictionary<string, IVirtualMachineScaleSetNicIPConfiguration>();
            foreach (NetworkInterfaceIPConfigurationInner inner in inners)
            {
                VirtualMachineScaleSetNicIPConfigurationImpl nicIPConfiguration = new VirtualMachineScaleSetNicIPConfigurationImpl(inner, this, this.networkManager);
                nicIPConfigurations.Add(nicIPConfiguration.Name(), nicIPConfiguration);
            }
            return nicIPConfigurations;
        }

        internal IVirtualMachineScaleSetNicIPConfiguration PrimaryIPConfiguration()
        {
            foreach (var ipConfiguration in this.IPConfigurations().Values)
            {
                if (ipConfiguration.IsPrimary)
                {
                    return ipConfiguration;
                }
            }
            return null;
        }

        internal string NetworkSecurityGroupId()
        {
            if (Inner.NetworkSecurityGroup == null)
            {
                return null;
            }
            return Inner.NetworkSecurityGroup.Id;
        }

        internal INetworkSecurityGroup GetNetworkSecurityGroup()
        {
            var nsgId = this.NetworkSecurityGroupId();
            if (nsgId == null)
            {
                return null;
            }
            return networkManager
                .NetworkSecurityGroups
                .GetByResourceGroup(ResourceUtils.GroupFromResourceId(nsgId),
                    ResourceUtils.NameFromResourceId(nsgId));
        }

        internal string VirtualMachineId()
        {
            if (Inner.VirtualMachine == null)
            {
                return null;
            }
            return Inner.VirtualMachine.Id;
        }

        public override Task<IVirtualMachineScaleSetNetworkInterface> CreateResourceAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            // VMSS NIC is a read-only resource hence this operation is not supported.
            throw new NotSupportedException();
        }

        protected override async Task<NetworkInterfaceInner> GetInnerAsync(CancellationToken cancellationToken)
        {
            return await Manager().Inner.NetworkInterfaces.GetVirtualMachineScaleSetNetworkInterfaceAsync(
                resourceGroupName,
                scaleSetName,
                ResourceUtils.NameFromResourceId(VirtualMachineId()),
                Name, cancellationToken: cancellationToken);
        }

    }
}
