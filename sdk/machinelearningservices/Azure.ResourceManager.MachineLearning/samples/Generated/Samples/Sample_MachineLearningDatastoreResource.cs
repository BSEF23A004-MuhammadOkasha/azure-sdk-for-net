// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningDatastoreResource
    {
        // Delete datastore.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteDatastore()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Datastore/delete.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Datastore/delete.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "Datastores_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDatastoreResource created on azure
            // for more information of creating MachineLearningDatastoreResource, please refer to the document of MachineLearningDatastoreResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDatastoreResourceId = MachineLearningDatastoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDatastoreResource machineLearningDatastore = client.GetMachineLearningDatastoreResource(machineLearningDatastoreResourceId);

            // invoke the operation
            await machineLearningDatastore.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get datastore.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDatastore()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Datastore/get.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Datastore/get.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "Datastores_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDatastoreResource created on azure
            // for more information of creating MachineLearningDatastoreResource, please refer to the document of MachineLearningDatastoreResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDatastoreResourceId = MachineLearningDatastoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDatastoreResource machineLearningDatastore = client.GetMachineLearningDatastoreResource(machineLearningDatastoreResourceId);

            // invoke the operation
            MachineLearningDatastoreResource result = await machineLearningDatastore.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDatastoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate datastore (Azure Data Lake Gen1 w/ ServicePrincipal).
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateDatastoreAzureDataLakeGen1WServicePrincipal()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Datastore/AzureDataLakeGen1WServicePrincipal/createOrUpdate.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Datastore/AzureDataLakeGen1WServicePrincipal/createOrUpdate.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "Datastores_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDatastoreResource created on azure
            // for more information of creating MachineLearningDatastoreResource, please refer to the document of MachineLearningDatastoreResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDatastoreResourceId = MachineLearningDatastoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDatastoreResource machineLearningDatastore = client.GetMachineLearningDatastoreResource(machineLearningDatastoreResourceId);

            // invoke the operation
            MachineLearningDatastoreData data = new MachineLearningDatastoreData(new MachineLearningAzureDataLakeGen1Datastore(new MachineLearningServicePrincipalDatastoreCredentials(Guid.Parse("00000000-1111-2222-3333-444444444444"), Guid.Parse("00000000-1111-2222-3333-444444444444"), new MachineLearningServicePrincipalDatastoreSecrets()
            {
                ClientSecret = "string",
            })
            {
                AuthorityUri = new Uri("string"),
                ResourceUri = new Uri("string"),
            }, "string")
            {
                Description = "string",
                Tags =
{
["string"] = "string",
},
                Properties =
{
},
            });
            bool? skipValidation = false;
            ArmOperation<MachineLearningDatastoreResource> lro = await machineLearningDatastore.UpdateAsync(WaitUntil.Completed, data, skipValidation: skipValidation);
            MachineLearningDatastoreResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDatastoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate datastore (Azure Data Lake Gen2 w/ Service Principal).
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateDatastoreAzureDataLakeGen2WServicePrincipal()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Datastore/AzureDataLakeGen2WServicePrincipal/createOrUpdate.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Datastore/AzureDataLakeGen2WServicePrincipal/createOrUpdate.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "Datastores_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDatastoreResource created on azure
            // for more information of creating MachineLearningDatastoreResource, please refer to the document of MachineLearningDatastoreResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDatastoreResourceId = MachineLearningDatastoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDatastoreResource machineLearningDatastore = client.GetMachineLearningDatastoreResource(machineLearningDatastoreResourceId);

            // invoke the operation
            MachineLearningDatastoreData data = new MachineLearningDatastoreData(new MachineLearningAzureDataLakeGen2Datastore(new MachineLearningServicePrincipalDatastoreCredentials(Guid.Parse("00000000-1111-2222-3333-444444444444"), Guid.Parse("00000000-1111-2222-3333-444444444444"), new MachineLearningServicePrincipalDatastoreSecrets()
            {
                ClientSecret = "string",
            })
            {
                AuthorityUri = new Uri("string"),
                ResourceUri = new Uri("string"),
            }, "string", "string")
            {
                Endpoint = "string",
                Protocol = "string",
                Description = "string",
                Tags =
{
["string"] = "string",
},
                Properties =
{
},
            });
            bool? skipValidation = false;
            ArmOperation<MachineLearningDatastoreResource> lro = await machineLearningDatastore.UpdateAsync(WaitUntil.Completed, data, skipValidation: skipValidation);
            MachineLearningDatastoreResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDatastoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate datastore (Azure File store w/ AccountKey).
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateDatastoreAzureFileStoreWAccountKey()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Datastore/AzureFileWAccountKey/createOrUpdate.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Datastore/AzureFileWAccountKey/createOrUpdate.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "Datastores_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDatastoreResource created on azure
            // for more information of creating MachineLearningDatastoreResource, please refer to the document of MachineLearningDatastoreResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDatastoreResourceId = MachineLearningDatastoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDatastoreResource machineLearningDatastore = client.GetMachineLearningDatastoreResource(machineLearningDatastoreResourceId);

            // invoke the operation
            MachineLearningDatastoreData data = new MachineLearningDatastoreData(new MachineLearningAzureFileDatastore(new MachineLearningAccountKeyDatastoreCredentials(new MachineLearningAccountKeyDatastoreSecrets()
            {
                Key = "string",
            }), "string", "string")
            {
                Endpoint = "string",
                Protocol = "string",
                Description = "string",
                Tags =
{
["string"] = "string",
},
                Properties =
{
},
            });
            bool? skipValidation = false;
            ArmOperation<MachineLearningDatastoreResource> lro = await machineLearningDatastore.UpdateAsync(WaitUntil.Completed, data, skipValidation: skipValidation);
            MachineLearningDatastoreResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDatastoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate datastore (AzureBlob w/ AccountKey).
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateDatastoreAzureBlobWAccountKey()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Datastore/AzureBlobWAccountKey/createOrUpdate.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Datastore/AzureBlobWAccountKey/createOrUpdate.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "Datastores_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDatastoreResource created on azure
            // for more information of creating MachineLearningDatastoreResource, please refer to the document of MachineLearningDatastoreResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDatastoreResourceId = MachineLearningDatastoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDatastoreResource machineLearningDatastore = client.GetMachineLearningDatastoreResource(machineLearningDatastoreResourceId);

            // invoke the operation
            MachineLearningDatastoreData data = new MachineLearningDatastoreData(new MachineLearningAzureBlobDatastore(new MachineLearningAccountKeyDatastoreCredentials(new MachineLearningAccountKeyDatastoreSecrets()
            {
                Key = "string",
            }))
            {
                AccountName = "string",
                ContainerName = "string",
                Endpoint = "core.windows.net",
                Protocol = "https",
                Description = "string",
                Tags =
{
["string"] = "string",
},
                Properties =
{
},
            });
            bool? skipValidation = false;
            ArmOperation<MachineLearningDatastoreResource> lro = await machineLearningDatastore.UpdateAsync(WaitUntil.Completed, data, skipValidation: skipValidation);
            MachineLearningDatastoreResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDatastoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get datastore secrets.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSecrets_GetDatastoreSecrets()
        {
<<<<<<< HEAD
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Datastore/listSecrets.json
=======
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Datastore/listSecrets.json
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            // this example is just showing the usage of "Datastores_ListSecrets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDatastoreResource created on azure
            // for more information of creating MachineLearningDatastoreResource, please refer to the document of MachineLearningDatastoreResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningDatastoreResourceId = MachineLearningDatastoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDatastoreResource machineLearningDatastore = client.GetMachineLearningDatastoreResource(machineLearningDatastoreResourceId);

            // invoke the operation
            SecretExpiry body = new SecretExpiry()
            {
                ExpirableSecret = false,
                ExpireAfterHours = 1,
            };
            MachineLearningDatastoreSecrets result = await machineLearningDatastore.GetSecretsAsync(body: body);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
