// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    /// <summary> The response model for the successful Stateset Get API. </summary>
    public partial class StatesetGetResponse
    {
        /// <summary> Initializes a new instance of StatesetGetResponse. </summary>
        internal StatesetGetResponse()
        {
            DatasetIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of StatesetGetResponse. </summary>
        /// <param name="description"> Description associated with the stateset. </param>
        /// <param name="datasetIds"> Dataset ID associated with the stateset. </param>
        /// <param name="statesetStyle"> The styles model. </param>
        internal StatesetGetResponse(string description, IReadOnlyList<string> datasetIds, StylesObject statesetStyle)
        {
            Description = description;
            DatasetIds = datasetIds;
            StatesetStyle = statesetStyle;
        }

        /// <summary> Description associated with the stateset. </summary>
        public string Description { get; }
        /// <summary> Dataset ID associated with the stateset. </summary>
        public IReadOnlyList<string> DatasetIds { get; }
        /// <summary> The styles model. </summary>
        public StylesObject StatesetStyle { get; }
    }
}
