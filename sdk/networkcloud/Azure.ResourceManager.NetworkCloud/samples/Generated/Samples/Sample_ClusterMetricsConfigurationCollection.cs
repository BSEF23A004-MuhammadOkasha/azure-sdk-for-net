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
using Azure.ResourceManager.NetworkCloud;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_ClusterMetricsConfigurationCollection
    {
        // List metrics configurations of the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListMetricsConfigurationsOfTheCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2023-05-01-preview/examples/ClusterMetricsConfigurations_ListByCluster.json
            // this example is just showing the usage of "MetricsConfigurations_ListByCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ClusterResource created on azure
            // for more information of creating ClusterResource, please refer to the document of ClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier clusterResourceId = ClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ClusterResource cluster = client.GetClusterResource(clusterResourceId);

            // get the collection of this ClusterMetricsConfigurationResource
            ClusterMetricsConfigurationCollection collection = cluster.GetClusterMetricsConfigurations();

            // invoke the operation and iterate over the result
            await foreach (ClusterMetricsConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ClusterMetricsConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get metrics configuration of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMetricsConfigurationOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2023-05-01-preview/examples/ClusterMetricsConfigurations_Get.json
            // this example is just showing the usage of "MetricsConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ClusterResource created on azure
            // for more information of creating ClusterResource, please refer to the document of ClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier clusterResourceId = ClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ClusterResource cluster = client.GetClusterResource(clusterResourceId);

            // get the collection of this ClusterMetricsConfigurationResource
            ClusterMetricsConfigurationCollection collection = cluster.GetClusterMetricsConfigurations();

            // invoke the operation
            string metricsConfigurationName = "default";
            ClusterMetricsConfigurationResource result = await collection.GetAsync(metricsConfigurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ClusterMetricsConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get metrics configuration of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetMetricsConfigurationOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2023-05-01-preview/examples/ClusterMetricsConfigurations_Get.json
            // this example is just showing the usage of "MetricsConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ClusterResource created on azure
            // for more information of creating ClusterResource, please refer to the document of ClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier clusterResourceId = ClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ClusterResource cluster = client.GetClusterResource(clusterResourceId);

            // get the collection of this ClusterMetricsConfigurationResource
            ClusterMetricsConfigurationCollection collection = cluster.GetClusterMetricsConfigurations();

            // invoke the operation
            string metricsConfigurationName = "default";
            bool result = await collection.ExistsAsync(metricsConfigurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create or update metrics configuration of cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateMetricsConfigurationOfCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2023-05-01-preview/examples/ClusterMetricsConfigurations_Create.json
            // this example is just showing the usage of "MetricsConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ClusterResource created on azure
            // for more information of creating ClusterResource, please refer to the document of ClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string clusterName = "clusterName";
            ResourceIdentifier clusterResourceId = ClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ClusterResource cluster = client.GetClusterResource(clusterResourceId);

            // get the collection of this ClusterMetricsConfigurationResource
            ClusterMetricsConfigurationCollection collection = cluster.GetClusterMetricsConfigurations();

            // invoke the operation
            string metricsConfigurationName = "default";
            ClusterMetricsConfigurationData data = new ClusterMetricsConfigurationData(new AzureLocation("location"), new ExtendedLocation("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.ExtendedLocation/customLocations/clusterExtendedLocationName", "CustomLocation"), 15)
            {
                EnabledMetrics =
{
"metric1","metric2"
},
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
            };
            ArmOperation<ClusterMetricsConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, metricsConfigurationName, data);
            ClusterMetricsConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ClusterMetricsConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
