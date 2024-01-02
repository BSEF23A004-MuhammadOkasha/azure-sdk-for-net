// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The check policy restrictions parameters describing the resource that is being evaluated. </summary>
    public partial class CheckPolicyRestrictionsContent
    {
        /// <summary> Initializes a new instance of <see cref="CheckPolicyRestrictionsContent"/>. </summary>
        /// <param name="resourceDetails"> The information about the resource that will be evaluated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceDetails"/> is null. </exception>
        public CheckPolicyRestrictionsContent(CheckRestrictionsResourceDetails resourceDetails)
        {
            Argument.AssertNotNull(resourceDetails, nameof(resourceDetails));

            ResourceDetails = resourceDetails;
            PendingFields = new ChangeTrackingList<PendingField>();
        }

        /// <summary> Initializes a new instance of <see cref="CheckPolicyRestrictionsContent"/>. </summary>
        /// <param name="resourceDetails"> The information about the resource that will be evaluated. </param>
        /// <param name="pendingFields"> The list of fields and values that should be evaluated for potential restrictions. </param>
        internal CheckPolicyRestrictionsContent(CheckRestrictionsResourceDetails resourceDetails, IList<PendingField> pendingFields)
        {
            ResourceDetails = resourceDetails;
            PendingFields = pendingFields;
        }

        /// <summary> The information about the resource that will be evaluated. </summary>
        public CheckRestrictionsResourceDetails ResourceDetails { get; }
        /// <summary> The list of fields and values that should be evaluated for potential restrictions. </summary>
        public IList<PendingField> PendingFields { get; }
    }
}
