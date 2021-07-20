// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Creator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This object is returned from a successful Great Circle Distance call
    /// </summary>
    public partial class GreatCircleDistanceResponse
    {
        /// <summary>
        /// Initializes a new instance of the GreatCircleDistanceResponse
        /// class.
        /// </summary>
        public GreatCircleDistanceResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GreatCircleDistanceResponse
        /// class.
        /// </summary>
        /// <param name="summary">Summary object</param>
        /// <param name="result">Result Object</param>
        public GreatCircleDistanceResponse(GreatCircleDistanceResponseSummary summary = default(GreatCircleDistanceResponseSummary), GreatCircleDistanceResponseResult result = default(GreatCircleDistanceResponseResult))
        {
            Summary = summary;
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets summary object
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public GreatCircleDistanceResponseSummary Summary { get; private set; }

        /// <summary>
        /// Gets result Object
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public GreatCircleDistanceResponseResult Result { get; private set; }

    }
}
