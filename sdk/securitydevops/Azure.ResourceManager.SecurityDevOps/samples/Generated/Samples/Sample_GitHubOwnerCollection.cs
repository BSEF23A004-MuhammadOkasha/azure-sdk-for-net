// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityDevOps.Samples
{
    public partial class Sample_GitHubOwnerCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GitHubOwnerList()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/GitHubOwnerList.json
            // this example is just showing the usage of "GitHubOwner_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GitHubConnectorResource created on azure
            // for more information of creating GitHubConnectorResource, please refer to the document of GitHubConnectorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string gitHubConnectorName = "testconnector";
            ResourceIdentifier gitHubConnectorResourceId = GitHubConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gitHubConnectorName);
            GitHubConnectorResource gitHubConnector = client.GetGitHubConnectorResource(gitHubConnectorResourceId);

            // get the collection of this GitHubOwnerResource
            GitHubOwnerCollection collection = gitHubConnector.GetGitHubOwners();

            // invoke the operation and iterate over the result
            await foreach (GitHubOwnerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GitHubOwnerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GitHubOwnerGet()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/GitHubOwnerGet.json
            // this example is just showing the usage of "GitHubOwner_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GitHubConnectorResource created on azure
            // for more information of creating GitHubConnectorResource, please refer to the document of GitHubConnectorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string gitHubConnectorName = "testconnector";
            ResourceIdentifier gitHubConnectorResourceId = GitHubConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gitHubConnectorName);
            GitHubConnectorResource gitHubConnector = client.GetGitHubConnectorResource(gitHubConnectorResourceId);

            // get the collection of this GitHubOwnerResource
            GitHubOwnerCollection collection = gitHubConnector.GetGitHubOwners();

            // invoke the operation
            string gitHubOwnerName = "Azure";
            GitHubOwnerResource result = await collection.GetAsync(gitHubOwnerName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GitHubOwnerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GitHubOwnerGet()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/GitHubOwnerGet.json
            // this example is just showing the usage of "GitHubOwner_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GitHubConnectorResource created on azure
            // for more information of creating GitHubConnectorResource, please refer to the document of GitHubConnectorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string gitHubConnectorName = "testconnector";
            ResourceIdentifier gitHubConnectorResourceId = GitHubConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gitHubConnectorName);
            GitHubConnectorResource gitHubConnector = client.GetGitHubConnectorResource(gitHubConnectorResourceId);

            // get the collection of this GitHubOwnerResource
            GitHubOwnerCollection collection = gitHubConnector.GetGitHubOwners();

            // invoke the operation
            string gitHubOwnerName = "Azure";
            bool result = await collection.ExistsAsync(gitHubOwnerName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GitHubOwnerGet()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/GitHubOwnerGet.json
            // this example is just showing the usage of "GitHubOwner_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GitHubConnectorResource created on azure
            // for more information of creating GitHubConnectorResource, please refer to the document of GitHubConnectorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string gitHubConnectorName = "testconnector";
            ResourceIdentifier gitHubConnectorResourceId = GitHubConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gitHubConnectorName);
            GitHubConnectorResource gitHubConnector = client.GetGitHubConnectorResource(gitHubConnectorResourceId);

            // get the collection of this GitHubOwnerResource
            GitHubOwnerCollection collection = gitHubConnector.GetGitHubOwners();

            // invoke the operation
            string gitHubOwnerName = "Azure";
            NullableResponse<GitHubOwnerResource> response = await collection.GetIfExistsAsync(gitHubOwnerName);
            GitHubOwnerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GitHubOwnerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_GitHubOwnerCreateOrUpdate()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/GitHubOwnerCreateOrUpdate.json
            // this example is just showing the usage of "GitHubOwner_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GitHubConnectorResource created on azure
            // for more information of creating GitHubConnectorResource, please refer to the document of GitHubConnectorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string gitHubConnectorName = "testconnector";
            ResourceIdentifier gitHubConnectorResourceId = GitHubConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gitHubConnectorName);
            GitHubConnectorResource gitHubConnector = client.GetGitHubConnectorResource(gitHubConnectorResourceId);

            // get the collection of this GitHubOwnerResource
            GitHubOwnerCollection collection = gitHubConnector.GetGitHubOwners();

            // invoke the operation
            string gitHubOwnerName = "Azure";
            GitHubOwnerData data = new GitHubOwnerData();
            ArmOperation<GitHubOwnerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, gitHubOwnerName, data);
            GitHubOwnerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GitHubOwnerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
