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
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_EventGridTopicResource
    {
        // Topics_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TopicsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Topics_Get.json
            // this example is just showing the usage of "Topics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridTopicResource created on azure
            // for more information of creating EventGridTopicResource, please refer to the document of EventGridTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string topicName = "exampletopic2";
            ResourceIdentifier eventGridTopicResourceId = EventGridTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, topicName);
            EventGridTopicResource eventGridTopic = client.GetEventGridTopicResource(eventGridTopicResourceId);

            // invoke the operation
            EventGridTopicResource result = await eventGridTopic.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Topics_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_TopicsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Topics_Delete.json
            // this example is just showing the usage of "Topics_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridTopicResource created on azure
            // for more information of creating EventGridTopicResource, please refer to the document of EventGridTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg1";
            string topicName = "exampletopic1";
            ResourceIdentifier eventGridTopicResourceId = EventGridTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, topicName);
            EventGridTopicResource eventGridTopic = client.GetEventGridTopicResource(eventGridTopicResourceId);

            // invoke the operation
            await eventGridTopic.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Topics_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_TopicsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Topics_Update.json
            // this example is just showing the usage of "Topics_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridTopicResource created on azure
            // for more information of creating EventGridTopicResource, please refer to the document of EventGridTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string topicName = "exampletopic1";
            ResourceIdentifier eventGridTopicResourceId = EventGridTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, topicName);
            EventGridTopicResource eventGridTopic = client.GetEventGridTopicResource(eventGridTopicResourceId);

            // invoke the operation
            EventGridTopicPatch patch = new EventGridTopicPatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
                PublicNetworkAccess = EventGridPublicNetworkAccess.Enabled,
                InboundIPRules =
{
new EventGridInboundIPRule()
{
IPMask = "12.18.30.15",
Action = EventGridIPActionType.Allow,
},new EventGridInboundIPRule()
{
IPMask = "12.18.176.1",
Action = EventGridIPActionType.Allow,
}
},
            };
            await eventGridTopic.UpdateAsync(WaitUntil.Completed, patch);

            Console.WriteLine($"Succeeded");
        }

        // Topics_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEventGridTopics_TopicsListBySubscription()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Topics_ListBySubscription.json
            // this example is just showing the usage of "Topics_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (EventGridTopicResource item in subscriptionResource.GetEventGridTopicsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventGridTopicData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Topics_ListSharedAccessKeys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSharedAccessKeys_TopicsListSharedAccessKeys()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Topics_ListSharedAccessKeys.json
            // this example is just showing the usage of "Topics_ListSharedAccessKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridTopicResource created on azure
            // for more information of creating EventGridTopicResource, please refer to the document of EventGridTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string topicName = "exampletopic2";
            ResourceIdentifier eventGridTopicResourceId = EventGridTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, topicName);
            EventGridTopicResource eventGridTopic = client.GetEventGridTopicResource(eventGridTopicResourceId);

            // invoke the operation
            TopicSharedAccessKeys result = await eventGridTopic.GetSharedAccessKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Topics_RegenerateKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateKey_TopicsRegenerateKey()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Topics_RegenerateKey.json
            // this example is just showing the usage of "Topics_RegenerateKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridTopicResource created on azure
            // for more information of creating EventGridTopicResource, please refer to the document of EventGridTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string topicName = "exampletopic2";
            ResourceIdentifier eventGridTopicResourceId = EventGridTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, topicName);
            EventGridTopicResource eventGridTopic = client.GetEventGridTopicResource(eventGridTopicResourceId);

            // invoke the operation
            TopicRegenerateKeyContent content = new TopicRegenerateKeyContent("key1");
            ArmOperation<TopicSharedAccessKeys> lro = await eventGridTopic.RegenerateKeyAsync(WaitUntil.Completed, content);
            TopicSharedAccessKeys result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
