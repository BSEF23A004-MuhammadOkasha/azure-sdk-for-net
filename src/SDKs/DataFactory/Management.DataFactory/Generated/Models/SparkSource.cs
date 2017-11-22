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
    /// A copy activity Spark Server source.
    /// </summary>
    public partial class SparkSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the SparkSource class.
        /// </summary>
        public SparkSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SparkSource class.
        /// </summary>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="query">A query to retrieve data from source. Type:
        /// string (or Expression with resultType string).</param>
        public SparkSource(object sourceRetryCount = default(object), object sourceRetryWait = default(object), object query = default(object))
            : base(sourceRetryCount, sourceRetryWait)
        {
            Query = query;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a query to retrieve data from source. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public object Query { get; set; }

    }
}
