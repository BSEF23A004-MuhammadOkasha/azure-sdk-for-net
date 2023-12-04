// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt specific resync input. </summary>
    public partial class VMwareCbtResyncContent : ResyncProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="VMwareCbtResyncContent"/>. </summary>
        /// <param name="skipCbtReset"> A value indicating whether CBT is to be reset. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skipCbtReset"/> is null. </exception>
        public VMwareCbtResyncContent(string skipCbtReset)
        {
            Argument.AssertNotNull(skipCbtReset, nameof(skipCbtReset));

            SkipCbtReset = skipCbtReset;
            InstanceType = "VMwareCbt";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtResyncContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="skipCbtReset"> A value indicating whether CBT is to be reset. </param>
        internal VMwareCbtResyncContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string skipCbtReset) : base(instanceType, serializedAdditionalRawData)
        {
            SkipCbtReset = skipCbtReset;
            InstanceType = instanceType ?? "VMwareCbt";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtResyncContent"/> for deserialization. </summary>
        internal VMwareCbtResyncContent()
        {
        }

        /// <summary> A value indicating whether CBT is to be reset. </summary>
        public string SkipCbtReset { get; }
    }
}
