// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_VirtualWorkspaceResource
    {
        // Workspace_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkspaceGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/Workspace_Get.json
            // this example is just showing the usage of "Workspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWorkspaceResource created on azure
            // for more information of creating VirtualWorkspaceResource, please refer to the document of VirtualWorkspaceResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string workspaceName = "workspace1";
            ResourceIdentifier virtualWorkspaceResourceId = VirtualWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            VirtualWorkspaceResource virtualWorkspace = client.GetVirtualWorkspaceResource(virtualWorkspaceResourceId);

            // invoke the operation
            VirtualWorkspaceResource result = await virtualWorkspace.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Workspace_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_WorkspaceDelete()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/Workspace_Delete.json
            // this example is just showing the usage of "Workspaces_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWorkspaceResource created on azure
            // for more information of creating VirtualWorkspaceResource, please refer to the document of VirtualWorkspaceResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string workspaceName = "workspace1";
            ResourceIdentifier virtualWorkspaceResourceId = VirtualWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            VirtualWorkspaceResource virtualWorkspace = client.GetVirtualWorkspaceResource(virtualWorkspaceResourceId);

            // invoke the operation
            await virtualWorkspace.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Workspace_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_WorkspaceUpdate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/Workspace_Update.json
            // this example is just showing the usage of "Workspaces_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWorkspaceResource created on azure
            // for more information of creating VirtualWorkspaceResource, please refer to the document of VirtualWorkspaceResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string workspaceName = "workspace1";
            ResourceIdentifier virtualWorkspaceResourceId = VirtualWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            VirtualWorkspaceResource virtualWorkspace = client.GetVirtualWorkspaceResource(virtualWorkspaceResourceId);

            // invoke the operation
            VirtualWorkspacePatch patch = new VirtualWorkspacePatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
                Description = "des1",
                FriendlyName = "friendly",
            };
            VirtualWorkspaceResource result = await virtualWorkspace.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Workspace_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualWorkspaces_WorkspaceListBySubscription()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/Workspace_ListBySubscription.json
            // this example is just showing the usage of "Workspaces_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (VirtualWorkspaceResource item in subscriptionResource.GetVirtualWorkspacesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualWorkspaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateLinkResources_ListByWorkspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPrivateLinkResources_PrivateLinkResourcesListByWorkspace()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/PrivateLinkResources_ListByWorkspace.json
            // this example is just showing the usage of "PrivateLinkResources_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWorkspaceResource created on azure
            // for more information of creating VirtualWorkspaceResource, please refer to the document of VirtualWorkspaceResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string workspaceName = "workspace1";
            ResourceIdentifier virtualWorkspaceResourceId = VirtualWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            VirtualWorkspaceResource virtualWorkspace = client.GetVirtualWorkspaceResource(virtualWorkspaceResourceId);

            // invoke the operation and iterate over the result
            await foreach (DesktopVirtualizationPrivateLinkResourceData item in virtualWorkspace.GetPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
