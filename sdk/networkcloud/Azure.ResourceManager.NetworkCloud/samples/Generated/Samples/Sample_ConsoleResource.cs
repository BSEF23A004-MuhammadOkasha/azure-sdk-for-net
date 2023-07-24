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
    public partial class Sample_ConsoleResource
    {
        // Get virtual machine console
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualMachineConsole()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2023-05-01-preview/examples/Consoles_Get.json
            // this example is just showing the usage of "Consoles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConsoleResource created on azure
            // for more information of creating ConsoleResource, please refer to the document of ConsoleResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            string consoleName = "default";
            ResourceIdentifier consoleResourceId = ConsoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName, consoleName);
            ConsoleResource console = client.GetConsoleResource(consoleResourceId);

            // invoke the operation
            ConsoleResource result = await console.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConsoleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete virtual machine console
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteVirtualMachineConsole()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2023-05-01-preview/examples/Consoles_Delete.json
            // this example is just showing the usage of "Consoles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConsoleResource created on azure
            // for more information of creating ConsoleResource, please refer to the document of ConsoleResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            string consoleName = "default";
            ResourceIdentifier consoleResourceId = ConsoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName, consoleName);
            ConsoleResource console = client.GetConsoleResource(consoleResourceId);

            // invoke the operation
            await console.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Patch virtual machine console
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchVirtualMachineConsole()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2023-05-01-preview/examples/Consoles_Patch.json
            // this example is just showing the usage of "Consoles_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConsoleResource created on azure
            // for more information of creating ConsoleResource, please refer to the document of ConsoleResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            string consoleName = "default";
            ResourceIdentifier consoleResourceId = ConsoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName, consoleName);
            ConsoleResource console = client.GetConsoleResource(consoleResourceId);

            // invoke the operation
            ConsolePatch patch = new ConsolePatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                Enabled = ConsoleEnabled.True,
                Expiration = DateTimeOffset.Parse("2022-06-01T01:27:03.008Z"),
                KeyData = "ssh-rsa AAtsE3njSONzDYRIZv/WLjVuMfrUSByHp+jfaaOLHTIIB4fJvo6dQUZxE20w2iDHV3tEkmnTo84eba97VMueQD6OzJPEyWZMRpz8UYWOd0IXeRqiFu1lawNblZhwNT/ojNZfpB3af/YDzwQCZgTcTRyNNhL4o/blKUmug0daSsSXISTRnIDpcf5qytjs1Xo+yYyJMvzLL59mhAyb3p/cD+Y3/s3WhAx+l0XOKpzXnblrv9d3q4c2tWmm/SyFqthaqd0= admin@vm",
            };
            ArmOperation<ConsoleResource> lro = await console.UpdateAsync(WaitUntil.Completed, patch);
            ConsoleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConsoleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
