// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    /// <summary> Enables a media graph to publish messages that can be delivered via routes declared in the IoT Edge deployment manifest. </summary>
    public partial class MediaGraphIoTHubMessageSink : MediaGraphSink
    {
        /// <summary> Initializes a new instance of MediaGraphIoTHubMessageSink. </summary>
        /// <param name="name"> The name to be used for the media graph sink. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this sink node. </param>
        /// <param name="hubOutputName"> Name of the output path to which the media graph will publish message. These messages can then be delivered to desired destinations by declaring routes referencing the output path in the IoT Edge deployment manifest. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="inputs"/>, or <paramref name="hubOutputName"/> is null. </exception>
        public MediaGraphIoTHubMessageSink(string name, IEnumerable<MediaGraphNodeInput> inputs, string hubOutputName) : base(name, inputs)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }
            if (hubOutputName == null)
            {
                throw new ArgumentNullException(nameof(hubOutputName));
            }

            HubOutputName = hubOutputName;
            Type = "#Microsoft.Media.MediaGraphIoTHubMessageSink";
        }

        /// <summary> Initializes a new instance of MediaGraphIoTHubMessageSink. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="name"> The name to be used for the media graph sink. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this sink node. </param>
        /// <param name="hubOutputName"> Name of the output path to which the media graph will publish message. These messages can then be delivered to desired destinations by declaring routes referencing the output path in the IoT Edge deployment manifest. </param>
        internal MediaGraphIoTHubMessageSink(string type, string name, IList<MediaGraphNodeInput> inputs, string hubOutputName) : base(type, name, inputs)
        {
            HubOutputName = hubOutputName;
            Type = type ?? "#Microsoft.Media.MediaGraphIoTHubMessageSink";
        }

        /// <summary> Name of the output path to which the media graph will publish message. These messages can then be delivered to desired destinations by declaring routes referencing the output path in the IoT Edge deployment manifest. </summary>
        public string HubOutputName { get; set; }
    }
}
