// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableResourcesArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableResourcesArmClient"/> class for mocking. </summary>
        protected MockableResourcesArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableResourcesArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableResourcesArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableResourcesArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DataBoundaryResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of DataBoundaryResources and their operations over a DataBoundaryResource. </returns>
        public virtual DataBoundaryCollection GetDataBoundaries(ResourceIdentifier scope)
        {
            return new DataBoundaryCollection(Client, scope);
        }

        /// <summary>
        /// Get data boundary at specified scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Resources/dataBoundaries/{default}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataBoundaries_GetScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoundaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="name"> Default string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataBoundaryResource>> GetDataBoundaryAsync(ResourceIdentifier scope, DataBoundaryName name, CancellationToken cancellationToken = default)
        {
            return await GetDataBoundaries(scope).GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get data boundary at specified scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Resources/dataBoundaries/{default}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataBoundaries_GetScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoundaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="name"> Default string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<DataBoundaryResource> GetDataBoundary(ResourceIdentifier scope, DataBoundaryName name, CancellationToken cancellationToken = default)
        {
            return GetDataBoundaries(scope).Get(name, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TemplateSpecResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TemplateSpecResource.CreateResourceIdentifier" /> to create a <see cref="TemplateSpecResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TemplateSpecResource"/> object. </returns>
        public virtual TemplateSpecResource GetTemplateSpecResource(ResourceIdentifier id)
        {
            TemplateSpecResource.ValidateResourceId(id);
            return new TemplateSpecResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TemplateSpecVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TemplateSpecVersionResource.CreateResourceIdentifier" /> to create a <see cref="TemplateSpecVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TemplateSpecVersionResource"/> object. </returns>
        public virtual TemplateSpecVersionResource GetTemplateSpecVersionResource(ResourceIdentifier id)
        {
            TemplateSpecVersionResource.ValidateResourceId(id);
            return new TemplateSpecVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ArmDeploymentScriptResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ArmDeploymentScriptResource.CreateResourceIdentifier" /> to create an <see cref="ArmDeploymentScriptResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArmDeploymentScriptResource"/> object. </returns>
        public virtual ArmDeploymentScriptResource GetArmDeploymentScriptResource(ResourceIdentifier id)
        {
            ArmDeploymentScriptResource.ValidateResourceId(id);
            return new ArmDeploymentScriptResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ScriptLogResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScriptLogResource.CreateResourceIdentifier" /> to create a <see cref="ScriptLogResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScriptLogResource"/> object. </returns>
        public virtual ScriptLogResource GetScriptLogResource(ResourceIdentifier id)
        {
            ScriptLogResource.ValidateResourceId(id);
            return new ScriptLogResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ArmDeploymentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ArmDeploymentResource.CreateResourceIdentifier" /> to create an <see cref="ArmDeploymentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArmDeploymentResource"/> object. </returns>
        public virtual ArmDeploymentResource GetArmDeploymentResource(ResourceIdentifier id)
        {
            ArmDeploymentResource.ValidateResourceId(id);
            return new ArmDeploymentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ArmApplicationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ArmApplicationResource.CreateResourceIdentifier" /> to create an <see cref="ArmApplicationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArmApplicationResource"/> object. </returns>
        public virtual ArmApplicationResource GetArmApplicationResource(ResourceIdentifier id)
        {
            ArmApplicationResource.ValidateResourceId(id);
            return new ArmApplicationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ArmApplicationDefinitionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ArmApplicationDefinitionResource.CreateResourceIdentifier" /> to create an <see cref="ArmApplicationDefinitionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArmApplicationDefinitionResource"/> object. </returns>
        public virtual ArmApplicationDefinitionResource GetArmApplicationDefinitionResource(ResourceIdentifier id)
        {
            ArmApplicationDefinitionResource.ValidateResourceId(id);
            return new ArmApplicationDefinitionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="JitRequestResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="JitRequestResource.CreateResourceIdentifier" /> to create a <see cref="JitRequestResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="JitRequestResource"/> object. </returns>
        public virtual JitRequestResource GetJitRequestResource(ResourceIdentifier id)
        {
            JitRequestResource.ValidateResourceId(id);
            return new JitRequestResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeploymentStackResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeploymentStackResource.CreateResourceIdentifier" /> to create a <see cref="DeploymentStackResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeploymentStackResource"/> object. </returns>
        public virtual DeploymentStackResource GetDeploymentStackResource(ResourceIdentifier id)
        {
            DeploymentStackResource.ValidateResourceId(id);
            return new DeploymentStackResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TenantDataBoundaryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TenantDataBoundaryResource.CreateResourceIdentifier" /> to create a <see cref="TenantDataBoundaryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TenantDataBoundaryResource"/> object. </returns>
        public virtual TenantDataBoundaryResource GetTenantDataBoundaryResource(ResourceIdentifier id)
        {
            TenantDataBoundaryResource.ValidateResourceId(id);
            return new TenantDataBoundaryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataBoundaryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoundaryResource.CreateResourceIdentifier" /> to create a <see cref="DataBoundaryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoundaryResource"/> object. </returns>
        public virtual DataBoundaryResource GetDataBoundaryResource(ResourceIdentifier id)
        {
            DataBoundaryResource.ValidateResourceId(id);
            return new DataBoundaryResource(Client, id);
        }
    }
}
