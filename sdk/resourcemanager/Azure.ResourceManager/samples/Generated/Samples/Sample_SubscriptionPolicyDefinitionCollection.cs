// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Resources.Samples
{
    public partial class Sample_SubscriptionPolicyDefinitionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAPolicyDefinition()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/examples/createOrUpdatePolicyDefinition.json
            // this example is just showing the usage of "PolicyDefinitions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ae640e6b-ba3e-4256-9d62-2993eecfa6f2";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionPolicyDefinitionResource
            SubscriptionPolicyDefinitionCollection collection = subscription.GetSubscriptionPolicyDefinitions();

            // invoke the operation
            string policyDefinitionName = "ResourceNaming";
            PolicyDefinitionData data = new PolicyDefinitionData()
            {
                Mode = "All",
                DisplayName = "Enforce resource naming convention",
                Description = "Force resource names to begin with given 'prefix' and/or end with given 'suffix'",
                PolicyRule = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["if"] = new Dictionary<string, object>()
                    {
                        ["not"] = new Dictionary<string, object>()
                        {
                            ["field"] = "name",
                            ["like"] = "[concat(parameters('prefix'), '*', parameters('suffix'))]"
                        }
                    },
                    ["then"] = new Dictionary<string, object>()
                    {
                        ["effect"] = "deny"
                    }
                }),
                Metadata = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["category"] = "Naming"
                }),
                Parameters =
{
["prefix"] = new ArmPolicyParameter()
{
ParameterType = ArmPolicyParameterType.String,
Metadata = new ParameterDefinitionsValueMetadata()
{
DisplayName = "Prefix",
Description = "Resource name prefix",
},
},
["suffix"] = new ArmPolicyParameter()
{
ParameterType = ArmPolicyParameterType.String,
Metadata = new ParameterDefinitionsValueMetadata()
{
DisplayName = "Suffix",
Description = "Resource name suffix",
},
},
},
            };
            ArmOperation<SubscriptionPolicyDefinitionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, policyDefinitionName, data);
            SubscriptionPolicyDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAPolicyDefinitionWithAdvancedParameters()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/examples/createOrUpdatePolicyDefinitionAdvancedParams.json
            // this example is just showing the usage of "PolicyDefinitions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ae640e6b-ba3e-4256-9d62-2993eecfa6f2";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionPolicyDefinitionResource
            SubscriptionPolicyDefinitionCollection collection = subscription.GetSubscriptionPolicyDefinitions();

            // invoke the operation
            string policyDefinitionName = "EventHubDiagnosticLogs";
            PolicyDefinitionData data = new PolicyDefinitionData()
            {
                Mode = "Indexed",
                DisplayName = "Event Hubs should have diagnostic logging enabled",
                Description = "Audit enabling of logs and retain them up to a year. This enables recreation of activity trails for investigation purposes when a security incident occurs or your network is compromised",
                PolicyRule = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["if"] = new Dictionary<string, object>()
                    {
                        ["equals"] = "Microsoft.EventHub/namespaces",
                        ["field"] = "type"
                    },
                    ["then"] = new Dictionary<string, object>()
                    {
                        ["effect"] = "AuditIfNotExists",
                        ["details"] = new Dictionary<string, object>()
                        {
                            ["type"] = "Microsoft.Insights/diagnosticSettings",
                            ["existenceCondition"] = new Dictionary<string, object>()
                            {
                                ["allOf"] = new object[] { new Dictionary<string, object>()
{
["equals"] = "true",
["field"] = "Microsoft.Insights/diagnosticSettings/logs[*].retentionPolicy.enabled"}, new Dictionary<string, object>()
{
["equals"] = "[parameters('requiredRetentionDays')]",
["field"] = "Microsoft.Insights/diagnosticSettings/logs[*].retentionPolicy.days"} }
                            }
                        }
                    }
                }),
                Metadata = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["category"] = "Event Hub"
                }),
                Parameters =
{
["requiredRetentionDays"] = new ArmPolicyParameter()
{
ParameterType = ArmPolicyParameterType.Integer,
AllowedValues =
{
BinaryData.FromString("\"0\""),BinaryData.FromString("\"30\""),BinaryData.FromString("\"90\""),BinaryData.FromString("\"180\""),BinaryData.FromString("\"365\"")
},
DefaultValue = BinaryData.FromString("\"365\""),
Metadata = new ParameterDefinitionsValueMetadata()
{
DisplayName = "Required retention (days)",
Description = "The required diagnostic logs retention in days",
},
},
},
            };
            ArmOperation<SubscriptionPolicyDefinitionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, policyDefinitionName, data);
            SubscriptionPolicyDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RetrieveAPolicyDefinition()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/examples/getPolicyDefinition.json
            // this example is just showing the usage of "PolicyDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ae640e6b-ba3e-4256-9d62-2993eecfa6f2";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionPolicyDefinitionResource
            SubscriptionPolicyDefinitionCollection collection = subscription.GetSubscriptionPolicyDefinitions();

            // invoke the operation
            string policyDefinitionName = "ResourceNaming";
            SubscriptionPolicyDefinitionResource result = await collection.GetAsync(policyDefinitionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_RetrieveAPolicyDefinition()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/examples/getPolicyDefinition.json
            // this example is just showing the usage of "PolicyDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ae640e6b-ba3e-4256-9d62-2993eecfa6f2";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionPolicyDefinitionResource
            SubscriptionPolicyDefinitionCollection collection = subscription.GetSubscriptionPolicyDefinitions();

            // invoke the operation
            string policyDefinitionName = "ResourceNaming";
            bool result = await collection.ExistsAsync(policyDefinitionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_RetrieveAPolicyDefinition()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/examples/getPolicyDefinition.json
            // this example is just showing the usage of "PolicyDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ae640e6b-ba3e-4256-9d62-2993eecfa6f2";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionPolicyDefinitionResource
            SubscriptionPolicyDefinitionCollection collection = subscription.GetSubscriptionPolicyDefinitions();

            // invoke the operation
            string policyDefinitionName = "ResourceNaming";
            NullableResponse<SubscriptionPolicyDefinitionResource> response = await collection.GetIfExistsAsync(policyDefinitionName);
            SubscriptionPolicyDefinitionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyDefinitionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListPolicyDefinitionsBySubscription()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/examples/listPolicyDefinitions.json
            // this example is just showing the usage of "PolicyDefinitions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ae640e6b-ba3e-4256-9d62-2993eecfa6f2";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionPolicyDefinitionResource
            SubscriptionPolicyDefinitionCollection collection = subscription.GetSubscriptionPolicyDefinitions();

            // invoke the operation and iterate over the result
            await foreach (SubscriptionPolicyDefinitionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyDefinitionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
