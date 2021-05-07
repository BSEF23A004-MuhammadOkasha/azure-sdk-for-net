﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.ResourceManager.Core
{
    /// <summary>
    /// A class representing collection of resources and their operations over their parent.
    /// </summary>
    /// <typeparam name="TIdentifier"> The type of the resource identifier. </typeparam>
    /// <typeparam name="TOperations"> The type of the class containing operations for the underlying resource. </typeparam>
    /// <typeparam name="TResource"> The type of the class containing properties for the underlying resource. </typeparam>
    public abstract class ResourceContainerBase<TIdentifier, TOperations, TResource> : ContainerBase<TIdentifier, TOperations>
        where TIdentifier : TenantResourceIdentifier
        where TOperations : ResourceOperationsBase<TIdentifier, TOperations>
        where TResource : class
    {
        private static readonly object _parentLock = new object();
        private object _parentResource;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceContainerBase{TIdentifier, TOperations, TResource}"/> class for mocking.
        /// </summary>
        protected ResourceContainerBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceContainerBase{TIdentifier, TOperations, TData}"/> class.
        /// </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        protected ResourceContainerBase(ResourceOperationsBase parent)
            : base(parent)
        {
        }

        /// <summary>
        /// Verify that the input resource Id is a valid container for this type.
        /// </summary>
        /// <param name="identifier"> The input resource Id to check. </param>
        /// <exception cref="InvalidOperationException"> Resource identifier is not a valid type for this container. </exception>
        protected override void Validate(ResourceIdentifier identifier)
        {
            if (identifier.ResourceType != ValidResourceType)
                throw new InvalidOperationException($"{identifier.ResourceType} is not a valid container for {Id.ResourceType}");
        }

        /// <summary>
        /// Gets the location of the parent object.
        /// </summary>
        /// <typeparam name="TParent"> The type of the parents full resource object. </typeparam>
        /// <typeparam name="TParentId"> The type of the parents resource id. </typeparam>
        /// <typeparam name="TParentOperations"> The type of the parents operations object. </typeparam>
        /// <returns> The <see cref="LocationData"/> associated with the parent object. </returns>
        protected TParent GetParentResource<TParent, TParentId, TParentOperations>()
            where TParent : TParentOperations
            where TParentOperations : ResourceOperationsBase<TParentId, TParent>
            where TParentId : ResourceIdentifier
        {
            if (_parentResource is null)
            {
                lock (_parentLock)
                {
                    if (_parentResource is null)
                    {
                        _parentResource = Parent as TParent;
                        if (_parentResource is null)
                        {
                            _parentResource = (Parent as TParentOperations).Get().Value;
                        }
                    }
                }
            }

            return _parentResource as TParent;
        }

        /// <summary>
        /// Gets details for this resource from the service.
        /// </summary>
        /// <param name="resourceName"> The name of the resource to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A response with the <see cref="ArmResponse{TOperations}"/> operation for this resource. </returns>
        /// <exception cref="ArgumentException"> resourceName cannot be null or a whitespace. </exception>
        public abstract ArmResponse<TOperations> Get(string resourceName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets details for this resource from the service.
        /// </summary>
        /// <param name="resourceName"> The name of the resource to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A <see cref="Task"/> that on completion returns a response with the <see cref="ArmResponse{TOperations}"/> operation for this resource. </returns>
        /// <exception cref="ArgumentException"> resourceName cannot be null or a whitespace. </exception>
        public abstract Task<ArmResponse<TOperations>> GetAsync(string resourceName, CancellationToken cancellationToken = default);
    }
}
