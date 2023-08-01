// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    internal partial class MachineLearningArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MachineLearningArmClientMockingExtension"/> class for mocking. </summary>
        protected MachineLearningArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MachineLearningArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningWorkspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningWorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningWorkspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningWorkspaceResource" /> object. </returns>
        public virtual MachineLearningWorkspaceResource GetMachineLearningWorkspaceResource(ResourceIdentifier id)
        {
            MachineLearningWorkspaceResource.ValidateResourceId(id);
            return new MachineLearningWorkspaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningComputeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningComputeResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningComputeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningComputeResource" /> object. </returns>
        public virtual MachineLearningComputeResource GetMachineLearningComputeResource(ResourceIdentifier id)
        {
            MachineLearningComputeResource.ValidateResourceId(id);
            return new MachineLearningComputeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningPrivateEndpointConnectionResource" /> object. </returns>
        public virtual MachineLearningPrivateEndpointConnectionResource GetMachineLearningPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            MachineLearningPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new MachineLearningPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningWorkspaceConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningWorkspaceConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningWorkspaceConnectionResource" /> object. </returns>
        public virtual MachineLearningWorkspaceConnectionResource GetMachineLearningWorkspaceConnectionResource(ResourceIdentifier id)
        {
            MachineLearningWorkspaceConnectionResource.ValidateResourceId(id);
            return new MachineLearningWorkspaceConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningBatchEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningBatchEndpointResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningBatchEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningBatchEndpointResource" /> object. </returns>
        public virtual MachineLearningBatchEndpointResource GetMachineLearningBatchEndpointResource(ResourceIdentifier id)
        {
            MachineLearningBatchEndpointResource.ValidateResourceId(id);
            return new MachineLearningBatchEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningBatchDeploymentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningBatchDeploymentResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningBatchDeploymentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningBatchDeploymentResource" /> object. </returns>
        public virtual MachineLearningBatchDeploymentResource GetMachineLearningBatchDeploymentResource(ResourceIdentifier id)
        {
            MachineLearningBatchDeploymentResource.ValidateResourceId(id);
            return new MachineLearningBatchDeploymentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningCodeContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningCodeContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningCodeContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningCodeContainerResource" /> object. </returns>
        public virtual MachineLearningCodeContainerResource GetMachineLearningCodeContainerResource(ResourceIdentifier id)
        {
            MachineLearningCodeContainerResource.ValidateResourceId(id);
            return new MachineLearningCodeContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningCodeVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningCodeVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningCodeVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningCodeVersionResource" /> object. </returns>
        public virtual MachineLearningCodeVersionResource GetMachineLearningCodeVersionResource(ResourceIdentifier id)
        {
            MachineLearningCodeVersionResource.ValidateResourceId(id);
            return new MachineLearningCodeVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningComponentContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningComponentContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningComponentContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningComponentContainerResource" /> object. </returns>
        public virtual MachineLearningComponentContainerResource GetMachineLearningComponentContainerResource(ResourceIdentifier id)
        {
            MachineLearningComponentContainerResource.ValidateResourceId(id);
            return new MachineLearningComponentContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningComponentVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningComponentVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningComponentVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningComponentVersionResource" /> object. </returns>
        public virtual MachineLearningComponentVersionResource GetMachineLearningComponentVersionResource(ResourceIdentifier id)
        {
            MachineLearningComponentVersionResource.ValidateResourceId(id);
            return new MachineLearningComponentVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningDataContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningDataContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningDataContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningDataContainerResource" /> object. </returns>
        public virtual MachineLearningDataContainerResource GetMachineLearningDataContainerResource(ResourceIdentifier id)
        {
            MachineLearningDataContainerResource.ValidateResourceId(id);
            return new MachineLearningDataContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningDataVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningDataVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningDataVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningDataVersionResource" /> object. </returns>
        public virtual MachineLearningDataVersionResource GetMachineLearningDataVersionResource(ResourceIdentifier id)
        {
            MachineLearningDataVersionResource.ValidateResourceId(id);
            return new MachineLearningDataVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningDatastoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningDatastoreResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningDatastoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningDatastoreResource" /> object. </returns>
        public virtual MachineLearningDatastoreResource GetMachineLearningDatastoreResource(ResourceIdentifier id)
        {
            MachineLearningDatastoreResource.ValidateResourceId(id);
            return new MachineLearningDatastoreResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningEnvironmentContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningEnvironmentContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningEnvironmentContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningEnvironmentContainerResource" /> object. </returns>
        public virtual MachineLearningEnvironmentContainerResource GetMachineLearningEnvironmentContainerResource(ResourceIdentifier id)
        {
            MachineLearningEnvironmentContainerResource.ValidateResourceId(id);
            return new MachineLearningEnvironmentContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningEnvironmentVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningEnvironmentVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningEnvironmentVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningEnvironmentVersionResource" /> object. </returns>
        public virtual MachineLearningEnvironmentVersionResource GetMachineLearningEnvironmentVersionResource(ResourceIdentifier id)
        {
            MachineLearningEnvironmentVersionResource.ValidateResourceId(id);
            return new MachineLearningEnvironmentVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningJobResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningJobResource" /> object. </returns>
        public virtual MachineLearningJobResource GetMachineLearningJobResource(ResourceIdentifier id)
        {
            MachineLearningJobResource.ValidateResourceId(id);
            return new MachineLearningJobResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningModelContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningModelContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningModelContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningModelContainerResource" /> object. </returns>
        public virtual MachineLearningModelContainerResource GetMachineLearningModelContainerResource(ResourceIdentifier id)
        {
            MachineLearningModelContainerResource.ValidateResourceId(id);
            return new MachineLearningModelContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningModelVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningModelVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningModelVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningModelVersionResource" /> object. </returns>
        public virtual MachineLearningModelVersionResource GetMachineLearningModelVersionResource(ResourceIdentifier id)
        {
            MachineLearningModelVersionResource.ValidateResourceId(id);
            return new MachineLearningModelVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningOnlineEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningOnlineEndpointResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningOnlineEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningOnlineEndpointResource" /> object. </returns>
        public virtual MachineLearningOnlineEndpointResource GetMachineLearningOnlineEndpointResource(ResourceIdentifier id)
        {
            MachineLearningOnlineEndpointResource.ValidateResourceId(id);
            return new MachineLearningOnlineEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningOnlineDeploymentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningOnlineDeploymentResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningOnlineDeploymentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningOnlineDeploymentResource" /> object. </returns>
        public virtual MachineLearningOnlineDeploymentResource GetMachineLearningOnlineDeploymentResource(ResourceIdentifier id)
        {
            MachineLearningOnlineDeploymentResource.ValidateResourceId(id);
            return new MachineLearningOnlineDeploymentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningScheduleResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningScheduleResource" /> object. </returns>
        public virtual MachineLearningScheduleResource GetMachineLearningScheduleResource(ResourceIdentifier id)
        {
            MachineLearningScheduleResource.ValidateResourceId(id);
            return new MachineLearningScheduleResource(Client, id);
        }
    }
}
