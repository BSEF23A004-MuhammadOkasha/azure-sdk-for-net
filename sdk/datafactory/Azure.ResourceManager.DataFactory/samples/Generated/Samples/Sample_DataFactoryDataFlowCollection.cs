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
using Azure.ResourceManager.DataFactory;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory.Samples
{
    public partial class Sample_DataFactoryDataFlowCollection
    {
        // DataFlows_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DataFlowsCreate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/DataFlows_Create.json
            // this example is just showing the usage of "DataFlows_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryDataFlowResource
            DataFactoryDataFlowCollection collection = dataFactory.GetDataFactoryDataFlows();

            // invoke the operation
            string dataFlowName = "exampleDataFlow";
            DataFactoryDataFlowData data = new DataFactoryDataFlowData(new DataFactoryMappingDataFlowProperties()
            {
                Sources =
{
new DataFlowSource("USDCurrency")
{
Dataset = new DatasetReference(DatasetReferenceType.DatasetReference,"CurrencyDatasetUSD"),
},new DataFlowSource("CADSource")
{
Dataset = new DatasetReference(DatasetReferenceType.DatasetReference,"CurrencyDatasetCAD"),
}
},
                Sinks =
{
new DataFlowSink("USDSink")
{
Dataset = new DatasetReference(DatasetReferenceType.DatasetReference,"USDOutput"),
},new DataFlowSink("CADSink")
{
Dataset = new DatasetReference(DatasetReferenceType.DatasetReference,"CADOutput"),
}
},
                ScriptLines =
{
"source(output(","PreviousConversionRate as double,","Country as string,","DateTime1 as string,","CurrentConversionRate as double","),","allowSchemaDrift: false,","validateSchema: false) ~> USDCurrency","source(output(","PreviousConversionRate as double,","Country as string,","DateTime1 as string,","CurrentConversionRate as double","),","allowSchemaDrift: true,","validateSchema: false) ~> CADSource","USDCurrency, CADSource union(byName: true)~> Union","Union derive(NewCurrencyRate = round(CurrentConversionRate*1.25)) ~> NewCurrencyColumn","NewCurrencyColumn split(Country == 'USD',","Country == 'CAD',disjoint: false) ~> ConditionalSplit1@(USD, CAD)","ConditionalSplit1@USD sink(saveMode:'overwrite' ) ~> USDSink","ConditionalSplit1@CAD sink(saveMode:'overwrite' ) ~> CADSink"
},
                Description = "Sample demo data flow to convert currencies showing usage of union, derive and conditional split transformation.",
            });
            ArmOperation<DataFactoryDataFlowResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataFlowName, data);
            DataFactoryDataFlowResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryDataFlowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataFlows_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DataFlowsUpdate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/DataFlows_Update.json
            // this example is just showing the usage of "DataFlows_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryDataFlowResource
            DataFactoryDataFlowCollection collection = dataFactory.GetDataFactoryDataFlows();

            // invoke the operation
            string dataFlowName = "exampleDataFlow";
            DataFactoryDataFlowData data = new DataFactoryDataFlowData(new DataFactoryMappingDataFlowProperties()
            {
                Sources =
{
new DataFlowSource("USDCurrency")
{
Dataset = new DatasetReference(DatasetReferenceType.DatasetReference,"CurrencyDatasetUSD"),
},new DataFlowSource("CADSource")
{
Dataset = new DatasetReference(DatasetReferenceType.DatasetReference,"CurrencyDatasetCAD"),
}
},
                Sinks =
{
new DataFlowSink("USDSink")
{
Dataset = new DatasetReference(DatasetReferenceType.DatasetReference,"USDOutput"),
},new DataFlowSink("CADSink")
{
Dataset = new DatasetReference(DatasetReferenceType.DatasetReference,"CADOutput"),
}
},
                ScriptLines =
{
"source(output(","PreviousConversionRate as double,","Country as string,","DateTime1 as string,","CurrentConversionRate as double","),","allowSchemaDrift: false,","validateSchema: false) ~> USDCurrency","source(output(","PreviousConversionRate as double,","Country as string,","DateTime1 as string,","CurrentConversionRate as double","),","allowSchemaDrift: true,","validateSchema: false) ~> CADSource","USDCurrency, CADSource union(byName: true)~> Union","Union derive(NewCurrencyRate = round(CurrentConversionRate*1.25)) ~> NewCurrencyColumn","NewCurrencyColumn split(Country == 'USD',","Country == 'CAD',disjoint: false) ~> ConditionalSplit1@(USD, CAD)","ConditionalSplit1@USD sink(saveMode:'overwrite' ) ~> USDSink","ConditionalSplit1@CAD sink(saveMode:'overwrite' ) ~> CADSink"
},
                Description = "Sample demo data flow to convert currencies showing usage of union, derive and conditional split transformation.",
            });
            ArmOperation<DataFactoryDataFlowResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataFlowName, data);
            DataFactoryDataFlowResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryDataFlowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataFlows_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DataFlowsGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/DataFlows_Get.json
            // this example is just showing the usage of "DataFlows_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryDataFlowResource
            DataFactoryDataFlowCollection collection = dataFactory.GetDataFactoryDataFlows();

            // invoke the operation
            string dataFlowName = "exampleDataFlow";
            DataFactoryDataFlowResource result = await collection.GetAsync(dataFlowName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryDataFlowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataFlows_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_DataFlowsGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/DataFlows_Get.json
            // this example is just showing the usage of "DataFlows_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryDataFlowResource
            DataFactoryDataFlowCollection collection = dataFactory.GetDataFactoryDataFlows();

            // invoke the operation
            string dataFlowName = "exampleDataFlow";
            bool result = await collection.ExistsAsync(dataFlowName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // DataFlows_ListByFactory
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DataFlowsListByFactory()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/DataFlows_ListByFactory.json
            // this example is just showing the usage of "DataFlows_ListByFactory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryDataFlowResource
            DataFactoryDataFlowCollection collection = dataFactory.GetDataFactoryDataFlows();

            // invoke the operation and iterate over the result
            await foreach (DataFactoryDataFlowResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryDataFlowData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
