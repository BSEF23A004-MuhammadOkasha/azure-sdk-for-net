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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_GalleryImageVersionResource
    {
        // Update a simple Gallery Image Version (Managed Image as source).
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateASimpleGalleryImageVersionManagedImageAsSource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/GalleryImageVersion_Update.json
            // this example is just showing the usage of "GalleryImageVersions_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryImageVersionResource created on azure
            // for more information of creating GalleryImageVersionResource, please refer to the document of GalleryImageVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            string galleryImageVersionName = "1.0.0";
            ResourceIdentifier galleryImageVersionResourceId = Compute.GalleryImageVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            Compute.GalleryImageVersionResource galleryImageVersion = client.GetGalleryImageVersionResource(galleryImageVersionResourceId);

            // invoke the operation
            Compute.Models.GalleryImageVersionPatch patch = new GalleryImageVersionPatch()
            {
                PublishingProfile = new GalleryImageVersionPublishingProfile()
                {
                    TargetRegions =
{
new TargetRegion("West US")
{
RegionalReplicaCount = 1,
},new TargetRegion("East US")
{
RegionalReplicaCount = 2,
StorageAccountType = ImageStorageAccountType.StandardZrs,
}
},
                },
                StorageProfile = new GalleryImageVersionStorageProfile()
                {
                    Source = new GalleryArtifactVersionSource()
                    {
                        Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/images/{imageName}"),
                    },
                },
            };
            ArmOperation<Compute.GalleryImageVersionResource> lro = await galleryImageVersion.UpdateAsync(WaitUntil.Completed, patch);
            Compute.GalleryImageVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryImageVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a simple Gallery Image Version without source id.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateASimpleGalleryImageVersionWithoutSourceId()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/GalleryImageVersion_Update_WithoutSourceId.json
            // this example is just showing the usage of "GalleryImageVersions_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryImageVersionResource created on azure
            // for more information of creating GalleryImageVersionResource, please refer to the document of GalleryImageVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            string galleryImageVersionName = "1.0.0";
            ResourceIdentifier galleryImageVersionResourceId = Compute.GalleryImageVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            Compute.GalleryImageVersionResource galleryImageVersion = client.GetGalleryImageVersionResource(galleryImageVersionResourceId);

            // invoke the operation
            Compute.Models.GalleryImageVersionPatch patch = new GalleryImageVersionPatch()
            {
                PublishingProfile = new GalleryImageVersionPublishingProfile()
                {
                    TargetRegions =
{
new TargetRegion("West US")
{
RegionalReplicaCount = 1,
},new TargetRegion("East US")
{
RegionalReplicaCount = 2,
StorageAccountType = ImageStorageAccountType.StandardZrs,
}
},
                },
                StorageProfile = new GalleryImageVersionStorageProfile(),
            };
            ArmOperation<Compute.GalleryImageVersionResource> lro = await galleryImageVersion.UpdateAsync(WaitUntil.Completed, patch);
            Compute.GalleryImageVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryImageVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a gallery image version with replication status.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAGalleryImageVersionWithReplicationStatus()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/GalleryImageVersion_Get_WithReplicationStatus.json
            // this example is just showing the usage of "GalleryImageVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryImageVersionResource created on azure
            // for more information of creating GalleryImageVersionResource, please refer to the document of GalleryImageVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            string galleryImageVersionName = "1.0.0";
            ResourceIdentifier galleryImageVersionResourceId = Compute.GalleryImageVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            Compute.GalleryImageVersionResource galleryImageVersion = client.GetGalleryImageVersionResource(galleryImageVersionResourceId);

            // invoke the operation
            Compute.Models.ReplicationStatusType? expand = ReplicationStatusType.ReplicationStatus;
            Compute.GalleryImageVersionResource result = await galleryImageVersion.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryImageVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a gallery image version with snapshots as a source.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAGalleryImageVersionWithSnapshotsAsASource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/GalleryImageVersion_Get_WithSnapshotsAsSource.json
            // this example is just showing the usage of "GalleryImageVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryImageVersionResource created on azure
            // for more information of creating GalleryImageVersionResource, please refer to the document of GalleryImageVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            string galleryImageVersionName = "1.0.0";
            ResourceIdentifier galleryImageVersionResourceId = Compute.GalleryImageVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            Compute.GalleryImageVersionResource galleryImageVersion = client.GetGalleryImageVersionResource(galleryImageVersionResourceId);

            // invoke the operation
            Compute.GalleryImageVersionResource result = await galleryImageVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryImageVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a gallery image version with vhd as a source.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAGalleryImageVersionWithVhdAsASource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/GalleryImageVersion_Get_WithVhdAsSource.json
            // this example is just showing the usage of "GalleryImageVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryImageVersionResource created on azure
            // for more information of creating GalleryImageVersionResource, please refer to the document of GalleryImageVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            string galleryImageVersionName = "1.0.0";
            ResourceIdentifier galleryImageVersionResourceId = Compute.GalleryImageVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            Compute.GalleryImageVersionResource galleryImageVersion = client.GetGalleryImageVersionResource(galleryImageVersionResourceId);

            // invoke the operation
            Compute.GalleryImageVersionResource result = await galleryImageVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryImageVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a gallery image version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAGalleryImageVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/GalleryImageVersion_Get.json
            // this example is just showing the usage of "GalleryImageVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryImageVersionResource created on azure
            // for more information of creating GalleryImageVersionResource, please refer to the document of GalleryImageVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            string galleryImageVersionName = "1.0.0";
            ResourceIdentifier galleryImageVersionResourceId = Compute.GalleryImageVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            Compute.GalleryImageVersionResource galleryImageVersion = client.GetGalleryImageVersionResource(galleryImageVersionResourceId);

            // invoke the operation
            Compute.GalleryImageVersionResource result = await galleryImageVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryImageVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a gallery image version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAGalleryImageVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/GalleryImageVersion_Delete.json
            // this example is just showing the usage of "GalleryImageVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryImageVersionResource created on azure
            // for more information of creating GalleryImageVersionResource, please refer to the document of GalleryImageVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            string galleryImageVersionName = "1.0.0";
            ResourceIdentifier galleryImageVersionResourceId = Compute.GalleryImageVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            Compute.GalleryImageVersionResource galleryImageVersion = client.GetGalleryImageVersionResource(galleryImageVersionResourceId);

            // invoke the operation
            await galleryImageVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
