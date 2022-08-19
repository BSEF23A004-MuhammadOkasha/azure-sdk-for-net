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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_DiskEncryptionSetCollection
    {
        // Create a disk encryption set with key vault from a different subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateADiskEncryptionSetWithKeyVaultFromADifferentSubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskEncryptionSetExamples/DiskEncryptionSet_Create_WithKeyVaultFromADifferentSubscription.json
            // this example is just showing the usage of "DiskEncryptionSets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskEncryptionSetResource
            Compute.DiskEncryptionSetCollection collection = resourceGroupResource.GetDiskEncryptionSets();

            // invoke the operation
            string diskEncryptionSetName = "myDiskEncryptionSet";
            Compute.DiskEncryptionSetData data = new DiskEncryptionSetData(new AzureLocation("West US"))
            {
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                EncryptionType = DiskEncryptionSetType.EncryptionAtRestWithCustomerKey,
                ActiveKey = new KeyForDiskEncryptionSet(new Uri("https://myvaultdifferentsub.vault-int.azure-int.net/keys/{key}")),
            };
            ArmOperation<Compute.DiskEncryptionSetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, diskEncryptionSetName, data);
            Compute.DiskEncryptionSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.DiskEncryptionSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a disk encryption set with key vault from a different tenant.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateADiskEncryptionSetWithKeyVaultFromADifferentTenant()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskEncryptionSetExamples/DiskEncryptionSet_Create_WithKeyVaultFromADifferentTenant.json
            // this example is just showing the usage of "DiskEncryptionSets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskEncryptionSetResource
            Compute.DiskEncryptionSetCollection collection = resourceGroupResource.GetDiskEncryptionSets();

            // invoke the operation
            string diskEncryptionSetName = "myDiskEncryptionSet";
            Compute.DiskEncryptionSetData data = new DiskEncryptionSetData(new AzureLocation("West US"))
            {
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}")] = new UserAssignedIdentity(),
},
                },
                EncryptionType = DiskEncryptionSetType.EncryptionAtRestWithCustomerKey,
                ActiveKey = new KeyForDiskEncryptionSet(new Uri("https://myvaultdifferenttenant.vault-int.azure-int.net/keys/{key}")),
                FederatedClientId = "00000000-0000-0000-0000-000000000000",
            };
            ArmOperation<Compute.DiskEncryptionSetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, diskEncryptionSetName, data);
            Compute.DiskEncryptionSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.DiskEncryptionSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a disk encryption set.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateADiskEncryptionSet()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskEncryptionSetExamples/DiskEncryptionSet_Create.json
            // this example is just showing the usage of "DiskEncryptionSets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskEncryptionSetResource
            Compute.DiskEncryptionSetCollection collection = resourceGroupResource.GetDiskEncryptionSets();

            // invoke the operation
            string diskEncryptionSetName = "myDiskEncryptionSet";
            Compute.DiskEncryptionSetData data = new DiskEncryptionSetData(new AzureLocation("West US"))
            {
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                EncryptionType = DiskEncryptionSetType.EncryptionAtRestWithCustomerKey,
                ActiveKey = new KeyForDiskEncryptionSet(new Uri("https://myvmvault.vault-int.azure-int.net/keys/{key}"))
                {
                    SourceVaultId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/myResourceGroup/providers/Microsoft.KeyVault/vaults/myVMVault"),
                },
            };
            ArmOperation<Compute.DiskEncryptionSetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, diskEncryptionSetName, data);
            Compute.DiskEncryptionSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.DiskEncryptionSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get information about a disk encryption set when auto-key rotation failed.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetInformationAboutADiskEncryptionSetWhenAutoKeyRotationFailed()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskEncryptionSetExamples/DiskEncryptionSet_Get_WithAutoKeyRotationError.json
            // this example is just showing the usage of "DiskEncryptionSets_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskEncryptionSetResource
            Compute.DiskEncryptionSetCollection collection = resourceGroupResource.GetDiskEncryptionSets();

            // invoke the operation
            string diskEncryptionSetName = "myDiskEncryptionSet";
            Compute.DiskEncryptionSetResource result = await collection.GetAsync(diskEncryptionSetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.DiskEncryptionSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get information about a disk encryption set.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetInformationAboutADiskEncryptionSet()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskEncryptionSetExamples/DiskEncryptionSet_Get.json
            // this example is just showing the usage of "DiskEncryptionSets_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskEncryptionSetResource
            Compute.DiskEncryptionSetCollection collection = resourceGroupResource.GetDiskEncryptionSets();

            // invoke the operation
            string diskEncryptionSetName = "myDiskEncryptionSet";
            Compute.DiskEncryptionSetResource result = await collection.GetAsync(diskEncryptionSetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.DiskEncryptionSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all disk encryption sets in a resource group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllDiskEncryptionSetsInAResourceGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskEncryptionSetExamples/DiskEncryptionSet_ListByResourceGroup.json
            // this example is just showing the usage of "DiskEncryptionSets_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskEncryptionSetResource
            Compute.DiskEncryptionSetCollection collection = resourceGroupResource.GetDiskEncryptionSets();

            // invoke the operation and iterate over the result
            await foreach (Compute.DiskEncryptionSetResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.DiskEncryptionSetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
