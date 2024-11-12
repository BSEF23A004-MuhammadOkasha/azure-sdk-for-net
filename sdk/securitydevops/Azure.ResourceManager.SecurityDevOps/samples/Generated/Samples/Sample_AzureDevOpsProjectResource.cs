// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SecurityDevOps.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityDevOps.Samples
{
    public partial class Sample_AzureDevOpsProjectResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AzureDevOpsProjectGet()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/AzureDevOpsProjectGet.json
            // this example is just showing the usage of "AzureDevOpsProject_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureDevOpsProjectResource created on azure
            // for more information of creating AzureDevOpsProjectResource, please refer to the document of AzureDevOpsProjectResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string azureDevOpsConnectorName = "testconnector";
            string azureDevOpsOrgName = "myOrg";
            string azureDevOpsProjectName = "myProject";
            ResourceIdentifier azureDevOpsProjectResourceId = AzureDevOpsProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName, azureDevOpsProjectName);
            AzureDevOpsProjectResource azureDevOpsProject = client.GetAzureDevOpsProjectResource(azureDevOpsProjectResourceId);

            // invoke the operation
            AzureDevOpsProjectResource result = await azureDevOpsProject.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureDevOpsProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_AzureDevOpsProjectUpdate()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/AzureDevOpsProjectUpdate.json
            // this example is just showing the usage of "AzureDevOpsProject_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureDevOpsProjectResource created on azure
            // for more information of creating AzureDevOpsProjectResource, please refer to the document of AzureDevOpsProjectResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string azureDevOpsConnectorName = "testconnector";
            string azureDevOpsOrgName = "myOrg";
            string azureDevOpsProjectName = "myProject";
            ResourceIdentifier azureDevOpsProjectResourceId = AzureDevOpsProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName, azureDevOpsProjectName);
            AzureDevOpsProjectResource azureDevOpsProject = client.GetAzureDevOpsProjectResource(azureDevOpsProjectResourceId);

            // invoke the operation
            AzureDevOpsProjectData data = new AzureDevOpsProjectData()
            {
                Properties = new AzureDevOpsProjectProperties()
                {
                    AutoDiscovery = AutoDiscovery.Disabled,
                },
            };
            ArmOperation<AzureDevOpsProjectResource> lro = await azureDevOpsProject.UpdateAsync(WaitUntil.Completed, data);
            AzureDevOpsProjectResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureDevOpsProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
