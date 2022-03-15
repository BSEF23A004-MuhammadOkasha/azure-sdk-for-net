// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Configuration settings for Docker build context. </summary>
    public partial class BuildContext
    {
        /// <summary> Initializes a new instance of BuildContext. </summary>
        /// <param name="contextUri">
        /// URI of the Docker build context used to build the image. Supports blob URIs on environment creation and may return blob or Git URIs.
        /// &lt;seealso href=&quot;https://docs.docker.com/engine/reference/commandline/build/#extended-description&quot; /&gt;
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contextUri"/> is null. </exception>
        public BuildContext(Uri contextUri)
        {
            if (contextUri == null)
            {
                throw new ArgumentNullException(nameof(contextUri));
            }

            ContextUri = contextUri;
        }

        /// <summary> Initializes a new instance of BuildContext. </summary>
        /// <param name="contextUri">
        /// URI of the Docker build context used to build the image. Supports blob URIs on environment creation and may return blob or Git URIs.
        /// &lt;seealso href=&quot;https://docs.docker.com/engine/reference/commandline/build/#extended-description&quot; /&gt;
        /// </param>
        /// <param name="dockerfilePath">
        /// Path to the Dockerfile in the build context.
        /// &lt;seealso href=&quot;https://docs.docker.com/engine/reference/builder/&quot; /&gt;
        /// </param>
        internal BuildContext(Uri contextUri, string dockerfilePath)
        {
            ContextUri = contextUri;
            DockerfilePath = dockerfilePath;
        }

        /// <summary>
        /// URI of the Docker build context used to build the image. Supports blob URIs on environment creation and may return blob or Git URIs.
        /// &lt;seealso href=&quot;https://docs.docker.com/engine/reference/commandline/build/#extended-description&quot; /&gt;
        /// </summary>
        public Uri ContextUri { get; set; }
        /// <summary>
        /// Path to the Dockerfile in the build context.
        /// &lt;seealso href=&quot;https://docs.docker.com/engine/reference/builder/&quot; /&gt;
        /// </summary>
        public string DockerfilePath { get; set; }
    }
}
