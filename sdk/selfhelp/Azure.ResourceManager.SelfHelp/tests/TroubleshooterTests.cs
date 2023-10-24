﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.ResourceManager.SelfHelp.Tests
{
    using Azure.Core.TestFramework;
    using Azure.Core;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using System;
    using Azure.ResourceManager.SelfHelp.Models;
    using System.Collections.Generic;

    public class TroubleshooterTests : SelfHelpManagementTestBase
    {
        public TroubleshooterTests(bool isAsync) : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        [Test]
        public async Task CreateAndGetTroubleshooterTest()
        {
            var subId = "6bded6d5-a6af-43e1-96d3-bf71f6f5f8ba";
            var resourceGroupName = "DiagnosticsRp-Gateway-Public-Dev-Global";
            var resourceName = "DiagRpGwPubDev";
            var troubleshooterResourceName = Guid.NewGuid().ToString();
            ResourceIdentifier scope = new ResourceIdentifier($"/subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{resourceName}");
            TroubleshooterResourceData resourceData = CreateTroubleshooterResourceData(scope);

            var createTroubleshooterData = await Client.GetTroubleshooterResources(scope).CreateOrUpdateAsync(WaitUntil.Started, troubleshooterResourceName, resourceData);
            Assert.NotNull(createTroubleshooterData);

            var readTroubleshooterData = await Client.GetTroubleshooterResourceAsync(scope, troubleshooterResourceName);
            Assert.NotNull(readTroubleshooterData);
        }

        private TroubleshooterResourceData CreateTroubleshooterResourceData(ResourceIdentifier scope)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>()
            {
                { "ResourceUri","/subscriptions/02d59989-f8a9-4b69-9919-1ef51df4eff6/resourceGroups/AcisValidation/providers/Microsoft.Compute/virtualMachines/vm-for-validation-port-80"},
                { "PuID", "100320019A2D7EB8"},
                { "SubscriptionId", "02d59989-f8a9-4b69-9919-1ef51df4eff6"},
                { "SapId", "1c2f964e-9219-e8fe-f027-95330b445941" },
                { "language", "en-us" },
                { "SessionId", "63e88074-1ac0-475a-8aee-e33f8477a4b3" },
                { "TimeZone", "GMT-0800 (Pacific Standard Time)" },
                { "TimeZoneOffset", "480" },
                { "TenantId", "72f988bf-86f1-41af-91ab-2d7cd011db47" },
                { "ProductId", "15571" },
                { "UserIPAddress", "174.164.29.4" }
            };

            List<SelfHelpSection> sections = new List< SelfHelpSection>();
            ResourceType resourceType = new ResourceType("Microsoft.KeyVault/vaults");
            var data = new TroubleshooterResourceData(scope, null, resourceType, null, "e104dbdf-9e14-4c9f-bc78-21ac90382231", parameters, null, null);

            return data;
        }
    }
}
