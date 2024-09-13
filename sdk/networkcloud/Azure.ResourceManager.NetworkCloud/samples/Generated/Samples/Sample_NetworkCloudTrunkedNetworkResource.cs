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
    public partial class Sample_NetworkCloudTrunkedNetworkResource
    {
        // List trunked networks for subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkCloudTrunkedNetworks_ListTrunkedNetworksForSubscription()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/TrunkedNetworks_ListBySubscription.json
            // this example is just showing the usage of "TrunkedNetworks_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (NetworkCloudTrunkedNetworkResource item in subscriptionResource.GetNetworkCloudTrunkedNetworksAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudTrunkedNetworkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Trunked network
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTrunkedNetwork()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/TrunkedNetworks_Get.json
            // this example is just showing the usage of "TrunkedNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudTrunkedNetworkResource created on azure
            // for more information of creating NetworkCloudTrunkedNetworkResource, please refer to the document of NetworkCloudTrunkedNetworkResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string trunkedNetworkName = "trunkedNetworkName";
            ResourceIdentifier networkCloudTrunkedNetworkResourceId = NetworkCloudTrunkedNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, trunkedNetworkName);
            NetworkCloudTrunkedNetworkResource networkCloudTrunkedNetwork = client.GetNetworkCloudTrunkedNetworkResource(networkCloudTrunkedNetworkResourceId);

            // invoke the operation
            NetworkCloudTrunkedNetworkResource result = await networkCloudTrunkedNetwork.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudTrunkedNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch trunked network
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchTrunkedNetwork()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/TrunkedNetworks_Patch.json
            // this example is just showing the usage of "TrunkedNetworks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudTrunkedNetworkResource created on azure
            // for more information of creating NetworkCloudTrunkedNetworkResource, please refer to the document of NetworkCloudTrunkedNetworkResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string trunkedNetworkName = "trunkedNetworkName";
            ResourceIdentifier networkCloudTrunkedNetworkResourceId = NetworkCloudTrunkedNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, trunkedNetworkName);
            NetworkCloudTrunkedNetworkResource networkCloudTrunkedNetwork = client.GetNetworkCloudTrunkedNetworkResource(networkCloudTrunkedNetworkResourceId);

            // invoke the operation
            NetworkCloudTrunkedNetworkPatch patch = new NetworkCloudTrunkedNetworkPatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
            };
            NetworkCloudTrunkedNetworkResource result = await networkCloudTrunkedNetwork.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudTrunkedNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
