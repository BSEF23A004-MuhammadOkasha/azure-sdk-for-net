// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudStorageApplianceResource
    {
        // List storage appliances for subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkCloudStorageAppliances_ListStorageAppliancesForSubscription()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/StorageAppliances_ListBySubscription.json
            // this example is just showing the usage of "StorageAppliances_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkCloudStorageApplianceResource item in subscriptionResource.GetNetworkCloudStorageAppliancesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudStorageApplianceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get storage appliance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetStorageAppliance()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/StorageAppliances_Get.json
            // this example is just showing the usage of "StorageAppliances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudStorageApplianceResource created on azure
            // for more information of creating NetworkCloudStorageApplianceResource, please refer to the document of NetworkCloudStorageApplianceResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string storageApplianceName = "storageApplianceName";
            ResourceIdentifier networkCloudStorageApplianceResourceId = NetworkCloudStorageApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageApplianceName);
            NetworkCloudStorageApplianceResource networkCloudStorageAppliance = client.GetNetworkCloudStorageApplianceResource(networkCloudStorageApplianceResourceId);

            // invoke the operation
            NetworkCloudStorageApplianceResource result = await networkCloudStorageAppliance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudStorageApplianceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch storage appliance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchStorageAppliance()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/StorageAppliances_Patch.json
            // this example is just showing the usage of "StorageAppliances_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudStorageApplianceResource created on azure
            // for more information of creating NetworkCloudStorageApplianceResource, please refer to the document of NetworkCloudStorageApplianceResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string storageApplianceName = "storageApplianceName";
            ResourceIdentifier networkCloudStorageApplianceResourceId = NetworkCloudStorageApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageApplianceName);
            NetworkCloudStorageApplianceResource networkCloudStorageAppliance = client.GetNetworkCloudStorageApplianceResource(networkCloudStorageApplianceResourceId);

            // invoke the operation
            NetworkCloudStorageAppliancePatch patch = new NetworkCloudStorageAppliancePatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                SerialNumber = "BM1219XXX",
            };
            ArmOperation<NetworkCloudStorageApplianceResource> lro = await networkCloudStorageAppliance.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudStorageApplianceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudStorageApplianceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Turn off remote vendor management for storage appliance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DisableRemoteVendorManagement_TurnOffRemoteVendorManagementForStorageAppliance()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/StorageAppliances_DisableRemoteVendorManagement.json
            // this example is just showing the usage of "StorageAppliances_DisableRemoteVendorManagement" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudStorageApplianceResource created on azure
            // for more information of creating NetworkCloudStorageApplianceResource, please refer to the document of NetworkCloudStorageApplianceResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string storageApplianceName = "storageApplianceName";
            ResourceIdentifier networkCloudStorageApplianceResourceId = NetworkCloudStorageApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageApplianceName);
            NetworkCloudStorageApplianceResource networkCloudStorageAppliance = client.GetNetworkCloudStorageApplianceResource(networkCloudStorageApplianceResourceId);

            // invoke the operation
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudStorageAppliance.DisableRemoteVendorManagementAsync(WaitUntil.Completed);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Turn on remote vendor management for storage appliance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task EnableRemoteVendorManagement_TurnOnRemoteVendorManagementForStorageAppliance()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/StorageAppliances_EnableRemoteVendorManagement.json
            // this example is just showing the usage of "StorageAppliances_EnableRemoteVendorManagement" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudStorageApplianceResource created on azure
            // for more information of creating NetworkCloudStorageApplianceResource, please refer to the document of NetworkCloudStorageApplianceResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string storageApplianceName = "storageApplianceName";
            ResourceIdentifier networkCloudStorageApplianceResourceId = NetworkCloudStorageApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageApplianceName);
            NetworkCloudStorageApplianceResource networkCloudStorageAppliance = client.GetNetworkCloudStorageApplianceResource(networkCloudStorageApplianceResourceId);

            // invoke the operation
            StorageApplianceEnableRemoteVendorManagementContent content = new StorageApplianceEnableRemoteVendorManagementContent()
            {
                SupportEndpoints =
{
"10.0.0.0/24"
},
            };
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudStorageAppliance.EnableRemoteVendorManagementAsync(WaitUntil.Completed, content: content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
