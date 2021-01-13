// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.MixedReality.RemoteRendering.Models
{
    /// <summary> The ConversionList. </summary>
    public partial class ConversionList
    {
        /// <summary> Initializes a new instance of ConversionList. </summary>
        /// <param name="conversions"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversions"/> is null. </exception>
        internal ConversionList(IEnumerable<ConversionInformation> conversions)
        {
            if (conversions == null)
            {
                throw new ArgumentNullException(nameof(conversions));
            }

            Conversions = conversions.ToList();
        }

        /// <summary> Initializes a new instance of ConversionList. </summary>
        /// <param name="conversions"> . </param>
        /// <param name="nextLink"> If more conversions are available this link with the same authentication header can be used to retrieve further values. </param>
        internal ConversionList(IReadOnlyList<ConversionInformation> conversions, string nextLink)
        {
            Conversions = conversions;
            NextLink = nextLink;
        }

        public IReadOnlyList<ConversionInformation> Conversions { get; }
        /// <summary> If more conversions are available this link with the same authentication header can be used to retrieve further values. </summary>
        public string NextLink { get; }
    }
}
