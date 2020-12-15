﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Processor.Tests;
using Azure.Messaging.EventHubs.Producer;
using Azure.Messaging.EventHubs.Tests;
using Microsoft.Azure.WebJobs.EventHubs;
using Microsoft.Azure.WebJobs.Host.TestCommon;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace Microsoft.Azure.WebJobs.Host.EndToEndTests
{
    [NonParallelizable]
    [LiveOnly]
    public class EventHubEndToEndTests
    {
        private const string TestHubName = "%webjobstesthub%";
        private const int Timeout = 30000;
        private static EventWaitHandle _eventWait;
        private static string _testId;
        private static List<string> _results;

        /// <summary>The active Event Hub resource scope for the test fixture.</summary>
        private EventHubScope _eventHubScope;

        /// <summary>The active Blob storage resource scope for the test fixture.</summary>
        private StorageScope _storageScope;

        /// <summary>
        ///   Performs the tasks needed to initialize the test fixture.  This
        ///   method runs once for the entire fixture, prior to running any tests.
        /// </summary>
        ///
        [SetUp]
        public async Task FixtureSetUp()
        {
            _results = new List<string>();
            _testId = Guid.NewGuid().ToString();
            _eventWait = new ManualResetEvent(initialState: false);
            _eventHubScope = await EventHubScope.CreateAsync(2);
            _storageScope = await StorageScope.CreateAsync();
        }

        /// <summary>
        ///   Performs the tasks needed to cleanup the test fixture after all
        ///   tests have run.  This method runs once for the entire fixture.
        /// </summary>
        ///
        [TearDown]
        public async Task FixtureTearDown()
        {
            await Task.WhenAll
            (
                _eventHubScope.DisposeAsync().AsTask(),
                _storageScope.DisposeAsync().AsTask()
            );
        }

        [Test]
        public async Task EventHub_PocoBinding()
        {
            var (jobHost, host) = BuildHost<EventHubTestBindToPocoJobs>();
            using (jobHost)
            {
                var method = typeof(EventHubTestBindToPocoJobs).GetMethod(nameof(EventHubTestBindToPocoJobs.SendEvent_TestHub), BindingFlags.Static | BindingFlags.Public);
                await jobHost.CallAsync(method, new { input = "{ Name: 'foo', Value: '" + _testId +"' }" });

                bool result = _eventWait.WaitOne(Timeout);
                Assert.True(result);
            }

            var logs = host.GetTestLoggerProvider().GetAllLogMessages().Select(p => p.FormattedMessage);

            CollectionAssert.Contains(logs, $"PocoValues(foo,{_testId})");
        }

        [Test]
        public async Task EventHub_StringBinding()
        {
            var (jobHost, host) = BuildHost<EventHubTestBindToStringJobs>();
            using (jobHost)
            {
                var method = typeof(EventHubTestBindToStringJobs).GetMethod(nameof(EventHubTestBindToStringJobs.SendEvent_TestHub), BindingFlags.Static | BindingFlags.Public);
                await jobHost.CallAsync(method, new { input = _testId });

                bool result = _eventWait.WaitOne(Timeout);
                Assert.True(result);

                var logs = host.GetTestLoggerProvider().GetAllLogMessages().Select(p => p.FormattedMessage);

                CollectionAssert.Contains(logs, $"Input({_testId})");
            }
        }

        [Test]
        public async Task EventHub_SingleDispatch()
        {
            var (jobHost, host) = BuildHost<EventHubTestSingleDispatchJobs>();
            using (jobHost)
            {
                var method = typeof(EventHubTestSingleDispatchJobs).GetMethod(nameof(EventHubTestSingleDispatchJobs.SendEvent_TestHub), BindingFlags.Static | BindingFlags.Public);
                await jobHost.CallAsync(method, new { input = _testId });

                bool result = _eventWait.WaitOne(Timeout);
                Assert.True(result);
            }

            IEnumerable<LogMessage> logMessages = host.GetTestLoggerProvider()
                .GetAllLogMessages();

            Assert.AreEqual(logMessages.Where(x => !string.IsNullOrEmpty(x.FormattedMessage)
                && x.FormattedMessage.Contains("Trigger Details:")
                && x.FormattedMessage.Contains("Offset:")).Count(), 1);

            Assert.True(logMessages.Where(x => !string.IsNullOrEmpty(x.FormattedMessage)
                && x.FormattedMessage.Contains("OpenAsync")).Count() > 0);

            Assert.True(logMessages.Where(x => !string.IsNullOrEmpty(x.FormattedMessage)
                && x.FormattedMessage.Contains("CheckpointAsync")
                && x.FormattedMessage.Contains("lease")
                && x.FormattedMessage.Contains("offset")
                && x.FormattedMessage.Contains("sequenceNumber")).Count() > 0);

            Assert.True(logMessages.Where(x => !string.IsNullOrEmpty(x.FormattedMessage)
                && x.FormattedMessage.Contains("Sending events to EventHub")).Count() > 0);
        }

        [Test]
        public async Task CanSendAndReceive_ConnectionStringUsingAddMethods()
        {
            await AssertCanSendReceiveMessage(host =>
                host.ConfigureServices(services =>
                    services.Configure<EventHubOptions>(options =>
                    {
                        options.AddSender(_eventHubScope.EventHubName, EventHubsTestEnvironment.Instance.EventHubsConnectionString);
                        options.AddReceiver(_eventHubScope.EventHubName, EventHubsTestEnvironment.Instance.EventHubsConnectionString);
                    })));
        }

        [Test]
        public async Task CanSendAndReceive_ConnectionStringInConfiguration()
        {
            await AssertCanSendReceiveMessage(host =>
                host.ConfigureAppConfiguration(configurationBuilder =>
                    configurationBuilder.AddInMemoryCollection(new Dictionary<string, string>()
                    {
                        {"TestConnection", EventHubsTestEnvironment.Instance.EventHubsConnectionString}
                    })));
        }

        [Test]
        public async Task CanSendAndReceive_TokenCredentialInConfiguration()
        {
            await AssertCanSendReceiveMessage(host =>
                host.ConfigureAppConfiguration(configurationBuilder =>
                    configurationBuilder.AddInMemoryCollection(new Dictionary<string, string>()
                    {
                        {"TestConnection:fullyQualifiedNamespace", EventHubsTestEnvironment.Instance.FullyQualifiedNamespace},
                        {"TestConnection:clientId", EventHubsTestEnvironment.Instance.ClientId},
                        {"TestConnection:clientSecret", EventHubsTestEnvironment.Instance.ClientSecret},
                        {"TestConnection:tenantId", EventHubsTestEnvironment.Instance.TenantId},
                    })));
        }

        public async Task AssertCanSendReceiveMessage(Action<IHostBuilder> hostConfiguration)
        {
            var (jobHost, host) = BuildHost<EventHubTestSingleDispatchJobWithConnection>(hostConfiguration);
            using (jobHost)
            {
                await jobHost.CallAsync(nameof(EventHubTestSingleDispatchJobWithConnection.SendEvent_TestHub), new { input = _testId });

                bool result = _eventWait.WaitOne(Timeout);
                Assert.True(result);
            }
        }

        [Test]
        public async Task EventHub_MultipleDispatch()
        {
            var (jobHost, host) = BuildHost<EventHubTestMultipleDispatchJobs>();
            using (jobHost)
            {
                var method = typeof(EventHubTestMultipleDispatchJobs).GetMethod("SendEvents_TestHub", BindingFlags.Static | BindingFlags.Public);
                int numEvents = 5;
                await jobHost.CallAsync(method, new { numEvents = numEvents, input = _testId });

                bool result = _eventWait.WaitOne(Timeout);
                Assert.True(result);
            }

            IEnumerable<LogMessage> logMessages = host.GetTestLoggerProvider()
                .GetAllLogMessages();

            Assert.True(logMessages.Where(x => !string.IsNullOrEmpty(x.FormattedMessage)
                && x.FormattedMessage.Contains("Trigger Details:")
                && x.FormattedMessage.Contains("Offset:")).Count() > 0);

            Assert.True(logMessages.Where(x => !string.IsNullOrEmpty(x.FormattedMessage)
                && x.FormattedMessage.Contains("OpenAsync")).Count() > 0);

            Assert.True(logMessages.Where(x => !string.IsNullOrEmpty(x.FormattedMessage)
                && x.FormattedMessage.Contains("CheckpointAsync")
                && x.FormattedMessage.Contains("lease")
                && x.FormattedMessage.Contains("offset")
                && x.FormattedMessage.Contains("sequenceNumber")).Count() > 0);

            Assert.True(logMessages.Where(x => !string.IsNullOrEmpty(x.FormattedMessage)
                && x.FormattedMessage.Contains("Sending events to EventHub")).Count() > 0);
        }

        [Test]
        public async Task EventHub_PartitionKey()
        {
            var (jobHost, host) = BuildHost<EventHubPartitionKeyTestJobs>();
            using (jobHost)
            {
                var method = typeof(EventHubPartitionKeyTestJobs).GetMethod("SendEvents_TestHub", BindingFlags.Static | BindingFlags.Public);
                _eventWait = new ManualResetEvent(initialState: false);
                await jobHost.CallAsync(method, new { input = _testId });

                bool result = _eventWait.WaitOne(Timeout);

                Assert.True(result);
            }
        }

        public class EventHubTestSingleDispatchJobs
        {
            public static void SendEvent_TestHub(string input, [EventHub(TestHubName)] out EventData evt)
            {
                evt = new EventData(Encoding.UTF8.GetBytes(input));
                evt.Properties.Add("TestProp1", "value1");
                evt.Properties.Add("TestProp2", "value2");
            }

            public static void ProcessSingleEvent([EventHubTrigger(TestHubName)] string evt,
                       string partitionKey, DateTime enqueuedTimeUtc, IDictionary<string, object> properties,
                       IDictionary<string, object> systemProperties)
            {
                // filter for the ID the current test is using
                if (evt == _testId)
                {
                    Assert.True((DateTime.Now - enqueuedTimeUtc).TotalSeconds < 30);

                    Assert.AreEqual("value1", properties["TestProp1"]);
                    Assert.AreEqual("value2", properties["TestProp2"]);

                    _eventWait.Set();
                }
            }
        }

        public class EventHubTestBindToPocoJobs
        {
            public static void SendEvent_TestHub(string input, [EventHub(TestHubName)] out EventData evt)
            {
                evt = new EventData(Encoding.UTF8.GetBytes(input));
            }

            public static void BindToPoco([EventHubTrigger(TestHubName)] TestPoco input, string value, string name, ILogger logger)
            {
                if (value == _testId)
                {
                    Assert.AreEqual(input.Value, value);
                    Assert.AreEqual(input.Name, name);
                    logger.LogInformation($"PocoValues({name},{value})");
                    _eventWait.Set();
                }
            }
        }

        public class EventHubTestBindToStringJobs
        {
            public static void SendEvent_TestHub(string input, [EventHub(TestHubName)] out EventData evt)
            {
                evt = new EventData(Encoding.UTF8.GetBytes(input));
            }

            public static void BindToString([EventHubTrigger(TestHubName)] string input, ILogger logger)
            {
                if (input == _testId)
                {
                    logger.LogInformation($"Input({input})");
                    _eventWait.Set();
                }
            }
        }

        public class EventHubTestMultipleDispatchJobs
        {
            private static int s_eventCount;
            private static int s_processedEventCount;
            public static void SendEvents_TestHub(int numEvents, string input, [EventHub(TestHubName)] out EventData[] events)
            {
                s_eventCount = numEvents;
                events = new EventData[numEvents];
                for (int i = 0; i < numEvents; i++)
                {
                    var evt = new EventData(Encoding.UTF8.GetBytes(input));
                    evt.Properties.Add("TestIndex", i);
                    evt.Properties.Add("TestProp1", "value1");
                    evt.Properties.Add("TestProp2", "value2");
                    events[i] = evt;
                }
            }

            public static void ProcessMultipleEvents([EventHubTrigger(TestHubName)] string[] events,
                string[] partitionKeyArray, DateTime[] enqueuedTimeUtcArray, IDictionary<string, object>[] propertiesArray,
                IDictionary<string, object>[] systemPropertiesArray)
            {
                Assert.AreEqual(events.Length, partitionKeyArray.Length);
                Assert.AreEqual(events.Length, enqueuedTimeUtcArray.Length);
                Assert.AreEqual(events.Length, propertiesArray.Length);
                Assert.AreEqual(events.Length, systemPropertiesArray.Length);

                for (int i = 0; i < events.Length; i++)
                {
                    Assert.AreEqual(s_processedEventCount++, propertiesArray[i]["TestIndex"]);
                }

                // filter for the ID the current test is using
                if (events[0] == _testId && s_processedEventCount == s_eventCount)
                {
                    _results.AddRange(events);
                    _eventWait.Set();
                }
            }
        }

        public class EventHubPartitionKeyTestJobs
        {
            // send more events per partition than the EventHubsOptions.MaxBatchSize
            // so that we get coverage for receiving events from the same partition in multiple chunks
            private const int EventsPerPartition = 15;
            private const int PartitionCount = 5;
            private const int TotalEventsCount = EventsPerPartition * PartitionCount;

            public static async Task SendEvents_TestHub(
                string input,
                [EventHub(TestHubName)] EventHubProducerClient client)
            {
                List<EventData> list = new List<EventData>();
                EventData evt = new EventData(Encoding.UTF8.GetBytes(input));

                // Send event without PK
                await client.SendAsync(new[] { evt });

                // Send event with different PKs
                for (int i = 0; i < PartitionCount; i++)
                {
                    evt = new EventData(Encoding.UTF8.GetBytes(input));
                    await client.SendAsync(Enumerable.Repeat(evt, EventsPerPartition), new SendEventOptions() { PartitionKey = "test_pk" + i });
                }
            }

            public static void ProcessMultiplePartitionEvents([EventHubTrigger(TestHubName)] EventData[] events)
            {
                foreach (EventData eventData in events)
                {
                    string message = Encoding.UTF8.GetString(eventData.Body.ToArray());

                    // filter for the ID the current test is using
                    if (message == _testId)
                    {
                        _results.Add(eventData.PartitionKey);
                        _results.Sort();

                        // count is 1 more because we sent an event without PK
                        if (_results.Count == TotalEventsCount + 1 && _results[TotalEventsCount] == "test_pk4")
                        {
                            _eventWait.Set();
                        }
                    }
                }
            }
        }

        public class EventHubTestSingleDispatchJobWithConnection
        {
            public static void SendEvent_TestHub(string input, [EventHub(TestHubName, Connection = "TestConnection")] out EventData evt)
            {
                evt = new EventData(Encoding.UTF8.GetBytes(input));
                evt.Properties.Add("TestProp1", "value1");
                evt.Properties.Add("TestProp2", "value2");
            }

            public static void ProcessSingleEvent([EventHubTrigger(TestHubName, Connection = "TestConnection")] string evt, DateTime enqueuedTimeUtc, IDictionary<string, object> properties)
            {
                // filter for the ID the current test is using
                if (evt == _testId)
                {
                    Assert.True((DateTime.Now - enqueuedTimeUtc).TotalSeconds < 30);

                    Assert.AreEqual("value1", properties["TestProp1"]);
                    Assert.AreEqual("value2", properties["TestProp2"]);

                    _eventWait.Set();
                }
            }
        }

        private (JobHost, IHost) BuildHost<T>(Action<IHostBuilder> configurationDelegate = null)
        {
            var eventHubName = _eventHubScope.EventHubName;

            configurationDelegate ??= builder =>
            {
                builder.ConfigureServices(services =>
                {
                    services.Configure<EventHubOptions>(options =>
                    {
                        options.AddSender(eventHubName, EventHubsTestEnvironment.Instance.EventHubsConnectionString);
                        options.AddReceiver(eventHubName, EventHubsTestEnvironment.Instance.EventHubsConnectionString);
                    });
                });
            };

            var hostBuilder = new HostBuilder()
                .ConfigureAppConfiguration(builder =>
                {
                    builder.AddInMemoryCollection(new Dictionary<string, string>()
                    {
                        {"webjobstesthub", eventHubName},
                        {"AzureWebJobsStorage", StorageTestEnvironment.Instance.StorageConnectionString}
                    });
                })
                .ConfigureServices(services =>
                {
                    // Speedup shutdown
                    services.Configure<EventHubOptions>(options =>
                    {
                        options.LeaseContainerName = _storageScope.ContainerName;
                        options.EventProcessorOptions.MaximumWaitTime = TimeSpan.FromSeconds(5);
                    });
                })
                .ConfigureDefaultTestHost<T>(b =>
                {
                    b.AddEventHubs(options =>
                    {
                        options.EventProcessorOptions.TrackLastEnqueuedEventProperties = true;
                    });
                })
                .ConfigureLogging(b =>
                {
                    b.SetMinimumLevel(LogLevel.Debug);
                });

            configurationDelegate(hostBuilder);
            var host = hostBuilder.Build();

            var jobHost = host.GetJobHost();
            jobHost.StartAsync().GetAwaiter().GetResult();

            return (jobHost, host);
        }
        public class TestPoco
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
    }
}