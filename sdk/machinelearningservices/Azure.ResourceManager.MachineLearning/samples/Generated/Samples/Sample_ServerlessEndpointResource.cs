// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_ServerlessEndpointResource
    {
        // Delete Workspace Serverless Endpoint.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteWorkspaceServerlessEndpoint()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/ServerlessEndpoint/delete.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/ServerlessEndpoint/delete.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "ServerlessEndpoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServerlessEndpointResource created on azure
            // for more information of creating ServerlessEndpointResource, please refer to the document of ServerlessEndpointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier serverlessEndpointResourceId = ServerlessEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            ServerlessEndpointResource serverlessEndpoint = client.GetServerlessEndpointResource(serverlessEndpointResourceId);

            // invoke the operation
            await serverlessEndpoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Workspace Serverless Endpoint.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceServerlessEndpoint()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/ServerlessEndpoint/get.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/ServerlessEndpoint/get.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "ServerlessEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServerlessEndpointResource created on azure
            // for more information of creating ServerlessEndpointResource, please refer to the document of ServerlessEndpointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier serverlessEndpointResourceId = ServerlessEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            ServerlessEndpointResource serverlessEndpoint = client.GetServerlessEndpointResource(serverlessEndpointResourceId);

            // invoke the operation
            ServerlessEndpointResource result = await serverlessEndpoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServerlessEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update Workspace Serverless Endpoint.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateWorkspaceServerlessEndpoint()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/ServerlessEndpoint/update.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/ServerlessEndpoint/update.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "ServerlessEndpoints_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServerlessEndpointResource created on azure
            // for more information of creating ServerlessEndpointResource, please refer to the document of ServerlessEndpointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier serverlessEndpointResourceId = ServerlessEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            ServerlessEndpointResource serverlessEndpoint = client.GetServerlessEndpointResource(serverlessEndpointResourceId);

            // invoke the operation
            ServerlessEndpointPatch patch = new ServerlessEndpointPatch()
            {
<<<<<<< HEAD
                Sku = new MachineLearningSkuPatch()
                {
                    Name = "string",
                    Tier = MachineLearningSkuTier.Premium,
                    Size = "string",
                    Family = "string",
                    Capacity = 1,
                },
=======
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                Identity = new MachineLearningPartialManagedServiceIdentity()
                {
                    ManagedServiceIdentityType = "None",
                    UserAssignedIdentities =
{
["string"] = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
{
}),
},
                },
<<<<<<< HEAD
=======
                Sku = new MachineLearningSkuPatch()
                {
                    Capacity = 1,
                    Family = "string",
                    Name = "string",
                    Size = "string",
                    Tier = MachineLearningSkuTier.Premium,
                },
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                Tags =
{
},
            };
            ArmOperation<ServerlessEndpointResource> lro = await serverlessEndpoint.UpdateAsync(WaitUntil.Completed, patch);
            ServerlessEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServerlessEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ListKeys Workspace Serverless Endpoint.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeys_ListKeysWorkspaceServerlessEndpoint()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/ServerlessEndpoint/listKeys.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/ServerlessEndpoint/listKeys.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "ServerlessEndpoints_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServerlessEndpointResource created on azure
            // for more information of creating ServerlessEndpointResource, please refer to the document of ServerlessEndpointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier serverlessEndpointResourceId = ServerlessEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            ServerlessEndpointResource serverlessEndpoint = client.GetServerlessEndpointResource(serverlessEndpointResourceId);

            // invoke the operation
            MachineLearningEndpointAuthKeys result = await serverlessEndpoint.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // RegenerateKeys Workspace Serverless Endpoint.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateKeys_RegenerateKeysWorkspaceServerlessEndpoint()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/ServerlessEndpoint/regenerateKeys.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/ServerlessEndpoint/regenerateKeys.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "ServerlessEndpoints_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServerlessEndpointResource created on azure
            // for more information of creating ServerlessEndpointResource, please refer to the document of ServerlessEndpointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier serverlessEndpointResourceId = ServerlessEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            ServerlessEndpointResource serverlessEndpoint = client.GetServerlessEndpointResource(serverlessEndpointResourceId);

            // invoke the operation
            MachineLearningEndpointKeyRegenerateContent content = new MachineLearningEndpointKeyRegenerateContent(MachineLearningKeyType.Primary)
            {
                KeyValue = "string",
            };
            ArmOperation<MachineLearningEndpointAuthKeys> lro = await serverlessEndpoint.RegenerateKeysAsync(WaitUntil.Completed, content);
            MachineLearningEndpointAuthKeys result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
