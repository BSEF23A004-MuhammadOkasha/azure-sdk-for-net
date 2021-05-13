// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ExportJobsOperationResultOperations operations.
    /// </summary>
    public partial interface IExportJobsOperationResultOperations
    {
        /// <summary>
        /// Gets the operation result of operation triggered by Export Jobs
        /// API. If the operation is successful, then it also contains URL of a
        /// Blob and a SAS key to access the same. The blob contains exported
        /// jobs in JSON serialized format.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='operationId'>
        /// OperationID which represents the export job.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ExportJobsResult>> GetWithHttpMessagesAsync(string resourceGroupName, string vaultName, string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
