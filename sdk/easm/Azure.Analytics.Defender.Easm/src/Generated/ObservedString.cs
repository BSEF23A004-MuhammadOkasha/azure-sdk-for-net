// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The ObservedString. </summary>
    public partial class ObservedString : ObservedValue
    {
        /// <summary> Initializes a new instance of ObservedString. </summary>
        public ObservedString()
        {
            Sources = new ChangeTrackingList<Source>();
        }

        /// <summary> Initializes a new instance of ObservedString. </summary>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="recent"></param>
        /// <param name="value"></param>
        /// <param name="sources"></param>
        internal ObservedString(DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, bool? recent, string value, IList<Source> sources) : base(firstSeen, lastSeen, count, recent)
        {
            Value = value;
            Sources = sources;
        }

        /// <summary> Gets or sets the value. </summary>
        public string Value { get; set; }
        /// <summary> Gets the sources. </summary>
        public IList<Source> Sources { get; }
    }
}
