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

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_VirtualMachineScaleSetExtensionCollection
    {
        // VirtualMachineScaleSetExtensions_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VirtualMachineScaleSetExtensionsCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtensions_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = Compute.VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            Compute.VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetExtensionResource
            Compute.VirtualMachineScaleSetExtensionCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetExtensions();

            // invoke the operation
            string vmssExtensionName = "aaaaaaaaaaaaaaaaaaaaa";
            Compute.VirtualMachineScaleSetExtensionData data = new VirtualMachineScaleSetExtensionData()
            {
                ForceUpdateTag = "aaaaaaaaa",
                Publisher = "{extension-Publisher}",
                ExtensionType = "{extension-Type}",
                TypeHandlerVersion = "{handler-version}",
                AutoUpgradeMinorVersion = true,
                EnableAutomaticUpgrade = true,
                Settings = BinaryData.FromObjectAsJson(new
                {
                }),
                ProtectedSettings = BinaryData.FromObjectAsJson(new
                {
                }),
                ProvisionAfterExtensions =
{
"aa"
},
                SuppressFailures = true,
            };
            ArmOperation<Compute.VirtualMachineScaleSetExtensionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmssExtensionName, data);
            Compute.VirtualMachineScaleSetExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineScaleSetExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineScaleSetExtensions_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VirtualMachineScaleSetExtensionsCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtensions_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = Compute.VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            Compute.VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetExtensionResource
            Compute.VirtualMachineScaleSetExtensionCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetExtensions();

            // invoke the operation
            string vmssExtensionName = "aaaaaaaaaaa";
            Compute.VirtualMachineScaleSetExtensionData data = new VirtualMachineScaleSetExtensionData();
            ArmOperation<Compute.VirtualMachineScaleSetExtensionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmssExtensionName, data);
            Compute.VirtualMachineScaleSetExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineScaleSetExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineScaleSetExtensions_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualMachineScaleSetExtensionsGetMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtensions_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = Compute.VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            Compute.VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetExtensionResource
            Compute.VirtualMachineScaleSetExtensionCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetExtensions();

            // invoke the operation
            string vmssExtensionName = "aaaaaaaaaaaaaaaaaaaa";
            string expand = "aaaaaaa";
            Compute.VirtualMachineScaleSetExtensionResource result = await collection.GetAsync(vmssExtensionName, expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineScaleSetExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineScaleSetExtensions_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualMachineScaleSetExtensionsGetMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtensions_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "a";
            ResourceIdentifier virtualMachineScaleSetResourceId = Compute.VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            Compute.VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetExtensionResource
            Compute.VirtualMachineScaleSetExtensionCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetExtensions();

            // invoke the operation
            string vmssExtensionName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Compute.VirtualMachineScaleSetExtensionResource result = await collection.GetAsync(vmssExtensionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineScaleSetExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineScaleSetExtensions_List_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VirtualMachineScaleSetExtensionsListMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtensions_List_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = Compute.VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            Compute.VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetExtensionResource
            Compute.VirtualMachineScaleSetExtensionCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetExtensions();

            // invoke the operation and iterate over the result
            await foreach (Compute.VirtualMachineScaleSetExtensionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.VirtualMachineScaleSetExtensionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VirtualMachineScaleSetExtensions_List_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VirtualMachineScaleSetExtensionsListMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtensions_List_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = Compute.VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            Compute.VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetExtensionResource
            Compute.VirtualMachineScaleSetExtensionCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetExtensions();

            // invoke the operation and iterate over the result
            await foreach (Compute.VirtualMachineScaleSetExtensionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.VirtualMachineScaleSetExtensionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
