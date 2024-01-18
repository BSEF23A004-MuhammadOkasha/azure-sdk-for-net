// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlTimeZone along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SqlTimeZoneResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSqlTimeZoneResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSqlTimeZone method.
    /// </summary>
    public partial class SqlTimeZoneResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlTimeZoneResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="locationName"> The locationName. </param>
        /// <param name="timeZoneId"> The timeZoneId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation locationName, string timeZoneId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlTimeZoneTimeZonesClientDiagnostics;
        private readonly TimeZonesRestOperations _sqlTimeZoneTimeZonesRestClient;
        private readonly SqlTimeZoneData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/locations/timeZones";

        /// <summary> Initializes a new instance of the <see cref="SqlTimeZoneResource"/> class for mocking. </summary>
        protected SqlTimeZoneResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlTimeZoneResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlTimeZoneResource(ArmClient client, SqlTimeZoneData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlTimeZoneResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlTimeZoneResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlTimeZoneTimeZonesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlTimeZoneTimeZonesApiVersion);
            _sqlTimeZoneTimeZonesRestClient = new TimeZonesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlTimeZoneTimeZonesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlTimeZoneData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a managed instance time zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlTimeZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlTimeZoneResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlTimeZoneTimeZonesRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlTimeZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed instance time zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlTimeZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlTimeZoneResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneResource.Get");
            scope.Start();
            try
            {
                var response = _sqlTimeZoneTimeZonesRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlTimeZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
