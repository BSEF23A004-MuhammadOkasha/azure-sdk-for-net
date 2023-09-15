// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="RegulatoryComplianceAssessmentResource" /> and their operations.
    /// Each <see cref="RegulatoryComplianceAssessmentResource" /> in the collection will belong to the same instance of <see cref="RegulatoryComplianceControlResource" />.
    /// To get a <see cref="RegulatoryComplianceAssessmentCollection" /> instance call the GetRegulatoryComplianceAssessments method from an instance of <see cref="RegulatoryComplianceControlResource" />.
    /// </summary>
    public partial class RegulatoryComplianceAssessmentCollection : ArmCollection, IEnumerable<RegulatoryComplianceAssessmentResource>, IAsyncEnumerable<RegulatoryComplianceAssessmentResource>
    {
        private readonly ClientDiagnostics _regulatoryComplianceAssessmentClientDiagnostics;
        private readonly RegulatoryComplianceAssessmentsRestOperations _regulatoryComplianceAssessmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceAssessmentCollection"/> class for mocking. </summary>
        protected RegulatoryComplianceAssessmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceAssessmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RegulatoryComplianceAssessmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _regulatoryComplianceAssessmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", RegulatoryComplianceAssessmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RegulatoryComplianceAssessmentResource.ResourceType, out string regulatoryComplianceAssessmentApiVersion);
            _regulatoryComplianceAssessmentRestClient = new RegulatoryComplianceAssessmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, regulatoryComplianceAssessmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RegulatoryComplianceControlResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RegulatoryComplianceControlResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Supported regulatory compliance details and state for selected assessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments/{regulatoryComplianceAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceAssessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceAssessmentName"> Name of the regulatory compliance assessment object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceAssessmentName"/> is null. </exception>
        public virtual async Task<Response<RegulatoryComplianceAssessmentResource>> GetAsync(string regulatoryComplianceAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceAssessmentName, nameof(regulatoryComplianceAssessmentName));

            using var scope = _regulatoryComplianceAssessmentClientDiagnostics.CreateScope("RegulatoryComplianceAssessmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _regulatoryComplianceAssessmentRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, regulatoryComplianceAssessmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Supported regulatory compliance details and state for selected assessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments/{regulatoryComplianceAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceAssessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceAssessmentName"> Name of the regulatory compliance assessment object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceAssessmentName"/> is null. </exception>
        public virtual Response<RegulatoryComplianceAssessmentResource> Get(string regulatoryComplianceAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceAssessmentName, nameof(regulatoryComplianceAssessmentName));

            using var scope = _regulatoryComplianceAssessmentClientDiagnostics.CreateScope("RegulatoryComplianceAssessmentCollection.Get");
            scope.Start();
            try
            {
                var response = _regulatoryComplianceAssessmentRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, regulatoryComplianceAssessmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Details and state of assessments mapped to selected regulatory compliance control
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceAssessments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RegulatoryComplianceAssessmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RegulatoryComplianceAssessmentResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _regulatoryComplianceAssessmentRestClient.CreateListRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _regulatoryComplianceAssessmentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RegulatoryComplianceAssessmentResource(Client, RegulatoryComplianceAssessmentData.DeserializeRegulatoryComplianceAssessmentData(e)), _regulatoryComplianceAssessmentClientDiagnostics, Pipeline, "RegulatoryComplianceAssessmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Details and state of assessments mapped to selected regulatory compliance control
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceAssessments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RegulatoryComplianceAssessmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RegulatoryComplianceAssessmentResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _regulatoryComplianceAssessmentRestClient.CreateListRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _regulatoryComplianceAssessmentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RegulatoryComplianceAssessmentResource(Client, RegulatoryComplianceAssessmentData.DeserializeRegulatoryComplianceAssessmentData(e)), _regulatoryComplianceAssessmentClientDiagnostics, Pipeline, "RegulatoryComplianceAssessmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments/{regulatoryComplianceAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceAssessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceAssessmentName"> Name of the regulatory compliance assessment object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceAssessmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string regulatoryComplianceAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceAssessmentName, nameof(regulatoryComplianceAssessmentName));

            using var scope = _regulatoryComplianceAssessmentClientDiagnostics.CreateScope("RegulatoryComplianceAssessmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _regulatoryComplianceAssessmentRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, regulatoryComplianceAssessmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments/{regulatoryComplianceAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceAssessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceAssessmentName"> Name of the regulatory compliance assessment object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceAssessmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string regulatoryComplianceAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceAssessmentName, nameof(regulatoryComplianceAssessmentName));

            using var scope = _regulatoryComplianceAssessmentClientDiagnostics.CreateScope("RegulatoryComplianceAssessmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _regulatoryComplianceAssessmentRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, regulatoryComplianceAssessmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RegulatoryComplianceAssessmentResource> IEnumerable<RegulatoryComplianceAssessmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RegulatoryComplianceAssessmentResource> IAsyncEnumerable<RegulatoryComplianceAssessmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
