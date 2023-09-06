// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the safety profile of the Gallery Image Version. </summary>
    public partial class GalleryImageVersionSafetyProfile : GalleryArtifactSafetyProfileBase
    {
        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionSafetyProfile"/>. </summary>
        public GalleryImageVersionSafetyProfile()
        {
            PolicyViolations = new ChangeTrackingList<GalleryImageVersionPolicyViolation>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionSafetyProfile"/>. </summary>
        /// <param name="allowDeletionOfReplicatedLocations"> Indicates whether or not removing this Gallery Image Version from replicated regions is allowed. </param>
        /// <param name="isReportedForPolicyViolation"> Indicates whether this image has been reported as violating Microsoft's policies. </param>
        /// <param name="policyViolations"> A list of Policy Violations that have been reported for this Gallery Image Version. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryImageVersionSafetyProfile(bool? allowDeletionOfReplicatedLocations, bool? isReportedForPolicyViolation, IReadOnlyList<GalleryImageVersionPolicyViolation> policyViolations, Dictionary<string, BinaryData> rawData) : base(allowDeletionOfReplicatedLocations, rawData)
        {
            IsReportedForPolicyViolation = isReportedForPolicyViolation;
            PolicyViolations = policyViolations;
        }

        /// <summary> Indicates whether this image has been reported as violating Microsoft's policies. </summary>
        public bool? IsReportedForPolicyViolation { get; }
        /// <summary> A list of Policy Violations that have been reported for this Gallery Image Version. </summary>
        public IReadOnlyList<GalleryImageVersionPolicyViolation> PolicyViolations { get; }
    }
}
