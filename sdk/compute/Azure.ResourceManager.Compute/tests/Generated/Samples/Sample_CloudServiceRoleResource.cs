// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_CloudServiceRoleResource
    {
        // Get Cloud Service Role
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCloudServiceRole()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-04-04/CloudServiceRP/examples/CloudServiceRole_Get.json
            // this example is just showing the usage of "CloudServiceRoles_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this CloudServiceRoleResource created on azure
            // for more information of creating CloudServiceRoleResource, please refer to the document of CloudServiceRoleResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            string cloudServiceName = "{cs-name}";
            string roleName = "{role-name}";
            ResourceIdentifier cloudServiceRoleResourceId = Compute.CloudServiceRoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudServiceName, roleName);
            Compute.CloudServiceRoleResource cloudServiceRole = client.GetCloudServiceRoleResource(cloudServiceRoleResourceId);

            // invoke the operation
            Compute.CloudServiceRoleResource result = await cloudServiceRole.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.CloudServiceRoleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
