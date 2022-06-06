// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// The condition that results in the alert rule being activated.
    /// Please note <see cref="RuleCondition"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
    /// The available derived classes include <see cref="ThresholdRuleCondition"/>, <see cref="LocationThresholdRuleCondition"/>, <see cref="ManagementEventRuleCondition"/>.
    /// </summary>
    public partial class RuleCondition
    {
        /// <summary> Initializes a new instance of RuleCondition. </summary>
        public RuleCondition()
        {
        }

        /// <summary> Initializes a new instance of RuleCondition. </summary>
        /// <param name="odataType"> specifies the type of condition. This can be one of three types: ManagementEventRuleCondition (occurrences of management events), LocationThresholdRuleCondition (based on the number of failures of a web test), and ThresholdRuleCondition (based on the threshold of a metric). </param>
        /// <param name="dataSource">
        /// the resource from which the rule collects its data. For this type dataSource will always be of type RuleMetricDataSource.
        /// Please note <see cref="RuleDataSource"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
        /// The available derived classes include <see cref="RuleMetricDataSource"/>, <see cref="RuleManagementEventDataSource"/>.
        /// </param>
        internal RuleCondition(string odataType, RuleDataSource dataSource)
        {
            OdataType = odataType;
            DataSource = dataSource;
        }

        /// <summary> specifies the type of condition. This can be one of three types: ManagementEventRuleCondition (occurrences of management events), LocationThresholdRuleCondition (based on the number of failures of a web test), and ThresholdRuleCondition (based on the threshold of a metric). </summary>
        internal string OdataType { get; set; }
        /// <summary>
        /// the resource from which the rule collects its data. For this type dataSource will always be of type RuleMetricDataSource.
        /// Please note <see cref="RuleDataSource"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
        /// The available derived classes include <see cref="RuleMetricDataSource"/>, <see cref="RuleManagementEventDataSource"/>.
        /// </summary>
        public RuleDataSource DataSource { get; set; }
    }
}
