// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> The UnknownRouterRule. </summary>
    internal partial class UnknownRouterRule : RouterRule
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRouterRule"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of Rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRouterRule(string kind, Dictionary<string, BinaryData> rawData) : base(kind, rawData)
        {
            Kind = kind ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRouterRule"/> for deserialization. </summary>
        internal UnknownRouterRule()
        {
        }
    }
}
