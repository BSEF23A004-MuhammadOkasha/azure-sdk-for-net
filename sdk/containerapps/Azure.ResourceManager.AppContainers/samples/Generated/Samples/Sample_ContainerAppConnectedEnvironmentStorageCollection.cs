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
using Azure.ResourceManager.AppContainers;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppConnectedEnvironmentStorageCollection
    {
        // List environments storages by subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListEnvironmentsStoragesBySubscription()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ConnectedEnvironmentsStorages_List.json
            // this example is just showing the usage of "ConnectedEnvironmentsStorages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "managedEnv";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // get the collection of this ContainerAppConnectedEnvironmentStorageResource
            ContainerAppConnectedEnvironmentStorageCollection collection = containerAppConnectedEnvironment.GetContainerAppConnectedEnvironmentStorages();

            // invoke the operation and iterate over the result
            await foreach (ContainerAppConnectedEnvironmentStorageResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppConnectedEnvironmentStorageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // get a environments storage properties by subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAEnvironmentsStoragePropertiesBySubscription()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ConnectedEnvironmentsStorages_Get.json
            // this example is just showing the usage of "ConnectedEnvironmentsStorages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "env";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // get the collection of this ContainerAppConnectedEnvironmentStorageResource
            ContainerAppConnectedEnvironmentStorageCollection collection = containerAppConnectedEnvironment.GetContainerAppConnectedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            ContainerAppConnectedEnvironmentStorageResource result = await collection.GetAsync(storageName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppConnectedEnvironmentStorageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // get a environments storage properties by subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAEnvironmentsStoragePropertiesBySubscription()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ConnectedEnvironmentsStorages_Get.json
            // this example is just showing the usage of "ConnectedEnvironmentsStorages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "env";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // get the collection of this ContainerAppConnectedEnvironmentStorageResource
            ContainerAppConnectedEnvironmentStorageCollection collection = containerAppConnectedEnvironment.GetContainerAppConnectedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            bool result = await collection.ExistsAsync(storageName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create or update environments storage
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateEnvironmentsStorage()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ConnectedEnvironmentsStorages_CreateOrUpdate.json
            // this example is just showing the usage of "ConnectedEnvironmentsStorages_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "env";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // get the collection of this ContainerAppConnectedEnvironmentStorageResource
            ContainerAppConnectedEnvironmentStorageCollection collection = containerAppConnectedEnvironment.GetContainerAppConnectedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            ContainerAppConnectedEnvironmentStorageData data = new ContainerAppConnectedEnvironmentStorageData()
            {
                ConnectedEnvironmentStorageAzureFile = new ContainerAppAzureFileProperties()
                {
                    AccountName = "account1",
                    AccountKey = "key",
                    AccessMode = ContainerAppAccessMode.ReadOnly,
                    ShareName = "share1",
                },
            };
            ArmOperation<ContainerAppConnectedEnvironmentStorageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, storageName, data);
            ContainerAppConnectedEnvironmentStorageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppConnectedEnvironmentStorageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
