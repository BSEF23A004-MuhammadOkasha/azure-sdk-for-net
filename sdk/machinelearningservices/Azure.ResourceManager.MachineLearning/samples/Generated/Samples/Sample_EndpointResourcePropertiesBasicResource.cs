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
    public partial class Sample_EndpointResourcePropertiesBasicResource
    {
        // Get Endpoint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Endpoint/get.json
            // this example is just showing the usage of "Endpoint_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EndpointResourcePropertiesBasicResource created on azure
            // for more information of creating EndpointResourcePropertiesBasicResource, please refer to the document of EndpointResourcePropertiesBasicResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "aml-workspace-name";
            string endpointName = "Azure.OpenAI";
            ResourceIdentifier endpointResourcePropertiesBasicResourceId = EndpointResourcePropertiesBasicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName);
            EndpointResourcePropertiesBasicResource endpointResourcePropertiesBasicResource = client.GetEndpointResourcePropertiesBasicResource(endpointResourcePropertiesBasicResourceId);

            // invoke the operation
            EndpointResourcePropertiesBasicResource result = await endpointResourcePropertiesBasicResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EndpointResourcePropertiesBasicResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create Endpoint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Endpoint/create.json
            // this example is just showing the usage of "Endpoint_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EndpointResourcePropertiesBasicResource created on azure
            // for more information of creating EndpointResourcePropertiesBasicResource, please refer to the document of EndpointResourcePropertiesBasicResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "aml-workspace-name";
            string endpointName = "Azure.OpenAI";
            ResourceIdentifier endpointResourcePropertiesBasicResourceId = EndpointResourcePropertiesBasicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName);
            EndpointResourcePropertiesBasicResource endpointResourcePropertiesBasicResource = client.GetEndpointResourcePropertiesBasicResource(endpointResourcePropertiesBasicResourceId);

            // invoke the operation
            EndpointResourcePropertiesBasicResourceData data = new EndpointResourcePropertiesBasicResourceData(new OpenAIEndpointResourceProperties()
            {
                AssociatedResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/test-rg/providers/Microsoft.CognitiveService/account/account-1"),
                Name = "Azure.OpenAI",
            });
            ArmOperation<EndpointResourcePropertiesBasicResource> lro = await endpointResourcePropertiesBasicResource.UpdateAsync(WaitUntil.Completed, data);
            EndpointResourcePropertiesBasicResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EndpointResourcePropertiesBasicResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List Endpoint Keys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeys_ListEndpointKeys()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Endpoint/listKeys.json
            // this example is just showing the usage of "Endpoint_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EndpointResourcePropertiesBasicResource created on azure
            // for more information of creating EndpointResourcePropertiesBasicResource, please refer to the document of EndpointResourcePropertiesBasicResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "aml-workspace-name";
            string endpointName = "Azure.OpenAI";
            ResourceIdentifier endpointResourcePropertiesBasicResourceId = EndpointResourcePropertiesBasicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName);
            EndpointResourcePropertiesBasicResource endpointResourcePropertiesBasicResource = client.GetEndpointResourcePropertiesBasicResource(endpointResourcePropertiesBasicResourceId);

            // invoke the operation
            EndpointKeys result = await endpointResourcePropertiesBasicResource.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Endpoint Models
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetModels_GetEndpointModels()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Endpoint/getModels.json
            // this example is just showing the usage of "Endpoint_GetModels" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EndpointResourcePropertiesBasicResource created on azure
            // for more information of creating EndpointResourcePropertiesBasicResource, please refer to the document of EndpointResourcePropertiesBasicResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "aml-workspace-name";
            string endpointName = "Azure.OpenAI";
            ResourceIdentifier endpointResourcePropertiesBasicResourceId = EndpointResourcePropertiesBasicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName);
            EndpointResourcePropertiesBasicResource endpointResourcePropertiesBasicResource = client.GetEndpointResourcePropertiesBasicResource(endpointResourcePropertiesBasicResourceId);

            // invoke the operation and iterate over the result
            await foreach (EndpointModelProperties item in endpointResourcePropertiesBasicResource.GetModelsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Regenerate Endpoint Keys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateKeys_RegenerateEndpointKeys()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Endpoint/regenerateKey.json
            // this example is just showing the usage of "Endpoint_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EndpointResourcePropertiesBasicResource created on azure
            // for more information of creating EndpointResourcePropertiesBasicResource, please refer to the document of EndpointResourcePropertiesBasicResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "aml-workspace-name";
            string endpointName = "Azure.OpenAI";
            ResourceIdentifier endpointResourcePropertiesBasicResourceId = EndpointResourcePropertiesBasicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName);
            EndpointResourcePropertiesBasicResource endpointResourcePropertiesBasicResource = client.GetEndpointResourcePropertiesBasicResource(endpointResourcePropertiesBasicResourceId);

            // invoke the operation
            RegenerateServiceAccountKeyContent content = new RegenerateServiceAccountKeyContent()
            {
                KeyName = ServiceAccountKeyName.Key1,
            };
            AccountApiKeys result = await endpointResourcePropertiesBasicResource.RegenerateKeysAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
