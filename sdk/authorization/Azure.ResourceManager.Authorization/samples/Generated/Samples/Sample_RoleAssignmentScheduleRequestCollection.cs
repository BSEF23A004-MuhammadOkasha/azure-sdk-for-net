// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Authorization;
using Azure.ResourceManager.Authorization.Models;

namespace Azure.ResourceManager.Authorization.Samples
{
    public partial class Sample_RoleAssignmentScheduleRequestCollection
    {
        // PutRoleAssignmentScheduleRequest
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutRoleAssignmentScheduleRequest()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/PutRoleAssignmentScheduleRequest.json
            // this example is just showing the usage of "RoleAssignmentScheduleRequests_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleAssignmentScheduleRequestResource
            string scope = "providers/Microsoft.Subscription/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleAssignmentScheduleRequestCollection collection = client.GetRoleAssignmentScheduleRequests(scopeId);

            // invoke the operation
            string roleAssignmentScheduleRequestName = "fea7a502-9a96-4806-a26f-eee560e52045";
            RoleAssignmentScheduleRequestData data = new RoleAssignmentScheduleRequestData()
            {
                RoleDefinitionId = new ResourceIdentifier("/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f/providers/Microsoft.Authorization/roleDefinitions/c8d4ff99-41c3-41a8-9f60-21dfdad59608"),
                PrincipalId = Guid.Parse("a3bb8764-cb92-4276-9d2a-ca1e895e55ea"),
                RequestType = RoleManagementScheduleRequestType.SelfActivate,
                LinkedRoleEligibilityScheduleId = new ResourceIdentifier("b1477448-2cc6-4ceb-93b4-54a202a89413"),
                Condition = "@Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'",
                ConditionVersion = "1.0",
                StartOn = DateTimeOffset.Parse("2020-09-09T21:35:27.91Z"),
                ExpirationType = RoleManagementScheduleExpirationType.AfterDuration,
                EndOn = null,
                Duration = XmlConvert.ToTimeSpan("PT8H"),
            };
            ArmOperation<RoleAssignmentScheduleRequestResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, roleAssignmentScheduleRequestName, data);
            RoleAssignmentScheduleRequestResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentScheduleRequestData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetRoleAssignmentScheduleRequestByName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRoleAssignmentScheduleRequestByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleAssignmentScheduleRequestByName.json
            // this example is just showing the usage of "RoleAssignmentScheduleRequests_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleAssignmentScheduleRequestResource
            string scope = "providers/Microsoft.Subscription/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleAssignmentScheduleRequestCollection collection = client.GetRoleAssignmentScheduleRequests(scopeId);

            // invoke the operation
            string roleAssignmentScheduleRequestName = "fea7a502-9a96-4806-a26f-eee560e52045";
            RoleAssignmentScheduleRequestResource result = await collection.GetAsync(roleAssignmentScheduleRequestName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentScheduleRequestData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetRoleAssignmentScheduleRequestByName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRoleAssignmentScheduleRequestByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleAssignmentScheduleRequestByName.json
            // this example is just showing the usage of "RoleAssignmentScheduleRequests_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleAssignmentScheduleRequestResource
            string scope = "providers/Microsoft.Subscription/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleAssignmentScheduleRequestCollection collection = client.GetRoleAssignmentScheduleRequests(scopeId);

            // invoke the operation
            string roleAssignmentScheduleRequestName = "fea7a502-9a96-4806-a26f-eee560e52045";
            bool result = await collection.ExistsAsync(roleAssignmentScheduleRequestName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetRoleAssignmentScheduleRequestByName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRoleAssignmentScheduleRequestByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleAssignmentScheduleRequestByName.json
            // this example is just showing the usage of "RoleAssignmentScheduleRequests_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleAssignmentScheduleRequestResource
            string scope = "providers/Microsoft.Subscription/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleAssignmentScheduleRequestCollection collection = client.GetRoleAssignmentScheduleRequests(scopeId);

            // invoke the operation
            string roleAssignmentScheduleRequestName = "fea7a502-9a96-4806-a26f-eee560e52045";
            NullableResponse<RoleAssignmentScheduleRequestResource> response = await collection.GetIfExistsAsync(roleAssignmentScheduleRequestName);
            RoleAssignmentScheduleRequestResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoleAssignmentScheduleRequestData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // GetRoleAssignmentScheduleRequestByScope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetRoleAssignmentScheduleRequestByScope()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleAssignmentScheduleRequestByScope.json
            // this example is just showing the usage of "RoleAssignmentScheduleRequests_ListForScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleAssignmentScheduleRequestResource
            string scope = "providers/Microsoft.Subscription/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleAssignmentScheduleRequestCollection collection = client.GetRoleAssignmentScheduleRequests(scopeId);

            // invoke the operation and iterate over the result
            string filter = "assignedTo('A3BB8764-CB92-4276-9D2A-CA1E895E55EA')";
            await foreach (RoleAssignmentScheduleRequestResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoleAssignmentScheduleRequestData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
