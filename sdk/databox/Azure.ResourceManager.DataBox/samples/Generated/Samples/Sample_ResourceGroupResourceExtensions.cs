// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataBox.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.DataBox.Samples
{
    public partial class Sample_ResourceGroupResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAvailableSkus_AvailableSkusPost()
        {
            // Generated from example definition: specification/databox/resource-manager/Microsoft.DataBox/stable/2022-12-01/examples/AvailableSkusPost.json
            // this example is just showing the usage of "Service_ListAvailableSkusByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "YourSubscriptionId";
            string resourceGroupName = "YourResourceGroupName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("westus");
            AvailableSkusContent content = new AvailableSkusContent(DataBoxJobTransferType.ImportToAzure, "XX", new AzureLocation("westus"));
            await foreach (DataBoxSkuInformation item in resourceGroupResource.GetAvailableSkusAsync(location, content))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ValidateInputs_ValidateInputsByResourceGroup()
        {
            // Generated from example definition: specification/databox/resource-manager/Microsoft.DataBox/stable/2022-12-01/examples/ValidateInputsByResourceGroup.json
            // this example is just showing the usage of "Service_ValidateInputsByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "YourSubscriptionId";
            string resourceGroupName = "YourResourceGroupName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            DataBoxValidationContent content = new CreateJobValidationContent(new DataBoxValidationInputContent[]
            {
new DataTransferDetailsValidationContent(DataBoxSkuName.DataBox,DataBoxJobTransferType.ImportToAzure)
{
DataImportDetails =
{
new DataImportDetails(new DataBoxStorageAccountDetails(new ResourceIdentifier("/subscriptions/YourSubscriptionId/resourcegroups/YourResourceGroupName/providers/Microsoft.Storage/storageAccounts/YourStorageAccountName")))
},
},new DataBoxValidateAddressContent(new DataBoxShippingAddress("XXXX XXXX","XX","00000")
{
StreetAddress2 = "XXXX XXXX",
City = "XXXX XXXX",
StateOrProvince = "XX",
CompanyName = "XXXX XXXX",
AddressType = DataBoxShippingAddressType.Commercial,
},DataBoxSkuName.DataBox)
{
TransportPreferences = new TransportPreferences(TransportShipmentType.MicrosoftManaged),
},new SubscriptionIsAllowedToCreateJobValidationContent(),new SkuAvailabilityValidationContent(DataBoxSkuName.DataBox,DataBoxJobTransferType.ImportToAzure,"XX",new AzureLocation("westus")),new CreateOrderLimitForSubscriptionValidationContent(DataBoxSkuName.DataBox),new PreferencesValidationContent(DataBoxSkuName.DataBox)
{
Preference = new DataBoxOrderPreferences()
{
TransportPreferences = new TransportPreferences(TransportShipmentType.MicrosoftManaged),
},
}
            });
            DataBoxValidationResult result = await resourceGroupResource.ValidateInputsAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetRegionConfiguration_RegionConfigurationByResourceGroup()
        {
            // Generated from example definition: specification/databox/resource-manager/Microsoft.DataBox/stable/2022-12-01/examples/RegionConfigurationByResourceGroup.json
            // this example is just showing the usage of "Service_RegionConfigurationByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "YourSubscriptionId";
            string resourceGroupName = "YourResourceGroupName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            RegionConfigurationContent content = new RegionConfigurationContent()
            {
                ScheduleAvailabilityRequest = new DataBoxScheduleAvailabilityContent(new AzureLocation("westus")),
            };
            RegionConfigurationResult result = await resourceGroupResource.GetRegionConfigurationAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
