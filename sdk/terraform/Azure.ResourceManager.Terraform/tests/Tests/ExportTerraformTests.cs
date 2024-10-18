// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Terraform.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Terraform.Tests
{
    public class ExportTerraformTests : TerraformManagementTestBase
    {
        private ResourceGroupResource _resourceGroup;

        public ExportTerraformTests(bool isAsync) : base(isAsync)
        {
        }

        [SetUp]
        public async Task SetUp()
        {
            _resourceGroup = await CreateResourceGroup(DefaultSubscription, "exportTerraformRg", AzureLocation.WestUS);
        }

        [TearDown]
        public async Task TearDown()
        {
            await _resourceGroup.DeleteAsync(WaitUntil.Completed);
        }

        [TestCase]
        [RecordedTest]
        public async Task ExportTerraformTest()
        {
            string rgName = _resourceGroup.Data.Name;
            ArmOperation<TerraformOperationStatus> operationStatus = await DefaultSubscription.ExportTerraformAsync(WaitUntil.Completed, new ExportResourceGroup(rgName));
            string hcl = operationStatus.Value.Properties.Configuration;

            Assert.That(hcl, Does.Contain("azurerm_resource_group"));
            Assert.That(hcl, Does.Contain(rgName));
        }
    }
}
