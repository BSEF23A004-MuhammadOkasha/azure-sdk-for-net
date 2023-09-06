// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Paged instance of ClassificationPolicy. </summary>
    public partial class ClassificationPolicyItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ClassificationPolicyItem"/>. </summary>
        internal ClassificationPolicyItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClassificationPolicyItem"/>. </summary>
        /// <param name="classificationPolicy"> A container for the rules that govern how jobs are classified. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClassificationPolicyItem(ClassificationPolicy classificationPolicy, string etag, Dictionary<string, BinaryData> rawData)
        {
            ClassificationPolicy = classificationPolicy;
            _etag = etag;
            _rawData = rawData;
        }

        /// <summary> A container for the rules that govern how jobs are classified. </summary>
        public ClassificationPolicy ClassificationPolicy { get; }
    }
}
