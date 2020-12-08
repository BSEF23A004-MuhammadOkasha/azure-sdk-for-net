// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    /// <summary> A processor that allows the media graph to send video frames to an external inference container over a gRPC connection. This can be done using shared memory (for high frame rates), or over the network. Inference results are relayed to downstream nodes. </summary>
    public partial class MediaGraphGrpcExtension : MediaGraphExtensionProcessorBase
    {
        /// <summary> Initializes a new instance of MediaGraphGrpcExtension. </summary>
        /// <param name="name"> The name for this processor node. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this processor node. </param>
        /// <param name="endpoint"> Endpoint to which this processor should connect. </param>
        /// <param name="image"> Describes the parameters of the image that is sent as input to the endpoint. </param>
        /// <param name="dataTransfer"> How media should be transferred to the inference engine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="inputs"/>, <paramref name="endpoint"/>, <paramref name="image"/>, or <paramref name="dataTransfer"/> is null. </exception>
        public MediaGraphGrpcExtension(string name, IEnumerable<MediaGraphNodeInput> inputs, MediaGraphEndpoint endpoint, MediaGraphImage image, MediaGraphGrpcExtensionDataTransfer dataTransfer) : base(name, inputs, endpoint, image)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image));
            }
            if (dataTransfer == null)
            {
                throw new ArgumentNullException(nameof(dataTransfer));
            }

            DataTransfer = dataTransfer;
            Type = "#Microsoft.Media.MediaGraphGrpcExtension";
        }

        /// <summary> Initializes a new instance of MediaGraphGrpcExtension. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="name"> The name for this processor node. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this processor node. </param>
        /// <param name="endpoint"> Endpoint to which this processor should connect. </param>
        /// <param name="image"> Describes the parameters of the image that is sent as input to the endpoint. </param>
        /// <param name="samplingOptions"> Describes the sampling options to be applied when forwarding samples to the extension. </param>
        /// <param name="dataTransfer"> How media should be transferred to the inference engine. </param>
        /// <param name="extensionConfiguration"> Optional configuration to pass to the gRPC extension. </param>
        internal MediaGraphGrpcExtension(string type, string name, IList<MediaGraphNodeInput> inputs, MediaGraphEndpoint endpoint, MediaGraphImage image, MediaGraphSamplingOptions samplingOptions, MediaGraphGrpcExtensionDataTransfer dataTransfer, string extensionConfiguration) : base(type, name, inputs, endpoint, image, samplingOptions)
        {
            DataTransfer = dataTransfer;
            ExtensionConfiguration = extensionConfiguration;
            Type = type ?? "#Microsoft.Media.MediaGraphGrpcExtension";
        }

        /// <summary> How media should be transferred to the inference engine. </summary>
        public MediaGraphGrpcExtensionDataTransfer DataTransfer { get; set; }
        /// <summary> Optional configuration to pass to the gRPC extension. </summary>
        public string ExtensionConfiguration { get; set; }
    }
}
