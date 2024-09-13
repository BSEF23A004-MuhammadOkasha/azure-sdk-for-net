// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudL2NetworkResource
    {
        // List L2 networks for subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkCloudL2Networks_ListL2NetworksForSubscription()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/L2Networks_ListBySubscription.json
            // this example is just showing the usage of "L2Networks_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkCloudL2NetworkResource item in subscriptionResource.GetNetworkCloudL2NetworksAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudL2NetworkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get L2 network
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetL2Network()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/L2Networks_Get.json
            // this example is just showing the usage of "L2Networks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudL2NetworkResource created on azure
            // for more information of creating NetworkCloudL2NetworkResource, please refer to the document of NetworkCloudL2NetworkResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string l2NetworkName = "l2NetworkName";
            ResourceIdentifier networkCloudL2NetworkResourceId = NetworkCloudL2NetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l2NetworkName);
            NetworkCloudL2NetworkResource networkCloudL2Network = client.GetNetworkCloudL2NetworkResource(networkCloudL2NetworkResourceId);

            // invoke the operation
            NetworkCloudL2NetworkResource result = await networkCloudL2Network.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudL2NetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch L2 network
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchL2Network()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/L2Networks_Patch.json
            // this example is just showing the usage of "L2Networks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudL2NetworkResource created on azure
            // for more information of creating NetworkCloudL2NetworkResource, please refer to the document of NetworkCloudL2NetworkResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string l2NetworkName = "l2NetworkName";
            ResourceIdentifier networkCloudL2NetworkResourceId = NetworkCloudL2NetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l2NetworkName);
            NetworkCloudL2NetworkResource networkCloudL2Network = client.GetNetworkCloudL2NetworkResource(networkCloudL2NetworkResourceId);

            // invoke the operation
            NetworkCloudL2NetworkPatch patch = new NetworkCloudL2NetworkPatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
            };
            NetworkCloudL2NetworkResource result = await networkCloudL2Network.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudL2NetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
