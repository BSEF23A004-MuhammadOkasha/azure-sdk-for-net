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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_RestorePointResource
    {
        // Copy a restore point to a different region
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CopyARestorePointToADifferentRegion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/restorePointExamples/RestorePoint_Copy_BetweenRegions.json
            // this example is just showing the usage of "RestorePoints_Create" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpcName";
            string restorePointName = "rpName";
            ResourceIdentifier restorePointResourceId = Compute.RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            Compute.RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            Compute.RestorePointData data = new RestorePointData()
            {
                SourceRestorePointId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/restorePointCollections/sourceRpcName/restorePoints/sourceRpName"),
            };
            ArmOperation<Compute.RestorePointResource> lro = await restorePoint.UpdateAsync(WaitUntil.Completed, data);
            Compute.RestorePointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.RestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a restore point
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateARestorePoint()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/restorePointExamples/RestorePoint_Create.json
            // this example is just showing the usage of "RestorePoints_Create" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpcName";
            string restorePointName = "rpName";
            ResourceIdentifier restorePointResourceId = Compute.RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            Compute.RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            Compute.RestorePointData data = new RestorePointData()
            {
                ExcludeDisks =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/disks/disk123"),
}
},
            };
            ArmOperation<Compute.RestorePointResource> lro = await restorePoint.UpdateAsync(WaitUntil.Completed, data);
            Compute.RestorePointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.RestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RestorePoints_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RestorePointsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/restorePointExamples/RestorePoints_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "RestorePoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string restorePointGroupName = "aaaaaaaaaaaaaaaaaaaaaa";
            string restorePointName = "a";
            ResourceIdentifier restorePointResourceId = Compute.RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            Compute.RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            await restorePoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // RestorePoints_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RestorePointsDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/restorePointExamples/RestorePoints_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "RestorePoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string restorePointGroupName = "aaaaaaaaaaaaaaaaa";
            string restorePointName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier restorePointResourceId = Compute.RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            Compute.RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            await restorePoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a restore point
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetARestorePoint()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/restorePointExamples/RestorePoint_Get.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpcName";
            string restorePointName = "rpName";
            ResourceIdentifier restorePointResourceId = Compute.RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            Compute.RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            Compute.RestorePointResource result = await restorePoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.RestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get restore point with instance view
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRestorePointWithInstanceView()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/restorePointExamples/RestorePoint_Get_WithInstanceView.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpcName";
            string restorePointName = "rpName";
            ResourceIdentifier restorePointResourceId = Compute.RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            Compute.RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            Compute.RestorePointResource result = await restorePoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.RestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
