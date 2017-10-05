// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApplicationInsights.Management
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApplicationInsights;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Composite Swagger for Application Insights Management Client
    /// </summary>
    public partial interface IApplicationInsightsManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The Azure subscription ID.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IComponentsOperations.
        /// </summary>
        IComponentsOperations Components { get; }

        /// <summary>
        /// Gets the IWebTestsOperations.
        /// </summary>
        IWebTestsOperations WebTests { get; }

        /// <summary>
        /// Gets the IExportConfigurationsOperations.
        /// </summary>
        IExportConfigurationsOperations ExportConfigurations { get; }

        /// <summary>
        /// Gets the IComponentCurrentBillingFeaturesOperations.
        /// </summary>
        IComponentCurrentBillingFeaturesOperations ComponentCurrentBillingFeatures { get; }

        /// <summary>
        /// Gets the IComponentQuotaStatusOperations.
        /// </summary>
        IComponentQuotaStatusOperations ComponentQuotaStatus { get; }

        /// <summary>
        /// Gets the IAPIKeysOperations.
        /// </summary>
        IAPIKeysOperations APIKeys { get; }

    }
}
