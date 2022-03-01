// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Allowed Audiences validation flow. </summary>
    internal partial class AllowedAudiencesValidation
    {
        /// <summary> Initializes a new instance of AllowedAudiencesValidation. </summary>
        public AllowedAudiencesValidation()
        {
            AllowedAudiences = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AllowedAudiencesValidation. </summary>
        /// <param name="allowedAudiences"> The configuration settings of the allowed list of audiences from which to validate the JWT token. </param>
        internal AllowedAudiencesValidation(IList<string> allowedAudiences)
        {
            AllowedAudiences = allowedAudiences;
        }

        /// <summary> The configuration settings of the allowed list of audiences from which to validate the JWT token. </summary>
        public IList<string> AllowedAudiences { get; }
    }
}
