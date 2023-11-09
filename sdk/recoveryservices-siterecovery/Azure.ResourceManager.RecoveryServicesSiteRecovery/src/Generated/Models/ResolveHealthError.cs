// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Resolve health errors input properties. </summary>
    public partial class ResolveHealthError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResolveHealthError"/>. </summary>
        public ResolveHealthError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResolveHealthError"/>. </summary>
        /// <param name="healthErrorId"> Health error id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResolveHealthError(string healthErrorId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HealthErrorId = healthErrorId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Health error id. </summary>
        public string HealthErrorId { get; set; }
    }
}
