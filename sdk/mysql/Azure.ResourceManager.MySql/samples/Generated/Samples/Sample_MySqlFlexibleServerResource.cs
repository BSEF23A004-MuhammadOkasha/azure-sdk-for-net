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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.FlexibleServers;
using Azure.ResourceManager.MySql.FlexibleServers.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MySql.FlexibleServers.Samples
{
    public partial class Sample_MySqlFlexibleServerResource
    {
        // Create and Export Backup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateBackupAndExport_CreateAndExportBackup()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Backups/preview/2022-09-30-preview/examples/BackupAndExport.json
            // this example is just showing the usage of "BackupAndExport_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "mysqltestserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            MySqlFlexibleServerBackupAndExportContent content = new MySqlFlexibleServerBackupAndExportContent(new MySqlFlexibleServerBackupSettings("customer-backup-name"), new MySqlFlexibleServerFullBackupStoreDetails(new string[]
            {
"sasuri1","sasuri2"
            }));
            ArmOperation<MySqlFlexibleServerBackupAndExportResult> lro = await mySqlFlexibleServer.CreateBackupAndExportAsync(WaitUntil.Completed, content);
            MySqlFlexibleServerBackupAndExportResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Validate Backup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ValidateBackup_ValidateBackup()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Backups/preview/2022-09-30-preview/examples/ValidateBackup.json
            // this example is just showing the usage of "BackupAndExport_ValidateBackup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "mysqltestserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            MySqlFlexibleServerValidateBackupResult result = await mySqlFlexibleServer.ValidateBackupAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConfigurationList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateConfigurations_ConfigurationList()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Configurations/preview/2021-12-01-preview/examples/ConfigurationsBatchUpdate.json
            // this example is just showing the usage of "Configurations_BatchUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            MySqlFlexibleServerConfigurationListForBatchUpdate mySqlFlexibleServerConfigurationListForBatchUpdate = new MySqlFlexibleServerConfigurationListForBatchUpdate()
            {
                Values =
{
new MySqlFlexibleServerConfigurationForBatchUpdate()
{
Name = "event_scheduler",
Value = "OFF",
},new MySqlFlexibleServerConfigurationForBatchUpdate()
{
Name = "div_precision_increment",
Value = "8",
}
},
                ResetAllToDefault = MySqlFlexibleServerConfigurationResetAllToDefault.False,
            };
            ArmOperation<MySqlFlexibleServerConfigurations> lro = await mySqlFlexibleServer.UpdateConfigurationsAsync(WaitUntil.Completed, mySqlFlexibleServerConfigurationListForBatchUpdate);
            MySqlFlexibleServerConfigurations result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Update a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerUpdate.json
            // this example is just showing the usage of "Servers_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            MySqlFlexibleServerPatch patch = new MySqlFlexibleServerPatch()
            {
                Storage = new MySqlFlexibleServerStorage()
                {
                    StorageSizeInGB = 30,
                    Iops = 200,
                    AutoGrow = MySqlFlexibleServerEnableStatusEnum.Disabled,
                    AutoIoScaling = MySqlFlexibleServerEnableStatusEnum.Disabled,
                },
            };
            ArmOperation<MySqlFlexibleServerResource> lro = await mySqlFlexibleServer.UpdateAsync(WaitUntil.Completed, patch);
            MySqlFlexibleServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update server customer maintenance window
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateServerCustomerMaintenanceWindow()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerUpdateWithCustomerMaintenanceWindow.json
            // this example is just showing the usage of "Servers_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            MySqlFlexibleServerPatch patch = new MySqlFlexibleServerPatch()
            {
                MaintenanceWindow = new MySqlFlexibleServerMaintenanceWindow()
                {
                    CustomWindow = "Enabled",
                    StartHour = 8,
                    StartMinute = 0,
                    DayOfWeek = 1,
                },
            };
            ArmOperation<MySqlFlexibleServerResource> lro = await mySqlFlexibleServer.UpdateAsync(WaitUntil.Completed, patch);
            MySqlFlexibleServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update server with byok
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateServerWithByok()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerUpdateWithBYOK.json
            // this example is just showing the usage of "Servers_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            MySqlFlexibleServerPatch patch = new MySqlFlexibleServerPatch()
            {
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/testrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-identity")] = new UserAssignedIdentity(),
},
                },
                DataEncryption = new MySqlFlexibleServerDataEncryption()
                {
                    PrimaryUserAssignedIdentityId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/testrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-identity"),
                    PrimaryKeyUri = new Uri("https://test.vault.azure.net/keys/key/c8a92236622244c0a4fdb892666f671a"),
                    GeoBackupUserAssignedIdentityId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/testrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-geo-identity"),
                    GeoBackupKeyUri = new Uri("https://test-geo.vault.azure.net/keys/key/c8a92236622244c0a4fdb892666f671a"),
                    EncryptionType = MySqlFlexibleServerDataEncryptionType.AzureKeyVault,
                },
            };
            ArmOperation<MySqlFlexibleServerResource> lro = await mySqlFlexibleServer.UpdateAsync(WaitUntil.Completed, patch);
            MySqlFlexibleServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerDelete.json
            // this example is just showing the usage of "Servers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            await mySqlFlexibleServer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerGet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            MySqlFlexibleServerResource result = await mySqlFlexibleServer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a server with vnet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAServerWithVnet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerGetWithVnet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            MySqlFlexibleServerResource result = await mySqlFlexibleServer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List servers in a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetMySqlFlexibleServers_ListServersInASubscription()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServersList.json
            // this example is just showing the usage of "Servers_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (MySqlFlexibleServerResource item in subscriptionResource.GetMySqlFlexibleServersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Restart a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Failover_RestartAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerFailover.json
            // this example is just showing the usage of "Servers_Failover" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            await mySqlFlexibleServer.FailoverAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Restart a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Restart_RestartAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerRestart.json
            // this example is just showing the usage of "Servers_Restart" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            MySqlFlexibleServerRestartParameter mySqlFlexibleServerRestartParameter = new MySqlFlexibleServerRestartParameter()
            {
                RestartWithFailover = MySqlFlexibleServerEnableStatusEnum.Enabled,
                MaxFailoverSeconds = 60,
            };
            await mySqlFlexibleServer.RestartAsync(WaitUntil.Completed, mySqlFlexibleServerRestartParameter);

            Console.WriteLine($"Succeeded");
        }

        // Start a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_StartAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerStart.json
            // this example is just showing the usage of "Servers_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            await mySqlFlexibleServer.StartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Stop a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_StopAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerStop.json
            // this example is just showing the usage of "Servers_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            await mySqlFlexibleServer.StopAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Reset GTID on a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ResetGtid_ResetGTIDOnAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2022-09-30-preview/examples/ServerResetGtid.json
            // this example is just showing the usage of "Servers_ResetGtid" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation
            MySqlFlexibleServerGtidSetContent content = new MySqlFlexibleServerGtidSetContent()
            {
                GtidSet = "4aff5b51-97ba-11ed-a955-002248036acc:1-16",
            };
            await mySqlFlexibleServer.ResetGtidAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // List all server log files for a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetLogFiles_ListAllServerLogFilesForAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/LogFiles/preview/2021-12-01-preview/examples/LogFilesListByServer.json
            // this example is just showing the usage of "LogFiles_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestsvc1";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // invoke the operation and iterate over the result
            await foreach (MySqlFlexibleServerLogFile item in mySqlFlexibleServer.GetLogFilesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
