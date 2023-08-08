// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppRevisionCollection
    {
        // List Container App's revisions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListContainerAppSRevisions()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/Revisions_List.json
            // this example is just showing the usage of "ContainerAppsRevisions_ListRevisions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string containerAppName = "testcontainerApp0";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppRevisionResource
            ContainerAppRevisionCollection collection = containerApp.GetContainerAppRevisions();

            // invoke the operation and iterate over the result
            await foreach (ContainerAppRevisionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppRevisionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Container App's revision
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetContainerAppSRevision()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/Revisions_Get.json
            // this example is just showing the usage of "ContainerAppsRevisions_GetRevision" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string containerAppName = "testcontainerApp0";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppRevisionResource
            ContainerAppRevisionCollection collection = containerApp.GetContainerAppRevisions();

            // invoke the operation
            string revisionName = "testcontainerApp0-pjxhsye";
            ContainerAppRevisionResource result = await collection.GetAsync(revisionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppRevisionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Container App's revision
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetContainerAppSRevision()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/Revisions_Get.json
            // this example is just showing the usage of "ContainerAppsRevisions_GetRevision" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string containerAppName = "testcontainerApp0";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppRevisionResource
            ContainerAppRevisionCollection collection = containerApp.GetContainerAppRevisions();

            // invoke the operation
            string revisionName = "testcontainerApp0-pjxhsye";
            bool result = await collection.ExistsAsync(revisionName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
