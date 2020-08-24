// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Azure.ResourceManager.CosmosDB.Tests
{
    [RunFrequency(RunTestFrequency.Manually)]
    public class OperationsTest : CosmosDBManagementClientBase
    {
        public OperationsTest(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task ClearAndInitialize()
        {
            InitializeClients();
            await CosmosDBTestUtilities.TryRegisterResourceGroupAsync(ResourceGroupsOperations,
                CosmosDBTestUtilities.Location,
                Recording.GenerateAssetName(CosmosDBTestUtilities.ResourceGroupPrefix));
        }

        [TearDown]
        public async Task CleanupResourceGroup()
        {
            await CleanupResourceGroupsAsync();
        }

        [TestCase]
        public async Task ListOperationsTest()
        {
            var cosmosDBClient = GetCosmosDBManagementClient();
            var operations = cosmosDBClient.Operations.ListAsync();
            Assert.NotNull(operations);
            Assert.IsNotEmpty(await operations.ToEnumerableAsync());
        }
    }
}
