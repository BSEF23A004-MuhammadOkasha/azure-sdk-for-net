// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerJobCredentialResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetACredential()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/GetJobCredential.json
            // this example is just showing the usage of "JobCredentials_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobCredentialResource created on azure
            // for more information of creating SqlServerJobCredentialResource, please refer to the document of SqlServerJobCredentialResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string credentialName = "cred1";
            ResourceIdentifier sqlServerJobCredentialResourceId = SqlServerJobCredentialResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, credentialName);
            SqlServerJobCredentialResource sqlServerJobCredential = client.GetSqlServerJobCredentialResource(sqlServerJobCredentialResourceId);

            // invoke the operation
            SqlServerJobCredentialResource result = await sqlServerJobCredential.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerJobCredentialData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateACredential()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/CreateOrUpdateJobCredential.json
            // this example is just showing the usage of "JobCredentials_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobCredentialResource created on azure
            // for more information of creating SqlServerJobCredentialResource, please refer to the document of SqlServerJobCredentialResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string credentialName = "cred1";
            ResourceIdentifier sqlServerJobCredentialResourceId = SqlServerJobCredentialResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, credentialName);
            SqlServerJobCredentialResource sqlServerJobCredential = client.GetSqlServerJobCredentialResource(sqlServerJobCredentialResourceId);

            // invoke the operation
            SqlServerJobCredentialData data = new SqlServerJobCredentialData()
            {
                Username = "myuser",
                Password = "<password>",
            };
            ArmOperation<SqlServerJobCredentialResource> lro = await sqlServerJobCredential.UpdateAsync(WaitUntil.Completed, data);
            SqlServerJobCredentialResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerJobCredentialData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteACredential()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DeleteJobCredential.json
            // this example is just showing the usage of "JobCredentials_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobCredentialResource created on azure
            // for more information of creating SqlServerJobCredentialResource, please refer to the document of SqlServerJobCredentialResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string credentialName = "cred1";
            ResourceIdentifier sqlServerJobCredentialResourceId = SqlServerJobCredentialResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, credentialName);
            SqlServerJobCredentialResource sqlServerJobCredential = client.GetSqlServerJobCredentialResource(sqlServerJobCredentialResourceId);

            // invoke the operation
            await sqlServerJobCredential.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
