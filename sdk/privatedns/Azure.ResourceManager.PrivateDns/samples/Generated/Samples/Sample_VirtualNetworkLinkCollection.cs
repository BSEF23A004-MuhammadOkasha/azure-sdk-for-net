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
using Azure.ResourceManager.PrivateDns;

namespace Azure.ResourceManager.PrivateDns.Samples
{
    public partial class Sample_VirtualNetworkLinkCollection
    {
        // PUT Private DNS Zone Virtual Network Link
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PUTPrivateDNSZoneVirtualNetworkLink()
        {
            // Generated from example definition: specification/privatedns/resource-manager/Microsoft.Network/stable/2020-06-01/examples/VirtualNetworkLinkPut.json
            // this example is just showing the usage of "VirtualNetworkLinks_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateDnsZoneResource created on azure
            // for more information of creating PrivateDnsZoneResource, please refer to the document of PrivateDnsZoneResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroup1";
            string privateZoneName = "privatezone1.com";
            ResourceIdentifier privateDnsZoneResourceId = PrivateDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateZoneName);
            PrivateDnsZoneResource privateDnsZone = client.GetPrivateDnsZoneResource(privateDnsZoneResourceId);

            // get the collection of this VirtualNetworkLinkResource
            VirtualNetworkLinkCollection collection = privateDnsZone.GetVirtualNetworkLinks();

            // invoke the operation
            string virtualNetworkLinkName = "virtualNetworkLink1";
            VirtualNetworkLinkData data = new VirtualNetworkLinkData(new AzureLocation("Global"))
            {
                VirtualNetworkId = new ResourceIdentifier("/subscriptions/virtualNetworkSubscriptionId/resourceGroups/virtualNetworkResourceGroup/providers/Microsoft.Network/virtualNetworks/virtualNetworkName"),
                RegistrationEnabled = false,
                Tags =
{
["key1"] = "value1",
},
            };
            ArmOperation<VirtualNetworkLinkResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, virtualNetworkLinkName, data);
            VirtualNetworkLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkLinkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GET Private DNS Zone Virtual Network Link
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GETPrivateDNSZoneVirtualNetworkLink()
        {
            // Generated from example definition: specification/privatedns/resource-manager/Microsoft.Network/stable/2020-06-01/examples/VirtualNetworkLinkGet.json
            // this example is just showing the usage of "VirtualNetworkLinks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateDnsZoneResource created on azure
            // for more information of creating PrivateDnsZoneResource, please refer to the document of PrivateDnsZoneResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroup1";
            string privateZoneName = "privatezone1.com";
            ResourceIdentifier privateDnsZoneResourceId = PrivateDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateZoneName);
            PrivateDnsZoneResource privateDnsZone = client.GetPrivateDnsZoneResource(privateDnsZoneResourceId);

            // get the collection of this VirtualNetworkLinkResource
            VirtualNetworkLinkCollection collection = privateDnsZone.GetVirtualNetworkLinks();

            // invoke the operation
            string virtualNetworkLinkName = "virtualNetworkLink1";
            VirtualNetworkLinkResource result = await collection.GetAsync(virtualNetworkLinkName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkLinkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GET Private DNS Zone Virtual Network Link
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GETPrivateDNSZoneVirtualNetworkLink()
        {
            // Generated from example definition: specification/privatedns/resource-manager/Microsoft.Network/stable/2020-06-01/examples/VirtualNetworkLinkGet.json
            // this example is just showing the usage of "VirtualNetworkLinks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateDnsZoneResource created on azure
            // for more information of creating PrivateDnsZoneResource, please refer to the document of PrivateDnsZoneResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroup1";
            string privateZoneName = "privatezone1.com";
            ResourceIdentifier privateDnsZoneResourceId = PrivateDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateZoneName);
            PrivateDnsZoneResource privateDnsZone = client.GetPrivateDnsZoneResource(privateDnsZoneResourceId);

            // get the collection of this VirtualNetworkLinkResource
            VirtualNetworkLinkCollection collection = privateDnsZone.GetVirtualNetworkLinks();

            // invoke the operation
            string virtualNetworkLinkName = "virtualNetworkLink1";
            bool result = await collection.ExistsAsync(virtualNetworkLinkName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Private DNS Zone Virtual Network Links
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetPrivateDNSZoneVirtualNetworkLinks()
        {
            // Generated from example definition: specification/privatedns/resource-manager/Microsoft.Network/stable/2020-06-01/examples/VirtualNetworkLinkList.json
            // this example is just showing the usage of "VirtualNetworkLinks_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateDnsZoneResource created on azure
            // for more information of creating PrivateDnsZoneResource, please refer to the document of PrivateDnsZoneResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroup1";
            string privateZoneName = "privatezone1.com";
            ResourceIdentifier privateDnsZoneResourceId = PrivateDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateZoneName);
            PrivateDnsZoneResource privateDnsZone = client.GetPrivateDnsZoneResource(privateDnsZoneResourceId);

            // get the collection of this VirtualNetworkLinkResource
            VirtualNetworkLinkCollection collection = privateDnsZone.GetVirtualNetworkLinks();

            // invoke the operation and iterate over the result
            await foreach (VirtualNetworkLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkLinkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
