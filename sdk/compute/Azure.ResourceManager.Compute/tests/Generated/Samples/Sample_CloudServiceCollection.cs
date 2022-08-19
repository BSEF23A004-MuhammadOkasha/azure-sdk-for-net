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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_CloudServiceCollection
    {
        // Create New Cloud Service with Multiple Roles
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateNewCloudServiceWithMultipleRoles()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-04-04/CloudServiceRP/examples/CloudService_Create_WithMultiRole.json
            // this example is just showing the usage of "CloudServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            Compute.CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            Compute.CloudServiceData data = new CloudServiceData(new AzureLocation("westus"))
            {
                PackageUri = new Uri("{PackageUrl}"),
                Configuration = "{ServiceConfiguration}",
                UpgradeMode = CloudServiceUpgradeMode.Auto,
                NetworkProfile = new CloudServiceNetworkProfile()
                {
                    LoadBalancerConfigurations =
{
new CloudServiceLoadBalancerConfiguration("contosolb",new Compute.Models.LoadBalancerFrontendIPConfiguration[]
{
})
},
                },
            };
            ArmOperation<Compute.CloudServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudServiceName, data);
            Compute.CloudServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create New Cloud Service with Single Role
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateNewCloudServiceWithSingleRole()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-04-04/CloudServiceRP/examples/CloudService_Create_WithSingleRole.json
            // this example is just showing the usage of "CloudServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            Compute.CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            Compute.CloudServiceData data = new CloudServiceData(new AzureLocation("westus"))
            {
                PackageUri = new Uri("{PackageUrl}"),
                Configuration = "{ServiceConfiguration}",
                UpgradeMode = CloudServiceUpgradeMode.Auto,
                NetworkProfile = new CloudServiceNetworkProfile()
                {
                    LoadBalancerConfigurations =
{
new CloudServiceLoadBalancerConfiguration("myLoadBalancer",new Compute.Models.LoadBalancerFrontendIPConfiguration[]
{
})
},
                },
            };
            ArmOperation<Compute.CloudServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudServiceName, data);
            Compute.CloudServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create New Cloud Service with Single Role and Certificate from Key Vault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateNewCloudServiceWithSingleRoleAndCertificateFromKeyVault()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-04-04/CloudServiceRP/examples/CloudService_Create_WithSingleRoleAndCertificate.json
            // this example is just showing the usage of "CloudServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            Compute.CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            Compute.CloudServiceData data = new CloudServiceData(new AzureLocation("westus"))
            {
                PackageUri = new Uri("{PackageUrl}"),
                Configuration = "{ServiceConfiguration}",
                UpgradeMode = CloudServiceUpgradeMode.Auto,
                NetworkProfile = new CloudServiceNetworkProfile()
                {
                    LoadBalancerConfigurations =
{
new CloudServiceLoadBalancerConfiguration("contosolb",new Compute.Models.LoadBalancerFrontendIPConfiguration[]
{
})
},
                },
            };
            ArmOperation<Compute.CloudServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudServiceName, data);
            Compute.CloudServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create New Cloud Service with Single Role and RDP Extension
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateNewCloudServiceWithSingleRoleAndRDPExtension()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-04-04/CloudServiceRP/examples/CloudService_Create_WithSingleRoleAndRDP.json
            // this example is just showing the usage of "CloudServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            Compute.CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            Compute.CloudServiceData data = new CloudServiceData(new AzureLocation("westus"))
            {
                PackageUri = new Uri("{PackageUrl}"),
                Configuration = "{ServiceConfiguration}",
                UpgradeMode = CloudServiceUpgradeMode.Auto,
                NetworkProfile = new CloudServiceNetworkProfile()
                {
                    LoadBalancerConfigurations =
{
new CloudServiceLoadBalancerConfiguration("contosolb",new Compute.Models.LoadBalancerFrontendIPConfiguration[]
{
})
},
                },
            };
            ArmOperation<Compute.CloudServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudServiceName, data);
            Compute.CloudServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Cloud Service with Multiple Roles and RDP Extension
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCloudServiceWithMultipleRolesAndRDPExtension()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-04-04/CloudServiceRP/examples/CloudService_Get_WithMultiRoleAndRDP.json
            // this example is just showing the usage of "CloudServices_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            Compute.CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            Compute.CloudServiceResource result = await collection.GetAsync(cloudServiceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List Cloud Services in a Resource Group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListCloudServicesInAResourceGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-04-04/CloudServiceRP/examples/CloudService_List_ByResourceGroup.json
            // this example is just showing the usage of "CloudServices_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            Compute.CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation and iterate over the result
            await foreach (Compute.CloudServiceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.CloudServiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
