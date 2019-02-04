// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Jobs operations.
    /// </summary>
    public partial interface IJobs
    {
        /// <summary>
        /// This method gets all the jobs of a given job definition.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The name of the data service of the job definition.
        /// </param>
        /// <param name='jobDefinitionName'>
        /// The name of the job definition for which jobs are needed.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
        /// </param>
        /// <param name='filter'>
        /// OData Filter options
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<JobList>> ListByJobDefinitionWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, string resourceGroupName, string dataManagerName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method gets a data manager job given the jobId.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The name of the data service of the job definition.
        /// </param>
        /// <param name='jobDefinitionName'>
        /// The name of the job definition of the job.
        /// </param>
        /// <param name='jobId'>
        /// The job id of the job queried.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
        /// </param>
        /// <param name='expand'>
        /// $expand is supported on details parameter for job, which provides
        /// details on the job stages.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Job>> GetWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, string jobId, string resourceGroupName, string dataManagerName, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels the given job.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The name of the data service of the job definition.
        /// </param>
        /// <param name='jobDefinitionName'>
        /// The name of the job definition of the job.
        /// </param>
        /// <param name='jobId'>
        /// The job id of the job queried.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> CancelWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, string jobId, string resourceGroupName, string dataManagerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resumes the given job.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The name of the data service of the job definition.
        /// </param>
        /// <param name='jobDefinitionName'>
        /// The name of the job definition of the job.
        /// </param>
        /// <param name='jobId'>
        /// The job id of the job queried.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> ResumeWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, string jobId, string resourceGroupName, string dataManagerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method gets all the jobs of a data service type in a given
        /// resource.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The name of the data service of interest.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
        /// </param>
        /// <param name='filter'>
        /// OData Filter options
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<JobList>> ListByDataServiceWithHttpMessagesAsync(string dataServiceName, string resourceGroupName, string dataManagerName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method gets all the jobs at the data manager resource level.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
        /// </param>
        /// <param name='filter'>
        /// OData Filter options
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<JobList>> ListByDataManagerWithHttpMessagesAsync(string resourceGroupName, string dataManagerName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
