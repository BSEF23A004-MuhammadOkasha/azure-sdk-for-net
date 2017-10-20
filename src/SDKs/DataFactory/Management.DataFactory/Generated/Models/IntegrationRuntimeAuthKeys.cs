// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The integration runtime authentication keys.
    /// </summary>
    public partial class IntegrationRuntimeAuthKeys
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeAuthKeys class.
        /// </summary>
        public IntegrationRuntimeAuthKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeAuthKeys class.
        /// </summary>
        /// <param name="authKey1">The primary integration runtime
        /// authentication key.</param>
        /// <param name="authKey2">The secondary integration runtime
        /// authentication key.</param>
        public IntegrationRuntimeAuthKeys(string authKey1 = default(string), string authKey2 = default(string))
        {
            AuthKey1 = authKey1;
            AuthKey2 = authKey2;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the primary integration runtime authentication key.
        /// </summary>
        [JsonProperty(PropertyName = "authKey1")]
        public string AuthKey1 { get; set; }

        /// <summary>
        /// Gets or sets the secondary integration runtime authentication key.
        /// </summary>
        [JsonProperty(PropertyName = "authKey2")]
        public string AuthKey2 { get; set; }

    }
}
