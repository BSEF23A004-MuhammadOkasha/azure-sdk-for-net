// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_DiskRestorePointCollection
    {
        // Get an incremental disk restorePoint resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnIncrementalDiskRestorePointResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskRestorePointExamples/DiskRestorePoint_Get.json
            // this example is just showing the usage of "DiskRestorePoint_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpc";
            string vmRestorePointName = "vmrp";
            ResourceIdentifier restorePointResourceId = Compute.RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName);
            Compute.RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // get the collection of this DiskRestorePointResource
            Compute.DiskRestorePointCollection collection = restorePoint.GetDiskRestorePoints();

            // invoke the operation
            string diskRestorePointName = "TestDisk45ceb03433006d1baee0_b70cd924-3362-4a80-93c2-9415eaa12745";
            Compute.DiskRestorePointResource result = await collection.GetAsync(diskRestorePointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.DiskRestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an incremental disk restorePoint when source resource is from a different region
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnIncrementalDiskRestorePointWhenSourceResourceIsFromADifferentRegion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskRestorePointExamples/DiskRestorePoint_Get_WhenSourceResourceIsFromDifferentRegion.json
            // this example is just showing the usage of "DiskRestorePoint_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpc";
            string vmRestorePointName = "vmrp";
            ResourceIdentifier restorePointResourceId = Compute.RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName);
            Compute.RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // get the collection of this DiskRestorePointResource
            Compute.DiskRestorePointCollection collection = restorePoint.GetDiskRestorePoints();

            // invoke the operation
            string diskRestorePointName = "TestDisk45ceb03433006d1baee0_b70cd924-3362-4a80-93c2-9415eaa12745";
            Compute.DiskRestorePointResource result = await collection.GetAsync(diskRestorePointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.DiskRestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an incremental disk restorePoint resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAnIncrementalDiskRestorePointResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskRestorePointExamples/DiskRestorePoint_ListByVmRestorePoint.json
            // this example is just showing the usage of "DiskRestorePoint_ListByRestorePoint" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpc";
            string vmRestorePointName = "vmrp";
            ResourceIdentifier restorePointResourceId = Compute.RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName);
            Compute.RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // get the collection of this DiskRestorePointResource
            Compute.DiskRestorePointCollection collection = restorePoint.GetDiskRestorePoints();

            // invoke the operation and iterate over the result
            await foreach (Compute.DiskRestorePointResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.DiskRestorePointData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
