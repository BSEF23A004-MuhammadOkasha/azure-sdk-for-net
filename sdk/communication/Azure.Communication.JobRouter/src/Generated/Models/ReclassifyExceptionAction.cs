// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> An action that modifies labels on a job and then reclassifies it. </summary>
    public partial class ReclassifyExceptionAction : ExceptionAction
    {

        /// <summary> Initializes a new instance of ReclassifyExceptionAction. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionAction. </param>
        /// <param name="classificationPolicyId"> (optional) The new classification policy that will determine queue, priority and worker selectors. </param>
        /// <param name="labelsToUpsert"> (optional) Dictionary containing the labels to update (or add if not existing) in key-value pairs. </param>
        internal ReclassifyExceptionAction(string kind, string classificationPolicyId, IDictionary<string, object> labelsToUpsert) : base(kind)
        {
            ClassificationPolicyId = classificationPolicyId;
            _labelsToUpsert = labelsToUpsert;
            Kind = kind ?? "reclassify";
        }

        /// <summary> (optional) The new classification policy that will determine queue, priority and worker selectors. </summary>
        public string ClassificationPolicyId { get; set; }
    }
}
