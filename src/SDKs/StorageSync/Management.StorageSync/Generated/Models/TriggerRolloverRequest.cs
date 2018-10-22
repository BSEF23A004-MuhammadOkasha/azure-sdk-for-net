// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Trigger Rollover Request.
    /// </summary>
    public partial class TriggerRolloverRequest
    {
        /// <summary>
        /// Initializes a new instance of the TriggerRolloverRequest class.
        /// </summary>
        public TriggerRolloverRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TriggerRolloverRequest class.
        /// </summary>
        /// <param name="certificateData">Certificate Data</param>
        public TriggerRolloverRequest(string certificateData = default(string))
        {
            CertificateData = certificateData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificate Data
        /// </summary>
        [JsonProperty(PropertyName = "certificateData")]
        public string CertificateData { get; set; }

    }
}
