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
using Azure.ResourceManager.Storage;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage.Samples
{
    public partial class Sample_FileShareCollection
    {
        // ListDeletedShares
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDeletedShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/DeletedFileSharesList.json
            // this example is just showing the usage of "FileShares_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9290";
            string accountName = "sto1590";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation and iterate over the result
            string expand = "deleted";
            await foreach (FileShareResource item in collection.GetAllAsync(expand: expand))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FileShareData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ListShareSnapshots
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListShareSnapshots()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileShareSnapshotsList.json
            // this example is just showing the usage of "FileShares_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9290";
            string accountName = "sto1590";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation and iterate over the result
            string expand = "snapshots";
            await foreach (FileShareResource item in collection.GetAllAsync(expand: expand))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FileShareData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ListShares
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileSharesList.json
            // this example is just showing the usage of "FileShares_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9290";
            string accountName = "sto1590";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation and iterate over the result
            await foreach (FileShareResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FileShareData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Create NFS Shares
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateNFSShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileSharesPut_NFS.json
            // this example is just showing the usage of "FileShares_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res346";
            string accountName = "sto666";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation
            string shareName = "share1235";
            FileShareData data = new FileShareData()
            {
                EnabledProtocol = FileShareEnabledProtocol.Nfs,
            };
            ArmOperation<FileShareResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, shareName, data);
            FileShareResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileShareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PutShares
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileSharesPut.json
            // this example is just showing the usage of "FileShares_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation
            string shareName = "share6185";
            FileShareData data = new FileShareData();
            ArmOperation<FileShareResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, shareName, data);
            FileShareResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileShareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PutShares with Access Tier
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutSharesWithAccessTier()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileSharesPut_AccessTier.json
            // this example is just showing the usage of "FileShares_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res346";
            string accountName = "sto666";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation
            string shareName = "share1235";
            FileShareData data = new FileShareData()
            {
                AccessTier = FileShareAccessTier.Hot,
            };
            ArmOperation<FileShareResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, shareName, data);
            FileShareResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileShareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetShareStats
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetShareStats()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileSharesGet_Stats.json
            // this example is just showing the usage of "FileShares_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9871";
            string accountName = "sto6217";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation
            string shareName = "share1634";
            string expand = "stats";
            FileShareResource result = await collection.GetAsync(shareName, expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileShareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetShareStats
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetShareStats()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileSharesGet_Stats.json
            // this example is just showing the usage of "FileShares_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9871";
            string accountName = "sto6217";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation
            string shareName = "share1634";
            string expand = "stats";
            bool result = await collection.ExistsAsync(shareName, expand: expand);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetShareStats
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetShareStats()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileSharesGet_Stats.json
            // this example is just showing the usage of "FileShares_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9871";
            string accountName = "sto6217";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation
            string shareName = "share1634";
            string expand = "stats";
            NullableResponse<FileShareResource> response = await collection.GetIfExistsAsync(shareName, expand: expand);
            FileShareResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FileShareData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // GetShares
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileSharesGet.json
            // this example is just showing the usage of "FileShares_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9871";
            string accountName = "sto6217";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation
            string shareName = "share1634";
            FileShareResource result = await collection.GetAsync(shareName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileShareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetShares
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileSharesGet.json
            // this example is just showing the usage of "FileShares_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9871";
            string accountName = "sto6217";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation
            string shareName = "share1634";
            bool result = await collection.ExistsAsync(shareName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetShares
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/FileSharesGet.json
            // this example is just showing the usage of "FileShares_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileServiceResource created on azure
            // for more information of creating FileServiceResource, please refer to the document of FileServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9871";
            string accountName = "sto6217";
            ResourceIdentifier fileServiceResourceId = FileServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            FileServiceResource fileService = client.GetFileServiceResource(fileServiceResourceId);

            // get the collection of this FileShareResource
            FileShareCollection collection = fileService.GetFileShares();

            // invoke the operation
            string shareName = "share1634";
            NullableResponse<FileShareResource> response = await collection.GetIfExistsAsync(shareName);
            FileShareResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FileShareData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
