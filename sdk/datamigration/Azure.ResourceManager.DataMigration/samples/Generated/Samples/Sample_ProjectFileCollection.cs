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
using Azure.ResourceManager.DataMigration;
using Azure.ResourceManager.DataMigration.Models;

namespace Azure.ResourceManager.DataMigration.Samples
{
    public partial class Sample_ProjectFileCollection
    {
        // Files_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_FilesList()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Files_List.json
            // this example is just showing the usage of "Files_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string projectName = "DmsSdkProject";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ProjectFileResource
            ProjectFileCollection collection = project.GetProjectFiles();

            // invoke the operation and iterate over the result
            await foreach (ProjectFileResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProjectFileData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Files_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FilesList()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Files_Get.json
            // this example is just showing the usage of "Files_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string projectName = "DmsSdkProject";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ProjectFileResource
            ProjectFileCollection collection = project.GetProjectFiles();

            // invoke the operation
            string fileName = "x114d023d8";
            ProjectFileResource result = await collection.GetAsync(fileName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProjectFileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Files_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_FilesList()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Files_Get.json
            // this example is just showing the usage of "Files_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string projectName = "DmsSdkProject";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ProjectFileResource
            ProjectFileCollection collection = project.GetProjectFiles();

            // invoke the operation
            string fileName = "x114d023d8";
            bool result = await collection.ExistsAsync(fileName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Files_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_FilesList()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Files_Get.json
            // this example is just showing the usage of "Files_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string projectName = "DmsSdkProject";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ProjectFileResource
            ProjectFileCollection collection = project.GetProjectFiles();

            // invoke the operation
            string fileName = "x114d023d8";
            NullableResponse<ProjectFileResource> response = await collection.GetIfExistsAsync(fileName);
            ProjectFileResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProjectFileData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Files_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FilesCreateOrUpdate()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Files_CreateOrUpdate.json
            // this example is just showing the usage of "Files_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string projectName = "DmsSdkProject";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ProjectFileResource
            ProjectFileCollection collection = project.GetProjectFiles();

            // invoke the operation
            string fileName = "x114d023d8";
            ProjectFileData data = new ProjectFileData()
            {
                Properties = new ProjectFileProperties()
                {
                    FilePath = "DmsSdkFilePath/DmsSdkFile.sql",
                },
            };
            ArmOperation<ProjectFileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fileName, data);
            ProjectFileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProjectFileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
