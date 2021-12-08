// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Compute.Tests.Mock
{
    /// <summary> Test for DiskEncryptionSet. </summary>
    public partial class DiskEncryptionSetCollectionMockTests : MockTestBase
    {
        public DiskEncryptionSetCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Compute.DiskEncryptionSetCollection> GetDiskEncryptionSetCollectionAsync(string resourceGroupName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            DiskEncryptionSetCollection diskEncryptionSetCollection = resourceGroup.GetDiskEncryptionSets();
            return diskEncryptionSetCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create a disk encryption set with key vault from a different subscription.
            var collection = await GetDiskEncryptionSetCollectionAsync("myResourceGroup");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "myDiskEncryptionSet");
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync2()
        {
            // Example: Create a disk encryption set.
            var collection = await GetDiskEncryptionSetCollectionAsync("myResourceGroup");
            string diskEncryptionSetName = "myDiskEncryptionSet";
            Compute.DiskEncryptionSetData diskEncryptionSet = new Compute.DiskEncryptionSetData("West US")
            {
                Identity = new Compute.Models.EncryptionSetIdentity()
                {
                    Type = new Compute.Models.DiskEncryptionSetIdentityType("SystemAssigned"),
                },
                EncryptionType = new Compute.Models.DiskEncryptionSetType("EncryptionAtRestWithCustomerKey"),
                ActiveKey = new Compute.Models.KeyForDiskEncryptionSet("https://myvmvault.vault-int.azure-int.net/keys/{key}")
                {
                    SourceVault = new WritableSubResource()
                    {
                        Id = new ResourceIdentifier($"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.KeyVault/vaults/myVMVault"),
                    },
                },
            };

            await collection.CreateOrUpdateAsync(diskEncryptionSetName, diskEncryptionSet);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get information about a disk encryption set.
            var collection = await GetDiskEncryptionSetCollectionAsync("myResourceGroup");
            await TestHelper.GetExampleInstanceAsync(collection, "myDiskEncryptionSet");
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: List all disk encryption sets in a resource group.
            var collection = await GetDiskEncryptionSetCollectionAsync("myResourceGroup");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
