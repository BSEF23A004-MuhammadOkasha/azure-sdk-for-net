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
using Azure.ResourceManager.Hci;
using Azure.ResourceManager.Hci.Models;

namespace Azure.ResourceManager.Hci.Samples
{
    public partial class Sample_HciGuestAgentResource
    {
        // CreateGuestAgent
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateGuestAgent()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/preview/2022-12-15-preview/examples/CreateGuestAgent.json
            // this example is just showing the usage of "GuestAgents_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciGuestAgentResource created on azure
            // for more information of creating HciGuestAgentResource, please refer to the document of HciGuestAgentResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "ContosoVm";
            string name = "default";
            ResourceIdentifier hciGuestAgentResourceId = HciGuestAgentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName, name);
            HciGuestAgentResource hciGuestAgent = client.GetHciGuestAgentResource(hciGuestAgentResourceId);

            // invoke the operation
            HciGuestAgentData data = new HciGuestAgentData()
            {
                Credentials = new HciGuestCredential()
                {
                    Username = "tempuser",
                    Password = "<password>",
                },
                ProvisioningAction = HciAgentProvisioningAction.Install,
            };
            ArmOperation<HciGuestAgentResource> lro = await hciGuestAgent.UpdateAsync(WaitUntil.Completed, data);
            HciGuestAgentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HciGuestAgentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetGuestAgent
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetGuestAgent()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/preview/2022-12-15-preview/examples/GetGuestAgent.json
            // this example is just showing the usage of "GuestAgents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciGuestAgentResource created on azure
            // for more information of creating HciGuestAgentResource, please refer to the document of HciGuestAgentResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "ContosoVm";
            string name = "default";
            ResourceIdentifier hciGuestAgentResourceId = HciGuestAgentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName, name);
            HciGuestAgentResource hciGuestAgent = client.GetHciGuestAgentResource(hciGuestAgentResourceId);

            // invoke the operation
            HciGuestAgentResource result = await hciGuestAgent.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HciGuestAgentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteGuestAgent
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteGuestAgent()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/preview/2022-12-15-preview/examples/DeleteGuestAgent.json
            // this example is just showing the usage of "GuestAgents_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciGuestAgentResource created on azure
            // for more information of creating HciGuestAgentResource, please refer to the document of HciGuestAgentResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "ContosoVm";
            string name = "default";
            ResourceIdentifier hciGuestAgentResourceId = HciGuestAgentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName, name);
            HciGuestAgentResource hciGuestAgent = client.GetHciGuestAgentResource(hciGuestAgentResourceId);

            // invoke the operation
            await hciGuestAgent.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
