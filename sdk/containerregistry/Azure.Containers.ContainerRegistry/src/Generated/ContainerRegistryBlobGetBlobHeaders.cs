// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class ContainerRegistryBlobGetBlobHeaders
    {
        private readonly Response _response;
        public ContainerRegistryBlobGetBlobHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The length of the requested blob content. </summary>
        public long? ContentLength => _response.Headers.TryGetValue("Content-Length", out long? value) ? value : null;
        /// <summary> Digest of the targeted content for the request. </summary>
        public string DockerContentDigest => _response.Headers.TryGetValue("Docker-Content-Digest", out string value) ? value : null;
        /// <summary> The location where the layer should be accessible. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}
