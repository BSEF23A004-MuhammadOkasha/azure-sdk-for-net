// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DocumentDB.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DocumentDB;
    using Microsoft.Azure.Management.DocumentDB.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of new failover policies for the failover priority change.
    /// </summary>
    public partial class FailoverPolicies
    {
        /// <summary>
        /// Initializes a new instance of the FailoverPolicies class.
        /// </summary>
        public FailoverPolicies()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FailoverPolicies class.
        /// </summary>
        /// <param name="failoverPoliciesProperty">List of failover
        /// policies.</param>
        public FailoverPolicies(IList<FailoverPolicyInner> failoverPoliciesProperty = default(IList<FailoverPolicyInner>))
        {
            FailoverPoliciesProperty = failoverPoliciesProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of failover policies.
        /// </summary>
        [JsonProperty(PropertyName = "failoverPolicies")]
        public IList<FailoverPolicyInner> FailoverPoliciesProperty { get; set; }

    }
}
