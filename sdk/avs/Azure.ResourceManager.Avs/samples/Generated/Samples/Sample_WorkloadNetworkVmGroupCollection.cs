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
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkVmGroupCollection
    {
        // WorkloadNetworks_ListVMGroups
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WorkloadNetworksListVMGroups()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/WorkloadNetworks_ListVMGroups.json
            // this example is just showing the usage of "WorkloadNetworks_ListVMGroups" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this WorkloadNetworkVmGroupResource
            WorkloadNetworkVmGroupCollection collection = avsPrivateCloud.GetWorkloadNetworkVmGroups();

            // invoke the operation and iterate over the result
            await foreach (WorkloadNetworkVmGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadNetworkVmGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WorkloadNetworks_GetVMGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkloadNetworksGetVMGroup()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/WorkloadNetworks_GetVMGroups.json
            // this example is just showing the usage of "WorkloadNetworks_GetVMGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this WorkloadNetworkVmGroupResource
            WorkloadNetworkVmGroupCollection collection = avsPrivateCloud.GetWorkloadNetworkVmGroups();

            // invoke the operation
            string vmGroupId = "vmGroup1";
            WorkloadNetworkVmGroupResource result = await collection.GetAsync(vmGroupId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkVmGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkloadNetworks_GetVMGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_WorkloadNetworksGetVMGroup()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/WorkloadNetworks_GetVMGroups.json
            // this example is just showing the usage of "WorkloadNetworks_GetVMGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this WorkloadNetworkVmGroupResource
            WorkloadNetworkVmGroupCollection collection = avsPrivateCloud.GetWorkloadNetworkVmGroups();

            // invoke the operation
            string vmGroupId = "vmGroup1";
            bool result = await collection.ExistsAsync(vmGroupId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // WorkloadNetworks_GetVMGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_WorkloadNetworksGetVMGroup()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/WorkloadNetworks_GetVMGroups.json
            // this example is just showing the usage of "WorkloadNetworks_GetVMGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this WorkloadNetworkVmGroupResource
            WorkloadNetworkVmGroupCollection collection = avsPrivateCloud.GetWorkloadNetworkVmGroups();

            // invoke the operation
            string vmGroupId = "vmGroup1";
            NullableResponse<WorkloadNetworkVmGroupResource> response = await collection.GetIfExistsAsync(vmGroupId);
            WorkloadNetworkVmGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadNetworkVmGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // WorkloadNetworks_CreateVMGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_WorkloadNetworksCreateVMGroup()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/WorkloadNetworks_CreateVMGroups.json
            // this example is just showing the usage of "WorkloadNetworks_CreateVMGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this WorkloadNetworkVmGroupResource
            WorkloadNetworkVmGroupCollection collection = avsPrivateCloud.GetWorkloadNetworkVmGroups();

            // invoke the operation
            string vmGroupId = "vmGroup1";
            WorkloadNetworkVmGroupData data = new WorkloadNetworkVmGroupData()
            {
                DisplayName = "vmGroup1",
                Members =
{
"564d43da-fefc-2a3b-1d92-42855622fa50"
},
                Revision = 1,
            };
            ArmOperation<WorkloadNetworkVmGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmGroupId, data);
            WorkloadNetworkVmGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkVmGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
