// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBSqlRoleDefinitionResource
    {
        // CosmosDBSqlRoleDefinitionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBSqlRoleDefinitionGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBSqlRoleDefinitionGet.json
            // this example is just showing the usage of "SqlResources_GetSqlRoleDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlRoleDefinitionResource created on azure
            // for more information of creating CosmosDBSqlRoleDefinitionResource, please refer to the document of CosmosDBSqlRoleDefinitionResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            string roleDefinitionId = "myRoleDefinitionId";
            ResourceIdentifier cosmosDBSqlRoleDefinitionResourceId = CosmosDBSqlRoleDefinitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, roleDefinitionId);
            CosmosDBSqlRoleDefinitionResource cosmosDBSqlRoleDefinition = client.GetCosmosDBSqlRoleDefinitionResource(cosmosDBSqlRoleDefinitionResourceId);

            // invoke the operation
            CosmosDBSqlRoleDefinitionResource result = await cosmosDBSqlRoleDefinition.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlRoleDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlRoleDefinitionCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBSqlRoleDefinitionCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBSqlRoleDefinitionCreateUpdate.json
            // this example is just showing the usage of "SqlResources_CreateUpdateSqlRoleDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlRoleDefinitionResource created on azure
            // for more information of creating CosmosDBSqlRoleDefinitionResource, please refer to the document of CosmosDBSqlRoleDefinitionResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            string roleDefinitionId = "myRoleDefinitionId";
            ResourceIdentifier cosmosDBSqlRoleDefinitionResourceId = CosmosDBSqlRoleDefinitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, roleDefinitionId);
            CosmosDBSqlRoleDefinitionResource cosmosDBSqlRoleDefinition = client.GetCosmosDBSqlRoleDefinitionResource(cosmosDBSqlRoleDefinitionResourceId);

            // invoke the operation
            CosmosDBSqlRoleDefinitionCreateOrUpdateContent content = new CosmosDBSqlRoleDefinitionCreateOrUpdateContent()
            {
                RoleName = "myRoleName",
                RoleDefinitionType = CosmosDBSqlRoleDefinitionType.CustomRole,
                AssignableScopes =
{
"/subscriptions/mySubscriptionId/resourceGroups/myResourceGroupName/providers/Microsoft.DocumentDB/databaseAccounts/myAccountName/dbs/sales","/subscriptions/mySubscriptionId/resourceGroups/myResourceGroupName/providers/Microsoft.DocumentDB/databaseAccounts/myAccountName/dbs/purchases"
},
                Permissions =
{
new CosmosDBSqlRolePermission()
{
DataActions =
{
"Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/items/create","Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/items/read"
},
NotDataActions =
{
},
}
},
            };
            ArmOperation<CosmosDBSqlRoleDefinitionResource> lro = await cosmosDBSqlRoleDefinition.UpdateAsync(WaitUntil.Completed, content);
            CosmosDBSqlRoleDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlRoleDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlRoleDefinitionDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CosmosDBSqlRoleDefinitionDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBSqlRoleDefinitionDelete.json
            // this example is just showing the usage of "SqlResources_DeleteSqlRoleDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlRoleDefinitionResource created on azure
            // for more information of creating CosmosDBSqlRoleDefinitionResource, please refer to the document of CosmosDBSqlRoleDefinitionResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            string roleDefinitionId = "myRoleDefinitionId";
            ResourceIdentifier cosmosDBSqlRoleDefinitionResourceId = CosmosDBSqlRoleDefinitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, roleDefinitionId);
            CosmosDBSqlRoleDefinitionResource cosmosDBSqlRoleDefinition = client.GetCosmosDBSqlRoleDefinitionResource(cosmosDBSqlRoleDefinitionResourceId);

            // invoke the operation
            await cosmosDBSqlRoleDefinition.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
