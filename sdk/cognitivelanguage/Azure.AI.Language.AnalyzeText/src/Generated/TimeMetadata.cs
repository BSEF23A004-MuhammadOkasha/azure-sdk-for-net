// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> A Metadata for time entity instances. </summary>
    public partial class TimeMetadata : BaseMetadata
    {
        /// <summary> Initializes a new instance of <see cref="TimeMetadata"/>. </summary>
        internal TimeMetadata()
        {
            MetadataKind = MetadataKind.TimeMetadata;
            DateValues = new ChangeTrackingList<DateValue>();
        }

        /// <summary> Initializes a new instance of <see cref="TimeMetadata"/>. </summary>
        /// <param name="metadataKind"></param>
        /// <param name="dateValues"></param>
        internal TimeMetadata(MetadataKind metadataKind, IReadOnlyList<DateValue> dateValues) : base(metadataKind)
        {
            DateValues = dateValues;
        }

        /// <summary> Gets the date values. </summary>
        public IReadOnlyList<DateValue> DateValues { get; }
    }
}
