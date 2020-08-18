// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Dynamics source. </summary>
    public partial class DynamicsSource : CopySource
    {
        /// <summary> Initializes a new instance of DynamicsSource. </summary>
        public DynamicsSource()
        {
            Type = "DynamicsSource";
        }

        /// <summary> Initializes a new instance of DynamicsSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="query"> FetchXML is a proprietary query language that is used in Microsoft Dynamics (online &amp; on-premises). Type: string (or Expression with resultType string). </param>
        internal DynamicsSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object query) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            Query = query;
            Type = type ?? "DynamicsSource";
        }

        /// <summary> FetchXML is a proprietary query language that is used in Microsoft Dynamics (online &amp; on-premises). Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
    }
}
