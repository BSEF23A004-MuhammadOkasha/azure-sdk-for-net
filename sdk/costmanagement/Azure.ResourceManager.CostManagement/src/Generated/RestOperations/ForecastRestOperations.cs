// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CostManagement.Models;

namespace Azure.ResourceManager.CostManagement
{
    internal partial class ForecastRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ForecastRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ForecastRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateUsageRequestUri(string scope, ForecastDefinition forecastDefinition, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.CostManagement/forecast", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUsageRequest(string scope, ForecastDefinition forecastDefinition, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.CostManagement/forecast", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(forecastDefinition);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the forecast charges for scope defined. </summary>
        /// <param name="scope"> The scope associated with forecast operations. This includes '/subscriptions/{subscriptionId}/' for subscription scope, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, '/providers/Microsoft.Management/managementGroups/{managementGroupId} for Management Group scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for billingProfile scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}' for invoiceSection scope, and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}' specific for partners. </param>
        /// <param name="forecastDefinition"> Parameters supplied to the CreateOrUpdate Forecast Config operation. </param>
        /// <param name="filter"> May be used to filter forecasts by properties/usageDate (Utc time), properties/chargeType or properties/grain. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="forecastDefinition"/> is null. </exception>
        public async Task<Response<ForecastResult>> UsageAsync(string scope, ForecastDefinition forecastDefinition, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(forecastDefinition, nameof(forecastDefinition));

            using var message = CreateUsageRequest(scope, forecastDefinition, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ForecastResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ForecastResult.DeserializeForecastResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((ForecastResult)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the forecast charges for scope defined. </summary>
        /// <param name="scope"> The scope associated with forecast operations. This includes '/subscriptions/{subscriptionId}/' for subscription scope, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, '/providers/Microsoft.Management/managementGroups/{managementGroupId} for Management Group scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for billingProfile scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}' for invoiceSection scope, and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}' specific for partners. </param>
        /// <param name="forecastDefinition"> Parameters supplied to the CreateOrUpdate Forecast Config operation. </param>
        /// <param name="filter"> May be used to filter forecasts by properties/usageDate (Utc time), properties/chargeType or properties/grain. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="forecastDefinition"/> is null. </exception>
        public Response<ForecastResult> Usage(string scope, ForecastDefinition forecastDefinition, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(forecastDefinition, nameof(forecastDefinition));

            using var message = CreateUsageRequest(scope, forecastDefinition, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ForecastResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ForecastResult.DeserializeForecastResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((ForecastResult)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateExternalCloudProviderUsageRequestUri(ExternalCloudProviderType externalCloudProviderType, string externalCloudProviderId, ForecastDefinition forecastDefinition, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.CostManagement/", false);
            uri.AppendPath(externalCloudProviderType.ToString(), true);
            uri.AppendPath("/", false);
            uri.AppendPath(externalCloudProviderId, true);
            uri.AppendPath("/forecast", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateExternalCloudProviderUsageRequest(ExternalCloudProviderType externalCloudProviderType, string externalCloudProviderId, ForecastDefinition forecastDefinition, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.CostManagement/", false);
            uri.AppendPath(externalCloudProviderType.ToString(), true);
            uri.AppendPath("/", false);
            uri.AppendPath(externalCloudProviderId, true);
            uri.AppendPath("/forecast", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(forecastDefinition);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the forecast charges for external cloud provider type defined. </summary>
        /// <param name="externalCloudProviderType"> The external cloud provider type associated with dimension/query operations. This includes 'externalSubscriptions' for linked account and 'externalBillingAccounts' for consolidated account. </param>
        /// <param name="externalCloudProviderId"> This can be '{externalSubscriptionId}' for linked account or '{externalBillingAccountId}' for consolidated account used with dimension/query operations. </param>
        /// <param name="forecastDefinition"> Parameters supplied to the CreateOrUpdate Forecast Config operation. </param>
        /// <param name="filter"> May be used to filter forecasts by properties/usageDate (Utc time), properties/chargeType or properties/grain. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="externalCloudProviderId"/> or <paramref name="forecastDefinition"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="externalCloudProviderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ForecastResult>> ExternalCloudProviderUsageAsync(ExternalCloudProviderType externalCloudProviderType, string externalCloudProviderId, ForecastDefinition forecastDefinition, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(externalCloudProviderId, nameof(externalCloudProviderId));
            Argument.AssertNotNull(forecastDefinition, nameof(forecastDefinition));

            using var message = CreateExternalCloudProviderUsageRequest(externalCloudProviderType, externalCloudProviderId, forecastDefinition, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ForecastResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ForecastResult.DeserializeForecastResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the forecast charges for external cloud provider type defined. </summary>
        /// <param name="externalCloudProviderType"> The external cloud provider type associated with dimension/query operations. This includes 'externalSubscriptions' for linked account and 'externalBillingAccounts' for consolidated account. </param>
        /// <param name="externalCloudProviderId"> This can be '{externalSubscriptionId}' for linked account or '{externalBillingAccountId}' for consolidated account used with dimension/query operations. </param>
        /// <param name="forecastDefinition"> Parameters supplied to the CreateOrUpdate Forecast Config operation. </param>
        /// <param name="filter"> May be used to filter forecasts by properties/usageDate (Utc time), properties/chargeType or properties/grain. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="externalCloudProviderId"/> or <paramref name="forecastDefinition"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="externalCloudProviderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ForecastResult> ExternalCloudProviderUsage(ExternalCloudProviderType externalCloudProviderType, string externalCloudProviderId, ForecastDefinition forecastDefinition, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(externalCloudProviderId, nameof(externalCloudProviderId));
            Argument.AssertNotNull(forecastDefinition, nameof(forecastDefinition));

            using var message = CreateExternalCloudProviderUsageRequest(externalCloudProviderType, externalCloudProviderId, forecastDefinition, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ForecastResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ForecastResult.DeserializeForecastResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
