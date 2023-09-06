// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Traffic weight assigned to a revision. </summary>
    public partial class ContainerAppRevisionTrafficWeight
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppRevisionTrafficWeight"/>. </summary>
        public ContainerAppRevisionTrafficWeight()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppRevisionTrafficWeight"/>. </summary>
        /// <param name="revisionName"> Name of a revision. </param>
        /// <param name="weight"> Traffic weight assigned to a revision. </param>
        /// <param name="isLatestRevision"> Indicates that the traffic weight belongs to a latest stable revision. </param>
        /// <param name="label"> Associates a traffic label with a revision. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppRevisionTrafficWeight(string revisionName, int? weight, bool? isLatestRevision, string label, Dictionary<string, BinaryData> rawData)
        {
            RevisionName = revisionName;
            Weight = weight;
            IsLatestRevision = isLatestRevision;
            Label = label;
            _rawData = rawData;
        }

        /// <summary> Name of a revision. </summary>
        public string RevisionName { get; set; }
        /// <summary> Traffic weight assigned to a revision. </summary>
        public int? Weight { get; set; }
        /// <summary> Indicates that the traffic weight belongs to a latest stable revision. </summary>
        public bool? IsLatestRevision { get; set; }
        /// <summary> Associates a traffic label with a revision. </summary>
        public string Label { get; set; }
    }
}
