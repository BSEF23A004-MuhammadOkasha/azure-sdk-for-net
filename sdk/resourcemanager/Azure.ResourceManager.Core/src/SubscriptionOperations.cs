﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Core
{
    /// <summary>
    /// A class representing the operations that can be performed over a specific subscription.
    /// </summary>
    public class SubscriptionOperations : ResourceOperationsBase<SubscriptionResourceIdentifier, Subscription>
    {
        /// <summary>
        /// The resource type for subscription
        /// </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/subscriptions";

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOperations"/> class for mocking.
        /// </summary>
        protected SubscriptionOperations()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOperations"/> class.
        /// </summary>
        /// <param name="clientContext"></param>
        /// <param name="subscriptionGuid"> The Guid of the subscription. </param>
        internal SubscriptionOperations(ClientContext clientContext, string subscriptionGuid)
            : base(clientContext, $"/subscriptions/{subscriptionGuid}")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOperations"/> class.
        /// </summary>
        /// <param name="subscription"> The subscription operations to copy client options from. </param>
        /// <param name="id"> The identifier of the subscription. </param>
        protected SubscriptionOperations(SubscriptionOperations subscription, SubscriptionResourceIdentifier id)
            : base(subscription, id)
        {
        }

        /// <summary>
        /// ListResources of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public virtual T ListResources<T>(Func<Uri, TokenCredential, AzureResourceManagerClientOptions, T> func)
        {
            return func(BaseUri, Credential, ClientOptions);
        }

        /// <summary>
        /// ListResourcesAsync of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public virtual AsyncPageable<T> ListResourcesAsync<T>(Func<Uri, TokenCredential, AzureResourceManagerClientOptions, AsyncPageable<T>> func)
        {
            return func(BaseUri, Credential, ClientOptions);
        }

        /// <summary>
        /// Gets the valid resource type for this operation class
        /// </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        private SubscriptionsOperations SubscriptionsClient => new ResourcesManagementClient(
            BaseUri,
            Guid.NewGuid().ToString(),
            Credential,
            ClientOptions.Convert<ResourcesManagementClientOptions>()).Subscriptions;

        /// <summary>
        /// Gets the resource group operations for a given resource group.
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <returns> The resource group operations. </returns>
        /// <exception cref="ArgumentOutOfRangeException"> resourceGroupName must be at least one character long and cannot be longer than 90 characters. </exception>
        /// <exception cref="ArgumentException"> The name of the resource group can include alphanumeric, underscore, parentheses, hyphen, period (except at end), and Unicode characters that match the allowed characters. </exception>
        public virtual ResourceGroupOperations GetResourceGroupOperations(string resourceGroupName)
        {
            return new ResourceGroupOperations(this, resourceGroupName);
        }

        /// <summary>
        /// Gets the resource group container under this subscription
        /// </summary>
        /// <returns> The resource group container. </returns>
        public virtual ResourceGroupContainer GetResourceGroupContainer()
        {
            return new ResourceGroupContainer(this);
        }

        /// <summary>
        /// Gets the location group container under this subscription
        /// </summary>
        /// <returns> The resource group container. </returns>
        public virtual LocationContainer GetLocationContainer()
        {
            return new LocationContainer(this);
        }

        /// <inheritdoc/>
        public override ArmResponse<Subscription> Get(CancellationToken cancellationToken = default)
        {
            return new PhArmResponse<Subscription, ResourceManager.Resources.Models.Subscription>(
                SubscriptionsClient.Get(Id.Name, cancellationToken),
                Converter());
        }

        /// <inheritdoc/>
        public override async Task<ArmResponse<Subscription>> GetAsync(CancellationToken cancellationToken = default)
        {
            return new PhArmResponse<Subscription, ResourceManager.Resources.Models.Subscription>(
                await SubscriptionsClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false),
                Converter());
        }

        private Func<ResourceManager.Resources.Models.Subscription, Subscription> Converter()
        {
            return s => new Subscription(this, new SubscriptionData(s));
        }
    }
}
