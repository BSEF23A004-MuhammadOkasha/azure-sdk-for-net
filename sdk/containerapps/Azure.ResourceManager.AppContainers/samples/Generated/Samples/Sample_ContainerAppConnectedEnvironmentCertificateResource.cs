// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppConnectedEnvironmentCertificateResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/ConnectedEnvironmentsCertificate_Get.json
            // this example is just showing the usage of "ConnectedEnvironmentsCertificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentCertificateResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentCertificateResource, please refer to the document of ContainerAppConnectedEnvironmentCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "testcontainerenv";
            string certificateName = "certificate-firendly-name";
            ResourceIdentifier containerAppConnectedEnvironmentCertificateResourceId = ContainerAppConnectedEnvironmentCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName, certificateName);
            ContainerAppConnectedEnvironmentCertificateResource containerAppConnectedEnvironmentCertificate = client.GetContainerAppConnectedEnvironmentCertificateResource(containerAppConnectedEnvironmentCertificateResourceId);

            // invoke the operation
            ContainerAppConnectedEnvironmentCertificateResource result = await containerAppConnectedEnvironmentCertificate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/ConnectedEnvironmentsCertificate_Delete.json
            // this example is just showing the usage of "ConnectedEnvironmentsCertificates_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentCertificateResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentCertificateResource, please refer to the document of ContainerAppConnectedEnvironmentCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "testcontainerenv";
            string certificateName = "certificate-firendly-name";
            ResourceIdentifier containerAppConnectedEnvironmentCertificateResourceId = ContainerAppConnectedEnvironmentCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName, certificateName);
            ContainerAppConnectedEnvironmentCertificateResource containerAppConnectedEnvironmentCertificate = client.GetContainerAppConnectedEnvironmentCertificateResource(containerAppConnectedEnvironmentCertificateResourceId);

            // invoke the operation
            await containerAppConnectedEnvironmentCertificate.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/ConnectedEnvironmentsCertificates_Patch.json
            // this example is just showing the usage of "ConnectedEnvironmentsCertificates_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentCertificateResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentCertificateResource, please refer to the document of ContainerAppConnectedEnvironmentCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "testcontainerenv";
            string certificateName = "certificate-firendly-name";
            ResourceIdentifier containerAppConnectedEnvironmentCertificateResourceId = ContainerAppConnectedEnvironmentCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName, certificateName);
            ContainerAppConnectedEnvironmentCertificateResource containerAppConnectedEnvironmentCertificate = client.GetContainerAppConnectedEnvironmentCertificateResource(containerAppConnectedEnvironmentCertificateResourceId);

            // invoke the operation
            ContainerAppCertificatePatch patch = new ContainerAppCertificatePatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ContainerAppConnectedEnvironmentCertificateResource result = await containerAppConnectedEnvironmentCertificate.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
