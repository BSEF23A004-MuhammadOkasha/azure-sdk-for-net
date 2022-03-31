// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specifies the metric alert criteria for multiple resource that has multiple metric criteria. </summary>
    public partial class MetricAlertMultipleResourceMultipleMetricCriteria : MetricAlertCriteria
    {
        /// <summary> Initializes a new instance of MetricAlertMultipleResourceMultipleMetricCriteria. </summary>
        public MetricAlertMultipleResourceMultipleMetricCriteria()
        {
            AllOf = new ChangeTrackingList<MultiMetricCriteria>();
            OdataType = Odatatype.MicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria;
        }

        /// <summary> Initializes a new instance of MetricAlertMultipleResourceMultipleMetricCriteria. </summary>
        /// <param name="odataType"> specifies the type of the alert criteria. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="allOf"> the list of multiple metric criteria for this &apos;all of&apos; operation. </param>
        internal MetricAlertMultipleResourceMultipleMetricCriteria(Odatatype odataType, IDictionary<string, BinaryData> additionalProperties, IList<MultiMetricCriteria> allOf) : base(odataType, additionalProperties)
        {
            AllOf = allOf;
            OdataType = odataType;
        }

        /// <summary> the list of multiple metric criteria for this &apos;all of&apos; operation. </summary>
        public IList<MultiMetricCriteria> AllOf { get; }
    }
}
