// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The List Aml user feature operation response. </summary>
    internal partial class ListAmlUserFeatureResult
    {
        /// <summary> Initializes a new instance of <see cref="ListAmlUserFeatureResult"/>. </summary>
        internal ListAmlUserFeatureResult()
        {
            Value = new ChangeTrackingList<MachineLearningUserFeature>();
        }

        /// <summary> Initializes a new instance of <see cref="ListAmlUserFeatureResult"/>. </summary>
        /// <param name="value"> The list of AML user facing features. </param>
        /// <param name="nextLink"> The URI to fetch the next page of AML user features information. Call ListNext() with this to fetch the next page of AML user features information. </param>
        internal ListAmlUserFeatureResult(IReadOnlyList<MachineLearningUserFeature> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of AML user facing features. </summary>
        public IReadOnlyList<MachineLearningUserFeature> Value { get; }
        /// <summary> The URI to fetch the next page of AML user features information. Call ListNext() with this to fetch the next page of AML user features information. </summary>
        public string NextLink { get; }
    }
}
