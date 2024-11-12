// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SpringAppDiscovery.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SpringAppDiscovery.Samples
{
    public partial class Sample_SpringBootSiteResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SpringbootsitesGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootsites_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootsites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "chshxczdscjpcyvyethat";
            string resourceGroupName = "rgspringbootsites";
            string springbootsitesName = "xrmzlavpewxtfeitghdrj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, springbootsitesName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // invoke the operation
            SpringBootSiteResource result = await springBootSite.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SpringbootsitesGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootsites_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootsites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "chshxczdscjpcyvyethat";
            string resourceGroupName = "rgspringbootsites";
            string springbootsitesName = "xrmzlavpewxtfeitghdrj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, springbootsitesName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // invoke the operation
            SpringBootSiteResource result = await springBootSite.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SpringbootsitesDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootsites_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootsites_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "chshxczdscjpcyvyethat";
            string resourceGroupName = "rgspringbootsites";
            string springbootsitesName = "xrmzlavpewxtfeitghdrj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, springbootsitesName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // invoke the operation
            await springBootSite.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SpringbootsitesDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootsites_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootsites_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "chshxczdscjpcyvyethat";
            string resourceGroupName = "rgspringbootsites";
            string springbootsitesName = "xrmzlavpewxtfeitghdrj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, springbootsitesName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // invoke the operation
            await springBootSite.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SpringbootsitesUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootsites_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootsites_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "chshxczdscjpcyvyethat";
            string resourceGroupName = "rgspringbootsites";
            string springbootsitesName = "xrmzlavpewxtfeitghdrj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, springbootsitesName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // invoke the operation
            SpringBootSitePatch patch = new SpringBootSitePatch(new AzureLocation("icnumzvzzeqhuxtcefuqdcro"))
            {
                Tags =
{
["key9581"] = "cgdqvbknjrwcwuesquddsxu",
},
            };
            ArmOperation<SpringBootSiteResource> lro = await springBootSite.UpdateAsync(WaitUntil.Completed, patch);
            SpringBootSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SpringbootsitesUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootsites_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootsites_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "chshxczdscjpcyvyethat";
            string resourceGroupName = "rgspringbootsites";
            string springbootsitesName = "xrmzlavpewxtfeitghdrj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, springbootsitesName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // invoke the operation
            SpringBootSitePatch patch = new SpringBootSitePatch(new AzureLocation("icnumzvzzeqhuxtcefuqdcro"));
            ArmOperation<SpringBootSiteResource> lro = await springBootSite.UpdateAsync(WaitUntil.Completed, patch);
            SpringBootSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task TriggerRefreshSite_SpringbootsitesTriggerRefreshSiteMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootsites_TriggerRefreshSite_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootsites_TriggerRefreshSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "z";
            string resourceGroupName = "rgspringbootsites";
            string springbootsitesName = "czarpuxwoafaqsuptutcwyu";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, springbootsitesName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // invoke the operation
            await springBootSite.TriggerRefreshSiteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task TriggerRefreshSite_SpringbootsitesTriggerRefreshSiteMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootsites_TriggerRefreshSite_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootsites_TriggerRefreshSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "z";
            string resourceGroupName = "rgspringbootsites";
            string springbootsitesName = "czarpuxwoafaqsuptutcwyu";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, springbootsitesName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // invoke the operation
            await springBootSite.TriggerRefreshSiteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSpringBootSites_SpringbootsitesListBySubscriptionMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootsites_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootsites_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "chshxczdscjpcyvyethat";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SpringBootSiteResource item in subscriptionResource.GetSpringBootSitesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootSiteData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSpringBootSites_SpringbootsitesListBySubscriptionMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootsites_ListBySubscription_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootsites_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "chshxczdscjpcyvyethat";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SpringBootSiteResource item in subscriptionResource.GetSpringBootSitesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootSiteData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
