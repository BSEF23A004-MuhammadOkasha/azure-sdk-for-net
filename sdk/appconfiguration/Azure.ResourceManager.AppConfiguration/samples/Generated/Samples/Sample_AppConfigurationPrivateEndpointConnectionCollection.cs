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
using Azure.ResourceManager.AppConfiguration;
using Azure.ResourceManager.AppConfiguration.Models;

namespace Azure.ResourceManager.AppConfiguration.Samples
{
    public partial class Sample_AppConfigurationPrivateEndpointConnectionCollection
    {
        // PrivateEndpointConnection_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateEndpointConnectionList()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2022-05-01/examples/ConfigurationStoresListPrivateEndpointConnections.json
            // this example is just showing the usage of "PrivateEndpointConnections_ListByConfigurationStore" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationStoreResource created on azure
            // for more information of creating AppConfigurationStoreResource, please refer to the document of AppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            ResourceIdentifier appConfigurationStoreResourceId = AppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName);
            AppConfigurationStoreResource appConfigurationStore = client.GetAppConfigurationStoreResource(appConfigurationStoreResourceId);

            // get the collection of this AppConfigurationPrivateEndpointConnectionResource
            AppConfigurationPrivateEndpointConnectionCollection collection = appConfigurationStore.GetAppConfigurationPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (AppConfigurationPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppConfigurationPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateEndpointConnection_GetConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateEndpointConnectionGetConnection()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2022-05-01/examples/ConfigurationStoresGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationStoreResource created on azure
            // for more information of creating AppConfigurationStoreResource, please refer to the document of AppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            ResourceIdentifier appConfigurationStoreResourceId = AppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName);
            AppConfigurationStoreResource appConfigurationStore = client.GetAppConfigurationStoreResource(appConfigurationStoreResourceId);

            // get the collection of this AppConfigurationPrivateEndpointConnectionResource
            AppConfigurationPrivateEndpointConnectionCollection collection = appConfigurationStore.GetAppConfigurationPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myConnection";
            AppConfigurationPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppConfigurationPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnection_GetConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateEndpointConnectionGetConnection()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2022-05-01/examples/ConfigurationStoresGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationStoreResource created on azure
            // for more information of creating AppConfigurationStoreResource, please refer to the document of AppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            ResourceIdentifier appConfigurationStoreResourceId = AppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName);
            AppConfigurationStoreResource appConfigurationStore = client.GetAppConfigurationStoreResource(appConfigurationStoreResourceId);

            // get the collection of this AppConfigurationPrivateEndpointConnectionResource
            AppConfigurationPrivateEndpointConnectionCollection collection = appConfigurationStore.GetAppConfigurationPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myConnection";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateEndpointConnection_GetConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PrivateEndpointConnectionGetConnection()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2022-05-01/examples/ConfigurationStoresGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationStoreResource created on azure
            // for more information of creating AppConfigurationStoreResource, please refer to the document of AppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            ResourceIdentifier appConfigurationStoreResourceId = AppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName);
            AppConfigurationStoreResource appConfigurationStore = client.GetAppConfigurationStoreResource(appConfigurationStoreResourceId);

            // get the collection of this AppConfigurationPrivateEndpointConnectionResource
            AppConfigurationPrivateEndpointConnectionCollection collection = appConfigurationStore.GetAppConfigurationPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myConnection";
            NullableResponse<AppConfigurationPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            AppConfigurationPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppConfigurationPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PrivateEndpointConnection_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PrivateEndpointConnectionCreateOrUpdate()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2022-05-01/examples/ConfigurationStoresCreatePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationStoreResource created on azure
            // for more information of creating AppConfigurationStoreResource, please refer to the document of AppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            ResourceIdentifier appConfigurationStoreResourceId = AppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName);
            AppConfigurationStoreResource appConfigurationStore = client.GetAppConfigurationStoreResource(appConfigurationStoreResourceId);

            // get the collection of this AppConfigurationPrivateEndpointConnectionResource
            AppConfigurationPrivateEndpointConnectionCollection collection = appConfigurationStore.GetAppConfigurationPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myConnection";
            AppConfigurationPrivateEndpointConnectionData data = new AppConfigurationPrivateEndpointConnectionData()
            {
                ConnectionState = new AppConfigurationPrivateLinkServiceConnectionState()
                {
                    Status = AppConfigurationPrivateLinkServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<AppConfigurationPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            AppConfigurationPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppConfigurationPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
