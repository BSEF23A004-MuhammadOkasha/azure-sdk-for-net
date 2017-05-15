// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input definition for test failover cleanup input properties.
    /// </summary>
    public partial class TestFailoverCleanupInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TestFailoverCleanupInputProperties class.
        /// </summary>
        public TestFailoverCleanupInputProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TestFailoverCleanupInputProperties class.
        /// </summary>
        /// <param name="comments">Test failover cleanup comments.</param>
        public TestFailoverCleanupInputProperties(string comments = default(string))
        {
            Comments = comments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets test failover cleanup comments.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

    }
}
