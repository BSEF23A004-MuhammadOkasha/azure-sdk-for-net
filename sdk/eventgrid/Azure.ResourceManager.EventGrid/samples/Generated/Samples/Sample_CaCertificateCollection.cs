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
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_CaCertificateCollection
    {
        // CaCertificates_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CaCertificatesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/CaCertificates_Get.json
            // this example is just showing the usage of "CaCertificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this CaCertificateResource
            CaCertificateCollection collection = eventGridNamespace.GetCaCertificates();

            // invoke the operation
            string caCertificateName = "exampleCACertificateName1";
            CaCertificateResource result = await collection.GetAsync(caCertificateName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CaCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CaCertificates_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_CaCertificatesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/CaCertificates_Get.json
            // this example is just showing the usage of "CaCertificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this CaCertificateResource
            CaCertificateCollection collection = eventGridNamespace.GetCaCertificates();

            // invoke the operation
            string caCertificateName = "exampleCACertificateName1";
            bool result = await collection.ExistsAsync(caCertificateName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // CaCertificates_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_CaCertificatesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/CaCertificates_Get.json
            // this example is just showing the usage of "CaCertificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this CaCertificateResource
            CaCertificateCollection collection = eventGridNamespace.GetCaCertificates();

            // invoke the operation
            string caCertificateName = "exampleCACertificateName1";
            NullableResponse<CaCertificateResource> response = await collection.GetIfExistsAsync(caCertificateName);
            CaCertificateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CaCertificateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CaCertificates_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CaCertificatesCreateOrUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/CaCertificates_CreateOrUpdate.json
            // this example is just showing the usage of "CaCertificates_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this CaCertificateResource
            CaCertificateCollection collection = eventGridNamespace.GetCaCertificates();

            // invoke the operation
            string caCertificateName = "exampleCACertificateName1";
            CaCertificateData data = new CaCertificateData()
            {
                Description = "This is a test certificate",
                EncodedCertificate = "base64EncodePemFormattedCertificateString",
            };
            ArmOperation<CaCertificateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, caCertificateName, data);
            CaCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CaCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CaCertificates_ListByNamespace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_CaCertificatesListByNamespace()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/CaCertificates_ListByNamespace.json
            // this example is just showing the usage of "CaCertificates_ListByNamespace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "namespace123";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this CaCertificateResource
            CaCertificateCollection collection = eventGridNamespace.GetCaCertificates();

            // invoke the operation and iterate over the result
            await foreach (CaCertificateResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CaCertificateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
