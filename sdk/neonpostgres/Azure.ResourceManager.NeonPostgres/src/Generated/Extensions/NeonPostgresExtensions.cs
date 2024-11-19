// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.NeonPostgres.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NeonPostgres
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.NeonPostgres. </summary>
    public static partial class NeonPostgresExtensions
    {
        private static MockableNeonPostgresArmClient GetMockableNeonPostgresArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableNeonPostgresArmClient(client0));
        }

        private static MockableNeonPostgresResourceGroupResource GetMockableNeonPostgresResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableNeonPostgresResourceGroupResource(client, resource.Id));
        }

        private static MockableNeonPostgresSubscriptionResource GetMockableNeonPostgresSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableNeonPostgresSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="NeonOrganizationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NeonOrganizationResource.CreateResourceIdentifier" /> to create a <see cref="NeonOrganizationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNeonPostgresArmClient.GetNeonOrganizationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="NeonOrganizationResource"/> object. </returns>
        public static NeonOrganizationResource GetNeonOrganizationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableNeonPostgresArmClient(client).GetNeonOrganizationResource(id);
        }

        /// <summary>
        /// Gets a collection of NeonOrganizationResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNeonPostgresResourceGroupResource.GetNeonOrganizations()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of NeonOrganizationResources and their operations over a NeonOrganizationResource. </returns>
        public static NeonOrganizationCollection GetNeonOrganizations(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableNeonPostgresResourceGroupResource(resourceGroupResource).GetNeonOrganizations();
        }

        /// <summary>
        /// Get a OrganizationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Neon.Postgres/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NeonOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNeonPostgresResourceGroupResource.GetNeonOrganizationAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationName"> Name of the Neon Organizations resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="organizationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<NeonOrganizationResource>> GetNeonOrganizationAsync(this ResourceGroupResource resourceGroupResource, string organizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableNeonPostgresResourceGroupResource(resourceGroupResource).GetNeonOrganizationAsync(organizationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a OrganizationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Neon.Postgres/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NeonOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNeonPostgresResourceGroupResource.GetNeonOrganization(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationName"> Name of the Neon Organizations resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="organizationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<NeonOrganizationResource> GetNeonOrganization(this ResourceGroupResource resourceGroupResource, string organizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableNeonPostgresResourceGroupResource(resourceGroupResource).GetNeonOrganization(organizationName, cancellationToken);
        }

        /// <summary>
        /// List OrganizationResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Neon.Postgres/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NeonOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNeonPostgresSubscriptionResource.GetNeonOrganizations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="NeonOrganizationResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NeonOrganizationResource> GetNeonOrganizationsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableNeonPostgresSubscriptionResource(subscriptionResource).GetNeonOrganizationsAsync(cancellationToken);
        }

        /// <summary>
        /// List OrganizationResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Neon.Postgres/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NeonOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNeonPostgresSubscriptionResource.GetNeonOrganizations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="NeonOrganizationResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NeonOrganizationResource> GetNeonOrganizations(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableNeonPostgresSubscriptionResource(subscriptionResource).GetNeonOrganizations(cancellationToken);
        }
    }
}
