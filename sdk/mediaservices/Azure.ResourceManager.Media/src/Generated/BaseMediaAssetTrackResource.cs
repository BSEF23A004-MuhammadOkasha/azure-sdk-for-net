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

namespace Azure.ResourceManager.Media
{
    /// <summary> TODO. </summary>
    public abstract partial class BaseMediaAssetTrackResource : ArmResource
    {
        internal static BaseMediaAssetTrackResource GetResource(ArmClient client, MediaAssetTrackData data)
        {
            if (IsMediaAssetTrackResource(data.Id))
            {
                return new MediaAssetTrackResource(client, data);
            }
            if (IsMediaAssetTrackOperationResultResource(data.Id))
            {
                return new MediaAssetTrackOperationResultResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsMediaAssetTrackResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != MediaAssetTrackResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsMediaAssetTrackOperationResultResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != MediaAssetTrackOperationResultResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        private readonly MediaAssetTrackData _data;

        /// <summary> Initializes a new instance of the <see cref="BaseMediaAssetTrackResource"/> class for mocking. </summary>
        protected BaseMediaAssetTrackResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BaseMediaAssetTrackResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BaseMediaAssetTrackResource(ArmClient client, MediaAssetTrackData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BaseMediaAssetTrackResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BaseMediaAssetTrackResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MediaAssetTrackData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        protected abstract Task<Response<BaseMediaAssetTrackResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<BaseMediaAssetTrackResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken);
        }

        protected abstract Response<BaseMediaAssetTrackResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<BaseMediaAssetTrackResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
