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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_AvailabilitySetResource
    {
        // AvailabilitySets_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_AvailabilitySetsUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/availabilitySetExamples/AvailabilitySets_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "AvailabilitySets_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this AvailabilitySetResource created on azure
            // for more information of creating AvailabilitySetResource, please refer to the document of AvailabilitySetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string availabilitySetName = "aaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier availabilitySetResourceId = Compute.AvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetName);
            Compute.AvailabilitySetResource availabilitySet = client.GetAvailabilitySetResource(availabilitySetResourceId);

            // invoke the operation
            Compute.Models.AvailabilitySetPatch patch = new AvailabilitySetPatch()
            {
                Sku = new ComputeSku()
                {
                    Name = "DSv3-Type1",
                    Tier = "aaa",
                    Capacity = 7,
                },
                PlatformUpdateDomainCount = 20,
                PlatformFaultDomainCount = 2,
                VirtualMachines =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
}
},
                ProximityPlacementGroupId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
                Tags =
{
["key2574"] = "aaaaaaaa",
},
            };
            Compute.AvailabilitySetResource result = await availabilitySet.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.AvailabilitySetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AvailabilitySets_Update_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_AvailabilitySetsUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/availabilitySetExamples/AvailabilitySets_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "AvailabilitySets_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this AvailabilitySetResource created on azure
            // for more information of creating AvailabilitySetResource, please refer to the document of AvailabilitySetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string availabilitySetName = "aaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier availabilitySetResourceId = Compute.AvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetName);
            Compute.AvailabilitySetResource availabilitySet = client.GetAvailabilitySetResource(availabilitySetResourceId);

            // invoke the operation
            Compute.Models.AvailabilitySetPatch patch = new AvailabilitySetPatch();
            Compute.AvailabilitySetResource result = await availabilitySet.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.AvailabilitySetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AvailabilitySets_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_AvailabilitySetsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/availabilitySetExamples/AvailabilitySets_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "AvailabilitySets_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this AvailabilitySetResource created on azure
            // for more information of creating AvailabilitySetResource, please refer to the document of AvailabilitySetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string availabilitySetName = "aaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier availabilitySetResourceId = Compute.AvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetName);
            Compute.AvailabilitySetResource availabilitySet = client.GetAvailabilitySetResource(availabilitySetResourceId);

            // invoke the operation
            await availabilitySet.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // AvailabilitySets_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_AvailabilitySetsDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/availabilitySetExamples/AvailabilitySets_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "AvailabilitySets_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this AvailabilitySetResource created on azure
            // for more information of creating AvailabilitySetResource, please refer to the document of AvailabilitySetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string availabilitySetName = "aaaaaaaaaaa";
            ResourceIdentifier availabilitySetResourceId = Compute.AvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetName);
            Compute.AvailabilitySetResource availabilitySet = client.GetAvailabilitySetResource(availabilitySetResourceId);

            // invoke the operation
            await availabilitySet.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // AvailabilitySets_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AvailabilitySetsGetMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/availabilitySetExamples/AvailabilitySets_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "AvailabilitySets_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this AvailabilitySetResource created on azure
            // for more information of creating AvailabilitySetResource, please refer to the document of AvailabilitySetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string availabilitySetName = "aaaaaaaaaaaa";
            ResourceIdentifier availabilitySetResourceId = Compute.AvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetName);
            Compute.AvailabilitySetResource availabilitySet = client.GetAvailabilitySetResource(availabilitySetResourceId);

            // invoke the operation
            Compute.AvailabilitySetResource result = await availabilitySet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.AvailabilitySetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AvailabilitySets_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AvailabilitySetsGetMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/availabilitySetExamples/AvailabilitySets_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "AvailabilitySets_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this AvailabilitySetResource created on azure
            // for more information of creating AvailabilitySetResource, please refer to the document of AvailabilitySetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string availabilitySetName = "aaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier availabilitySetResourceId = Compute.AvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetName);
            Compute.AvailabilitySetResource availabilitySet = client.GetAvailabilitySetResource(availabilitySetResourceId);

            // invoke the operation
            Compute.AvailabilitySetResource result = await availabilitySet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.AvailabilitySetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List availability sets in a subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailabilitySets_ListAvailabilitySetsInASubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/availabilitySetExamples/AvailabilitySet_ListBySubscription.json
            // this example is just showing the usage of "AvailabilitySets_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscriptionId}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            string expand = "virtualMachines\\$ref";
            await foreach (Compute.AvailabilitySetResource item in subscriptionResource.GetAvailabilitySetsAsync(expand: expand))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.AvailabilitySetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // AvailabilitySets_ListAvailableSizes_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableSizes_AvailabilitySetsListAvailableSizesMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/availabilitySetExamples/AvailabilitySets_ListAvailableSizes_MaximumSet_Gen.json
            // this example is just showing the usage of "AvailabilitySets_ListAvailableSizes" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this AvailabilitySetResource created on azure
            // for more information of creating AvailabilitySetResource, please refer to the document of AvailabilitySetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string availabilitySetName = "aaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier availabilitySetResourceId = Compute.AvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetName);
            Compute.AvailabilitySetResource availabilitySet = client.GetAvailabilitySetResource(availabilitySetResourceId);

            // invoke the operation and iterate over the result
            await foreach (Compute.Models.VirtualMachineSize item in availabilitySet.GetAvailableSizesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // AvailabilitySets_ListAvailableSizes_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableSizes_AvailabilitySetsListAvailableSizesMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/availabilitySetExamples/AvailabilitySets_ListAvailableSizes_MinimumSet_Gen.json
            // this example is just showing the usage of "AvailabilitySets_ListAvailableSizes" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this AvailabilitySetResource created on azure
            // for more information of creating AvailabilitySetResource, please refer to the document of AvailabilitySetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string availabilitySetName = "aa";
            ResourceIdentifier availabilitySetResourceId = Compute.AvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetName);
            Compute.AvailabilitySetResource availabilitySet = client.GetAvailabilitySetResource(availabilitySetResourceId);

            // invoke the operation and iterate over the result
            await foreach (Compute.Models.VirtualMachineSize item in availabilitySet.GetAvailableSizesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
