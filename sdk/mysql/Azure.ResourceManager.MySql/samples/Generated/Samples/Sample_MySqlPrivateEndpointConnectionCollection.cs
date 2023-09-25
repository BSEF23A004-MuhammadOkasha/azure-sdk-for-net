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
using Azure.ResourceManager.MySql;
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql.Samples
{
    public partial class Sample_MySqlPrivateEndpointConnectionCollection
    {
        // Gets private endpoint connection.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/PrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "test-svr";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlPrivateEndpointConnectionResource
            MySqlPrivateEndpointConnectionCollection collection = mySqlServer.GetMySqlPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "private-endpoint-connection-name";
            MySqlPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets private endpoint connection.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/PrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "test-svr";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlPrivateEndpointConnectionResource
            MySqlPrivateEndpointConnectionCollection collection = mySqlServer.GetMySqlPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "private-endpoint-connection-name";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets private endpoint connection.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/PrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "test-svr";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlPrivateEndpointConnectionResource
            MySqlPrivateEndpointConnectionCollection collection = mySqlServer.GetMySqlPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "private-endpoint-connection-name";
            NullableResponse<MySqlPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            MySqlPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Approve or reject a private endpoint connection with a given name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApproveOrRejectAPrivateEndpointConnectionWithAGivenName()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/PrivateEndpointConnectionUpdate.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "test-svr";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlPrivateEndpointConnectionResource
            MySqlPrivateEndpointConnectionCollection collection = mySqlServer.GetMySqlPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "private-endpoint-connection-name";
            MySqlPrivateEndpointConnectionData data = new MySqlPrivateEndpointConnectionData()
            {
                ConnectionState = new MySqlPrivateLinkServiceConnectionStateProperty("Approved", "Approved by johndoe@contoso.com"),
            };
            ArmOperation<MySqlPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            MySqlPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets list of private endpoint connections on a server.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetsListOfPrivateEndpointConnectionsOnAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/PrivateEndpointConnectionList.json
            // this example is just showing the usage of "PrivateEndpointConnections_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "test-svr";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlPrivateEndpointConnectionResource
            MySqlPrivateEndpointConnectionCollection collection = mySqlServer.GetMySqlPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (MySqlPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
