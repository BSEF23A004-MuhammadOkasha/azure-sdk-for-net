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
    public partial class Sample_MachineLearningRegistryEnvironmentVersionCollection
    {
        // List Registry Environment Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListRegistryEnvironmentVersion()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/EnvironmentVersion/list.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Registry/EnvironmentVersion/list.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "RegistryEnvironmentVersions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryEnvironmentContainerResource created on azure
            // for more information of creating MachineLearningRegistryEnvironmentContainerResource, please refer to the document of MachineLearningRegistryEnvironmentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-regsitry";
            string environmentName = "string";
            ResourceIdentifier machineLearningRegistryEnvironmentContainerResourceId = MachineLearningRegistryEnvironmentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, environmentName);
            MachineLearningRegistryEnvironmentContainerResource machineLearningRegistryEnvironmentContainer = client.GetMachineLearningRegistryEnvironmentContainerResource(machineLearningRegistryEnvironmentContainerResourceId);

            // get the collection of this MachineLearningRegistryEnvironmentVersionResource
            MachineLearningRegistryEnvironmentVersionCollection collection = machineLearningRegistryEnvironmentContainer.GetMachineLearningRegistryEnvironmentVersions();

            // invoke the operation and iterate over the result
            string orderBy = "string";
            int? top = 1;
            await foreach (MachineLearningRegistryEnvironmentVersionResource item in collection.GetAllAsync(orderBy: orderBy, top: top))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningEnvironmentVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Registry Environment Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRegistryEnvironmentVersion()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/EnvironmentVersion/get.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Registry/EnvironmentVersion/get.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "RegistryEnvironmentVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryEnvironmentContainerResource created on azure
            // for more information of creating MachineLearningRegistryEnvironmentContainerResource, please refer to the document of MachineLearningRegistryEnvironmentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string environmentName = "string";
            ResourceIdentifier machineLearningRegistryEnvironmentContainerResourceId = MachineLearningRegistryEnvironmentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, environmentName);
            MachineLearningRegistryEnvironmentContainerResource machineLearningRegistryEnvironmentContainer = client.GetMachineLearningRegistryEnvironmentContainerResource(machineLearningRegistryEnvironmentContainerResourceId);

            // get the collection of this MachineLearningRegistryEnvironmentVersionResource
            MachineLearningRegistryEnvironmentVersionCollection collection = machineLearningRegistryEnvironmentContainer.GetMachineLearningRegistryEnvironmentVersions();

            // invoke the operation
            string version = "string";
            MachineLearningRegistryEnvironmentVersionResource result = await collection.GetAsync(version);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningEnvironmentVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Registry Environment Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRegistryEnvironmentVersion()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/EnvironmentVersion/get.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Registry/EnvironmentVersion/get.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "RegistryEnvironmentVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryEnvironmentContainerResource created on azure
            // for more information of creating MachineLearningRegistryEnvironmentContainerResource, please refer to the document of MachineLearningRegistryEnvironmentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string environmentName = "string";
            ResourceIdentifier machineLearningRegistryEnvironmentContainerResourceId = MachineLearningRegistryEnvironmentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, environmentName);
            MachineLearningRegistryEnvironmentContainerResource machineLearningRegistryEnvironmentContainer = client.GetMachineLearningRegistryEnvironmentContainerResource(machineLearningRegistryEnvironmentContainerResourceId);

            // get the collection of this MachineLearningRegistryEnvironmentVersionResource
            MachineLearningRegistryEnvironmentVersionCollection collection = machineLearningRegistryEnvironmentContainer.GetMachineLearningRegistryEnvironmentVersions();

            // invoke the operation
            string version = "string";
            bool result = await collection.ExistsAsync(version);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Registry Environment Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRegistryEnvironmentVersion()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/EnvironmentVersion/get.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Registry/EnvironmentVersion/get.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "RegistryEnvironmentVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryEnvironmentContainerResource created on azure
            // for more information of creating MachineLearningRegistryEnvironmentContainerResource, please refer to the document of MachineLearningRegistryEnvironmentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string environmentName = "string";
            ResourceIdentifier machineLearningRegistryEnvironmentContainerResourceId = MachineLearningRegistryEnvironmentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, environmentName);
            MachineLearningRegistryEnvironmentContainerResource machineLearningRegistryEnvironmentContainer = client.GetMachineLearningRegistryEnvironmentContainerResource(machineLearningRegistryEnvironmentContainerResourceId);

            // get the collection of this MachineLearningRegistryEnvironmentVersionResource
            MachineLearningRegistryEnvironmentVersionCollection collection = machineLearningRegistryEnvironmentContainer.GetMachineLearningRegistryEnvironmentVersions();

            // invoke the operation
            string version = "string";
            NullableResponse<MachineLearningRegistryEnvironmentVersionResource> response = await collection.GetIfExistsAsync(version);
            MachineLearningRegistryEnvironmentVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningEnvironmentVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CreateOrUpdate Registry Environment Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateRegistryEnvironmentVersion()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/EnvironmentVersion/createOrUpdate.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Registry/EnvironmentVersion/createOrUpdate.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "RegistryEnvironmentVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryEnvironmentContainerResource created on azure
            // for more information of creating MachineLearningRegistryEnvironmentContainerResource, please refer to the document of MachineLearningRegistryEnvironmentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string environmentName = "string";
            ResourceIdentifier machineLearningRegistryEnvironmentContainerResourceId = MachineLearningRegistryEnvironmentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, environmentName);
            MachineLearningRegistryEnvironmentContainerResource machineLearningRegistryEnvironmentContainer = client.GetMachineLearningRegistryEnvironmentContainerResource(machineLearningRegistryEnvironmentContainerResourceId);

            // get the collection of this MachineLearningRegistryEnvironmentVersionResource
            MachineLearningRegistryEnvironmentVersionCollection collection = machineLearningRegistryEnvironmentContainer.GetMachineLearningRegistryEnvironmentVersions();

            // invoke the operation
            string version = "string";
            MachineLearningEnvironmentVersionData data = new MachineLearningEnvironmentVersionData(new MachineLearningEnvironmentVersionProperties()
            {
                Image = "docker.io/tensorflow/serving:latest",
                CondaFile = "string",
                Build = new MachineLearningBuildContext(new Uri("https://storage-account.blob.core.windows.net/azureml/DockerBuildContext/95ddede6b9b8c4e90472db3acd0a8d28/"))
                {
                    DockerfilePath = "prod/Dockerfile",
                },
                InferenceConfig = new MachineLearningInferenceContainerProperties()
                {
                    LivenessRoute = new MachineLearningInferenceContainerRoute("string", 1),
                    ReadinessRoute = new MachineLearningInferenceContainerRoute("string", 1),
                    ScoringRoute = new MachineLearningInferenceContainerRoute("string", 1),
                },
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
            ArmOperation<MachineLearningRegistryEnvironmentVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, version, data);
            MachineLearningRegistryEnvironmentVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningEnvironmentVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
