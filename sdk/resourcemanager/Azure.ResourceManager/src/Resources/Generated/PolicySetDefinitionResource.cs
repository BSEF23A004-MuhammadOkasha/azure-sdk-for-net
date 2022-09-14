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

namespace Azure.ResourceManager.Resources
{
    /// <summary> TODO. </summary>
    public abstract partial class PolicySetDefinitionResource : ArmResource
    {
        internal static PolicySetDefinitionResource GetResource(ArmClient client, PolicySetDefinitionData data)
        {
            if (IsSubscriptionPolicySetDefinitionResource(data.Id))
            {
                return new SubscriptionPolicySetDefinitionResource(client, data);
            }
            if (IsTenantPolicySetDefinitionResource(data.Id))
            {
                return new TenantPolicySetDefinitionResource(client, data);
            }
            if (IsManagementGroupPolicySetDefinitionResource(data.Id))
            {
                return new ManagementGroupPolicySetDefinitionResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsSubscriptionPolicySetDefinitionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SubscriptionPolicySetDefinitionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.ResourceType != "Microsoft.Resources/subscriptions")
            {
                return false;
            }
            return true;
        }

        internal static bool IsTenantPolicySetDefinitionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != TenantPolicySetDefinitionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.ResourceType != "Microsoft.Resources/tenants")
            {
                return false;
            }
            return true;
        }

        internal static bool IsManagementGroupPolicySetDefinitionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ManagementGroupPolicySetDefinitionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.ResourceType != "Microsoft.Management/managementGroups")
            {
                return false;
            }
            return true;
        }

        private readonly PolicySetDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="PolicySetDefinitionResource"/> class for mocking. </summary>
        protected PolicySetDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PolicySetDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PolicySetDefinitionResource(ArmClient client, PolicySetDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PolicySetDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicySetDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicySetDefinitionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        protected abstract Task<Response<PolicySetDefinitionResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<PolicySetDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken);
        }

        protected abstract Response<PolicySetDefinitionResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<PolicySetDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
