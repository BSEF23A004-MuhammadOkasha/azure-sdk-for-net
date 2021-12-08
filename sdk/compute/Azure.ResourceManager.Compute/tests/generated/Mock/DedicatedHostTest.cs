// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Compute.Tests.Mock
{
    /// <summary> Test for DedicatedHost. </summary>
    public partial class DedicatedHostMockTests : MockTestBase
    {
        public DedicatedHostMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Compute.DedicatedHostCollection> GetDedicatedHostCollectionAsync(string resourceGroupName, string hostGroupName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            DedicatedHostGroupCollection dedicatedHostGroupCollection = resourceGroup.GetDedicatedHostGroups();
            var dedicatedHostGroupOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(dedicatedHostGroupCollection, hostGroupName);
            DedicatedHostGroup dedicatedHostGroup = dedicatedHostGroupOperation.Value;
            DedicatedHostCollection dedicatedHostCollection = dedicatedHostGroup.GetDedicatedHosts();
            return dedicatedHostCollection;
        }

        private async Task<Compute.DedicatedHost> GetDedicatedHostAsync()
        {
            var collection = await GetDedicatedHostCollectionAsync("myResourceGroup", "myDedicatedHostGroup");
            var createOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "myDedicatedHost");
            return createOperation.Value;
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a dedicated host.
            var dedicatedHost = await GetDedicatedHostAsync();
            Compute.Models.InstanceViewTypes? expand = null;

            await dedicatedHost.GetAsync(expand);
        }
    }
}
