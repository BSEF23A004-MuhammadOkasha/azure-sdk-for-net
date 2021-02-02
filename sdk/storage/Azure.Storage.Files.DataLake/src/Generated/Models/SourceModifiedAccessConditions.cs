// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary> Parameter group. </summary>
    public partial class SourceModifiedAccessConditions
    {
        /// <summary> Initializes a new instance of SourceModifiedAccessConditions. </summary>
        public SourceModifiedAccessConditions()
        {
        }

        /// <summary> Specify an ETag value to operate only on blobs with a matching value. </summary>
        public string SourceIfMatch { get; set; }
        /// <summary> Specify an ETag value to operate only on blobs without a matching value. </summary>
        public string SourceIfNoneMatch { get; set; }
        /// <summary> Specify this header value to operate only on a blob if it has been modified since the specified date/time. </summary>
        public DateTimeOffset? SourceIfModifiedSince { get; set; }
        /// <summary> Specify this header value to operate only on a blob if it has not been modified since the specified date/time. </summary>
        public DateTimeOffset? SourceIfUnmodifiedSince { get; set; }
    }
}
