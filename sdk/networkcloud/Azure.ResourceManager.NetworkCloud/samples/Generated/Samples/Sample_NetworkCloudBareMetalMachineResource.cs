// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudBareMetalMachineResource
    {
        // List bare metal machines for subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkCloudBareMetalMachines_ListBareMetalMachinesForSubscription()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_ListBySubscription.json
            // this example is just showing the usage of "BareMetalMachines_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkCloudBareMetalMachineResource item in subscriptionResource.GetNetworkCloudBareMetalMachinesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudBareMetalMachineData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_Get.json
            // this example is just showing the usage of "BareMetalMachines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            NetworkCloudBareMetalMachineResource result = await networkCloudBareMetalMachine.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudBareMetalMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_Patch.json
            // this example is just showing the usage of "BareMetalMachines_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            NetworkCloudBareMetalMachinePatch patch = new NetworkCloudBareMetalMachinePatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                MachineDetails = "machinedetails",
            };
            ArmOperation<NetworkCloudBareMetalMachineResource> lro = await networkCloudBareMetalMachine.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudBareMetalMachineResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudBareMetalMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Cordon bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Cordon_CordonBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_Cordon.json
            // this example is just showing the usage of "BareMetalMachines_Cordon" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            BareMetalMachineCordonContent content = new BareMetalMachineCordonContent()
            {
                Evacuate = BareMetalMachineEvacuate.True,
            };
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachine.CordonAsync(WaitUntil.Completed, content: content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Power off bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PowerOff_PowerOffBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_PowerOff.json
            // this example is just showing the usage of "BareMetalMachines_PowerOff" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            BareMetalMachinePowerOffContent content = new BareMetalMachinePowerOffContent()
            {
                SkipShutdown = BareMetalMachineSkipShutdown.True,
            };
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachine.PowerOffAsync(WaitUntil.Completed, content: content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Reimage bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Reimage_ReimageBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_Reimage.json
            // this example is just showing the usage of "BareMetalMachines_Reimage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachine.ReimageAsync(WaitUntil.Completed);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Replace bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Replace_ReplaceBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_Replace.json
            // this example is just showing the usage of "BareMetalMachines_Replace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            BareMetalMachineReplaceContent content = new BareMetalMachineReplaceContent()
            {
                BmcCredentials = new AdministrativeCredentials("bmcuser")
                {
                    Password = "{password}",
                },
                BmcMacAddress = "00:00:4f:00:57:ad",
                BootMacAddress = "00:00:4e:00:58:af",
                MachineName = "name",
                SerialNumber = "BM1219XXX",
            };
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachine.ReplaceAsync(WaitUntil.Completed, content: content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Restart bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Restart_RestartBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_Restart.json
            // this example is just showing the usage of "BareMetalMachines_Restart" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachine.RestartAsync(WaitUntil.Completed);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Run command on bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RunCommand_RunCommandOnBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_RunCommand.json
            // this example is just showing the usage of "BareMetalMachines_RunCommand" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            BareMetalMachineRunCommandContent content = new BareMetalMachineRunCommandContent(60L, "cHdkCg==")
            {
                Arguments =
{
"--argument1","argument2"
},
            };
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachine.RunCommandAsync(WaitUntil.Completed, content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Run data extraction on bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RunDataExtracts_RunDataExtractionOnBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_RunDataExtracts.json
            // this example is just showing the usage of "BareMetalMachines_RunDataExtracts" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            BareMetalMachineRunDataExtractsContent content = new BareMetalMachineRunDataExtractsContent(new BareMetalMachineCommandSpecification[]
            {
new BareMetalMachineCommandSpecification("hardware-support-data-collection")
{
Arguments =
{
"SysInfo","TTYLog"
},
}
            }, 60L);
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachine.RunDataExtractsAsync(WaitUntil.Completed, content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Run and retrieve output from read only commands on bare metal machine.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RunReadCommands_RunAndRetrieveOutputFromReadOnlyCommandsOnBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_RunReadCommands.json
            // this example is just showing the usage of "BareMetalMachines_RunReadCommands" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            BareMetalMachineRunReadCommandsContent content = new BareMetalMachineRunReadCommandsContent(new BareMetalMachineCommandSpecification[]
            {
new BareMetalMachineCommandSpecification("kubectl get")
{
Arguments =
{
"pods","-A"
},
},new BareMetalMachineCommandSpecification("ping")
{
Arguments =
{
"192.168.0.99","-c","3"
},
}
            }, 60L);
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachine.RunReadCommandsAsync(WaitUntil.Completed, content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Start bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_StartBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_Start.json
            // this example is just showing the usage of "BareMetalMachines_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachine.StartAsync(WaitUntil.Completed);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Uncordon bare metal machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Uncordon_UncordonBareMetalMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/BareMetalMachines_Uncordon.json
            // this example is just showing the usage of "BareMetalMachines_Uncordon" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudBareMetalMachineResource created on azure
            // for more information of creating NetworkCloudBareMetalMachineResource, please refer to the document of NetworkCloudBareMetalMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string bareMetalMachineName = "bareMetalMachineName";
            ResourceIdentifier networkCloudBareMetalMachineResourceId = NetworkCloudBareMetalMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bareMetalMachineName);
            NetworkCloudBareMetalMachineResource networkCloudBareMetalMachine = client.GetNetworkCloudBareMetalMachineResource(networkCloudBareMetalMachineResourceId);

            // invoke the operation
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudBareMetalMachine.UncordonAsync(WaitUntil.Completed);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
