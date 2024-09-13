// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudVirtualMachineConsoleCollection
    {
        // List consoles of the virtual machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListConsolesOfTheVirtualMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Consoles_ListByVirtualMachine.json
            // this example is just showing the usage of "Consoles_ListByVirtualMachine" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // get the collection of this NetworkCloudVirtualMachineConsoleResource
            NetworkCloudVirtualMachineConsoleCollection collection = networkCloudVirtualMachine.GetNetworkCloudVirtualMachineConsoles();

            // invoke the operation and iterate over the result
            await foreach (NetworkCloudVirtualMachineConsoleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudVirtualMachineConsoleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get virtual machine console
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualMachineConsole()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Consoles_Get.json
            // this example is just showing the usage of "Consoles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // get the collection of this NetworkCloudVirtualMachineConsoleResource
            NetworkCloudVirtualMachineConsoleCollection collection = networkCloudVirtualMachine.GetNetworkCloudVirtualMachineConsoles();

            // invoke the operation
            string consoleName = "default";
            NetworkCloudVirtualMachineConsoleResource result = await collection.GetAsync(consoleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudVirtualMachineConsoleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get virtual machine console
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetVirtualMachineConsole()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Consoles_Get.json
            // this example is just showing the usage of "Consoles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // get the collection of this NetworkCloudVirtualMachineConsoleResource
            NetworkCloudVirtualMachineConsoleCollection collection = networkCloudVirtualMachine.GetNetworkCloudVirtualMachineConsoles();

            // invoke the operation
            string consoleName = "default";
            bool result = await collection.ExistsAsync(consoleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get virtual machine console
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetVirtualMachineConsole()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Consoles_Get.json
            // this example is just showing the usage of "Consoles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // get the collection of this NetworkCloudVirtualMachineConsoleResource
            NetworkCloudVirtualMachineConsoleCollection collection = networkCloudVirtualMachine.GetNetworkCloudVirtualMachineConsoles();

            // invoke the operation
            string consoleName = "default";
            NullableResponse<NetworkCloudVirtualMachineConsoleResource> response = await collection.GetIfExistsAsync(consoleName);
            NetworkCloudVirtualMachineConsoleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudVirtualMachineConsoleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update virtual machine console
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateVirtualMachineConsole()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/Consoles_Create.json
            // this example is just showing the usage of "Consoles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // get the collection of this NetworkCloudVirtualMachineConsoleResource
            NetworkCloudVirtualMachineConsoleCollection collection = networkCloudVirtualMachine.GetNetworkCloudVirtualMachineConsoles();

            // invoke the operation
            string consoleName = "default";
            NetworkCloudVirtualMachineConsoleData data = new NetworkCloudVirtualMachineConsoleData(new AzureLocation("location"), new ExtendedLocation("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.ExtendedLocation/customLocations/clusterManagerExtendedLocationName", "CustomLocation"), ConsoleEnabled.True, new NetworkCloudSshPublicKey("ssh-rsa AAtsE3njSONzDYRIZv/WLjVuMfrUSByHp+jfaaOLHTIIB4fJvo6dQUZxE20w2iDHV3tEkmnTo84eba97VMueQD6OzJPEyWZMRpz8UYWOd0IXeRqiFu1lawNblZhwNT/ojNZfpB3af/YDzwQCZgTcTRyNNhL4o/blKUmug0daSsSXISTRnIDpcf5qytjs1Xo+yYyJMvzLL59mhAyb3p/cD+Y3/s3WhAx+l0XOKpzXnblrv9d3q4c2tWmm/SyFqthaqd0= admin@vm"))
            {
                ExpireOn = DateTimeOffset.Parse("2022-06-01T01:27:03.008Z"),
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
            };
            ArmOperation<NetworkCloudVirtualMachineConsoleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, consoleName, data);
            NetworkCloudVirtualMachineConsoleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudVirtualMachineConsoleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
