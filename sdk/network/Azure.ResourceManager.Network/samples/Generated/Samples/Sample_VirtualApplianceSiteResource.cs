// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualApplianceSiteResource
    {
        // Delete Network Virtual Appliance Site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteNetworkVirtualApplianceSite()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkVirtualApplianceSiteDelete.json
            // this example is just showing the usage of "VirtualApplianceSites_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualApplianceSiteResource created on azure
            // for more information of creating VirtualApplianceSiteResource, please refer to the document of VirtualApplianceSiteResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            string siteName = "site1";
            ResourceIdentifier virtualApplianceSiteResourceId = VirtualApplianceSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName, siteName);
            VirtualApplianceSiteResource virtualApplianceSite = client.GetVirtualApplianceSiteResource(virtualApplianceSiteResourceId);

            // invoke the operation
            await virtualApplianceSite.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // GetNetwork Virtual Appliance Site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetNetworkVirtualApplianceSite()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkVirtualApplianceSiteGet.json
            // this example is just showing the usage of "VirtualApplianceSites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualApplianceSiteResource created on azure
            // for more information of creating VirtualApplianceSiteResource, please refer to the document of VirtualApplianceSiteResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            string siteName = "site1";
            ResourceIdentifier virtualApplianceSiteResourceId = VirtualApplianceSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName, siteName);
            VirtualApplianceSiteResource virtualApplianceSite = client.GetVirtualApplianceSiteResource(virtualApplianceSiteResourceId);

            // invoke the operation
            VirtualApplianceSiteResource result = await virtualApplianceSite.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualApplianceSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create Network Virtual Appliance Site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateNetworkVirtualApplianceSite()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkVirtualApplianceSitePut.json
            // this example is just showing the usage of "VirtualApplianceSites_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualApplianceSiteResource created on azure
            // for more information of creating VirtualApplianceSiteResource, please refer to the document of VirtualApplianceSiteResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            string siteName = "site1";
            ResourceIdentifier virtualApplianceSiteResourceId = VirtualApplianceSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName, siteName);
            VirtualApplianceSiteResource virtualApplianceSite = client.GetVirtualApplianceSiteResource(virtualApplianceSiteResourceId);

            // invoke the operation
            VirtualApplianceSiteData data = new VirtualApplianceSiteData()
            {
                AddressPrefix = "192.168.1.0/24",
                O365BreakOutCategories = new BreakOutCategoryPolicies()
                {
                    Allow = true,
                    Optimize = true,
                    Default = true,
                },
            };
            ArmOperation<VirtualApplianceSiteResource> lro = await virtualApplianceSite.UpdateAsync(WaitUntil.Completed, data);
            VirtualApplianceSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualApplianceSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
