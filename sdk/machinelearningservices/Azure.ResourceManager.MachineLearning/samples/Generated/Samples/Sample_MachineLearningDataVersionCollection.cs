// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningDataVersionCollection
    {
        // List Workspace Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListWorkspaceDataVersionBase()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/DataVersionBase/list.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/DataVersionBase/list.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "DataVersions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataContainerResource created on azure
            // for more information of creating MachineLearningDataContainerResource, please refer to the document of MachineLearningDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDataContainerResourceId = MachineLearningDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDataContainerResource machineLearningDataContainer = client.GetMachineLearningDataContainerResource(machineLearningDataContainerResourceId);

            // get the collection of this MachineLearningDataVersionResource
            MachineLearningDataVersionCollection collection = machineLearningDataContainer.GetMachineLearningDataVersions();

            // invoke the operation and iterate over the result
            string orderBy = "string";
            int? top = 1;
            string tags = "string";
            await foreach (MachineLearningDataVersionResource item in collection.GetAllAsync(orderBy: orderBy, top: top, tags: tags))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningDataVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Workspace Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceDataVersionBase()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/DataVersionBase/get.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/DataVersionBase/get.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "DataVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataContainerResource created on azure
            // for more information of creating MachineLearningDataContainerResource, please refer to the document of MachineLearningDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDataContainerResourceId = MachineLearningDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDataContainerResource machineLearningDataContainer = client.GetMachineLearningDataContainerResource(machineLearningDataContainerResourceId);

            // get the collection of this MachineLearningDataVersionResource
            MachineLearningDataVersionCollection collection = machineLearningDataContainer.GetMachineLearningDataVersions();

            // invoke the operation
            string version = "string";
            MachineLearningDataVersionResource result = await collection.GetAsync(version);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDataVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Workspace Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetWorkspaceDataVersionBase()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/DataVersionBase/get.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/DataVersionBase/get.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "DataVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataContainerResource created on azure
            // for more information of creating MachineLearningDataContainerResource, please refer to the document of MachineLearningDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDataContainerResourceId = MachineLearningDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDataContainerResource machineLearningDataContainer = client.GetMachineLearningDataContainerResource(machineLearningDataContainerResourceId);

            // get the collection of this MachineLearningDataVersionResource
            MachineLearningDataVersionCollection collection = machineLearningDataContainer.GetMachineLearningDataVersions();

            // invoke the operation
            string version = "string";
            bool result = await collection.ExistsAsync(version);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Workspace Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetWorkspaceDataVersionBase()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/DataVersionBase/get.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/DataVersionBase/get.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "DataVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataContainerResource created on azure
            // for more information of creating MachineLearningDataContainerResource, please refer to the document of MachineLearningDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDataContainerResourceId = MachineLearningDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDataContainerResource machineLearningDataContainer = client.GetMachineLearningDataContainerResource(machineLearningDataContainerResourceId);

            // get the collection of this MachineLearningDataVersionResource
            MachineLearningDataVersionCollection collection = machineLearningDataContainer.GetMachineLearningDataVersions();

            // invoke the operation
            string version = "string";
            NullableResponse<MachineLearningDataVersionResource> response = await collection.GetIfExistsAsync(version);
            MachineLearningDataVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningDataVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CreateOrUpdate Workspace Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateWorkspaceDataVersionBase()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/DataVersionBase/createOrUpdate.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/DataVersionBase/createOrUpdate.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "DataVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataContainerResource created on azure
            // for more information of creating MachineLearningDataContainerResource, please refer to the document of MachineLearningDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDataContainerResourceId = MachineLearningDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDataContainerResource machineLearningDataContainer = client.GetMachineLearningDataContainerResource(machineLearningDataContainerResourceId);

            // get the collection of this MachineLearningDataVersionResource
            MachineLearningDataVersionCollection collection = machineLearningDataContainer.GetMachineLearningDataVersions();

            // invoke the operation
            string version = "string";
            MachineLearningDataVersionData data = new MachineLearningDataVersionData(new MachineLearningUriFileDataVersion(new Uri("string"))
            {
                IsAnonymous = false,
                Description = "string",
                Tags =
{
["string"] = "string",
},
                Properties =
{
["string"] = "string",
},
            });
            ArmOperation<MachineLearningDataVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, version, data);
            MachineLearningDataVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDataVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
