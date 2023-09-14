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
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_SubnetCollection
    {
        // Get subnet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSubnet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/SubnetGet.json
            // this example is just showing the usage of "Subnets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "subnet-test";
            string virtualNetworkName = "vnetname";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this SubnetResource
            SubnetCollection collection = virtualNetwork.GetSubnets();

            // invoke the operation
            string subnetName = "subnet1";
            SubnetResource result = await collection.GetAsync(subnetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SubnetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get subnet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetSubnet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/SubnetGet.json
            // this example is just showing the usage of "Subnets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "subnet-test";
            string virtualNetworkName = "vnetname";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this SubnetResource
            SubnetCollection collection = virtualNetwork.GetSubnets();

            // invoke the operation
            string subnetName = "subnet1";
            bool result = await collection.ExistsAsync(subnetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get subnet with a delegation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSubnetWithADelegation()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/SubnetGetWithDelegation.json
            // this example is just showing the usage of "Subnets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subId";
            string resourceGroupName = "subnet-test";
            string virtualNetworkName = "vnetname";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this SubnetResource
            SubnetCollection collection = virtualNetwork.GetSubnets();

            // invoke the operation
            string subnetName = "subnet1";
            SubnetResource result = await collection.GetAsync(subnetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SubnetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get subnet with a delegation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetSubnetWithADelegation()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/SubnetGetWithDelegation.json
            // this example is just showing the usage of "Subnets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subId";
            string resourceGroupName = "subnet-test";
            string virtualNetworkName = "vnetname";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this SubnetResource
            SubnetCollection collection = virtualNetwork.GetSubnets();

            // invoke the operation
            string subnetName = "subnet1";
            bool result = await collection.ExistsAsync(subnetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create subnet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateSubnet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/SubnetCreate.json
            // this example is just showing the usage of "Subnets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "subnet-test";
            string virtualNetworkName = "vnetname";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this SubnetResource
            SubnetCollection collection = virtualNetwork.GetSubnets();

            // invoke the operation
            string subnetName = "subnet1";
            SubnetData data = new SubnetData()
            {
                AddressPrefix = "10.0.0.0/16",
            };
            ArmOperation<SubnetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, subnetName, data);
            SubnetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SubnetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create subnet with a delegation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateSubnetWithADelegation()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/SubnetCreateWithDelegation.json
            // this example is just showing the usage of "Subnets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subId";
            string resourceGroupName = "subnet-test";
            string virtualNetworkName = "vnetname";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this SubnetResource
            SubnetCollection collection = virtualNetwork.GetSubnets();

            // invoke the operation
            string subnetName = "subnet1";
            SubnetData data = new SubnetData()
            {
                AddressPrefix = "10.0.0.0/16",
            };
            ArmOperation<SubnetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, subnetName, data);
            SubnetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SubnetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create subnet with service endpoints
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateSubnetWithServiceEndpoints()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/SubnetCreateServiceEndpoint.json
            // this example is just showing the usage of "Subnets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "subnet-test";
            string virtualNetworkName = "vnetname";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this SubnetResource
            SubnetCollection collection = virtualNetwork.GetSubnets();

            // invoke the operation
            string subnetName = "subnet1";
            SubnetData data = new SubnetData()
            {
                AddressPrefix = "10.0.0.0/16",
                ServiceEndpoints =
{
new ServiceEndpointProperties()
{
Service = "Microsoft.Storage",
}
},
            };
            ArmOperation<SubnetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, subnetName, data);
            SubnetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SubnetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List subnets
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSubnets()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/SubnetList.json
            // this example is just showing the usage of "Subnets_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "subnet-test";
            string virtualNetworkName = "vnetname";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this SubnetResource
            SubnetCollection collection = virtualNetwork.GetSubnets();

            // invoke the operation and iterate over the result
            await foreach (SubnetResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SubnetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
