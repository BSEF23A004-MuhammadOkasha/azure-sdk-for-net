// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningFeatureSetVersionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteWorkspaceFeaturesetVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/FeaturesetVersion/delete.json
            // this example is just showing the usage of "FeaturesetVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureSetVersionResource created on azure
            // for more information of creating MachineLearningFeatureSetVersionResource, please refer to the document of MachineLearningFeatureSetVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningFeatureSetVersionResourceId = MachineLearningFeatureSetVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningFeatureSetVersionResource machineLearningFeatureSetVersion = client.GetMachineLearningFeatureSetVersionResource(machineLearningFeatureSetVersionResourceId);

            // invoke the operation
            await machineLearningFeatureSetVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetWorkspaceFeaturesetVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/FeaturesetVersion/get.json
            // this example is just showing the usage of "FeaturesetVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureSetVersionResource created on azure
            // for more information of creating MachineLearningFeatureSetVersionResource, please refer to the document of MachineLearningFeatureSetVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningFeatureSetVersionResourceId = MachineLearningFeatureSetVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningFeatureSetVersionResource machineLearningFeatureSetVersion = client.GetMachineLearningFeatureSetVersionResource(machineLearningFeatureSetVersionResourceId);

            // invoke the operation
            MachineLearningFeatureSetVersionResource result = await machineLearningFeatureSetVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningFeatureSetVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateWorkspaceFeaturesetVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/FeaturesetVersion/createOrUpdate.json
            // this example is just showing the usage of "FeaturesetVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureSetVersionResource created on azure
            // for more information of creating MachineLearningFeatureSetVersionResource, please refer to the document of MachineLearningFeatureSetVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningFeatureSetVersionResourceId = MachineLearningFeatureSetVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningFeatureSetVersionResource machineLearningFeatureSetVersion = client.GetMachineLearningFeatureSetVersionResource(machineLearningFeatureSetVersionResourceId);

            // invoke the operation
            MachineLearningFeatureSetVersionData data = new MachineLearningFeatureSetVersionData(new MachineLearningFeatureSetVersionProperties()
            {
                SpecificationPath = "string",
                MaterializationSettings = new MaterializationSettings()
                {
                    StoreType = MaterializationStoreType.Online,
                    Schedule = new MachineLearningRecurrenceTrigger(MachineLearningRecurrenceFrequency.Day, 1)
                    {
                        Schedule = new MachineLearningRecurrenceSchedule(new int[]
            {
1
            }, new int[]
            {
1
            })
                        {
                            WeekDays =
{
MachineLearningDayOfWeek.Monday
},
                            MonthDays =
{
1
},
                        },
                        EndTime = "string",
                        StartTime = "string",
                        TimeZone = "string",
                    },
                    Notification = new NotificationSetting()
                    {
                        Emails =
{
"string"
},
                        EmailOn =
{
EmailNotificationEnableType.JobFailed
},
                    },
                    ResourceInstanceType = "string",
                    SparkConfiguration =
{
["string"] = "string",
},
                },
                Stage = "string",
                Entities =
{
"string"
},
                IsArchived = false,
                IsAnonymous = false,
                Description = "string",
                Tags =
{
["string"] = "string",
},
                Properties =
{
["string"] = "string",
},
            });
            ArmOperation<MachineLearningFeatureSetVersionResource> lro = await machineLearningFeatureSetVersion.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningFeatureSetVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningFeatureSetVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Backfill_BackfillWorkspaceFeaturesetVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/FeaturesetVersion/backfill.json
            // this example is just showing the usage of "FeaturesetVersions_Backfill" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureSetVersionResource created on azure
            // for more information of creating MachineLearningFeatureSetVersionResource, please refer to the document of MachineLearningFeatureSetVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningFeatureSetVersionResourceId = MachineLearningFeatureSetVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningFeatureSetVersionResource machineLearningFeatureSetVersion = client.GetMachineLearningFeatureSetVersionResource(machineLearningFeatureSetVersionResourceId);

            // invoke the operation
            FeatureSetVersionBackfillContent content = new FeatureSetVersionBackfillContent()
            {
                DisplayName = "string",
                Description = "string",
                FeatureWindow = new FeatureWindow()
                {
                    FeatureWindowStart = DateTimeOffset.Parse("2020-01-01T12:34:56.999+00:51"),
                    FeatureWindowEnd = DateTimeOffset.Parse("2020-01-01T12:34:56.999+00:51"),
                },
                DataAvailabilityStatus =
{
DataAvailabilityStatus.None
},
                JobId = "string",
                Tags =
{
["string"] = "string",
},
                ResourceInstanceType = "string",
                SparkConfiguration =
{
["string"] = "string",
},
            };
            ArmOperation<FeaturesetVersionBackfillResponse> lro = await machineLearningFeatureSetVersion.BackfillAsync(WaitUntil.Completed, content);
            FeaturesetVersionBackfillResponse result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
