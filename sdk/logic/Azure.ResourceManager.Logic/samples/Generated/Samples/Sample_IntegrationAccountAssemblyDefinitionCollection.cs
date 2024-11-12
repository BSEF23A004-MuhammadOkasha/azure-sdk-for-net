// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Logic.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_IntegrationAccountAssemblyDefinitionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListIntegrationAccountAssemblies()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountAssemblies_List.json
            // this example is just showing the usage of "IntegrationAccountAssemblies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountAssemblyDefinitionResource
            IntegrationAccountAssemblyDefinitionCollection collection = integrationAccount.GetIntegrationAccountAssemblyDefinitions();

            // invoke the operation and iterate over the result
            await foreach (IntegrationAccountAssemblyDefinitionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IntegrationAccountAssemblyDefinitionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnIntegrationAccountAssembly()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountAssemblies_Get.json
            // this example is just showing the usage of "IntegrationAccountAssemblies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountAssemblyDefinitionResource
            IntegrationAccountAssemblyDefinitionCollection collection = integrationAccount.GetIntegrationAccountAssemblyDefinitions();

            // invoke the operation
            string assemblyArtifactName = "testAssembly";
            IntegrationAccountAssemblyDefinitionResource result = await collection.GetAsync(assemblyArtifactName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountAssemblyDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAnIntegrationAccountAssembly()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountAssemblies_Get.json
            // this example is just showing the usage of "IntegrationAccountAssemblies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountAssemblyDefinitionResource
            IntegrationAccountAssemblyDefinitionCollection collection = integrationAccount.GetIntegrationAccountAssemblyDefinitions();

            // invoke the operation
            string assemblyArtifactName = "testAssembly";
            bool result = await collection.ExistsAsync(assemblyArtifactName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAnIntegrationAccountAssembly()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountAssemblies_Get.json
            // this example is just showing the usage of "IntegrationAccountAssemblies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountAssemblyDefinitionResource
            IntegrationAccountAssemblyDefinitionCollection collection = integrationAccount.GetIntegrationAccountAssemblyDefinitions();

            // invoke the operation
            string assemblyArtifactName = "testAssembly";
            NullableResponse<IntegrationAccountAssemblyDefinitionResource> response = await collection.GetIfExistsAsync(assemblyArtifactName);
            IntegrationAccountAssemblyDefinitionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IntegrationAccountAssemblyDefinitionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAnAccountAssembly()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountAssemblies_CreateOrUpdate.json
            // this example is just showing the usage of "IntegrationAccountAssemblies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountAssemblyDefinitionResource
            IntegrationAccountAssemblyDefinitionCollection collection = integrationAccount.GetIntegrationAccountAssemblyDefinitions();

            // invoke the operation
            string assemblyArtifactName = "testAssembly";
            IntegrationAccountAssemblyDefinitionData data = new IntegrationAccountAssemblyDefinitionData(new AzureLocation("westus"), new IntegrationAccountAssemblyProperties("System.IdentityModel.Tokens.Jwt")
            {
                Content = BinaryData.FromString("\"Base64 encoded Assembly Content\""),
                Metadata = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                }),
            });
            ArmOperation<IntegrationAccountAssemblyDefinitionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, assemblyArtifactName, data);
            IntegrationAccountAssemblyDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountAssemblyDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
