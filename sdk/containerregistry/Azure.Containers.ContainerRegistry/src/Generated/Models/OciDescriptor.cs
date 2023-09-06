// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Docker V2 image layer descriptor including config and layers. </summary>
    public partial class OciDescriptor
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OciDescriptor"/>. </summary>
        public OciDescriptor()
        {
            Urls = new ChangeTrackingList<Uri>();
        }

        /// <summary> Initializes a new instance of <see cref="OciDescriptor"/>. </summary>
        /// <param name="mediaType"> Layer media type. </param>
        /// <param name="sizeInBytes"> Layer size. </param>
        /// <param name="digest"> Layer digest. </param>
        /// <param name="urls"> Specifies a list of URIs from which this object may be downloaded. </param>
        /// <param name="annotations"> Additional information provided through arbitrary metadata. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OciDescriptor(string mediaType, long? sizeInBytes, string digest, IList<Uri> urls, OciAnnotations annotations, Dictionary<string, BinaryData> rawData)
        {
            MediaType = mediaType;
            SizeInBytes = sizeInBytes;
            Digest = digest;
            Urls = urls;
            Annotations = annotations;
            _rawData = rawData;
        }

        /// <summary> Layer media type. </summary>
        public string MediaType { get; set; }
        /// <summary> Layer size. </summary>
        public long? SizeInBytes { get; set; }
        /// <summary> Layer digest. </summary>
        public string Digest { get; set; }
        /// <summary> Additional information provided through arbitrary metadata. </summary>
        public OciAnnotations Annotations { get; set; }
    }
}
