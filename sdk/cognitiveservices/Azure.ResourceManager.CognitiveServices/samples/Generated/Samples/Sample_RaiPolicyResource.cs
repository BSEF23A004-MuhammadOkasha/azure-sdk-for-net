// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CognitiveServices.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_RaiPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetRaiPolicy()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2024-10-01/examples/GetRaiPolicy.json
            // this example is just showing the usage of "RaiPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RaiPolicyResource created on azure
            // for more information of creating RaiPolicyResource, please refer to the document of RaiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string raiPolicyName = "raiPolicyName";
            ResourceIdentifier raiPolicyResourceId = RaiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, raiPolicyName);
            RaiPolicyResource raiPolicy = client.GetRaiPolicyResource(raiPolicyResourceId);

            // invoke the operation
            RaiPolicyResource result = await raiPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RaiPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PutRaiPolicy()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2024-10-01/examples/PutRaiPolicy.json
            // this example is just showing the usage of "RaiPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RaiPolicyResource created on azure
            // for more information of creating RaiPolicyResource, please refer to the document of RaiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string raiPolicyName = "raiPolicyName";
            ResourceIdentifier raiPolicyResourceId = RaiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, raiPolicyName);
            RaiPolicyResource raiPolicy = client.GetRaiPolicyResource(raiPolicyResourceId);

            // invoke the operation
            RaiPolicyData data = new RaiPolicyData()
            {
                Properties = new RaiPolicyProperties()
                {
                    Mode = RaiPolicyMode.AsynchronousFilter,
                    BasePolicyName = "Microsoft.Default",
                    ContentFilters =
{
new RaiPolicyContentFilter()
{
Name = "hate",
Enabled = false,
SeverityThreshold = RaiPolicyContentLevel.High,
Blocking = false,
Source = RaiPolicyContentSource.Prompt,
},new RaiPolicyContentFilter()
{
Name = "hate",
Enabled = true,
SeverityThreshold = RaiPolicyContentLevel.Medium,
Blocking = true,
Source = RaiPolicyContentSource.Completion,
},new RaiPolicyContentFilter()
{
Name = "sexual",
Enabled = true,
SeverityThreshold = RaiPolicyContentLevel.High,
Blocking = true,
Source = RaiPolicyContentSource.Prompt,
},new RaiPolicyContentFilter()
{
Name = "sexual",
Enabled = true,
SeverityThreshold = RaiPolicyContentLevel.Medium,
Blocking = true,
Source = RaiPolicyContentSource.Completion,
},new RaiPolicyContentFilter()
{
Name = "selfharm",
Enabled = true,
SeverityThreshold = RaiPolicyContentLevel.High,
Blocking = true,
Source = RaiPolicyContentSource.Prompt,
},new RaiPolicyContentFilter()
{
Name = "selfharm",
Enabled = true,
SeverityThreshold = RaiPolicyContentLevel.Medium,
Blocking = true,
Source = RaiPolicyContentSource.Completion,
},new RaiPolicyContentFilter()
{
Name = "violence",
Enabled = true,
SeverityThreshold = RaiPolicyContentLevel.Medium,
Blocking = true,
Source = RaiPolicyContentSource.Prompt,
},new RaiPolicyContentFilter()
{
Name = "violence",
Enabled = true,
SeverityThreshold = RaiPolicyContentLevel.Medium,
Blocking = true,
Source = RaiPolicyContentSource.Completion,
},new RaiPolicyContentFilter()
{
Name = "jailbreak",
Enabled = true,
Blocking = true,
Source = RaiPolicyContentSource.Prompt,
},new RaiPolicyContentFilter()
{
Name = "protected_material_text",
Enabled = true,
Blocking = true,
Source = RaiPolicyContentSource.Completion,
},new RaiPolicyContentFilter()
{
Name = "protected_material_code",
Enabled = true,
Blocking = true,
Source = RaiPolicyContentSource.Completion,
},new RaiPolicyContentFilter()
{
Name = "profanity",
Enabled = true,
Blocking = true,
Source = RaiPolicyContentSource.Prompt,
}
},
                },
            };
            ArmOperation<RaiPolicyResource> lro = await raiPolicy.UpdateAsync(WaitUntil.Completed, data);
            RaiPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RaiPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteRaiPolicy()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2024-10-01/examples/DeleteRaiPolicy.json
            // this example is just showing the usage of "RaiPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RaiPolicyResource created on azure
            // for more information of creating RaiPolicyResource, please refer to the document of RaiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string raiPolicyName = "raiPolicyName";
            ResourceIdentifier raiPolicyResourceId = RaiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, raiPolicyName);
            RaiPolicyResource raiPolicy = client.GetRaiPolicyResource(raiPolicyResourceId);

            // invoke the operation
            await raiPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
