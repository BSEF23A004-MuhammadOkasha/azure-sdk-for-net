// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Samples
{
    public partial class Sample_PostgreSqlFlexibleServerDatabaseResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateADatabase()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/DatabaseCreate.json
            // this example is just showing the usage of "Databases_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerDatabaseResource created on azure
            // for more information of creating PostgreSqlFlexibleServerDatabaseResource, please refer to the document of PostgreSqlFlexibleServerDatabaseResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string databaseName = "db1";
            ResourceIdentifier postgreSqlFlexibleServerDatabaseResourceId = PostgreSqlFlexibleServerDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            PostgreSqlFlexibleServerDatabaseResource postgreSqlFlexibleServerDatabase = client.GetPostgreSqlFlexibleServerDatabaseResource(postgreSqlFlexibleServerDatabaseResourceId);

            // invoke the operation
            PostgreSqlFlexibleServerDatabaseData data = new PostgreSqlFlexibleServerDatabaseData()
            {
                Charset = "utf8",
                Collation = "en_US.utf8",
            };
            ArmOperation<PostgreSqlFlexibleServerDatabaseResource> lro = await postgreSqlFlexibleServerDatabase.UpdateAsync(WaitUntil.Completed, data);
            PostgreSqlFlexibleServerDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFlexibleServerDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteADatabase()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/DatabaseDelete.json
            // this example is just showing the usage of "Databases_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerDatabaseResource created on azure
            // for more information of creating PostgreSqlFlexibleServerDatabaseResource, please refer to the document of PostgreSqlFlexibleServerDatabaseResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string databaseName = "db1";
            ResourceIdentifier postgreSqlFlexibleServerDatabaseResourceId = PostgreSqlFlexibleServerDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            PostgreSqlFlexibleServerDatabaseResource postgreSqlFlexibleServerDatabase = client.GetPostgreSqlFlexibleServerDatabaseResource(postgreSqlFlexibleServerDatabaseResourceId);

            // invoke the operation
            await postgreSqlFlexibleServerDatabase.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetADatabase()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/DatabaseGet.json
            // this example is just showing the usage of "Databases_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerDatabaseResource created on azure
            // for more information of creating PostgreSqlFlexibleServerDatabaseResource, please refer to the document of PostgreSqlFlexibleServerDatabaseResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string databaseName = "db1";
            ResourceIdentifier postgreSqlFlexibleServerDatabaseResourceId = PostgreSqlFlexibleServerDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            PostgreSqlFlexibleServerDatabaseResource postgreSqlFlexibleServerDatabase = client.GetPostgreSqlFlexibleServerDatabaseResource(postgreSqlFlexibleServerDatabaseResourceId);

            // invoke the operation
            PostgreSqlFlexibleServerDatabaseResource result = await postgreSqlFlexibleServerDatabase.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFlexibleServerDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
