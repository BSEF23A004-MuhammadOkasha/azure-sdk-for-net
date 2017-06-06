// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Batch;
    using Microsoft.Azure.Management.Batch.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Quotas associated with a Batch region for a particular subscription.
    /// </summary>
    public partial class BatchLocationQuotaInner
    {
        /// <summary>
        /// Initializes a new instance of the BatchLocationQuotaInner class.
        /// </summary>
        public BatchLocationQuotaInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchLocationQuotaInner class.
        /// </summary>
        /// <param name="accountQuota">The number of Batch accounts that may be
        /// created under the subscription in the specified region.</param>
        public BatchLocationQuotaInner(int? accountQuota = default(int?))
        {
            AccountQuota = accountQuota;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the number of Batch accounts that may be created under the
        /// subscription in the specified region.
        /// </summary>
        [JsonProperty(PropertyName = "accountQuota")]
        public int? AccountQuota { get; private set; }

    }
}
