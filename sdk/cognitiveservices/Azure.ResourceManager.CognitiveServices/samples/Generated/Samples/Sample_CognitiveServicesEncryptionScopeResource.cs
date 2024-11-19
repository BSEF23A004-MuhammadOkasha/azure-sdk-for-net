// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CognitiveServices.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_CognitiveServicesEncryptionScopeResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetEncryptionScope()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2024-10-01/examples/GetEncryptionScope.json
            // this example is just showing the usage of "EncryptionScopes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesEncryptionScopeResource created on azure
            // for more information of creating CognitiveServicesEncryptionScopeResource, please refer to the document of CognitiveServicesEncryptionScopeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string encryptionScopeName = "encryptionScopeName";
            ResourceIdentifier cognitiveServicesEncryptionScopeResourceId = CognitiveServicesEncryptionScopeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, encryptionScopeName);
            CognitiveServicesEncryptionScopeResource cognitiveServicesEncryptionScope = client.GetCognitiveServicesEncryptionScopeResource(cognitiveServicesEncryptionScopeResourceId);

            // invoke the operation
            CognitiveServicesEncryptionScopeResource result = await cognitiveServicesEncryptionScope.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CognitiveServicesEncryptionScopeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PutEncryptionScope()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2024-10-01/examples/PutEncryptionScope.json
            // this example is just showing the usage of "EncryptionScopes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesEncryptionScopeResource created on azure
            // for more information of creating CognitiveServicesEncryptionScopeResource, please refer to the document of CognitiveServicesEncryptionScopeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string encryptionScopeName = "encryptionScopeName";
            ResourceIdentifier cognitiveServicesEncryptionScopeResourceId = CognitiveServicesEncryptionScopeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, encryptionScopeName);
            CognitiveServicesEncryptionScopeResource cognitiveServicesEncryptionScope = client.GetCognitiveServicesEncryptionScopeResource(cognitiveServicesEncryptionScopeResourceId);

            // invoke the operation
            CognitiveServicesEncryptionScopeData data = new CognitiveServicesEncryptionScopeData()
            {
                Properties = new CognitiveServicesEncryptionScopeProperties()
                {
                    State = EncryptionScopeState.Enabled,
                    KeyVaultProperties = new CognitiveServicesKeyVaultProperties()
                    {
                        KeyName = "DevKeyWestUS2",
                        KeyVersion = "9f85549d7bf14ff4bf178c10d3bdca95",
                        KeyVaultUri = new Uri("https://devkvwestus2.vault.azure.net/"),
                        IdentityClientId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                    },
                    KeySource = ServiceAccountEncryptionKeySource.MicrosoftKeyVault,
                },
            };
            ArmOperation<CognitiveServicesEncryptionScopeResource> lro = await cognitiveServicesEncryptionScope.UpdateAsync(WaitUntil.Completed, data);
            CognitiveServicesEncryptionScopeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CognitiveServicesEncryptionScopeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteEncryptionScope()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2024-10-01/examples/DeleteEncryptionScope.json
            // this example is just showing the usage of "EncryptionScopes_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesEncryptionScopeResource created on azure
            // for more information of creating CognitiveServicesEncryptionScopeResource, please refer to the document of CognitiveServicesEncryptionScopeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string encryptionScopeName = "encryptionScopeName";
            ResourceIdentifier cognitiveServicesEncryptionScopeResourceId = CognitiveServicesEncryptionScopeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, encryptionScopeName);
            CognitiveServicesEncryptionScopeResource cognitiveServicesEncryptionScope = client.GetCognitiveServicesEncryptionScopeResource(cognitiveServicesEncryptionScopeResourceId);

            // invoke the operation
            await cognitiveServicesEncryptionScope.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
