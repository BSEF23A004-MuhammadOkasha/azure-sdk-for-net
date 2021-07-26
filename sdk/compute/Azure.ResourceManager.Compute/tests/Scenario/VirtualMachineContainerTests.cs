﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Tests
{
    public class VirtualMachineContainerTests : VirtualMachineTestBase
    {
        public VirtualMachineContainerTests(bool async)
            : base(async)//, RecordedTestMode.Record)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var container = await GetVirtualMachineContainerAsync();
            var vmName = Recording.GenerateAssetName("testVM-");
            var nic = await CreateBasicDependenciesOfVirtualMachineAsync();
            var input = VirtualMachineHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName, nic.Id);
            VirtualMachine virtualMachine = await container.CreateOrUpdateAsync(vmName, input);
            Assert.AreEqual(vmName, virtualMachine.Data.Name);
        }

        [TestCase]
        [RecordedTest]
        public async Task Get()
        {
            var container = await GetVirtualMachineContainerAsync();
            var vmName = Recording.GenerateAssetName("testVM-");
            var nic = await CreateBasicDependenciesOfVirtualMachineAsync();
            var input = VirtualMachineHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName, nic.Id);
            VirtualMachine vm1 = await container.CreateOrUpdateAsync(vmName, input);
            VirtualMachine vm2 = await container.GetAsync(vmName);

            VirtualMachineHelper.AssertVirtualMachine(vm1.Data, vm2.Data);
        }

        [TestCase]
        [RecordedTest]
        public async Task DoesExist()
        {
            var container = await GetVirtualMachineContainerAsync();
            var vmName = Recording.GenerateAssetName("testVM-");
            var nic = await CreateBasicDependenciesOfVirtualMachineAsync();
            var input = VirtualMachineHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName, nic.Id);
            VirtualMachine vm = await container.CreateOrUpdateAsync(vmName, input);
            Assert.IsTrue(await container.DoesExistAsync(vmName));
            Assert.IsFalse(await container.DoesExistAsync(vmName + "1"));

            Assert.ThrowsAsync<ArgumentNullException>(async () => _ = await container.DoesExistAsync(null));
        }

        [TestCase]
        [RecordedTest]
        public async Task List()
        {
            var container = await GetVirtualMachineContainerAsync();
            var vmName1 = Recording.GenerateAssetName("testVM-");
            var vmName2 = Recording.GenerateAssetName("testVM-");
            var nic1 = await CreateBasicDependenciesOfVirtualMachineAsync();
            var nic2 = await CreateBasicDependenciesOfVirtualMachineAsync();
            var input1 = VirtualMachineHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName1, nic1.Id);
            var input2 = VirtualMachineHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName2, nic2.Id);
            _ = await container.CreateOrUpdateAsync(vmName1, input1);
            _ = await container.CreateOrUpdateAsync(vmName2, input2);
            int count = 0;
            await foreach (var vm in container.ListAsync())
            {
                count++;
            }
            Assert.GreaterOrEqual(count, 2);
        }

        [TestCase]
        [RecordedTest]
        public async Task ListBySubscription()
        {
            var container = await GetVirtualMachineContainerAsync();
            var vmName1 = Recording.GenerateAssetName("testVM-");
            var vmName2 = Recording.GenerateAssetName("testVM-");
            var nic1 = await CreateBasicDependenciesOfVirtualMachineAsync();
            var nic2 = await CreateBasicDependenciesOfVirtualMachineAsync();
            var input1 = VirtualMachineHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName1, nic1.Id);
            var input2 = VirtualMachineHelper.GetBasicLinuxVirtualMachineData(DefaultLocation, vmName2, nic2.Id);
            _ = await container.CreateOrUpdateAsync(vmName1, input1);
            _ = await container.CreateOrUpdateAsync(vmName2, input2);

            VirtualMachine vm1 = null, vm2 = null;
            await foreach (var vm in DefaultSubscription.ListVirtualMachinesAsync())
            {
                if (vm.Data.Name == vmName1)
                    vm1 = vm;
                if (vm.Data.Name == vmName2)
                    vm2 = vm;
            }

            Assert.NotNull(vm1);
            Assert.NotNull(vm2);
        }
    }
}
