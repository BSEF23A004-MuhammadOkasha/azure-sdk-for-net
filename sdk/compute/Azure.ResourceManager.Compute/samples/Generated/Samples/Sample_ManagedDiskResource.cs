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
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_ManagedDiskResource
    {
        // Create or update a bursting enabled managed disk.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateABurstingEnabledManagedDisk()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_CreateOrUpdate_BurstingEnabled.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                DiskSizeGB = 1024,
                BurstingEnabled = true,
            };
            ArmOperation<ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a managed disk to add accelerated networking.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAManagedDiskToAddAcceleratedNetworking()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Update_AddAcceleratedNetworking.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                SupportedCapabilities = new SupportedCapabilities()
                {
                    AcceleratedNetwork = false,
                },
            };
            ArmOperation<ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a managed disk to add architecture.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAManagedDiskToAddArchitecture()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Update_ToAddArchitecture.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                SupportedCapabilities = new SupportedCapabilities()
                {
                    Architecture = ArchitectureType.Arm64,
                },
            };
            ArmOperation<ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a managed disk to add purchase plan.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAManagedDiskToAddPurchasePlan()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Update_AddPurchasePlan.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                PurchasePlan = new DiskPurchasePlan("myPurchasePlanName", "myPurchasePlanPublisher", "myPurchasePlanProduct")
                {
                    PromotionCode = "myPurchasePlanPromotionCode",
                },
            };
            ArmOperation<ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a managed disk to add supportsHibernation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAManagedDiskToAddSupportsHibernation()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Update_AddSupportsHibernation.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                SupportsHibernation = true,
            };
            ArmOperation<ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a managed disk to change tier.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAManagedDiskToChangeTier()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Update_ChangeTier.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                Tier = "P30",
            };
            ArmOperation<ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a managed disk to disable bursting.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAManagedDiskToDisableBursting()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Update_DisableBursting.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                BurstingEnabled = false,
            };
            ArmOperation<ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a managed disk to disable optimizedForFrequentAttach.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAManagedDiskToDisableOptimizedForFrequentAttach()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Update_DisableOptimizedForFrequentAttach.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                IsOptimizedForFrequentAttach = false,
            };
            ArmOperation<ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a managed disk with diskControllerTypes.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAManagedDiskWithDiskControllerTypes()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Update_AddDiskControllerTypes.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                SupportedCapabilities = new SupportedCapabilities()
                {
                    DiskControllerTypes = "SCSI",
                },
            };
            ArmOperation<ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update managed disk to remove disk access resource association.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateManagedDiskToRemoveDiskAccessResourceAssociation()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Update_RemoveDiskAccess.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                NetworkAccessPolicy = NetworkAccessPolicy.AllowAll,
            };
            ArmOperation<ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get information about a managed disk.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetInformationAboutAManagedDisk()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Get.json
            // this example is just showing the usage of "Disks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myManagedDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            ManagedDiskResource result = await managedDisk.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a managed disk.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAManagedDisk()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_Delete.json
            // this example is just showing the usage of "Disks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            await managedDisk.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // List all managed disks in a subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetManagedDisks_ListAllManagedDisksInASubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_ListBySubscription.json
            // this example is just showing the usage of "Disks_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ManagedDiskResource item in subscriptionResource.GetManagedDisksAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedDiskData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a sas on a managed disk.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GrantAccess_GetASasOnAManagedDisk()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_BeginGetAccess.json
            // this example is just showing the usage of "Disks_GrantAccess" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            GrantAccessData data = new GrantAccessData(AccessLevel.Read, 300)
            {
                FileFormat = DiskImageFileFormat.Vhd,
            };
            ArmOperation<AccessUri> lro = await managedDisk.GrantAccessAsync(WaitUntil.Completed, data);
            AccessUri result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get sas on managed disk and VM guest state
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GrantAccess_GetSasOnManagedDiskAndVMGuestState()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_BeginGetAccess_WithVMGuestState.json
            // this example is just showing the usage of "Disks_GrantAccess" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            GrantAccessData data = new GrantAccessData(AccessLevel.Read, 300)
            {
                GetSecureVmGuestStateSas = true,
            };
            ArmOperation<AccessUri> lro = await managedDisk.GrantAccessAsync(WaitUntil.Completed, data);
            AccessUri result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Revoke access to a managed disk.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RevokeAccess_RevokeAccessToAManagedDisk()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2023-01-02/examples/diskExamples/Disk_EndGetAccess.json
            // this example is just showing the usage of "Disks_RevokeAccess" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            await managedDisk.RevokeAccessAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
