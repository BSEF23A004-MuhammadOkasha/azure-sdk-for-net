﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Storage.Test.Shared
{
    public abstract partial class StorageTestBase<TEnvironment> : RecordedTestBase<TEnvironment> where TEnvironment : StorageTestEnvironment, new()
    {
        // TODO Consider https://docs.nunit.org/articles/nunit-engine/extensions/Event-Listeners.html but that requires NUnit 3.4
        [TearDown]
        public void TearDown()
        {
            if (AppInsightsNUnitFixture.TelemetryClient != null)
            {
                var context = TestContext.CurrentContext;
                AppInsightsNUnitFixture.TelemetryClient.TrackTrace("Test finished", new Dictionary<string, string>()
                {
                    { "TestName", context.Test.FullName },
                    { "TestOutcome", context.Result.Outcome.Status.ToString() },
                    { "NumberOfAssertions", context.Result.Assertions.Count().ToString() }
                });

                foreach (var assertion in context.Result.Assertions)
                {
                    AppInsightsNUnitFixture.TelemetryClient.TrackTrace("Assertion Result", new Dictionary<string, string>()
                    {
                        { "TestName", context.Test.FullName },
                        { "AssertionStatus", assertion.Status.ToString() },
                        { "AssertionMessage", assertion.Message },
                        { "AssertionStackTrace", assertion.StackTrace }
                    });
                }
            }
        }
    }
}
