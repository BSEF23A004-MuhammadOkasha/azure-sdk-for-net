// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure VM (Mercury) workload-specific backup policy.
    /// </summary>
    public partial class GenericProtectionPolicy : ProtectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the GenericProtectionPolicy class.
        /// </summary>
        public GenericProtectionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenericProtectionPolicy class.
        /// </summary>
        /// <param name="protectedItemsCount">Number of items associated with
        /// this policy.</param>
        /// <param name="resourceGuardOperationRequests">ResourceGuard
        /// Operation Requests</param>
        /// <param name="subProtectionPolicy">List of sub-protection policies
        /// which includes schedule and retention</param>
        /// <param name="timeZone">TimeZone optional input as string. For
        /// example: TimeZone = "Pacific Standard Time".</param>
        /// <param name="fabricName">Name of this policy's fabric.</param>
        public GenericProtectionPolicy(int? protectedItemsCount = default(int?), IList<string> resourceGuardOperationRequests = default(IList<string>), IList<SubProtectionPolicy> subProtectionPolicy = default(IList<SubProtectionPolicy>), string timeZone = default(string), string fabricName = default(string))
            : base(protectedItemsCount, resourceGuardOperationRequests)
        {
            SubProtectionPolicy = subProtectionPolicy;
            TimeZone = timeZone;
            FabricName = fabricName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of sub-protection policies which includes
        /// schedule and retention
        /// </summary>
        [JsonProperty(PropertyName = "subProtectionPolicy")]
        public IList<SubProtectionPolicy> SubProtectionPolicy { get; set; }

        /// <summary>
        /// Gets or sets timeZone optional input as string. For example:
        /// TimeZone = "Pacific Standard Time".
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets name of this policy's fabric.
        /// </summary>
        [JsonProperty(PropertyName = "fabricName")]
        public string FabricName { get; set; }

    }
}
