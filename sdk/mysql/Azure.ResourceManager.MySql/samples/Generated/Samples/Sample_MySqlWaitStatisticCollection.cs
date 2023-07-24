// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql;
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql.Samples
{
    public partial class Sample_MySqlWaitStatisticCollection
    {
        // WaitStatisticsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WaitStatisticsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/WaitStatisticsGet.json
            // this example is just showing the usage of "WaitStatistics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlWaitStatisticResource
            MySqlWaitStatisticCollection collection = mySqlServer.GetMySqlWaitStatistics();

            // invoke the operation
            string waitStatisticsId = "636927606000000000-636927615000000000-send-wait/io/socket/sql/client_connection-2--0";
            MySqlWaitStatisticResource result = await collection.GetAsync(waitStatisticsId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlWaitStatisticData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WaitStatisticsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_WaitStatisticsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/WaitStatisticsGet.json
            // this example is just showing the usage of "WaitStatistics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlWaitStatisticResource
            MySqlWaitStatisticCollection collection = mySqlServer.GetMySqlWaitStatistics();

            // invoke the operation
            string waitStatisticsId = "636927606000000000-636927615000000000-send-wait/io/socket/sql/client_connection-2--0";
            bool result = await collection.ExistsAsync(waitStatisticsId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // WaitStatisticsListByServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WaitStatisticsListByServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/WaitStatisticsListByServer.json
            // this example is just showing the usage of "WaitStatistics_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlWaitStatisticResource
            MySqlWaitStatisticCollection collection = mySqlServer.GetMySqlWaitStatistics();

            // invoke the operation and iterate over the result
            MySqlWaitStatisticsInput input = new MySqlWaitStatisticsInput(DateTimeOffset.Parse("2019-05-01T20:00:00.000Z"), DateTimeOffset.Parse("2019-05-07T20:00:00.000Z"), "PT15M");
            await foreach (MySqlWaitStatisticResource item in collection.GetAllAsync(input))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlWaitStatisticData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
