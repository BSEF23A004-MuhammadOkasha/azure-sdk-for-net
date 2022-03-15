// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary>
        /// Lists all the addresses available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/addresses
        /// Operation Id: ListAddressesAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AddressResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AddressResource> GetAddressResourcesAsync(this Subscription subscription, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetAddressResourcesAsync(filter, skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists all the addresses available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/addresses
        /// Operation Id: ListAddressesAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AddressResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AddressResource> GetAddressResources(this Subscription subscription, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetAddressResources(filter, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listProductFamilies
        /// Operation Id: ListProductFamilies
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="productFamiliesRequest"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="productFamiliesRequest"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductFamily> GetProductFamiliesAsync(this Subscription subscription, ProductFamiliesRequest productFamiliesRequest, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(productFamiliesRequest, nameof(productFamiliesRequest));

            return GetExtensionClient(subscription).GetProductFamiliesAsync(productFamiliesRequest, expand, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listProductFamilies
        /// Operation Id: ListProductFamilies
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="productFamiliesRequest"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="productFamiliesRequest"/> is null. </exception>
        /// <returns> A collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductFamily> GetProductFamilies(this Subscription subscription, ProductFamiliesRequest productFamiliesRequest, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(productFamiliesRequest, nameof(productFamiliesRequest));

            return GetExtensionClient(subscription).GetProductFamilies(productFamiliesRequest, expand, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of configurations for the given product family, product line and product under subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listConfigurations
        /// Operation Id: ListConfigurations
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="configurationsRequest"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationsRequest"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductConfiguration> GetConfigurationsAsync(this Subscription subscription, ConfigurationsRequest configurationsRequest, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(configurationsRequest, nameof(configurationsRequest));

            return GetExtensionClient(subscription).GetConfigurationsAsync(configurationsRequest, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of configurations for the given product family, product line and product under subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listConfigurations
        /// Operation Id: ListConfigurations
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="configurationsRequest"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationsRequest"/> is null. </exception>
        /// <returns> A collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductConfiguration> GetConfigurations(this Subscription subscription, ConfigurationsRequest configurationsRequest, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(configurationsRequest, nameof(configurationsRequest));

            return GetExtensionClient(subscription).GetConfigurations(configurationsRequest, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families metadata for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/productFamiliesMetadata
        /// Operation Id: ListProductFamiliesMetadata
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProductFamiliesMetadataDetails" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductFamiliesMetadataDetails> GetProductFamiliesMetadataAsync(this Subscription subscription, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetProductFamiliesMetadataAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families metadata for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/productFamiliesMetadata
        /// Operation Id: ListProductFamiliesMetadata
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProductFamiliesMetadataDetails" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductFamiliesMetadataDetails> GetProductFamiliesMetadata(this Subscription subscription, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetProductFamiliesMetadata(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrderResource> GetOrderResourcesAsync(this Subscription subscription, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetOrderResourcesAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrderResource> GetOrderResources(this Subscription subscription, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetOrderResources(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order item at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orderItems
        /// Operation Id: ListOrderItemsAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrderItemResource> GetOrderItemResourcesAsync(this Subscription subscription, string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetOrderItemResourcesAsync(filter, expand, skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order item at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orderItems
        /// Operation Id: ListOrderItemsAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrderItemResource> GetOrderItemResources(this Subscription subscription, string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetOrderItemResources(filter, expand, skipToken, cancellationToken);
        }
    }
}
