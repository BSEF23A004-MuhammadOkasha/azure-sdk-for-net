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
    using System.Linq;

    /// <summary>
    /// A copy activity sink.
    /// </summary>
    public partial class CopySink
    {
        /// <summary>
        /// Initializes a new instance of the CopySink class.
        /// </summary>
        public CopySink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CopySink class.
        /// </summary>
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
        public CopySink(object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object))
        {
            WriteBatchSize = writeBatchSize;
            WriteBatchTimeout = writeBatchTimeout;
            SinkRetryCount = sinkRetryCount;
            SinkRetryWait = sinkRetryWait;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets write batch size. Type: integer (or Expression with
        /// resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "writeBatchSize")]
        public object WriteBatchSize { get; set; }

        /// <summary>
        /// Gets or sets write batch timeout. Type: string (or Expression with
        /// resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "writeBatchTimeout")]
        public object WriteBatchTimeout { get; set; }

        /// <summary>
        /// Gets or sets sink retry count. Type: integer (or Expression with
        /// resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "sinkRetryCount")]
        public object SinkRetryCount { get; set; }

        /// <summary>
        /// Gets or sets sink retry wait. Type: string (or Expression with
        /// resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "sinkRetryWait")]
        public object SinkRetryWait { get; set; }

    }
}
