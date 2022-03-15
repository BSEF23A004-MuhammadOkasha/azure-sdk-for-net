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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    internal partial class TenantExtensionClient : ArmResource
    {
        private ClientDiagnostics _deploymentClientDiagnostics;
        private DeploymentsRestOperations _deploymentRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantExtensionClient"/> class for mocking. </summary>
        protected TenantExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DeploymentClientDiagnostics => _deploymentClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Resources", Deployment.ResourceType.Namespace, DiagnosticOptions);
        private DeploymentsRestOperations DeploymentRestClient => _deploymentRestClient ??= new DeploymentsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(Deployment.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of Deployments in the Deployment. </summary>
        /// <returns> An object representing collection of Deployments and their operations over a Deployment. </returns>
        public virtual DeploymentCollection GetDeployments()
        {
            return new DeploymentCollection(Client, Id);
        }

        /// <summary>
        /// Calculate the hash of the given template.
        /// Request Path: /providers/Microsoft.Resources/calculateTemplateHash
        /// Operation Id: Deployments_CalculateTemplateHash
        /// </summary>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TemplateHashResult>> CalculateTemplateHashDeploymentAsync(object template, CancellationToken cancellationToken = default)
        {
            using var scope = DeploymentClientDiagnostics.CreateScope("TenantExtensionClient.CalculateTemplateHashDeployment");
            scope.Start();
            try
            {
                var response = await DeploymentRestClient.CalculateTemplateHashAsync(template, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Calculate the hash of the given template.
        /// Request Path: /providers/Microsoft.Resources/calculateTemplateHash
        /// Operation Id: Deployments_CalculateTemplateHash
        /// </summary>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TemplateHashResult> CalculateTemplateHashDeployment(object template, CancellationToken cancellationToken = default)
        {
            using var scope = DeploymentClientDiagnostics.CreateScope("TenantExtensionClient.CalculateTemplateHashDeployment");
            scope.Start();
            try
            {
                var response = DeploymentRestClient.CalculateTemplateHash(template, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
