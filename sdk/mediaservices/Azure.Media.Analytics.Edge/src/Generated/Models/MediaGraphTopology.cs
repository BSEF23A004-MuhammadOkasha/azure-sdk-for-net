// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> The definition of a media graph topology. </summary>
    public partial class MediaGraphTopology
    {
        /// <summary> Initializes a new instance of MediaGraphTopology. </summary>
        /// <param name="name"> The identifier for the media graph topology. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public MediaGraphTopology(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of MediaGraphTopology. </summary>
        /// <param name="name"> The identifier for the media graph topology. </param>
        /// <param name="systemData"> The system data for a resource. This is used by both topologies and instances. </param>
        /// <param name="properties"> A description of the properties of a media graph topology. </param>
        internal MediaGraphTopology(string name, MediaGraphSystemData systemData, MediaGraphTopologyProperties properties)
        {
            Name = name;
            SystemData = systemData;
            Properties = properties;
        }

        /// <summary> The identifier for the media graph topology. </summary>
        public string Name { get; set; }
        /// <summary> The system data for a resource. This is used by both topologies and instances. </summary>
        public MediaGraphSystemData SystemData { get; set; }
        /// <summary> A description of the properties of a media graph topology. </summary>
        public MediaGraphTopologyProperties Properties { get; set; }
    }
}
