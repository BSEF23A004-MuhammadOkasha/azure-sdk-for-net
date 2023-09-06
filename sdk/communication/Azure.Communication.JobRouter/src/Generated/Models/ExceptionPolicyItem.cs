// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Paged instance of ExceptionPolicy. </summary>
    public partial class ExceptionPolicyItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExceptionPolicyItem"/>. </summary>
        internal ExceptionPolicyItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExceptionPolicyItem"/>. </summary>
        /// <param name="exceptionPolicy"> A policy that defines actions to execute when exception are triggered. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExceptionPolicyItem(ExceptionPolicy exceptionPolicy, string etag, Dictionary<string, BinaryData> rawData)
        {
            ExceptionPolicy = exceptionPolicy;
            _etag = etag;
            _rawData = rawData;
        }

        /// <summary> A policy that defines actions to execute when exception are triggered. </summary>
        public ExceptionPolicy ExceptionPolicy { get; }
    }
}
