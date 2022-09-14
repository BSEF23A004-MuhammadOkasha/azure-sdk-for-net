// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary> TODO. </summary>
    public abstract partial class BaseSecurityRuleResource : ArmResource
    {
        internal static BaseSecurityRuleResource GetResource(ArmClient client, SecurityRuleData data)
        {
            if (IsSecurityRuleResource(data.Id))
            {
                return new SecurityRuleResource(client, data);
            }
            if (IsDefaultSecurityRuleResource(data.Id))
            {
                return new DefaultSecurityRuleResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsSecurityRuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SecurityRuleResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsDefaultSecurityRuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != DefaultSecurityRuleResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        private readonly SecurityRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="BaseSecurityRuleResource"/> class for mocking. </summary>
        protected BaseSecurityRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BaseSecurityRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BaseSecurityRuleResource(ArmClient client, SecurityRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BaseSecurityRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BaseSecurityRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityRuleData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        protected abstract Task<Response<BaseSecurityRuleResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<BaseSecurityRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken);
        }

        protected abstract Response<BaseSecurityRuleResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<BaseSecurityRuleResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
