// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteSlotDetectorResource
    {
        // Get App Detector Response
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteDetectorResponse.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponseSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotDetectorResource created on azure
            // for more information of creating SiteSlotDetectorResource, please refer to the document of SiteSlotDetectorResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            string detectorName = "runtimeavailability";
            ResourceIdentifier siteSlotDetectorResourceId = SiteSlotDetectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot, detectorName);
            SiteSlotDetectorResource siteSlotDetector = client.GetSiteSlotDetectorResource(siteSlotDetectorResourceId);

            // invoke the operation
            SiteSlotDetectorResource result = await siteSlotDetector.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceDetectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get App Slot Detector Response
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppSlotDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteDetectorResponseSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponseSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotDetectorResource created on azure
            // for more information of creating SiteSlotDetectorResource, please refer to the document of SiteSlotDetectorResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            string detectorName = "runtimeavailability";
            ResourceIdentifier siteSlotDetectorResourceId = SiteSlotDetectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot, detectorName);
            SiteSlotDetectorResource siteSlotDetector = client.GetSiteSlotDetectorResource(siteSlotDetectorResourceId);

            // invoke the operation
            SiteSlotDetectorResource result = await siteSlotDetector.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceDetectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
