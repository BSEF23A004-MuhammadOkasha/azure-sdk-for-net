// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_ScalingPlanPersonalScheduleResource
    {
        // ScalingPlanPersonalSchedules_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ScalingPlanPersonalSchedulesGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/ScalingPlanPersonalSchedule_Get.json
            // this example is just showing the usage of "ScalingPlanPersonalSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanPersonalScheduleResource created on azure
            // for more information of creating ScalingPlanPersonalScheduleResource, please refer to the document of ScalingPlanPersonalScheduleResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "PersonalScalingPlan1";
            string scalingPlanScheduleName = "PersonalScalingPlanSchedule";
            ResourceIdentifier scalingPlanPersonalScheduleResourceId = ScalingPlanPersonalScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName, scalingPlanScheduleName);
            ScalingPlanPersonalScheduleResource scalingPlanPersonalSchedule = client.GetScalingPlanPersonalScheduleResource(scalingPlanPersonalScheduleResourceId);

            // invoke the operation
            ScalingPlanPersonalScheduleResource result = await scalingPlanPersonalSchedule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScalingPlanPersonalScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScalingPlanPersonalSchedules_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ScalingPlanPersonalSchedulesDelete()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/ScalingPlanPersonalSchedule_Delete.json
            // this example is just showing the usage of "ScalingPlanPersonalSchedules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanPersonalScheduleResource created on azure
            // for more information of creating ScalingPlanPersonalScheduleResource, please refer to the document of ScalingPlanPersonalScheduleResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            string scalingPlanScheduleName = "scalingPlanScheduleWeekdays1";
            ResourceIdentifier scalingPlanPersonalScheduleResourceId = ScalingPlanPersonalScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName, scalingPlanScheduleName);
            ScalingPlanPersonalScheduleResource scalingPlanPersonalSchedule = client.GetScalingPlanPersonalScheduleResource(scalingPlanPersonalScheduleResourceId);

            // invoke the operation
            await scalingPlanPersonalSchedule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ScalingPlanPersonalSchedules_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ScalingPlanPersonalSchedulesUpdate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/ScalingPlanPersonalSchedule_Update.json
            // this example is just showing the usage of "ScalingPlanPersonalSchedules_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanPersonalScheduleResource created on azure
            // for more information of creating ScalingPlanPersonalScheduleResource, please refer to the document of ScalingPlanPersonalScheduleResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            string scalingPlanScheduleName = "scalingPlanScheduleWeekdays1";
            ResourceIdentifier scalingPlanPersonalScheduleResourceId = ScalingPlanPersonalScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName, scalingPlanScheduleName);
            ScalingPlanPersonalScheduleResource scalingPlanPersonalSchedule = client.GetScalingPlanPersonalScheduleResource(scalingPlanPersonalScheduleResourceId);

            // invoke the operation
            ScalingPlanPersonalSchedulePatch patch = new ScalingPlanPersonalSchedulePatch()
            {
                PeakStartTime = new ScalingActionTime(8, 0),
                PeakActionOnDisconnect = SessionHandlingOperation.None,
                PeakMinutesToWaitOnDisconnect = 10,
                PeakActionOnLogoff = SessionHandlingOperation.Deallocate,
                PeakMinutesToWaitOnLogoff = 10,
                RampDownStartTime = new ScalingActionTime(18, 0),
                RampDownActionOnDisconnect = SessionHandlingOperation.None,
                RampDownMinutesToWaitOnDisconnect = 10,
                RampDownActionOnLogoff = SessionHandlingOperation.Deallocate,
                RampDownMinutesToWaitOnLogoff = 10,
                OffPeakStartTime = new ScalingActionTime(20, 0),
                OffPeakStartVmOnConnect = SetStartVmOnConnect.Disable,
                OffPeakActionOnDisconnect = SessionHandlingOperation.None,
                OffPeakMinutesToWaitOnDisconnect = 10,
                OffPeakActionOnLogoff = SessionHandlingOperation.Deallocate,
                OffPeakMinutesToWaitOnLogoff = 10,
            };
            ScalingPlanPersonalScheduleResource result = await scalingPlanPersonalSchedule.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScalingPlanPersonalScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
