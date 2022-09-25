// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ProviderHubMetadataProviderAuthentication. </summary>
    internal partial class ProviderHubMetadataProviderAuthentication : ResourceProviderAuthentication
    {
        /// <summary> Initializes a new instance of ProviderHubMetadataProviderAuthentication. </summary>
        /// <param name="allowedAudiences"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowedAudiences"/> is null. </exception>
        public ProviderHubMetadataProviderAuthentication(IEnumerable<string> allowedAudiences) : base(allowedAudiences)
        {
            if (allowedAudiences == null)
            {
                throw new ArgumentNullException(nameof(allowedAudiences));
            }
        }

        /// <summary> Initializes a new instance of ProviderHubMetadataProviderAuthentication. </summary>
        /// <param name="allowedAudiences"></param>
        internal ProviderHubMetadataProviderAuthentication(IList<string> allowedAudiences) : base(allowedAudiences)
        {
        }
    }
}
