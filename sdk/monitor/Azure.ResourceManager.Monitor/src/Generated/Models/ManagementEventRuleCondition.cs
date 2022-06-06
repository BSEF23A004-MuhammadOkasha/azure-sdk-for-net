// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A management event rule condition. </summary>
    public partial class ManagementEventRuleCondition : RuleCondition
    {
        /// <summary> Initializes a new instance of ManagementEventRuleCondition. </summary>
        public ManagementEventRuleCondition()
        {
            OdataType = "Microsoft.Azure.Management.Insights.Models.ManagementEventRuleCondition";
        }

        /// <summary> Initializes a new instance of ManagementEventRuleCondition. </summary>
        /// <param name="odataType"> specifies the type of condition. This can be one of three types: ManagementEventRuleCondition (occurrences of management events), LocationThresholdRuleCondition (based on the number of failures of a web test), and ThresholdRuleCondition (based on the threshold of a metric). </param>
        /// <param name="dataSource">
        /// the resource from which the rule collects its data. For this type dataSource will always be of type RuleMetricDataSource.
        /// Please note <see cref="RuleDataSource"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
        /// The available derived classes include <see cref="RuleMetricDataSource"/>, <see cref="RuleManagementEventDataSource"/>.
        /// </param>
        /// <param name="aggregation"> How the data that is collected should be combined over time and when the alert is activated. Note that for management event alerts aggregation is optional – if it is not provided then any event will cause the alert to activate. </param>
        internal ManagementEventRuleCondition(string odataType, RuleDataSource dataSource, ManagementEventAggregationCondition aggregation) : base(odataType, dataSource)
        {
            Aggregation = aggregation;
            OdataType = odataType ?? "Microsoft.Azure.Management.Insights.Models.ManagementEventRuleCondition";
        }

        /// <summary> How the data that is collected should be combined over time and when the alert is activated. Note that for management event alerts aggregation is optional – if it is not provided then any event will cause the alert to activate. </summary>
        public ManagementEventAggregationCondition Aggregation { get; set; }
    }
}
