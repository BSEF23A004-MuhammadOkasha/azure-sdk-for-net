﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using FluentAssertions;
using NUnit.Framework;
using Azure.ResourceManager.IotFirmwareDefense.Models;

namespace Azure.ResourceManager.IotFirmwareDefense.Tests
{
    public class BinaryHardeningTest : IotFirmwareDefenseManagementTestBase
    {
        private static readonly string subscriptionId = "07aed47b-60ad-4d6e-a07a-89b602418441";
        private static readonly string rgName = "sdk-tests-rg";
        private static readonly string workspaceName = "default";
        private static readonly string firmwareId = "cf833be1-3e8e-a00a-a037-ad27a0fc0497";
        private static SubscriptionResource testSubscription;

        public BinaryHardeningTest(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public void setup()
        {
            var _ = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            testSubscription = Client.GetSubscriptionResource(_);
        }

        [TestCase]
        [RecordedTest]
        public async Task TestGetBinaryHardeningResults()
        {
            ResourceGroupResource testRg = await testSubscription.GetResourceGroupAsync(rgName);
            FirmwareWorkspaceResource testWorkspace = await testRg.GetFirmwareWorkspaceAsync(workspaceName);
            FirmwareResource testFirmware = await testWorkspace.GetFirmwareAsync(firmwareId);

            var results = testFirmware.GetBinaryHardeningResultsAsync();
            await foreach ( BinaryHardeningResult result in results ) {
                Console.WriteLine($"Fetched: {result}");
            }
            Assert.NotNull(results);
        }
    }
}
