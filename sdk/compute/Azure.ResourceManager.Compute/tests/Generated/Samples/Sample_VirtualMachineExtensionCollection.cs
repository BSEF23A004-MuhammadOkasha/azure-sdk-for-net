// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_VirtualMachineExtensionCollection
    {
        // VirtualMachineExtensions_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VirtualMachineExtensionsCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineExamples/VirtualMachineExtensions_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineExtensions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string vmName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineResourceId = Compute.VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName);
            Compute.VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // get the collection of this VirtualMachineExtensionResource
            Compute.VirtualMachineExtensionCollection collection = virtualMachine.GetVirtualMachineExtensions();

            // invoke the operation
            string vmExtensionName = "aaaaaaaaaaaaa";
            Compute.VirtualMachineExtensionData data = new VirtualMachineExtensionData(new AzureLocation("westus"))
            {
                ForceUpdateTag = "a",
                Publisher = "extPublisher",
                ExtensionType = "extType",
                TypeHandlerVersion = "1.2",
                AutoUpgradeMinorVersion = true,
                EnableAutomaticUpgrade = true,
                Settings = BinaryData.FromObjectAsJson(new
                {
                }),
                ProtectedSettings = BinaryData.FromObjectAsJson(new
                {
                }),
                InstanceView = new VirtualMachineExtensionInstanceView()
                {
                    Name = "aaaaaaaaaaaaaaaaa",
                    VirtualMachineExtensionInstanceViewType = "aaaaaaaaa",
                    TypeHandlerVersion = "aaaaaaaaaaaaaaaaaaaaaaaaaa",
                    Substatuses =
{
new InstanceViewStatus()
{
Code = "aaaaaaaaaaaaaaaaaaaaaaa",
Level = ComputeStatusLevelType.Info,
DisplayStatus = "aaaaaa",
Message = "a",
Time = DateTimeOffset.Parse("2021-11-30T12:58:26.522Z"),
}
},
                    Statuses =
{
new InstanceViewStatus()
{
Code = "aaaaaaaaaaaaaaaaaaaaaaa",
Level = ComputeStatusLevelType.Info,
DisplayStatus = "aaaaaa",
Message = "a",
Time = DateTimeOffset.Parse("2021-11-30T12:58:26.522Z"),
}
},
                },
                SuppressFailures = true,
                Tags =
{
["key9183"] = "aa",
},
            };
            ArmOperation<Compute.VirtualMachineExtensionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmExtensionName, data);
            Compute.VirtualMachineExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineExtensions_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VirtualMachineExtensionsCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineExamples/VirtualMachineExtensions_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineExtensions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string vmName = "aaaa";
            ResourceIdentifier virtualMachineResourceId = Compute.VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName);
            Compute.VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // get the collection of this VirtualMachineExtensionResource
            Compute.VirtualMachineExtensionCollection collection = virtualMachine.GetVirtualMachineExtensions();

            // invoke the operation
            string vmExtensionName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            Compute.VirtualMachineExtensionData data = new VirtualMachineExtensionData(new AzureLocation("westus"));
            ArmOperation<Compute.VirtualMachineExtensionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmExtensionName, data);
            Compute.VirtualMachineExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineExtensions_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualMachineExtensionsGetMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineExamples/VirtualMachineExtensions_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string vmName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineResourceId = Compute.VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName);
            Compute.VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // get the collection of this VirtualMachineExtensionResource
            Compute.VirtualMachineExtensionCollection collection = virtualMachine.GetVirtualMachineExtensions();

            // invoke the operation
            string vmExtensionName = "aaaaaaa";
            string expand = "aaaaaa";
            Compute.VirtualMachineExtensionResource result = await collection.GetAsync(vmExtensionName, expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineExtensions_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualMachineExtensionsGetMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineExamples/VirtualMachineExtensions_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string vmName = "a";
            ResourceIdentifier virtualMachineResourceId = Compute.VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName);
            Compute.VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // get the collection of this VirtualMachineExtensionResource
            Compute.VirtualMachineExtensionCollection collection = virtualMachine.GetVirtualMachineExtensions();

            // invoke the operation
            string vmExtensionName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Compute.VirtualMachineExtensionResource result = await collection.GetAsync(vmExtensionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineExtensions_List_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VirtualMachineExtensionsListMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineExamples/VirtualMachineExtensions_List_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineExtensions_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string vmName = "aaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineResourceId = Compute.VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName);
            Compute.VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // get the collection of this VirtualMachineExtensionResource
            Compute.VirtualMachineExtensionCollection collection = virtualMachine.GetVirtualMachineExtensions();

            // invoke the operation and iterate over the result
            string expand = "aaaaaaaaaaaaaaaaa";
            await foreach (Compute.VirtualMachineExtensionResource item in collection.GetAllAsync(expand: expand))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.VirtualMachineExtensionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VirtualMachineExtensions_List_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VirtualMachineExtensionsListMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineExamples/VirtualMachineExtensions_List_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineExtensions_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string vmName = "aaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineResourceId = Compute.VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName);
            Compute.VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // get the collection of this VirtualMachineExtensionResource
            Compute.VirtualMachineExtensionCollection collection = virtualMachine.GetVirtualMachineExtensions();

            // invoke the operation and iterate over the result
            await foreach (Compute.VirtualMachineExtensionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.VirtualMachineExtensionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
