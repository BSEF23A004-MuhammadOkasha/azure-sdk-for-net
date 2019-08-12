// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity Azure Blob sink.
    /// </summary>
    public partial class BlobSink : CopySink
    {
        /// <summary>
        /// Initializes a new instance of the BlobSink class.
        /// </summary>
        public BlobSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobSink class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="writeBatchSize">Write batch size. Type: integer (or
        /// Expression with resultType integer), minimum: 0.</param>
        /// <param name="writeBatchTimeout">Write batch timeout. Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="sinkRetryCount">Sink retry count. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="sinkRetryWait">Sink retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the sink data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="blobWriterOverwriteFiles">Blob writer overwrite files.
        /// Type: boolean (or Expression with resultType boolean).</param>
        /// <param name="blobWriterDateTimeFormat">Blob writer date time
        /// format. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="blobWriterAddHeader">Blob writer add header. Type:
        /// boolean (or Expression with resultType boolean).</param>
        /// <param name="copyBehavior">The type of copy behavior for copy
        /// sink.</param>
        /// <param name="blockSizeInMB">Indicates the block size(MB) when
        /// writing data to blob. Type: integer (or Expression with resultType
        /// integer).</param>
        public BlobSink(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object), object maxConcurrentConnections = default(object), object blobWriterOverwriteFiles = default(object), object blobWriterDateTimeFormat = default(object), object blobWriterAddHeader = default(object), object copyBehavior = default(object), int? blockSizeInMB = default(int?))
            : base(additionalProperties, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections)
        {
            BlobWriterOverwriteFiles = blobWriterOverwriteFiles;
            BlobWriterDateTimeFormat = blobWriterDateTimeFormat;
            BlobWriterAddHeader = blobWriterAddHeader;
            CopyBehavior = copyBehavior;
            BlockSizeInMB = blockSizeInMB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets blob writer overwrite files. Type: boolean (or
        /// Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "blobWriterOverwriteFiles")]
        public object BlobWriterOverwriteFiles { get; set; }

        /// <summary>
        /// Gets or sets blob writer date time format. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "blobWriterDateTimeFormat")]
        public object BlobWriterDateTimeFormat { get; set; }

        /// <summary>
        /// Gets or sets blob writer add header. Type: boolean (or Expression
        /// with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "blobWriterAddHeader")]
        public object BlobWriterAddHeader { get; set; }

        /// <summary>
        /// Gets or sets the type of copy behavior for copy sink.
        /// </summary>
        [JsonProperty(PropertyName = "copyBehavior")]
        public object CopyBehavior { get; set; }

        /// <summary>
        /// Gets or sets indicates the block size(MB) when writing data to
        /// blob. Type: integer (or Expression with resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "blockSizeInMB")]
        public int? BlockSizeInMB { get; set; }

    }
}
