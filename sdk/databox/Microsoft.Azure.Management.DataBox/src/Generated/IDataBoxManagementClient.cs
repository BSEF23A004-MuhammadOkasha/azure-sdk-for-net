// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IDataBoxManagementClient : System.IDisposable
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
        /// The API Version
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The Subscription Id
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        IJobsOperations Jobs { get; }

        /// <summary>
        /// Gets the IServiceOperations.
        /// </summary>
        IServiceOperations Service { get; }

        /// <summary>
        /// Request to mitigate for a given job
        /// </summary>
        /// <param name='jobName'>
        /// The name of the job Resource within the specified resource group.
        /// job names must be between 3 and 24 characters in length and use any
        /// alphanumeric and underscore only
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='customerResolutionCode'>
        /// Resolution code for the job. Possible values include: 'None',
        /// 'MoveToCleanUpDevice', 'Resume'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> MitigateWithHttpMessagesAsync(string jobName, string resourceGroupName, CustomerResolutionCode customerResolutionCode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
