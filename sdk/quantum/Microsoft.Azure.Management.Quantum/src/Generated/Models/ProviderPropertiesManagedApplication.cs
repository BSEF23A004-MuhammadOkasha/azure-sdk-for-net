// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quantum.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Provider's Managed-Application info
    /// </summary>
    public partial class ProviderPropertiesManagedApplication
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ProviderPropertiesManagedApplication class.
        /// </summary>
        public ProviderPropertiesManagedApplication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ProviderPropertiesManagedApplication class.
        /// </summary>
        /// <param name="publisherId">Provider's publisher id.</param>
        /// <param name="offerId">Provider's offer id.</param>
        public ProviderPropertiesManagedApplication(string publisherId = default(string), string offerId = default(string))
        {
            PublisherId = publisherId;
            OfferId = offerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provider's publisher id.
        /// </summary>
        [JsonProperty(PropertyName = "publisherId")]
        public string PublisherId { get; private set; }

        /// <summary>
        /// Gets provider's offer id.
        /// </summary>
        [JsonProperty(PropertyName = "offerId")]
        public string OfferId { get; private set; }

    }
}
