// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRouteCrossConnectionPeeringResource
    {
        // GetExpressRouteCrossConnectionsArpTable
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetArpTableExpressRouteCrossConnection_GetExpressRouteCrossConnectionsArpTable()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionsArpTable.json
            // this example is just showing the usage of "ExpressRouteCrossConnections_ListArpTable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCrossConnectionPeeringResource created on azure
            // for more information of creating ExpressRouteCrossConnectionPeeringResource, please refer to the document of ExpressRouteCrossConnectionPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            string crossConnectionName = "<circuitServiceKey>";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCrossConnectionPeeringResourceId = ExpressRouteCrossConnectionPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, crossConnectionName, peeringName);
            ExpressRouteCrossConnectionPeeringResource expressRouteCrossConnectionPeering = client.GetExpressRouteCrossConnectionPeeringResource(expressRouteCrossConnectionPeeringResourceId);

            // invoke the operation
            string devicePath = "primary";
            ArmOperation<ExpressRouteCircuitsArpTableListResult> lro = await expressRouteCrossConnectionPeering.GetArpTableExpressRouteCrossConnectionAsync(WaitUntil.Completed, devicePath);
            ExpressRouteCircuitsArpTableListResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetExpressRouteCrossConnectionsRouteTableSummary
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRoutesTableSummaryExpressRouteCrossConnection_GetExpressRouteCrossConnectionsRouteTableSummary()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionsRouteTableSummary.json
            // this example is just showing the usage of "ExpressRouteCrossConnections_ListRoutesTableSummary" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCrossConnectionPeeringResource created on azure
            // for more information of creating ExpressRouteCrossConnectionPeeringResource, please refer to the document of ExpressRouteCrossConnectionPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            string crossConnectionName = "<circuitServiceKey>";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCrossConnectionPeeringResourceId = ExpressRouteCrossConnectionPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, crossConnectionName, peeringName);
            ExpressRouteCrossConnectionPeeringResource expressRouteCrossConnectionPeering = client.GetExpressRouteCrossConnectionPeeringResource(expressRouteCrossConnectionPeeringResourceId);

            // invoke the operation
            string devicePath = "primary";
            ArmOperation<ExpressRouteCrossConnectionsRoutesTableSummaryListResult> lro = await expressRouteCrossConnectionPeering.GetRoutesTableSummaryExpressRouteCrossConnectionAsync(WaitUntil.Completed, devicePath);
            ExpressRouteCrossConnectionsRoutesTableSummaryListResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetExpressRouteCrossConnectionsRouteTable
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRoutesTableExpressRouteCrossConnection_GetExpressRouteCrossConnectionsRouteTable()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionsRouteTable.json
            // this example is just showing the usage of "ExpressRouteCrossConnections_ListRoutesTable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCrossConnectionPeeringResource created on azure
            // for more information of creating ExpressRouteCrossConnectionPeeringResource, please refer to the document of ExpressRouteCrossConnectionPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            string crossConnectionName = "<circuitServiceKey>";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCrossConnectionPeeringResourceId = ExpressRouteCrossConnectionPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, crossConnectionName, peeringName);
            ExpressRouteCrossConnectionPeeringResource expressRouteCrossConnectionPeering = client.GetExpressRouteCrossConnectionPeeringResource(expressRouteCrossConnectionPeeringResourceId);

            // invoke the operation
            string devicePath = "primary";
            ArmOperation<ExpressRouteCircuitsRoutesTableListResult> lro = await expressRouteCrossConnectionPeering.GetRoutesTableExpressRouteCrossConnectionAsync(WaitUntil.Completed, devicePath);
            ExpressRouteCircuitsRoutesTableListResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // DeleteExpressRouteCrossConnectionBgpPeering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteExpressRouteCrossConnectionBgpPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionBgpPeeringDelete.json
            // this example is just showing the usage of "ExpressRouteCrossConnectionPeerings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCrossConnectionPeeringResource created on azure
            // for more information of creating ExpressRouteCrossConnectionPeeringResource, please refer to the document of ExpressRouteCrossConnectionPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            string crossConnectionName = "<circuitServiceKey>";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCrossConnectionPeeringResourceId = ExpressRouteCrossConnectionPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, crossConnectionName, peeringName);
            ExpressRouteCrossConnectionPeeringResource expressRouteCrossConnectionPeering = client.GetExpressRouteCrossConnectionPeeringResource(expressRouteCrossConnectionPeeringResourceId);

            // invoke the operation
            await expressRouteCrossConnectionPeering.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // GetExpressRouteCrossConnectionBgpPeering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetExpressRouteCrossConnectionBgpPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionBgpPeeringGet.json
            // this example is just showing the usage of "ExpressRouteCrossConnectionPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCrossConnectionPeeringResource created on azure
            // for more information of creating ExpressRouteCrossConnectionPeeringResource, please refer to the document of ExpressRouteCrossConnectionPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            string crossConnectionName = "<circuitServiceKey>";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCrossConnectionPeeringResourceId = ExpressRouteCrossConnectionPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, crossConnectionName, peeringName);
            ExpressRouteCrossConnectionPeeringResource expressRouteCrossConnectionPeering = client.GetExpressRouteCrossConnectionPeeringResource(expressRouteCrossConnectionPeeringResourceId);

            // invoke the operation
            ExpressRouteCrossConnectionPeeringResource result = await expressRouteCrossConnectionPeering.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCrossConnectionPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRouteCrossConnectionBgpPeeringCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ExpressRouteCrossConnectionBgpPeeringCreate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionBgpPeeringCreate.json
            // this example is just showing the usage of "ExpressRouteCrossConnectionPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCrossConnectionPeeringResource created on azure
            // for more information of creating ExpressRouteCrossConnectionPeeringResource, please refer to the document of ExpressRouteCrossConnectionPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            string crossConnectionName = "<circuitServiceKey>";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCrossConnectionPeeringResourceId = ExpressRouteCrossConnectionPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, crossConnectionName, peeringName);
            ExpressRouteCrossConnectionPeeringResource expressRouteCrossConnectionPeering = client.GetExpressRouteCrossConnectionPeeringResource(expressRouteCrossConnectionPeeringResourceId);

            // invoke the operation
            ExpressRouteCrossConnectionPeeringData data = new ExpressRouteCrossConnectionPeeringData()
            {
                PeerASN = 200L,
                PrimaryPeerAddressPrefix = "192.168.16.252/30",
                SecondaryPeerAddressPrefix = "192.168.18.252/30",
                VlanId = 200,
                IPv6PeeringConfig = new IPv6ExpressRouteCircuitPeeringConfig()
                {
                    PrimaryPeerAddressPrefix = "3FFE:FFFF:0:CD30::/126",
                    SecondaryPeerAddressPrefix = "3FFE:FFFF:0:CD30::4/126",
                },
            };
            ArmOperation<ExpressRouteCrossConnectionPeeringResource> lro = await expressRouteCrossConnectionPeering.UpdateAsync(WaitUntil.Completed, data);
            ExpressRouteCrossConnectionPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCrossConnectionPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
