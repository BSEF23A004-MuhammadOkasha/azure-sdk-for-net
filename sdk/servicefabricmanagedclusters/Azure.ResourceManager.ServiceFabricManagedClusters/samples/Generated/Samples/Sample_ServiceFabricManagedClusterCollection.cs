// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Samples
{
    public partial class Sample_ServiceFabricManagedClusterCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListClusterByResourceGroup()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ManagedClusterListByResourceGroupOperation_example.json
            // this example is just showing the usage of "ManagedClusters_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricManagedClusterResource
            ServiceFabricManagedClusterCollection collection = resourceGroupResource.GetServiceFabricManagedClusters();

            // invoke the operation and iterate over the result
            await foreach (ServiceFabricManagedClusterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricManagedClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetACluster()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ManagedClusterGetOperation_example.json
            // this example is just showing the usage of "ManagedClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricManagedClusterResource
            ServiceFabricManagedClusterCollection collection = resourceGroupResource.GetServiceFabricManagedClusters();

            // invoke the operation
            string clusterName = "myCluster";
            ServiceFabricManagedClusterResource result = await collection.GetAsync(clusterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetACluster()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ManagedClusterGetOperation_example.json
            // this example is just showing the usage of "ManagedClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricManagedClusterResource
            ServiceFabricManagedClusterCollection collection = resourceGroupResource.GetServiceFabricManagedClusters();

            // invoke the operation
            string clusterName = "myCluster";
            bool result = await collection.ExistsAsync(clusterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetACluster()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ManagedClusterGetOperation_example.json
            // this example is just showing the usage of "ManagedClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricManagedClusterResource
            ServiceFabricManagedClusterCollection collection = resourceGroupResource.GetServiceFabricManagedClusters();

            // invoke the operation
            string clusterName = "myCluster";
            NullableResponse<ServiceFabricManagedClusterResource> response = await collection.GetIfExistsAsync(clusterName);
            ServiceFabricManagedClusterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricManagedClusterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutAClusterWithMaximumParameters()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ManagedClusterPutOperation_example_max.json
            // this example is just showing the usage of "ManagedClusters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricManagedClusterResource
            ServiceFabricManagedClusterCollection collection = resourceGroupResource.GetServiceFabricManagedClusters();

            // invoke the operation
            string clusterName = "myCluster";
            ServiceFabricManagedClusterData data = new ServiceFabricManagedClusterData(new AzureLocation("eastus"), new ServiceFabricManagedClustersSku(ServiceFabricManagedClustersSkuName.Basic))
            {
                DnsName = "myCluster",
                ClientConnectionPort = 19000,
                HttpGatewayConnectionPort = 19080,
                AdminUserName = "vmadmin",
                AdminPassword = "{vm-password}",
                LoadBalancingRules =
{
new ManagedClusterLoadBalancingRule(80,80,new ManagedClusterLoadBalancingRuleTransportProtocol("http"),ManagedClusterLoadBalanceProbeProtocol.Http)
{
ProbePort = 80,
},new ManagedClusterLoadBalancingRule(443,443,new ManagedClusterLoadBalancingRuleTransportProtocol("http"),ManagedClusterLoadBalanceProbeProtocol.Http)
{
ProbePort = 443,
},new ManagedClusterLoadBalancingRule(10000,10000,ManagedClusterLoadBalancingRuleTransportProtocol.Tcp,ManagedClusterLoadBalanceProbeProtocol.Http)
{
ProbePort = 10000,
LoadDistribution = "Default",
}
},
                IsRdpAccessAllowed = true,
                NetworkSecurityRules =
{
new ServiceFabricManagedNetworkSecurityRule("TestName",ServiceFabricManagedNsgProtocol.Tcp,ServiceFabricManagedNetworkTrafficAccess.Allow,1010,ServiceFabricManagedNetworkSecurityRuleDirection.Inbound)
{
Description = "Test description",
SourceAddressPrefixes =
{
"*"
},
DestinationAddressPrefixes =
{
"*"
},
SourcePortRanges =
{
"*"
},
DestinationPortRanges =
{
"*"
},
},new ServiceFabricManagedNetworkSecurityRule("AllowARM",new ServiceFabricManagedNsgProtocol("*"),ServiceFabricManagedNetworkTrafficAccess.Allow,2002,ServiceFabricManagedNetworkSecurityRuleDirection.Inbound)
{
SourceAddressPrefix = "AzureResourceManager",
DestinationAddressPrefix = "*",
SourcePortRange = "*",
DestinationPortRange = "33500-33699",
}
},
                FabricSettings =
{
new ClusterFabricSettingsSection("ManagedIdentityTokenService",new ClusterFabricSettingsParameterDescription[]
{
new ClusterFabricSettingsParameterDescription("IsEnabled","true")
})
},
                ClusterCodeVersion = "7.1.168.9494",
                ClusterUpgradeMode = ManagedClusterUpgradeMode.Manual,
                AddOnFeatures =
{
ManagedClusterAddOnFeature.DnsService,ManagedClusterAddOnFeature.BackupRestoreService,ManagedClusterAddOnFeature.ResourceMonitorService
},
                IsAutoOSUpgradeEnabled = true,
                HasZoneResiliency = true,
                MaxUnusedVersionsToKeep = 3,
                IsIPv6Enabled = true,
                IPTags =
{
new ManagedClusterIPTag("FirstPartyUsage","SQL")
},
                AuxiliarySubnets =
{
new ManagedClusterSubnet("testSubnet1")
{
IsIPv6Enabled = true,
PrivateEndpointNetworkPolicies = ManagedClusterSubnetPrivateEndpointNetworkPoliciesState.Enabled,
PrivateLinkServiceNetworkPolicies = ManagedClusterSubnetPrivateLinkServiceNetworkPoliciesState.Enabled,
NetworkSecurityGroupId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resRg/providers/Microsoft.Network/networkSecurityGroups/sn1"),
}
},
                ServiceEndpoints =
{
new ManagedClusterServiceEndpoint("Microsoft.Storage")
{
Locations =
{
new AzureLocation("eastus2"),new AzureLocation("usnorth")
},
}
},
                ZonalUpdateMode = ZonalUpdateMode.Fast,
                UseCustomVnet = true,
                PublicIPPrefixId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/resRg/providers/Microsoft.Network/publicIPPrefixes/myPublicIPPrefix"),
                PublicIPv6PrefixId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/resRg/providers/Microsoft.Network/publicIPPrefixes/myPublicIPv6Prefix"),
                DdosProtectionPlanId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resRg/providers/Microsoft.Network/ddosProtectionPlans/myDDoSProtectionPlan"),
                UpgradeDescription = new ManagedClusterUpgradePolicy()
                {
                    ForceRestart = false,
                    HealthPolicy = new ManagedClusterHealthPolicy(10, 30),
                    DeltaHealthPolicy = new ManagedClusterUpgradeDeltaHealthPolicy(20)
                    {
                        MaxPercentUpgradeDomainDeltaUnhealthyNodes = 40,
                        MaxPercentDeltaUnhealthyApplications = 40,
                    },
                    MonitoringPolicy = new ManagedClusterMonitoringPolicy(TimeSpan.Parse("00:05:00"), TimeSpan.Parse("00:45:00"), "00:55:00", "12:00:00", "03:00:00"),
                },
                HttpGatewayTokenAuthConnectionPort = 19081,
                IsHttpGatewayExclusiveAuthModeEnabled = true,
                Tags =
{
},
            };
            ArmOperation<ServiceFabricManagedClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            ServiceFabricManagedClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutAClusterWithMinimumParameters()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ManagedClusterPutOperation_example_min.json
            // this example is just showing the usage of "ManagedClusters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricManagedClusterResource
            ServiceFabricManagedClusterCollection collection = resourceGroupResource.GetServiceFabricManagedClusters();

            // invoke the operation
            string clusterName = "myCluster";
            ServiceFabricManagedClusterData data = new ServiceFabricManagedClusterData(new AzureLocation("eastus"), new ServiceFabricManagedClustersSku(ServiceFabricManagedClustersSkuName.Basic))
            {
                DnsName = "myCluster",
                AdminUserName = "vmadmin",
                AdminPassword = "{vm-password}",
                FabricSettings =
{
new ClusterFabricSettingsSection("ManagedIdentityTokenService",new ClusterFabricSettingsParameterDescription[]
{
new ClusterFabricSettingsParameterDescription("IsEnabled","true")
})
},
                ClusterUpgradeMode = ManagedClusterUpgradeMode.Automatic,
                ClusterUpgradeCadence = ManagedClusterUpgradeCadence.Wave1,
            };
            ArmOperation<ServiceFabricManagedClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            ServiceFabricManagedClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
