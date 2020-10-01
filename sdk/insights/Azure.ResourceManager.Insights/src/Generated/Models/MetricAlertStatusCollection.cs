// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> Represents a collection of alert rule resources. </summary>
    public partial class MetricAlertStatusCollection
    {
        /// <summary> Initializes a new instance of MetricAlertStatusCollection. </summary>
        internal MetricAlertStatusCollection()
        {
            Value = new ChangeTrackingList<MetricAlertStatus>();
        }

        /// <summary> Initializes a new instance of MetricAlertStatusCollection. </summary>
        /// <param name="value"> the values for the alert rule resources. </param>
        internal MetricAlertStatusCollection(IReadOnlyList<MetricAlertStatus> value)
        {
            Value = value;
        }

        /// <summary> the values for the alert rule resources. </summary>
        public IReadOnlyList<MetricAlertStatus> Value { get; }
    }
}
