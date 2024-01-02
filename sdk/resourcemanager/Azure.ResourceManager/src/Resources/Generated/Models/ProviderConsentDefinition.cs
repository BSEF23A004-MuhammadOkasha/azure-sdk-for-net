// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The provider consent. </summary>
    internal partial class ProviderConsentDefinition
    {
        /// <summary> Initializes a new instance of <see cref="ProviderConsentDefinition"/>. </summary>
        public ProviderConsentDefinition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProviderConsentDefinition"/>. </summary>
        /// <param name="consentToAuthorization"> A value indicating whether authorization is consented or not. </param>
        internal ProviderConsentDefinition(bool? consentToAuthorization)
        {
            ConsentToAuthorization = consentToAuthorization;
        }

        /// <summary> A value indicating whether authorization is consented or not. </summary>
        public bool? ConsentToAuthorization { get; set; }
    }
}
