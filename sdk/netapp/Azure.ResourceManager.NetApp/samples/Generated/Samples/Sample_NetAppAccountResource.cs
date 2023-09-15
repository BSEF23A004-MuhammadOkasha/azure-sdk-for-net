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
using Azure.ResourceManager.NetApp;
using Azure.ResourceManager.NetApp.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppAccountResource
    {
        // Accounts_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetAppAccounts_AccountsList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/Accounts_List.json
            // this example is just showing the usage of "Accounts_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetAppAccountResource item in subscriptionResource.GetNetAppAccountsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppAccountData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Accounts_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AccountsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/Accounts_Get.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // invoke the operation
            NetAppAccountResource result = await netAppAccount.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Accounts_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_AccountsDelete()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/Accounts_Delete.json
            // this example is just showing the usage of "Accounts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // invoke the operation
            await netAppAccount.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Accounts_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_AccountsUpdate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/Accounts_Update.json
            // this example is just showing the usage of "Accounts_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // invoke the operation
            NetAppAccountPatch patch = new NetAppAccountPatch(new AzureLocation("placeholder"))
            {
                Tags =
{
["Tag1"] = "Value1",
},
            };
            ArmOperation<NetAppAccountResource> lro = await netAppAccount.UpdateAsync(WaitUntil.Completed, patch);
            NetAppAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Accounts_RenewCredentials
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RenewCredentials_AccountsRenewCredentials()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/Accounts_RenewCredentials.json
            // this example is just showing the usage of "Accounts_RenewCredentials" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // invoke the operation
            await netAppAccount.RenewCredentialsAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VolumeGroups_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVolumeGroups_VolumeGroupsList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/VolumeGroups_List.json
            // this example is just showing the usage of "VolumeGroups_ListByNetAppAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetAppVolumeGroupResult item in netAppAccount.GetVolumeGroupsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
