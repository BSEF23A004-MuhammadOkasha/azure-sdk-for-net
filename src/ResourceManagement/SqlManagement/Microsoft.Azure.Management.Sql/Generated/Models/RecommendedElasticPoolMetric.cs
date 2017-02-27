// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Represents recommended elastic pool metric.
    /// </summary>
    public partial class RecommendedElasticPoolMetric
    {
        /// <summary>
        /// Initializes a new instance of the RecommendedElasticPoolMetric
        /// class.
        /// </summary>
        public RecommendedElasticPoolMetric() { }

        /// <summary>
        /// Initializes a new instance of the RecommendedElasticPoolMetric
        /// class.
        /// </summary>
        /// <param name="dateTime">The time of metric (ISO8601 format).</param>
        /// <param name="dtu">Gets or sets the DTUs (Database Transaction
        /// Units). See
        /// https://azure.microsoft.com/documentation/articles/sql-database-what-is-a-dtu/</param>
        /// <param name="sizeGB">Gets or sets size in gigabytes.</param>
        public RecommendedElasticPoolMetric(System.DateTime? dateTime = default(System.DateTime?), double? dtu = default(double?), double? sizeGB = default(double?))
        {
            DateTime = dateTime;
            Dtu = dtu;
            SizeGB = sizeGB;
        }

        /// <summary>
        /// Gets or sets the time of metric (ISO8601 format).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dateTime")]
        public System.DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or sets the DTUs (Database Transaction Units). See
        /// https://azure.microsoft.com/documentation/articles/sql-database-what-is-a-dtu/
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dtu")]
        public double? Dtu { get; set; }

        /// <summary>
        /// Gets or sets size in gigabytes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeGB")]
        public double? SizeGB { get; set; }

    }
}
