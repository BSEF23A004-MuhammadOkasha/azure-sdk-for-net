// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.MySql.FlexibleServers.Samples
{
    public partial class Sample_MySqlFlexibleServerDatabaseResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateADatabase()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Databases/stable/2023-12-30/examples/DatabaseCreate.json
            // this example is just showing the usage of "Databases_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerDatabaseResource created on azure
            // for more information of creating MySqlFlexibleServerDatabaseResource, please refer to the document of MySqlFlexibleServerDatabaseResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string databaseName = "db1";
            ResourceIdentifier mySqlFlexibleServerDatabaseResourceId = MySqlFlexibleServerDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            MySqlFlexibleServerDatabaseResource mySqlFlexibleServerDatabase = client.GetMySqlFlexibleServerDatabaseResource(mySqlFlexibleServerDatabaseResourceId);

            // invoke the operation
            MySqlFlexibleServerDatabaseData data = new MySqlFlexibleServerDatabaseData()
            {
                Charset = "utf8",
                Collation = "utf8_general_ci",
            };
            ArmOperation<MySqlFlexibleServerDatabaseResource> lro = await mySqlFlexibleServerDatabase.UpdateAsync(WaitUntil.Completed, data);
            MySqlFlexibleServerDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteADatabase()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Databases/stable/2023-12-30/examples/DatabaseDelete.json
            // this example is just showing the usage of "Databases_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerDatabaseResource created on azure
            // for more information of creating MySqlFlexibleServerDatabaseResource, please refer to the document of MySqlFlexibleServerDatabaseResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string databaseName = "db1";
            ResourceIdentifier mySqlFlexibleServerDatabaseResourceId = MySqlFlexibleServerDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            MySqlFlexibleServerDatabaseResource mySqlFlexibleServerDatabase = client.GetMySqlFlexibleServerDatabaseResource(mySqlFlexibleServerDatabaseResourceId);

            // invoke the operation
            await mySqlFlexibleServerDatabase.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetADatabase()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Databases/stable/2023-12-30/examples/DatabaseGet.json
            // this example is just showing the usage of "Databases_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerDatabaseResource created on azure
            // for more information of creating MySqlFlexibleServerDatabaseResource, please refer to the document of MySqlFlexibleServerDatabaseResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string databaseName = "db1";
            ResourceIdentifier mySqlFlexibleServerDatabaseResourceId = MySqlFlexibleServerDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            MySqlFlexibleServerDatabaseResource mySqlFlexibleServerDatabase = client.GetMySqlFlexibleServerDatabaseResource(mySqlFlexibleServerDatabaseResourceId);

            // invoke the operation
            MySqlFlexibleServerDatabaseResource result = await mySqlFlexibleServerDatabase.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
