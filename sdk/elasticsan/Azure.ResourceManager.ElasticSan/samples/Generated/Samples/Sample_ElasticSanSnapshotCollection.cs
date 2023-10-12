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
using Azure.ResourceManager.ElasticSan;
using Azure.ResourceManager.ElasticSan.Models;

namespace Azure.ResourceManager.ElasticSan.Samples
{
    public partial class Sample_ElasticSanSnapshotCollection
    {
        // VolumeSnapshots_ListByVolumeGroup_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VolumeSnapshotsListByVolumeGroupMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_ListByVolumeGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_ListByVolumeGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // get the collection of this ElasticSanSnapshotResource
            ElasticSanSnapshotCollection collection = elasticSanVolumeGroup.GetElasticSanSnapshots();

            // invoke the operation and iterate over the result
            string filter = "volumeName eq <volume name>";
            await foreach (ElasticSanSnapshotResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticSanSnapshotData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VolumeSnapshots_ListByVolumeGroup_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VolumeSnapshotsListByVolumeGroupMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_ListByVolumeGroup_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_ListByVolumeGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // get the collection of this ElasticSanSnapshotResource
            ElasticSanSnapshotCollection collection = elasticSanVolumeGroup.GetElasticSanSnapshots();

            // invoke the operation and iterate over the result
            await foreach (ElasticSanSnapshotResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticSanSnapshotData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VolumeSnapshots_Create_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VolumeSnapshotsCreateMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // get the collection of this ElasticSanSnapshotResource
            ElasticSanSnapshotCollection collection = elasticSanVolumeGroup.GetElasticSanSnapshots();

            // invoke the operation
            string snapshotName = "snapshotname";
            ElasticSanSnapshotData data = new ElasticSanSnapshotData(new SnapshotCreationData("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/volumes/{volumeName}"));
            ArmOperation<ElasticSanSnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            ElasticSanSnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeSnapshots_Create_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VolumeSnapshotsCreateMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Create_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // get the collection of this ElasticSanSnapshotResource
            ElasticSanSnapshotCollection collection = elasticSanVolumeGroup.GetElasticSanSnapshots();

            // invoke the operation
            string snapshotName = "snapshotname";
            ElasticSanSnapshotData data = new ElasticSanSnapshotData(new SnapshotCreationData("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/volumes/{volumeName}"));
            ArmOperation<ElasticSanSnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            ElasticSanSnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeSnapshots_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VolumeSnapshotsGetMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // get the collection of this ElasticSanSnapshotResource
            ElasticSanSnapshotCollection collection = elasticSanVolumeGroup.GetElasticSanSnapshots();

            // invoke the operation
            string snapshotName = "snapshotname";
            ElasticSanSnapshotResource result = await collection.GetAsync(snapshotName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeSnapshots_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_VolumeSnapshotsGetMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // get the collection of this ElasticSanSnapshotResource
            ElasticSanSnapshotCollection collection = elasticSanVolumeGroup.GetElasticSanSnapshots();

            // invoke the operation
            string snapshotName = "snapshotname";
            bool result = await collection.ExistsAsync(snapshotName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VolumeSnapshots_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_VolumeSnapshotsGetMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // get the collection of this ElasticSanSnapshotResource
            ElasticSanSnapshotCollection collection = elasticSanVolumeGroup.GetElasticSanSnapshots();

            // invoke the operation
            string snapshotName = "snapshotname";
            NullableResponse<ElasticSanSnapshotResource> response = await collection.GetIfExistsAsync(snapshotName);
            ElasticSanSnapshotResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticSanSnapshotData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // VolumeSnapshots_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VolumeSnapshotsGetMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // get the collection of this ElasticSanSnapshotResource
            ElasticSanSnapshotCollection collection = elasticSanVolumeGroup.GetElasticSanSnapshots();

            // invoke the operation
            string snapshotName = "snapshotname";
            ElasticSanSnapshotResource result = await collection.GetAsync(snapshotName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeSnapshots_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_VolumeSnapshotsGetMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // get the collection of this ElasticSanSnapshotResource
            ElasticSanSnapshotCollection collection = elasticSanVolumeGroup.GetElasticSanSnapshots();

            // invoke the operation
            string snapshotName = "snapshotname";
            bool result = await collection.ExistsAsync(snapshotName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VolumeSnapshots_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_VolumeSnapshotsGetMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/VolumeSnapshots_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeSnapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // get the collection of this ElasticSanSnapshotResource
            ElasticSanSnapshotCollection collection = elasticSanVolumeGroup.GetElasticSanSnapshots();

            // invoke the operation
            string snapshotName = "snapshotname";
            NullableResponse<ElasticSanSnapshotResource> response = await collection.GetIfExistsAsync(snapshotName);
            ElasticSanSnapshotResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticSanSnapshotData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
