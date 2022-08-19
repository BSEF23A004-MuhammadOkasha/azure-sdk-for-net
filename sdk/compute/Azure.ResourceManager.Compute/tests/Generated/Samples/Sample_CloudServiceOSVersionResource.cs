// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_CloudServiceOSVersionResource
    {
        // Get Cloud Service OS Version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCloudServiceOSVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-04-04/CloudServiceRP/examples/CloudServiceOSVersion_Get.json
            // this example is just showing the usage of "CloudServiceOperatingSystems_GetOSVersion" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this CloudServiceOSVersionResource created on azure
            // for more information of creating CloudServiceOSVersionResource, please refer to the document of CloudServiceOSVersionResource
            string subscriptionId = "{subscription-id}";
            AzureLocation location = new AzureLocation("westus2");
            string osVersionName = "WA-GUEST-OS-3.90_202010-02";
            ResourceIdentifier cloudServiceOSVersionResourceId = Compute.CloudServiceOSVersionResource.CreateResourceIdentifier(subscriptionId, location, osVersionName);
            Compute.CloudServiceOSVersionResource cloudServiceOSVersion = client.GetCloudServiceOSVersionResource(cloudServiceOSVersionResourceId);

            // invoke the operation
            Compute.CloudServiceOSVersionResource result = await cloudServiceOSVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.CloudServiceOSVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
