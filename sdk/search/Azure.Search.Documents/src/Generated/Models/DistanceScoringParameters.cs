// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> Provides parameter values to a distance scoring function. </summary>
    public partial class DistanceScoringParameters
    {
        /// <summary> Initializes a new instance of DistanceScoringParameters. </summary>
        public DistanceScoringParameters()
        {
        }

        /// <summary> Initializes a new instance of DistanceScoringParameters. </summary>
        /// <param name="referencePointParameter"> The name of the parameter passed in search queries to specify the reference location. </param>
        /// <param name="boostingDistance"> The distance in kilometers from the reference location where the boosting range ends. </param>
        internal DistanceScoringParameters(string referencePointParameter, double boostingDistance)
        {
            ReferencePointParameter = referencePointParameter;
            BoostingDistance = boostingDistance;
        }

        /// <summary> The name of the parameter passed in search queries to specify the reference location. </summary>
        public string ReferencePointParameter { get; set; }
        /// <summary> The distance in kilometers from the reference location where the boosting range ends. </summary>
        public double BoostingDistance { get; set; }
    }
}
