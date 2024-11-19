// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteWorkflowResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GETAWorkflow()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/GetWorkflow.json
            // this example is just showing the usage of "WebApps_GetWorkflow" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteWorkflowResource created on azure
            // for more information of creating SiteWorkflowResource, please refer to the document of SiteWorkflowResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testsite2";
            string workflowName = "stateful1";
            ResourceIdentifier siteWorkflowResourceId = SiteWorkflowResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName);
            SiteWorkflowResource siteWorkflow = client.GetSiteWorkflowResource(siteWorkflowResourceId);

            // invoke the operation
            SiteWorkflowResource result = await siteWorkflow.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkflowEnvelopeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
