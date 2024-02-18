// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.CostManagement
{
    internal partial class GenerateReservationDetailsReportRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of GenerateReservationDetailsReportRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public GenerateReservationDetailsReportRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateByBillingAccountIdRequestUri(string billingAccountId, string startDate, string endDate)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/providers/Microsoft.CostManagement/generateReservationDetailsReport", false);
            uri.AppendQuery("startDate", startDate, true);
            uri.AppendQuery("endDate", endDate, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateByBillingAccountIdRequest(string billingAccountId, string startDate, string endDate)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/providers/Microsoft.CostManagement/generateReservationDetailsReport", false);
            uri.AppendQuery("startDate", startDate, true);
            uri.AppendQuery("endDate", endDate, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Generates the reservations details report for provided date range asynchronously based on enrollment id. The Reservation usage details can be viewed only by certain enterprise roles. For more details on the roles see, https://docs.microsoft.com/en-us/azure/cost-management-billing/manage/understand-ea-roles#usage-and-costs-access-by-role. </summary>
        /// <param name="billingAccountId"> Enrollment ID (Legacy BillingAccount ID). </param>
        /// <param name="startDate"> Start Date. </param>
        /// <param name="endDate"> End Date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/>, <paramref name="startDate"/> or <paramref name="endDate"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> ByBillingAccountIdAsync(string billingAccountId, string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNull(startDate, nameof(startDate));
            Argument.AssertNotNull(endDate, nameof(endDate));

            using var message = CreateByBillingAccountIdRequest(billingAccountId, startDate, endDate);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Generates the reservations details report for provided date range asynchronously based on enrollment id. The Reservation usage details can be viewed only by certain enterprise roles. For more details on the roles see, https://docs.microsoft.com/en-us/azure/cost-management-billing/manage/understand-ea-roles#usage-and-costs-access-by-role. </summary>
        /// <param name="billingAccountId"> Enrollment ID (Legacy BillingAccount ID). </param>
        /// <param name="startDate"> Start Date. </param>
        /// <param name="endDate"> End Date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/>, <paramref name="startDate"/> or <paramref name="endDate"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response ByBillingAccountId(string billingAccountId, string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNull(startDate, nameof(startDate));
            Argument.AssertNotNull(endDate, nameof(endDate));

            using var message = CreateByBillingAccountIdRequest(billingAccountId, startDate, endDate);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateByBillingProfileIdRequestUri(string billingAccountId, string billingProfileId, string startDate, string endDate)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/billingProfiles/", false);
            uri.AppendPath(billingProfileId, true);
            uri.AppendPath("/providers/Microsoft.CostManagement/generateReservationDetailsReport", false);
            uri.AppendQuery("startDate", startDate, true);
            uri.AppendQuery("endDate", endDate, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateByBillingProfileIdRequest(string billingAccountId, string billingProfileId, string startDate, string endDate)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/billingProfiles/", false);
            uri.AppendPath(billingProfileId, true);
            uri.AppendPath("/providers/Microsoft.CostManagement/generateReservationDetailsReport", false);
            uri.AppendQuery("startDate", startDate, true);
            uri.AppendQuery("endDate", endDate, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Generates the reservations details report for provided date range asynchronously by billing profile. The Reservation usage details can be viewed by only certain enterprise roles by default. For more details on the roles see, https://docs.microsoft.com/en-us/azure/cost-management-billing/reservations/reservation-utilization#view-utilization-in-the-azure-portal-with-azure-rbac-access. </summary>
        /// <param name="billingAccountId"> Billing account ID. </param>
        /// <param name="billingProfileId"> Billing profile ID. </param>
        /// <param name="startDate"> Start Date. </param>
        /// <param name="endDate"> End Date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/>, <paramref name="billingProfileId"/>, <paramref name="startDate"/> or <paramref name="endDate"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> ByBillingProfileIdAsync(string billingAccountId, string billingProfileId, string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingProfileId, nameof(billingProfileId));
            Argument.AssertNotNull(startDate, nameof(startDate));
            Argument.AssertNotNull(endDate, nameof(endDate));

            using var message = CreateByBillingProfileIdRequest(billingAccountId, billingProfileId, startDate, endDate);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Generates the reservations details report for provided date range asynchronously by billing profile. The Reservation usage details can be viewed by only certain enterprise roles by default. For more details on the roles see, https://docs.microsoft.com/en-us/azure/cost-management-billing/reservations/reservation-utilization#view-utilization-in-the-azure-portal-with-azure-rbac-access. </summary>
        /// <param name="billingAccountId"> Billing account ID. </param>
        /// <param name="billingProfileId"> Billing profile ID. </param>
        /// <param name="startDate"> Start Date. </param>
        /// <param name="endDate"> End Date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/>, <paramref name="billingProfileId"/>, <paramref name="startDate"/> or <paramref name="endDate"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response ByBillingProfileId(string billingAccountId, string billingProfileId, string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingProfileId, nameof(billingProfileId));
            Argument.AssertNotNull(startDate, nameof(startDate));
            Argument.AssertNotNull(endDate, nameof(endDate));

            using var message = CreateByBillingProfileIdRequest(billingAccountId, billingProfileId, startDate, endDate);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
